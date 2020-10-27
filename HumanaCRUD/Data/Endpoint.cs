using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class Endpoint
    {
        [JsonProperty("reference")]
        public Uri Reference { get; set; }
    }
}
