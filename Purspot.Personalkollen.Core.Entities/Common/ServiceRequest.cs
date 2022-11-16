using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.Common
{
    /// <summary>
    /// The ServiceRequest
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ServiceRequest<T>
    {
        /// <summary>
        /// Uri.
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        public string BaseUri { get; set; }
        /// <summary>
        /// Uri.
        /// </summary>
        /// <value>
        /// The URI.
        /// </value>
        public string Uri { get; set; }
        /// <summary>
        /// Token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }
        /// <summary>
        /// Request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public T Request { get; set; }
    }

}
