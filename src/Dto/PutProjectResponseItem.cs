using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PutProjectResponseItem
    {
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "contactPerson")]
        public string ContactPerson { get; set; }
        [JsonProperty(PropertyName = "customerId")]
        public string CustomerId { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "responsiblePerson")]
        public string ResponsiblePerson { get; set; }
        [JsonProperty(PropertyName = "startDate")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "stopDate")]
        public string StopDate { get; set; }

        public PutProjectResponseItem()
        {
            Category = string.Empty;
            Comment = string.Empty;
            ContactPerson = string.Empty;
            CustomerId = string.Empty;
            Id = string.Empty;
            Name = string.Empty;
            ResponsiblePerson = string.Empty;
            StartDate = string.Empty;
            Status = string.Empty;
            StopDate = string.Empty;
        }
    }
}