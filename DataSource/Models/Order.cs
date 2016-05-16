using System;
using Newtonsoft.Json;

namespace DataSource.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("PersonId")]
        public int PersonId { get; set; }

        [JsonProperty("DateTime")]
        public DateTime DateTime { get; set; }
    }
}
