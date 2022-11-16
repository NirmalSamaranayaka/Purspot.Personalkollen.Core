using Purspot.Personalkollen.Core.Entities.Common;
using Purspot.Personalkollen.Core.Entities.ExportingSales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Contracts.Business
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISalesManager
    {
        /// <summary>
        /// Exports the sales data.
        /// </summary>
        /// <param name="sale">The sale.</param>
        /// <returns></returns>
        Task<ServiceResponse> ExportSalesData(Sale sale);
    }
}
