using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Meta
    {
        [JsonProperty("versionId")]
        public long VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("tag")]
        public List<Tag> Tag { get; set; }
    }
}
