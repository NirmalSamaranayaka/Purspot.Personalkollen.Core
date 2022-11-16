using Microsoft.Extensions.Configuration;
using Purspot.Personalkollen.Core.Business.Managers;
using Purspot.Personalkollen.Core.Business.Validator;
using Purspot.Personalkollen.Core.Common.Common;
using Purspot.Personalkollen.Core.Common.Mappers;
using Purspot.Personalkollen.Core.Common.Utils;
using Purspot.Personalkollen.Core.Contracts.Business;
using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Contracts.Resources;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.Configurations;
using Purspot.Personalkollen.Core.Entities.ExportingSales;
using Purspot.Personalkollen.Core.Resources;
using Purspot.Personalkollen.Core.Services;

namespace Purspot.Personalkollen.Core.Api.Startup
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Adds the configuration.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static IServiceCollection AddConfig(
            this IServiceCollection services, IConfiguration config)
        {
            #region Congigurations 
            services.Configure<PersonalkollenServiceConfig>(config.GetSection("PersonalkollenServiceConfig"));
            #endregion
            return services;
        }

        /// <summary>
        /// Registers the services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            
            #region HttpContext
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region swagger
            services.AddSwaggerGen();
            #endregion

            #region Managers
            services.AddScoped<ISalesManager, SalesManager>();
            #endregion

            #region Externam Connectors
            services.AddScoped<IPersonalkollenServerConnector, PersonalkollenServerConnector>();
            #endregion

            #region Validators
            services.AddScoped<IValidator<Sale>, SalesDetailsValidator>();
            #endregion

            #region ErrorHandlers
            services.AddSingleton<ISalesErrorMessageHandler, SalesErrorMessageHandler>();
            #endregion

            #region Mappers
            services.AddSingleton<IMapper<IList<Message>, ServiceResponse>, ServiceErrorMapper>();
            services.AddSingleton<IMapper<Object, ServiceResponse>, ServiceResponseMapper>();
            #endregion

            #region util
            services.AddScoped<IHttpHandler, HttpHandler>();
            services.AddSingleton<ICustomLogger, CoreLogger>();
            #endregion

            
            return services;
        }


        

    }
}