using System;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PostCostBearerRequestItem
    {
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public PostCostBearerRequestItem()
        {
            Comment = string.Empty;
            Id = string.Empty;
            Name = String.Empty;
        }
    }
}