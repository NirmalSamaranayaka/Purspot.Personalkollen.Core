using System;
using System.Collections.Generic;
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
    public class SaleCenter
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
    }
}
