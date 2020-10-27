using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class EntryOrganization { 

        [JsonProperty("fullUrl")]
        public Uri FullUrl { get; set; }

        [JsonProperty("resource")]
        public Organization Organization { get; set; }

        [JsonProperty("search")]
        public Search Search { get; set; }
    }
}
