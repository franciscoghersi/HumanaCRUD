using Newtonsoft.Json;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Organization
    {
            
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("identifier")]
        public List<Identifier> Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("telecom")]
        public List<Telecom> Telecom { get; set; }

        [JsonProperty("contact")]
        public List<Contact> Contact { get; set; }

        [JsonProperty("endpoint")]
        public List<Endpoint> Endpoint { get; set; }
    
    }
}
