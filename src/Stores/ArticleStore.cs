using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class ArticleStore
    {
        private readonly BaseRestClient _client;

        public ArticleStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetArticleResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetArticleResponseItem>(ApiControllers.ArticlePath);
        }

        public async Task<GetArticleResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetArticleResponseItem>($"{ApiControllers.ArticlePath}/{id}");
        }

        public async Task<IEnumerable<GetArticleResponseItem>> GetAllByAccountNrAsync(string accountNumber)
        {
            return await _client.GetAsync<GetArticleResponseItem>($"{ApiControllers.ArticleAccountPath}/{accountNumber}");
        }

        public async Task<PostArticleResponseItem> PostAsync(PostArticleRequestItem item)
        {
            return await _client.PostAsync<PostArticleResponseItem>(item, ApiControllers.ArticlePath);
        }

        public async Task<PutArticleResponseItem> PutAsync(PutArticleRequestItem item)
        {
            return await _client.PutAsync<PutArticleResponseItem>(item, ApiControllers.ArticlePath);
        }
     }
}
