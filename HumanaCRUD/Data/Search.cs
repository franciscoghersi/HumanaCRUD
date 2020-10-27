using Newtonsoft.Json;

namespace HumanaCRUD.Data
{
    public class Search
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
