using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Contracts.Resources
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISalesErrorMessageHandler
    {
        /// <summary>
        /// Saleses the payment count checking.
        /// </summary>
        /// <returns></returns>
        Message SalesPaymentCountChecking();
        /// <summary>
        /// Invalids the sales.
        /// </summary>
        /// <returns></returns>
        Message InvalidSales();
        /// <summary>
        /// Externals the server error.
        /// </summary>
        /// <returns></returns>
        Message ExternalServerError();
    }
}
