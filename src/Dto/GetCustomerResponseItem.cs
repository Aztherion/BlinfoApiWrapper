using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetCustomerResponseItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public GetCustomerResponseItem()
        {
            Id = string.Empty;
        }
    }
}
