using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class CustomerInvoiceStore
    {
        private readonly BaseRestClient _client;

        public CustomerInvoiceStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetCustomerInvoiceResponseItem>> GetByDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            var path = $"{ApiControllers.CustomerInvoiceDatePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}";
            return await _client.GetAsync<GetCustomerInvoiceResponseItem>(path);
        }

        public async Task<IEnumerable<GetCustomerInvoiceResponseItem>> GetByDueDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            var path = $"{ApiControllers.CustomerInvoiceDueDatePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}";
            return await _client.GetAsync<GetCustomerInvoiceResponseItem>(path);
        }

        public async Task<GetCustomerInvoiceResponseItem> GetSingleAsync(int number)
        {
            return await _client.GetSingleAsync<GetCustomerInvoiceResponseItem>($"{ApiControllers.CustomerInvoicePath}/{number:F0}");
        }
    }
}
