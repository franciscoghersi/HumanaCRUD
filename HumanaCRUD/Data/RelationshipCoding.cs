using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class RelationshipCoding
    {
        [JsonProperty("system")]
        public Uri System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
