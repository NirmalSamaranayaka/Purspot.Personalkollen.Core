using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Purspot.Personalkollen.Core.Entities.ExportingSales
{
    /// <summary>
    /// 
    /// </summary>
    public class Sale
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
        /// Gets or sets the checkout version.
        /// </summary>
        /// <value>
        /// The checkout version.
        /// </value>
        [JsonPropertyName("checkout_version")]
        [Required, MaxLength(100)]
        public string CheckoutVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is buy back.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is buy back; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("is_buy_back")]
        [Required]
        public bool IsBuyBack { get; set; }

        /// <summary>
        /// Gets or sets the sale time.
        /// </summary>
        /// <value>
        /// The sale time.
        /// </value>
        [JsonPropertyName("sale_time")]
        [Required]
        public DateTime SaleTime { get; set; }

        /// <summary>
        /// Gets or sets the counter.
        /// </summary>
        /// <value>
        /// The counter.
        /// </value>
        [JsonPropertyName("counter")]
        [Required]
        public Counter Counter { get; set; }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        /// <value>
        /// The payments.
        /// </value>
        [JsonPropertyName("payments")]
        [Required]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [JsonPropertyName("items")]
        [Required]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the is take away.
        /// </summary>
        /// <value>
        /// The is take away.
        /// </value>
        [JsonPropertyName("is_take_away")]
        public bool? IsTakeAway { get; set; }

        /// <summary>
        /// Gets or sets the sale center.
        /// </summary>
        /// <value>
        /// The sale center.
        /// </value>
        [JsonPropertyName("sale_center")]
        public SaleCenter SaleCenter { get; set; }

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        [JsonPropertyName("tip")]
        public decimal? Tip { get; set; }

        /// <summary>
        /// Gets or sets the personal identifier.
        /// </summary>
        /// <value>
        /// The personal identifier.
        /// </value>
        [JsonPropertyName("personal_id")]
        [MaxLength(100)]
        public string? PersonalId { get; set; }

        /// <summary>
        /// Gets or sets the staff.
        /// </summary>
        /// <value>
        /// The staff.
        /// </value>
        [JsonPropertyName("staff")]
        public Staff Staff { get; set; }

    }
}
