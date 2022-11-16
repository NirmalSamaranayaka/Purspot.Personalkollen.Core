using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPersonalkollenServerConnector
    {
        /// <summary>
        /// Creates the user post asynct.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputParm">The input parm.</param>
        /// <returns></returns>
        Task<ServiceResponse> CreateUserPostAsynct<T>(T inputParm);
    }
}
