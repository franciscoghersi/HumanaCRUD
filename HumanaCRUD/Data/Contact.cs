using Newtonsoft.Json;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Contact
    {
        [JsonProperty("relationship")]
        public List<Relationship> Relationship { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("telecom")]
        public List<Telecom> Telecom { get; set; }
    }
}
