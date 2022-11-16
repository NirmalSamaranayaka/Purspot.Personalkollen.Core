using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Common.Mappers
{
    /// <summary>
    /// Reference data response mapper
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Common.IMapper&lt;System.Object, Purspot.Personalkollen.Core.Entities.Common.ServiceResponse&gt;" />
    public class ServiceResponseMapper : IMapper<Object, ServiceResponse>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public ServiceResponse Map(object input)
        {
            return new ServiceResponse
            {
                ReturnObject = input,
                IsError = false
            };
        }
    }
}
