using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetOrderResponseItem
    {
        [JsonProperty(PropertyName = "box")]
        public string Box { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        [JsonProperty(PropertyName = "customerId")]
        public string CustomerId  { get; set; }
        [JsonProperty(PropertyName = "customerOrderNumber")]
        public string CustomerOrderNumber { get; set; }
        [JsonProperty(PropertyName = "deliveryBox")]
        public string DeliveryBox { get; set; }
        [JsonProperty(PropertyName = "deliveryCity")]
        public string DeliveryCity { get; set; }
        [JsonProperty(PropertyName = "deliveryCountry")]
        public string DeliveryCountry { get; set; }
        [JsonProperty(PropertyName = "deliveryDate")]
        public string DeliveryDate { get; set; }
        [JsonProperty(PropertyName = "deliveryMethodText")]
        public string DeliveryMethodText { get; set; }
        [JsonProperty(PropertyName = "deliveryName")]
        public string DeliveryName { get; set; }
        [JsonProperty(PropertyName = "deliveryRefrence")]
        public string DeliveryReference { get; set; }
        [JsonProperty(PropertyName = "deliveryStreet")]
        public string DeliveryStreet { get; set; }
        [JsonProperty(PropertyName = "deliveryTermsText")]
        public string DeliveryTermsText { get; set; }
        [JsonProperty(PropertyName = "deliveryZip")]
        public string DeliveryZip { get; set; }
        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "documentHeader")]
        public string DocumentHeader { get; set; }
        [JsonProperty(PropertyName = "freight")]
        public decimal Freight { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "invoiceDate")]
        public string InvoiceDate { get; set; }
        [JsonProperty(PropertyName = "invoiceDueDate")]
        public string InvoiceDueDate { get; set; }
        [JsonProperty(PropertyName = "invoiceNumber")]
        public int InvoiceNumber { get; set; }
        [JsonProperty(PropertyName = "invoicingBlocked")]
        public bool InvoicingBlocked { get; set; }
        [JsonProperty(PropertyName = "lines")]
        public List<GetOrderRowResponseItem> Lines { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "noVAT")]
        public bool NoVat { get; set; }
        [JsonProperty(PropertyName = "orderRegistrationDate")]
        public string OrderRegistrationDate { get; set; }
        [JsonProperty(PropertyName = "orderType")]
        public string OrderType { get; set; }
        [JsonProperty(PropertyName = "ourReference")]
        public string OurReference { get; set; }
        [JsonProperty(PropertyName = "paymentTermsText")]
        public string PaymentTermsText { get; set; }
        [JsonProperty(PropertyName = "preliminary")]
        public bool Preliminary { get; set; }
        [JsonProperty(PropertyName = "registeredByUser")]
        public string RegisteredByUser { get; set; }
        [JsonProperty(PropertyName = "requisitionNumber")]
        public string RequisitionNumber { get; set; }
        [JsonProperty(PropertyName = "rounding")]
        public decimal Rounding { get; set; }
        [JsonProperty(PropertyName = "serviceFee")]
        public decimal ServiceFee { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "sumGross")]
        public decimal SumGross { get; set; }
        [JsonProperty(PropertyName = "sumNet")]
        public decimal SumNet { get; set; }
        [JsonProperty(PropertyName = "sumVat")]
        public decimal SumVat { get; set; }
        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public decimal Weight { get; set; }
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        public GetOrderResponseItem()
        {
            Box = string.Empty;
            City = string.Empty;
            Comment = string.Empty;
            Country = string.Empty;
            Currency = string.Empty;
            CustomerId = string.Empty;
            CustomerOrderNumber = string.Empty;
            DeliveryBox = string.Empty;
            DeliveryCity = string.Empty;
            DeliveryCountry = string.Empty;
            DeliveryDate = string.Empty;
            DeliveryMethodText = string.Empty;
            DeliveryName = string.Empty;
            DeliveryReference = string.Empty;
            DeliveryStreet = string.Empty;
            DeliveryTermsText = string.Empty;
            DeliveryZip = string.Empty;
            Department = string.Empty;
            Description = string.Empty;
            DocumentHeader = string.Empty;
            InvoiceDate = string.Empty;
            InvoiceDueDate = string.Empty;
            Lines = new List<GetOrderRowResponseItem>();
            Name = string.Empty;
            RegisteredByUser = string.Empty;
            OrderType = string.Empty;
            OurReference = string.Empty;
            PaymentTermsText = string.Empty;
            RegisteredByUser = string.Empty;
            RequisitionNumber = string.Empty;
            Street = string.Empty;
            YourReference = string.Empty;
            Zip = string.Empty;
        }


    }

    public class GetOrderRowResponseItem
    {
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }
        [JsonProperty(PropertyName = "articleId")]
        public string ArticleId { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "deliveredQuantity")]
        public decimal DeliveredQuantity { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "discountAmount")]
        public decimal DiscountAmount { get; set; }
        [JsonProperty(PropertyName = "discountPercentage")]
        public decimal DiscountPercentage { get; set; }
        [JsonProperty(PropertyName = "orderedQuantity")]
        public decimal OrderedQuantity { get; set; }
        [JsonProperty(PropertyName = "registeredDate")]
        public string RegisteredDate { get; set; }
        [JsonProperty(PropertyName = "rowNumber")]
        public int RowNumber { get; set; }
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        [JsonProperty(PropertyName = "unitPrice")]
        public decimal UnitPrice { get; set; }
        [JsonProperty(PropertyName = "vatCode")]
        public string VatCode { get; set; }
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public decimal Weight { get; set; }

        public GetOrderRowResponseItem()
        {
            AccountId = string.Empty;
            ArticleId = string.Empty;
            Comment = string.Empty;
            Description = string.Empty;
            RegisteredDate = string.Empty;
            Unit = string.Empty;
            VatCode = string.Empty;
        }
    }
}
