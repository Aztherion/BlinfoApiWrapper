using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    internal class AuthTokenResponse
    {
        public AuthTokenResponse()
        {
            AccessToken = string.Empty;
        }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }
    }
}
