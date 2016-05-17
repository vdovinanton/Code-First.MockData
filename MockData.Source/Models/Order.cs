using Newtonsoft.Json;
using System;

namespace MockData.Source.Models
{
    /// <summary>
    /// Represents database entity
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the order id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the persone id
        /// </summary>
        [JsonProperty("PersonId")]
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the order date
        /// </summary>
        [JsonProperty("DateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product price
        /// </summary>
        public double? Price { get; set; }
    }
}
