using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HumanaCRUD.Data
{
    public class Patient
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("text")]
        public Text Text { get; set; }

        [JsonProperty("identifier")]
        public List<Identifier> Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public List<Name> Name { get; set; }

        [JsonProperty("telecom")]
        public List<Telecom> Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public List<Address> Address { get; set; }

        [JsonProperty("maritalStatus")]
        public MaritalStatus MaritalStatus { get; set; }

        [JsonProperty("multipleBirthBoolean")]
        public bool MultipleBirthBoolean { get; set; }

        [JsonProperty("contact")]
        public List<Contact> Contact { get; set; }

        [JsonProperty("communication")]
        public List<Communication> Communication { get; set; }

        [JsonProperty("managingOrganization")]
        public ManagingOrganization ManagingOrganization { get; set; }
    }

    public partial class Text
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public partial class MaritalStatus
    {
        [JsonProperty("coding")]
        public List<MaritalStatusCoding> Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
    public partial class Communication
    {
        [JsonProperty("language")]
        public MaritalStatus Language { get; set; }

        [JsonProperty("preferred")]
        public bool Preferred { get; set; }
    }

    public partial class MaritalStatusCoding
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public partial class ManagingOrganization
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}
