using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MockData.Source.Models
{
    /// <summary>
    /// Represents database entity
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person id
        /// </summary>
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the person gender
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the person First Name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the person Last Name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the person Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the person IpAddress
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the Order Id
        /// </summary>
        [JsonProperty("OrderId")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the person Orders
        /// </summary>
        public IList<Order> Orders { get; set; }

        public Person()
        {
            Orders = new List<Order>();
        }
    }
}
