using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Contracts.Common
{
    /// <summary>
    /// Generic validator contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IDisposable" />
    public interface IValidator<in T> : IDisposable
    {
        /// <summary>
        /// Validates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="messages">The messages.</param>
        /// <returns>
        /// validation status
        /// </returns>
        bool Validate(T obj, out IList<Message> messages);

    }

}
