using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class BundleOrganization
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("link")]
        public List<Link> Link { get; set; }

        [JsonProperty("entry")]
        public List<EntryOrganization> Entry { get; set; }
    }
}
