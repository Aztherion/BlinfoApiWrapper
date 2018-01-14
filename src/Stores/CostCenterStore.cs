using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class CostCenterStore
    {
        private readonly BaseRestClient _client;

        public CostCenterStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetCostCenterResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetCostCenterResponseItem>(ApiControllers.CostCenterPath);
        }

        public async Task<GetCostCenterResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetCostCenterResponseItem>($"{ApiControllers.CostCenterPath}/{id}");
        }

        public async Task<PostCostCenterResponseItem> Post(PostCostCenterRequestItem item)
        {
            return await _client.PostAsync<PostCostCenterResponseItem>(item, ApiControllers.CostCenterPath);
        }

        public async Task<PutCostCenterResponseItem> Put(PutCostCenterRequestItem item)
        {
            return await _client.PutAsync<PutCostCenterResponseItem>(item, ApiControllers.CostCenterPath);
        }
    }
}
