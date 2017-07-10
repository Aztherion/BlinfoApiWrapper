using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetMeResponseItem
    {
        [JsonProperty(PropertyName = "b2BEmail")]
        public string B2BEmail { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "enabledScopes")]
        public List<string> EnabledScopes { get; set; }
        [JsonProperty(PropertyName = "live")]
        public bool Live { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        [JsonProperty(PropertyName = "requestedScopes")]
        public List<GetScopeResponseItem> RequestedScopes { get; set; }
        [JsonProperty(PropertyName = "www")]
        public string Www { get; set; }

        public GetMeResponseItem()
        {
            B2BEmail = string.Empty;
            Description = string.Empty;
            Email = string.Empty;
            EnabledScopes = new List<string>();
            Name = string.Empty;
            Phone = string.Empty;
            PublicKey = string.Empty;
            RequestedScopes = new List<GetScopeResponseItem>();
            Www = string.Empty;
        }
    }
}
