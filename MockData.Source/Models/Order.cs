using Newtonsoft.Json;
using System;
using DataSource.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        /// Gets or sets product order
        /// </summary>
        public Product Product { get; set; }


        /// <summary>
        /// Gets or sets product id
        /// </summary>
        public int ProductId { get; set; }
    }
}
