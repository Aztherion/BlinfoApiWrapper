using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Stores
{
    public class CommonStore
    {
        private BaseRestClient _client;
        public CommonStore() : this(string.Empty) { }

        public CommonStore(string accessToken) : this(accessToken, String.Empty) { }

        public CommonStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<string> ConnectAsync(string clientId, string clientSecret)
        {
            using (var client = _client.GetClient())
            {
                var kvps = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("scope", ""),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                };
                var response = await client.PostAsync(ApiControllers.ApiAuthUrl, new FormUrlEncodedContent(kvps));
                var authTokenResponse = JsonConvert.DeserializeObject<AuthTokenResponse>(await response.Content.ReadAsStringAsync());
                var token = authTokenResponse.AccessToken;
                _client = new BaseRestClient(token);
                return token;
            }
        }

        public async Task<IEnumerable<GetServiceResponseItem>> GetServicesAsync()
        {
            return await _client.GetAsync<GetServiceResponseItem>(ApiControllers.CommonServicePath);
        }

        public async Task<GetMeResponseItem> GetMeAsync()
        {
            return await _client.GetSingleAsync<GetMeResponseItem>(ApiControllers.CommonMePath);
        }

        public async Task<GetMeResponseItem> UpdateMeAsync(PostMeRequestItem item)
        {
            return await _client.PostAsync<GetMeResponseItem>(item, ApiControllers.CommonMePath);
        }

        public async Task<IEnumerable<GetScopeResponseItem>> GetScopesAsync()
        {
            return await _client.GetAsync<GetScopeResponseItem>(ApiControllers.CommonScopePath);
        }

        public async Task<IEnumerable<GetScopeResponseItem>> SetScopeAsync(List<PostScopeRequestItem> scopes)
        {
            return await _client.PostAsync<List<GetScopeResponseItem>>(scopes, ApiControllers.CommonScopePath);
        }

        public async Task<IEnumerable<GetClientResponseItem>> GetClientsAsync()
        {
            return await _client.GetAsync<GetClientResponseItem>(ApiControllers.CommonClientPath);
        }

        public async Task DeleteClientAsync(string publicKey)
        {
            await _client.DeleteAsync($"{ApiControllers.CommonClientPath}/{publicKey}");
        }

        public async Task GetTestExceptionAsync()
        {
            await _client.GetAsync<string>(ApiControllers.CommonExceptionPath);
        }
    }
}
