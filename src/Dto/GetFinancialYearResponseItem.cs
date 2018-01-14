using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetFinancialYearResponseItem
    {
        [JsonProperty(PropertyName = "blockFollowingOpeningBalance")]
        public bool BlockFollowingOpeningBalance { get; set; }
        [JsonProperty(PropertyName = "closingActive")]
        public bool ClosingActive { get; set; }
        [JsonProperty(PropertyName = "firstOpenPeriod")]
        public string FirstOpenPeriod { get; set; }
        [JsonProperty(PropertyName = "fromDate")]
        public string FromDate { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "latestVoucherDate")]
        public string LatestVoucherDate { get; set; }
        [JsonProperty(PropertyName = "open")]
        public bool Open { get; set; }
        [JsonProperty(PropertyName = "openingBalanceClosed")]
        public bool OpeningBalanceClosed { get; set; }
        [JsonProperty(PropertyName = "toDate")]
        public string ToDate { get; set; }

        public GetFinancialYearResponseItem()
        {
            FirstOpenPeriod = string.Empty;
            FromDate = string.Empty;
            Id = string.Empty;
            LatestVoucherDate = string.Empty;
            ToDate = string.Empty;
        }
    }
}
