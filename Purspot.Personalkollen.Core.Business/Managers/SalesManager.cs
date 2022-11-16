using Purspot.Personalkollen.Core.Contracts.Business;
using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Contracts.Resources;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.ExportingSales;
using Purspot.Personalkollen.Core.Services;

namespace Purspot.Personalkollen.Core.Business.Managers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Business.ISalesManager" />
    public class SalesManager : ISalesManager
    {

        /// <summary>
        /// The logger
        /// </summary>
        private readonly ICustomLogger _logger;

        /// <summary>
        /// The service response mapper
        /// </summary>
        private readonly IMapper<object, ServiceResponse> _serviceResponseMapper;

        /// <summary>
        /// The sales detail validator
        /// </summary>
        private readonly IValidator<Sale> _salesDetailValidator;

        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;

        /// <summary>
        /// The sales error message handler
        /// </summary>
        private readonly ISalesErrorMessageHandler _salesErrorMessageHandler;

        /// <summary>
        /// The personalkollen server connector
        /// </summary>
        private readonly IPersonalkollenServerConnector _personalkollenServerConnector;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesManager"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="serviceResponseMapper">The service response mapper.</param>
        /// <param name="salesDetailValidator">The sales detail validator.</param>
        /// <param name="serviceResponseErrorMapper">The service response error mapper.</param>
        /// <param name="salesErrorMessageHandler">The sales error message handler.</param>
        /// <param name="personalkollenServerConnector">The personalkollen server connector.</param>
        public SalesManager(ICustomLogger logger,  IMapper<object, ServiceResponse> serviceResponseMapper,
            IValidator<Sale> salesDetailValidator, IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper, ISalesErrorMessageHandler salesErrorMessageHandler,
            IPersonalkollenServerConnector personalkollenServerConnector)
        {
            _logger = logger;
            _serviceResponseMapper = serviceResponseMapper;
            _salesDetailValidator = salesDetailValidator;
            _salesErrorMessageHandler = salesErrorMessageHandler;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _personalkollenServerConnector = personalkollenServerConnector;
        }

        /// <summary>
        /// Exports the sales data.
        /// </summary>
        /// <param name="sale">The sale.</param>
        /// <returns></returns>
        public async Task<ServiceResponse> ExportSalesData(Sale sale)
        {
            try
            {
                //Different services data validation before send to Personalkollen APIs
                if (!_salesDetailValidator.Validate(sale, out IList<Message> messages))
                {
                    return _serviceResponseErrorMapper.Map(messages);
                }
                else
                {
                    //TODO call HTTP EXternal Client and pass nessasary data for that API
                    var response = await _personalkollenServerConnector.CreateUserPostAsynct(sale);
                    if (response.IsError)
                    {
                        //TODO we can handle Error scenario related output messages
                        return _serviceResponseErrorMapper.Map(new List<Message> { _salesErrorMessageHandler.ExternalServerError() });
                    }
                    else
                    {
                        //TODO we can handle success scenario related output messages
                        return response;
                    }
                } 
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}