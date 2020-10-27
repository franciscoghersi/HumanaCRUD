using Newtonsoft.Json;
using System;

namespace HumanaCRUD.Data
{
    public class Period
    {
        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }
    }
}
