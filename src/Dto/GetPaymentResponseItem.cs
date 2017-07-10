using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetPaymentResponseItem
    {
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }
        [JsonProperty(PropertyName = "amountInLocalCurrency")]
        public decimal AmountInLocalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountInOriginalCurrency")]
        public decimal AmountInOriginalCurrency { get; set; }
        [JsonProperty(PropertyName = "journalEntryDate")]
        public string JournalEntryDate { get; set; }
        [JsonProperty(PropertyName = "journalEntryId")]
        public int JournalEntryId { get; set; }
        [JsonProperty(PropertyName = "journalId")]
        public string JournalId { get; set; }
        [JsonProperty(PropertyName = "paymentDate")]
        public string PaymentDate { get; set; }
        [JsonProperty(PropertyName = "preliminary")]
        public bool Preliminary { get; set; }
        [JsonProperty(PropertyName = "registeredByUser")]
        public string RegisteredByUser { get; set; }

        public GetPaymentResponseItem()
        {
            JournalEntryDate = string.Empty;
            JournalId = string.Empty;
            PaymentDate = string.Empty;
            RegisteredByUser = string.Empty;
        }
    }
}