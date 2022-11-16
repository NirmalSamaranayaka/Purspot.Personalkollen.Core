using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Services
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Services.IPersonalkollenServerConnector" />
    public class PersonalkollenServerConnector : IPersonalkollenServerConnector
    {
        /// <summary>
        /// The personalkollen service configuration
        /// </summary>
        private readonly IOptions<PersonalkollenServiceConfig> _personalkollenServiceConfig;
        /// <summary>
        /// The HTTP handler
        /// </summary>
        private readonly IHttpHandler _httpHandler;
        /// <summary>
        /// The service response error mapper
        /// </summary>
        private readonly IMapper<IList<Message>, ServiceResponse> _serviceResponseErrorMapper;
        /// <summary>
        /// The custome logger
        /// </summary>
        private readonly ICustomLogger _customeLogger;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalkollenServerConnector"/> class.
        /// </summary>
        /// <param name="personalkollenServiceConfig">The personalkollen service configuration.</param>
        /// <param name="httpHandler">The HTTP handler.</param>
        /// <param name="serviceResponseErrorMapper">The service response error mapper.</param>
        /// <param name="customeLogger">The custome logger.</param>
        public PersonalkollenServerConnector(IOptions<PersonalkollenServiceConfig> personalkollenServiceConfig, IHttpHandler httpHandler, IMapper<IList<Message>, ServiceResponse> serviceResponseErrorMapper, ICustomLogger customeLogger)
        {
            _personalkollenServiceConfig = personalkollenServiceConfig;
            _httpHandler = httpHandler;
            _serviceResponseErrorMapper = serviceResponseErrorMapper;
            _customeLogger = customeLogger;
        }
        /// <summary>
        /// Creates the user post asynct.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputParm">The input parm.</param>
        /// <returns></returns>
        public async Task<ServiceResponse> CreateUserPostAsynct<T>(T inputParm)
        {
            try
            {
                string authToken = _personalkollenServiceConfig.Value.ClientSecret;
                string authHeader = authToken;
                //TODO set correct auth mechanisam
                var serviceRequest = new ServiceRequest<T>
                {
                    Request = inputParm,
                    BaseUri = _personalkollenServiceConfig.Value.ServiceBaseUri,
                    Uri =  _personalkollenServiceConfig.Value.SalesEndpoint,
                    Token = authHeader
                };

                var httpResponseMessage = await _httpHandler.PostRequest<T>(serviceRequest);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string responseBody = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    var serviceResponse = JsonConvert.DeserializeObject<ServiceResponse>(responseBody);
                    return serviceResponse;
                }

                else
                {
                    IList<Message> errorMessage = new List<Message>();
                    return _serviceResponseErrorMapper.Map(errorMessage);
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
    }

}
