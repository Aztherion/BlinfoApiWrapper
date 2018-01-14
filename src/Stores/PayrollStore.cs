using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlInfoApiWrapper.Communication;
using BlInfoApiWrapper.Dto;
using BlInfoApiWrapper.Lib;

namespace BlInfoApiWrapper.Stores
{
    public class PayrollStore
    {
        private readonly BaseRestClient _client;

        public PayrollStore(string accessToken, string userKey)
        {
            _client = new BaseRestClient(accessToken, userKey);
        }

        public async Task<GetPayrollResponseItem> GetSingleAsync(int id)
        {
            return await _client.GetSingleAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollPath}/{id:F0}");
        }

        public async Task<IEnumerable<GetPayrollResponseItem>> GetByEmployeeAsync(int employeeId)
        {
            return await _client.GetAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollEmployeePath}/{employeeId:F0}");
        }

        public async Task<GetPayrollResponseItem> GetByEmployeeAndDateAsync(int employeeId, DateTime payrollDate)
        {
            return await _client.GetSingleAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollEmployeePath}/{employeeId:F0}/{payrollDate:yyyy-MM-dd}");
        }

        public async Task<IEnumerable<GetPayrollResponseItem>> GetByEmployeeAndDateIntervalAsync(int employeeId, DateTime fromDate, DateTime toDate)
        {
            return await _client.GetAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollEmployeePath}/{employeeId:F0}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}");
        }

        public async Task<IEnumerable<GetPayrollResponseItem>> GetByDateAsync(DateTime payrollDate)
        {
            return await _client.GetAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollDatePath}/{payrollDate:yyyy-MM-dd}");
        }

        public async Task<IEnumerable<GetPayrollResponseItem>> GetByDateIntervalAsync(DateTime fromDate, DateTime toDate)
        {
            return await _client.GetAsync<GetPayrollResponseItem>($"{ApiControllers.PayrollPath}/{fromDate:yyyy-MM-dd}/{toDate:yyyy-MM-dd}");
        }
    }
}
