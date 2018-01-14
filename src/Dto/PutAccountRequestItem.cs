using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PutAccountRequestItem
    {
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        [JsonProperty(PropertyName = "vatCode")]
        public string VatCode { get; set; }

        public PutAccountRequestItem()
        {
            Comment = string.Empty;
            Id = string.Empty;
            Name = string.Empty;
            Type = string.Empty;
            Unit = string.Empty;
            VatCode = string.Empty;
        }
    }
}