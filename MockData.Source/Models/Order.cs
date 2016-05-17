using Newtonsoft.Json;
using System;

namespace MockData.Source.Models
{
    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("PersonId")]
        public int PersonId { get; set; }

        [JsonProperty("DateTime")]
        public DateTime DateTime { get; set; }

        public string Name { get; set; }
        public double? Price { get; set; }
    }
}
