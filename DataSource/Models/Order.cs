using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CreateMockDb.Context.Models
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
