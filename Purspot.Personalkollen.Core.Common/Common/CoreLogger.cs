using Microsoft.Extensions.Logging;
using Purspot.Personalkollen.Core.Contracts.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Common.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Common.ICustomLogger" />
    public class CoreLogger : ICustomLogger
    {
        /// <summary>
        /// The factory
        /// </summary>
        private static ILoggerFactory _factory;
        /// <summary>
        /// The logger
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreLogger"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        public CoreLogger(ILoggerFactory factory)
        {
            _factory = factory;
        }
        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private ILogger GetLogger<T>()
        {
            if (_logger == null)
            {
                _logger = _factory.CreateLogger<T>();
            }

            return _logger;
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        public void LogError<T>(string message)
        {
            var logger = GetLogger<T>();
            logger.LogError(message);
        }

        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        public void LogMessage<T>(string message)
        {
            var logger = GetLogger<T>();
            logger.LogInformation(message);
        }

        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        public void LogWarning<T>(string message)
        {
            var logger = GetLogger<T>();
            logger.LogWarning(message);
        }
    }
}
