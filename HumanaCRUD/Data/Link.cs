using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class Link
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
