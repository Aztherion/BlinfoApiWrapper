using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostCostCenterRequestItem
    {
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public PostCostCenterRequestItem()
        {
            Comment = string.Empty;
            Id = string.Empty;
            Name = string.Empty;
        }
    }
}