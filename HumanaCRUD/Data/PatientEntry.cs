using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class PatientEntry
    {
        [JsonProperty("fullUrl")]
        public Uri FullUrl { get; set; }

        [JsonProperty("resource")]
        public Patient Patient { get; set; }

        [JsonProperty("search")]
        public Search Search { get; set; }
    }
}
