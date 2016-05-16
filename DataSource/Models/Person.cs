using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataSource.Models
{
    public class Person
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("OrderId")]
        public int? OrderId { get; set; }

        public IList<Order> Orders { get; set; }

        public Person()
        {
            Orders = new List<Order>();
        }
    }
}
