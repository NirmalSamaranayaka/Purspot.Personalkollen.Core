using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Contracts.Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHttpHandler
    {
        /// <summary>
        /// Posts the request.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="serviceRequest">The service request.</param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostRequest<TIn>(ServiceRequest<TIn> serviceRequest);
    }
}
