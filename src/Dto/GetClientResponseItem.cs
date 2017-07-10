using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetClientResponseItem
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "externalCustomerId")]
        public string ExternalCustomerId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        [JsonProperty(PropertyName = "scopes")]
        public List<GetScopeResponseItem> Scopes { get; set; }

        public GetClientResponseItem()
        {
            Email = string.Empty;
            ExternalCustomerId = string.Empty;
            Name = string.Empty;
            PublicKey = string.Empty;
            Scopes = new List<GetScopeResponseItem>();
        }
    }
}
