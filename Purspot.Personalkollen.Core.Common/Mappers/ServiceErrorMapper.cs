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
    /// Service Errror Mapper
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Common.IMapper&lt;System.Collections.Generic.IList&lt;Purspot.Personalkollen.Core.Entities.Common.Message&gt;, Purspot.Personalkollen.Core.Entities.Common.ServiceResponse&gt;" />
    public class ServiceErrorMapper : IMapper<IList<Message>, ServiceResponse>
    {
        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public ServiceResponse Map(IList<Message> input) => new ServiceResponse
        {
            IsError = true,
            Messages = input
        };
    }
}
