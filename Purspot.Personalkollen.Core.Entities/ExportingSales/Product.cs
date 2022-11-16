using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.ExportingSales
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        /// <value>
        /// The uid.
        /// </value>
        [JsonPropertyName("uid")]
        [Required, MaxLength(36)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonPropertyName("name")]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the purchase price.
        /// </summary>
        /// <value>
        /// The purchase price.
        /// </value>
        [JsonPropertyName("purchase_price")]
        [Column(TypeName = "decimal(14, 2)")]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        [JsonPropertyName("group")]
        public ProductGroup Group { get; set; }

    }
}
