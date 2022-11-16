using Purspot.Personalkollen.Core.Contracts.Resources;
using Purspot.Personalkollen.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Resources
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Resources.ISalesErrorMessageHandler" />
    public class SalesErrorMessageHandler : ISalesErrorMessageHandler
    {
        /// <summary>
        /// Saleses the payment count checking.
        /// </summary>
        /// <returns></returns>
        public Message SalesPaymentCountChecking()
        {
            return new Message
            {
                Code = "E0001",
                Description = SalesErrorResourceMessageHandler.E0001
            };
        }

        /// <summary>
        /// Invalids the sales.
        /// </summary>
        /// <returns></returns>
        public Message InvalidSales()
        {
            return new Message
            {
                Code = "E0002",
                Description = SalesErrorResourceMessageHandler.E0002
            };
        }

        /// <summary>
        /// Externals the server error.
        /// </summary>
        /// <returns></returns>
        public Message ExternalServerError()
        {
            return new Message
            {
                Code = "E0003",
                Description = SalesErrorResourceMessageHandler.E0003
            };
        }


        //TODO Error handling can do this layor
    }
}
