using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetCustomerInvoiceResponseItem
    {
        [JsonProperty(PropertyName = "amountInLocalCurrency")]
        public decimal AmountInLocalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountInOriginalCurrency")]
        public decimal AmountInOriginalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountPaidInLocalCurrency")]
        public decimal AmountPaidInLocalCurrency { get; set; }
        [JsonProperty(PropertyName = "amountPaidInOriginalCurrency")]
        public decimal AmountPaidInOriginalCurrency { get; set; }
        [JsonProperty(PropertyName = "associatedCustomerPayments")]
        public List<GetPaymentResponseItem> AssociatedCustomerPayments { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        [JsonProperty(PropertyName = "customerId")]
        public string CustomerId { get; set; }
        [JsonProperty(PropertyName = "dateOfLatestPayment")]
        public string DateOfLatestPayment { get; set; }
        [JsonProperty(PropertyName = "documentIds")]
        public List<string> DocumentIds { get; set; }
        [JsonProperty(PropertyName = "dueDate")]
        public string DueDate { get; set; }
        [JsonProperty(PropertyName = "externalInvoiceId")]
        public int ExternalInvoiceId { get; set; }
        [JsonProperty(PropertyName = "invoiceDate")]
        public string InvoiceDate { get; set; }
        [JsonProperty(PropertyName = "invoiceNumber")]
        public int InvoiceNumber { get;set; }
        [JsonProperty(PropertyName = "journalEntryDate")]
        public string JournalEntryDate { get; set; }
        [JsonProperty(PropertyName = "journalEntryId")]
        public int JournalEntryId { get; set; }
        [JsonProperty(PropertyName = "journalId")]
        public string JournalId { get; set; }
        [JsonProperty(PropertyName = "numberOfRemindersSent")]
        public int NumberOfRemindersSent { get; set; }
        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }
        [JsonProperty(PropertyName = "paid")]
        public bool Paid { get; set; }
        [JsonProperty(PropertyName = "paymentType")]
        public int PaymentType { get; set; }
        [JsonProperty(PropertyName = "preliminary")]
        public bool Preliminary { get; set; }
        [JsonProperty(PropertyName = "receivableAccount")]
        public string ReceivableAccount { get; set; }
        [JsonProperty(PropertyName = "registeredByUser")]
        public string RegisteredByUser { get; set; }
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }

        public GetCustomerInvoiceResponseItem()
        {
            AssociatedCustomerPayments = new List<GetPaymentResponseItem>();
            Currency = string.Empty;
            CustomerId = string.Empty;
            DateOfLatestPayment = string.Empty;
            DocumentIds = new List<string>();
            DueDate = string.Empty;
            InvoiceDate = string.Empty;
            JournalEntryDate = string.Empty;
            JournalId = string.Empty;
            ReceivableAccount = string.Empty;
            RegisteredByUser = string.Empty;
        }
    }
}
