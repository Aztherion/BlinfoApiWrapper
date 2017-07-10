using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class AccountStore
    {
        private readonly BaseRestClient _client;

        public AccountStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetAccountResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetAccountResponseItem>(ApiControllers.AccountPath);
        }

        public async Task<GetAccountResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetAccountResponseItem>($"{ApiControllers.AccountPath}/{id}");
        }
    }
}
