using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class OrderStore
    {
        private readonly BaseRestClient _client;

        public OrderStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetOrderResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetOrderResponseItem>(ApiControllers.OrderAllPath);
        }
        public async Task<IEnumerable<GetOrderResponseItem>> GetAllNormalOrdersAsync()
        {
            return await _client.GetAsync<GetOrderResponseItem>(ApiControllers.OrderPath);
        }

        public async Task<IEnumerable<GetOrderResponseItem>> GetAllByTypeAsync(int type)
        {
            return await _client.GetAsync<GetOrderResponseItem>($"{ApiControllers.OrderTypePath}/{type:F0}");
        }

        public async Task<GetOrderResponseItem> GetSingleAsync(int id)
        {
            return await _client.GetSingleAsync<GetOrderResponseItem>($"{ApiControllers.OrderPath}/{id:F0}");
        }

        public async Task<GetOrderResponseItem> GetSingleByTypeAsync(int id, int type)
        {
            return await _client.GetSingleAsync<GetOrderResponseItem>($"{ApiControllers.OrderPath}/{type:F0}/{id:F0}");
        }
    }
}
