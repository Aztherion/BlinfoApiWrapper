using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class DetailsStore
    {
        private readonly BaseRestClient _client;

        public DetailsStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<GetDetailsResponseItem> GetSingleAsync()
        {
            return await _client.GetSingleAsync<GetDetailsResponseItem>(ApiControllers.DetailsPath);
        }
    }
}
