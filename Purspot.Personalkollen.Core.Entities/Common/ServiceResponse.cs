using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.Common
{
    public class ServiceResponse
    {
        /// <summary>
        /// Gets or sets the return object.
        /// </summary>
        public Object ReturnObject { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is error.
        /// </summary>
        public bool IsError { get; set; }
        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public IList<Message> Messages { get; set; }
        /// <summary>
        /// Gets or sets the forbidden.
        /// </summary>
        /// <value>
        /// The forbidden.
        /// </value>
        public HttpStatusCode StatusCode { get; set; }
    }
}
