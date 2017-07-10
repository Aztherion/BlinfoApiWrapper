using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Exceptions;
using BlInfoApiWrapper.Lib;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Communication
{
    internal class BaseRestClient
    {
        private readonly string _accessToken;
        private readonly string _userKey;

        public BaseRestClient() : this(string.Empty, string.Empty) { }
        public BaseRestClient(string accessToken) : this(accessToken, string.Empty) { }

        public BaseRestClient(string accessToken, string userKey)
        {
            _accessToken = accessToken;
            _userKey = userKey;
        }

        public async Task DeleteAsync(string path)
        {
            using (var client = GetClient())
            {
                await client.DeleteAsync(GetUrl(path));
            }
        }

        public async Task<T> PostAsync<T>(object o, string path)
        {
            using (var client = GetClient())
            {
                var response = await client.PostAsync(GetUrl(path), new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8));
                var json = await response.Content.ReadAsStringAsync();
                if (IsErrorJson(json)) throw GetExceptionFromJson(json);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        public async Task<T> GetSingleAsync<T>(string path)
        {
            using (var client = GetClient())
            {
                var response = await client.GetAsync(GetUrl(path));
                var json = await response.Content.ReadAsStringAsync();
                if (IsErrorJson(json)) throw GetExceptionFromJson(json);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
        public async Task<IEnumerable<T>> GetAsync<T>(string path)
        {
            return await GetSingleAsync<List<T>>(path);
        }

        private bool IsErrorJson(string json)
        {
            return json.Contains("\"exception\"");
        }

        private Exception GetExceptionFromJson(string json)
        {
            return new BlApiException(JsonConvert.DeserializeObject<ExceptionItem>(json));
        }

        private string GetUrl(string path)
        {
            return $"{ApiControllers.ApiBaseUrl}{path}";
        }

        internal HttpClient GetClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.AcceptCharset.Clear();
            client.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue("utf-8"));

            if (!string.IsNullOrEmpty(_accessToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            }
            if (!string.IsNullOrEmpty(_userKey))
            {
                client.DefaultRequestHeaders.Add("User-Key", _userKey);
            }

            return client;
        }
    }
}
