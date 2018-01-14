using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class CostBearerStore
    {
        private readonly BaseRestClient _client;

        public CostBearerStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetCostBearerResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetCostBearerResponseItem>(ApiControllers.CostBearerPath);
        }

        public async Task<GetCostBearerResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetCostBearerResponseItem>($"{ApiControllers.CostBearerPath}/{id}");
        }

        public async Task<PostCostBearerResponseItem> Post(PostCostBearerRequestItem item)
        {
            return await _client.PostAsync<PostCostBearerResponseItem>(item, ApiControllers.CostBearerPath);
        }

        public async Task<PutCostBearerResponseItem> Put(PutCostBearerRequestItem item)
        {
            return await _client.PutAsync<PutCostBearerResponseItem>(item, ApiControllers.CostBearerPath);
        }
    }
}
