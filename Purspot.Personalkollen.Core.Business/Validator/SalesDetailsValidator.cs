using Purspot.Personalkollen.Core.Contracts.Common;
using Purspot.Personalkollen.Core.Contracts.Resources;
using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.ExportingSales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Business.Validator
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Purspot.Personalkollen.Core.Contracts.Common.IValidator&lt;Purspot.Personalkollen.Core.Entities.ExportingSales.Sale&gt;" />
    public class SalesDetailsValidator : IValidator<Sale>
    {

        /// <summary>
        /// The sales error message handler
        /// </summary>
        private readonly ISalesErrorMessageHandler _salesErrorMessageHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesDetailsValidator"/> class.
        /// </summary>
        /// <param name="salesErrorMessageHandler">The sales error message handler.</param>
        public SalesDetailsValidator(ISalesErrorMessageHandler salesErrorMessageHandler)
        {
            _salesErrorMessageHandler = salesErrorMessageHandler;
        }

        /// <summary>
        /// Validates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="messages">The messages.</param>
        /// <returns>
        /// validation status
        /// </returns>
        bool IValidator<Sale>.Validate(Sale obj, out IList<Message> messages)
        {
            messages = new List<Message>();
            //TODO All nessasary validations here
            if (obj.Payments.Count ==0)
            {
                messages.Add(_salesErrorMessageHandler.SalesPaymentCountChecking());
            }
          
            if (messages.Count > 0)
            {
                return false;
            }

            return messages.Count == 0;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="SaleDetailsValidator" /> class.
        /// </summary>
        ~SalesDetailsValidator()
        {
            Dispose(false);
        }
    }

}
