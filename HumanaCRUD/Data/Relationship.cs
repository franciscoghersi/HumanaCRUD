using Newtonsoft.Json;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Relationship
    {
        [JsonProperty("coding")]
        public List<RelationshipCoding> Coding { get; set; }
    }
}
