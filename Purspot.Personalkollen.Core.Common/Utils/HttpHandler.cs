using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Contracts.Common;

namespace Purspot.Personalkollen.Core.Common.Utils
{
    /// <summary>
    /// HTTP Handler
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Common.IHttpHandler" />
    public class HttpHandler : IHttpHandler
    {
        /// <summary>
        /// Post Request.
        /// </summary>
        /// <typeparam name="TIn">The type of the in.</typeparam>
        /// <param name="serviceRequest">Service Request</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PostRequest<TIn>(ServiceRequest<TIn> serviceRequest)
        {

            using (var client = new HttpClient())
            {
                //TODO need to change generic logic based on requirement
                client.Timeout = TimeSpan.FromMinutes(10);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", serviceRequest.Token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var serializedRequest = new StringContent(JsonConvert.SerializeObject(serviceRequest.Request), Encoding.UTF8, "application/json");
                var httpResponse = await client.PostAsync(new StringBuilder().Append(serviceRequest.BaseUri).Append(serviceRequest.Uri).ToString(), serializedRequest);

                return httpResponse;
            }

        }

    }

}
