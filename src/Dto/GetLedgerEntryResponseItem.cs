using System;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetLedgerEntryResponseItem
    {
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        [JsonProperty(PropertyName = "costBearerId")]
        public string CostBearerId { get; set; }
        [JsonProperty(PropertyName = "costCenterId")]
        public string CostCenterId { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        public GetLedgerEntryResponseItem()
        {
            AccountId = string.Empty;
            CostBearerId = string.Empty;
            CostCenterId = string.Empty;
            ProjectId = string.Empty;
            Text = string.Empty;
        }
    }
}