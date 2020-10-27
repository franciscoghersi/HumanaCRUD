using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class Identifier
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public Uri System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
