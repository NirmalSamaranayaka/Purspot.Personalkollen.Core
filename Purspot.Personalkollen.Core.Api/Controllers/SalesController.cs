using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Purspot.Personalkollen.Core.Business.Managers;
using Purspot.Personalkollen.Core.Contracts.Business;
using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Contracts.Resources;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.ExportingSales;

namespace Purspot.Personalkollen.Core.Api.Controllers
{

    //[Produces("application/json")]
    //[Route("api/v1/sales")]
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/v1")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        /// <summary>
        /// The sales manager
        /// </summary>
        private readonly ISalesManager _salesManager;
        /// <summary>
        /// The custome logger
        /// </summary>
        private readonly ICustomLogger _customeLogger;
        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;
        /// <summary>
        /// The sales error message handler
        /// </summary>
        private readonly ISalesErrorMessageHandler _salesErrorMessageHandler;
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ICustomLogger logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesController"/> class.
        /// </summary>
        /// <param name="salesManager">The sales manager.</param>
        /// <param name="customeLogger">The custome logger.</param>
        /// <param name="serviceResponseErrorMapper">The service response error mapper.</param>
        /// <param name="salesErrorMessageHandler">The sales error message handler.</param>
        /// <param name="logger">The logger.</param>
        public SalesController(ISalesManager salesManager,
            ICustomLogger customeLogger,
            IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper,
            ISalesErrorMessageHandler salesErrorMessageHandler,
        ICustomLogger logger)
        {
            _salesManager = salesManager;
            _customeLogger = customeLogger;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _salesErrorMessageHandler = salesErrorMessageHandler;
            this.logger = logger;
        }


        /// <summary>
        /// Exports the sales data.
        /// </summary>
        /// <param name="sales">The sales.</param>
        /// <returns></returns>
        [HttpPost("sales")]
        public async Task<ServiceResponse> ExportSalesData([FromBody] Sale sales)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return await _salesManager.ExportSalesData(sales);
                }
                else
                {
                    return _serviceResponseErrorMapper.Map(new List<Message> { _salesErrorMessageHandler.InvalidSales() });
                }
            }
            catch (Exception ex)
            {
                logger.LogError<Exception>(ex.StackTrace);
                return _serviceResponseErrorMapper.Map(new List<Message> { });

            }
        }
    }
}
