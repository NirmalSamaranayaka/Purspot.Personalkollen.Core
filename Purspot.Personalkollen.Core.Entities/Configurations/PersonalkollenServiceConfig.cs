using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonalkollenServiceConfig
    {
        /// <summary>
        /// Gets or sets the service base URI.
        /// </summary>
        /// <value>
        /// The service base URI.
        /// </value>
        public string ServiceBaseUri { get; set; }
        /// <summary>
        /// Gets or sets the sales endpoint.
        /// </summary>
        /// <value>
        /// The sales endpoint.
        /// </value>
        public string SalesEndpoint { get; set; }
        /// <summary>
        /// Gets or sets the client secret.
        /// </summary>
        /// <value>
        /// The client secret.
        /// </value>
        public string ClientSecret { get; set; }
    }
}
