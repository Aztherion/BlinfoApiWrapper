using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class FinancialYearStore
    {
        private readonly BaseRestClient _client;

        public FinancialYearStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetFinancialYearResponseItem>> GetAllAsync()
        {
            return await _client.GetAsync<GetFinancialYearResponseItem>(ApiControllers.FinancialYearPath);
        }

        public async Task<GetFinancialYearResponseItem> GetSingleAsync(string id)
        {
            return await _client.GetSingleAsync<GetFinancialYearResponseItem>($"{ApiControllers.FinancialYearPath}/{id}");
        }

        public async Task<GetFinancialYearResponseItem> GetByDate(DateTime date)
        {
            return await _client.GetSingleAsync<GetFinancialYearResponseItem>($"{ApiControllers.FinancialYearDatePath}/{date:yyyy-MM-dd}");
        }
    }
}
