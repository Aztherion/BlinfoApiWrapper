using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetDetailsResponseItem
    {
        [JsonProperty(PropertyName = "auditor")]
        public string Auditor { get; set; }
        [JsonProperty(PropertyName = "bg")]
        public string Bg { get; set; }
        [JsonProperty(PropertyName = "box")]
        public string Box { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }
        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "orgNumber")]
        public string OrganisationNumber { get; set; }
        [JsonProperty(PropertyName = "pg")]
        public string Pg { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "web")]
        public string Web { get; set; }
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }


        public GetDetailsResponseItem()
        {
            Auditor = string.Empty;
            Bg = string.Empty;
            Box = string.Empty;
            City = string.Empty;
            Comment = string.Empty;
            Country = string.Empty;
            Email = string.Empty;
            Fax = string.Empty;
            Mobile = string.Empty;
            Name = string.Empty;
            OrganisationNumber = string.Empty;
            Pg = string.Empty;
            Phone = string.Empty;
            Street = string.Empty;
            Web = string.Empty;
            Zip = string.Empty;
        }
    }
}
