using Newtonsoft.Json;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Address
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public List<string> Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
