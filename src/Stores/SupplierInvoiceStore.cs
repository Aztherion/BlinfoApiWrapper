using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class SupplierInvoiceStore
    {
        private readonly BaseRestClient _client;

        public SupplierInvoiceStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetSupplierInvoiceResponseItem>> GetByDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            var path = $"{ApiControllers.SupplierInvoiceDatePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}";
            return await _client.GetAsync<GetSupplierInvoiceResponseItem>(path);
        }

        public async Task<IEnumerable<GetSupplierInvoiceResponseItem>> GetByDueDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            var path = $"{ApiControllers.SupplierInvoiceDueDatePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}";
            return await _client.GetAsync<GetSupplierInvoiceResponseItem>(path);
        }

        public async Task<GetSupplierInvoiceResponseItem> GetSingleAsync(string consecutiveNumber)
        {
            return await _client.GetSingleAsync<GetSupplierInvoiceResponseItem>($"{ApiControllers.SupplierInvoicePath}/{consecutiveNumber}");
        }

        public async Task<PostSupplierInvoiceResponseItem> Post(PostSupplierInvoiceRequestItem item)
        {
            return await _client.PostAsync<PostSupplierInvoiceResponseItem>(item, ApiControllers.SupplierInvoicePath);
        }
    }
}
