using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class DocumentStore
    {
        private readonly BaseRestClient _client;

        public DocumentStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<GetDocumentResponseItem> GetSingleAsync(int documentId)
        {
            var document = new GetDocumentResponseItem();
            using (var client = _client.GetClient())
            {
                var response = await client.GetAsync($"{ApiControllers.ApiBaseUrl}/{ApiControllers.DocumentPath}/{documentId:F0}");
                document.Name = GetFilename(response.Content);
                document.Data = await response.Content.ReadAsByteArrayAsync();
                return document;
            }
        }

        private string GetFilename(HttpContent content)
        {
            var contentDispositionFilename = content.Headers.GetValues("Content-Disposition").SingleOrDefault(t => t.Contains("filename"));
            if (string.IsNullOrEmpty(contentDispositionFilename)) return null;
            var filename = contentDispositionFilename.Split('=')[1].Trim('"');
            return filename;
        }
    }
}
