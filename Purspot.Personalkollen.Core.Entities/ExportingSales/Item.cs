using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.ExportingSales
{
    /// <summary>
    /// 
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        [JsonPropertyName("amount")]
        [Required]
        [Column(TypeName = "decimal(14, 2)")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the price per unit.
        /// </summary>
        /// <value>
        /// The price per unit.
        /// </value>
        [JsonPropertyName("price_per_unit")]
        [Required]
        [Column(TypeName = "decimal(14, 2)")]
        public decimal PricePerUnit { get; set; }

        /// <summary>
        /// Gets or sets the list price per unit.
        /// </summary>
        /// <value>
        /// The list price per unit.
        /// </value>
        [JsonPropertyName("list_price_per_unit")]
        public decimal ListPricePerUnit { get; set; }

        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        /// <value>
        /// The vat.
        /// </value>
        [JsonPropertyName("vat")]
        [Required]
        [Column(TypeName = "decimal(14, 2)")]
        public decimal Vat { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        [JsonPropertyName("product")]
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the order time.
        /// </summary>
        /// <value>
        /// The order time.
        /// </value>
        [JsonPropertyName("order_time")]
        public DateTime OrderTime { get; set; }
    }
}
