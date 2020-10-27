using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class Tag
    {
        [JsonProperty("system")]
        public Uri System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}
