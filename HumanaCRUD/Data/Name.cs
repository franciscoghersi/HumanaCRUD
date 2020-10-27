using Newtonsoft.Json;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Name
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public List<string> Given { get; set; }

        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Suffix { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
