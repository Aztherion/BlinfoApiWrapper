using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class ScheduleStore
    {
        private readonly BaseRestClient _client;

        public ScheduleStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<IEnumerable<GetSchedulerResponseItem>> GetByDateIntervaAsync(DateTime fromDate, DateTime toDate, int employeeId)
        {
            return await _client.GetAsync<GetSchedulerResponseItem>($"{ApiControllers.SchedulePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}/{employeeId}");
        }

        public async Task<IEnumerable<GetSchedulerResponseItem>> GetByDateIntervalDetailsOnlyAsync(DateTime fromDate, DateTime toDate, int employeeId)
        {
            return await _client.GetAsync<GetSchedulerResponseItem>($"{ApiControllers.SchedulePath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}/{employeeId}?DETAILSONLY");
        }
    }
}
