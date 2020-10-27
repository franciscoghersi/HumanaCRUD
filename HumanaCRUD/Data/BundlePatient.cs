namespace HumanaCRUD.Entity
{
    using System;
    using System.Collections.Generic;
    using HumanaCRUD.Data;
    using Newtonsoft.Json;

    public class BunblePatient
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
        public List<PatientEntry> Entry { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
