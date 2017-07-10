using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostMeRequestItem
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "www")]
        public string Www { get; set; }

        public PostMeRequestItem()
        {
            Description = string.Empty;
            Email = string.Empty;
            Name = string.Empty;
            Phone = string.Empty;
            Www = string.Empty;
        }
    }
}
