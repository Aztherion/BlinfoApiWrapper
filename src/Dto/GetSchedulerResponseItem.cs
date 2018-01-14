using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetSchedulerResponseItem
    {
        public string Comment { get; set; }
        public string Date { get; set; }
        public List<GetScheduleDetailItem> Details { get; set; }
        public string EmployeeId { get; set; }
        public string EmploymentRate { get; set; }
        public  string FullDay { get; set; }
        public string HolidayCode { get; set; }
        public string Hours { get; set; }
        public string SpecialDay { get; set; }
        public string WeekDay { get; set; }
        public string WeeklyWorkingHours { get; set; }
        public int WeekNo { get; set; }
        public string WorkingDay { get; set; }

        public GetSchedulerResponseItem()
        {
            Comment = string.Empty;
            Date = string.Empty;
            EmployeeId = string.Empty;
            EmploymentRate = string.Empty;
            FullDay = string.Empty;
            HolidayCode = string.Empty;
            Hours = string.Empty;
            SpecialDay = string.Empty;
            WeekDay = string.Empty;
            WeeklyWorkingHours = string.Empty;
            WorkingDay = string.Empty;

        }
    }

    public class GetScheduleDetailItem
    {
        [JsonProperty(PropertyName = "activityCode")]
        public string ActivityCode { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        [JsonProperty(PropertyName = "compensationCode")]
        public string CompensationCode { get; set; }
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        [JsonProperty(PropertyName = "holidayFunding")]
        public bool HolidayFunding { get; set; }
        [JsonProperty(PropertyName = "invalidated")]
        public bool Invalidated { get; set; }
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        public GetScheduleDetailItem()
        {
            ActivityCode = string.Empty;
            CompensationCode = string.Empty;
            From = string.Empty;
            To = string.Empty;
            Unit = string.Empty;
        }
    }
}
