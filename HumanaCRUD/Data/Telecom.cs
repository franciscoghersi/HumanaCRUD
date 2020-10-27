using Newtonsoft.Json;

namespace HumanaCRUD.Data
{
    public class Telecom
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }
    }
}
