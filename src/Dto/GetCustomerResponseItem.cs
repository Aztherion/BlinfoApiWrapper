using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetCustomerResponseItem
    {
        [JsonProperty(PropertyName = "bg")]
        public string Bg { get; set; }
        [JsonProperty(PropertyName = "box")]
        public string Box { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "creditLimit")]
        public decimal? CreditLimit { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        [JsonProperty(PropertyName = "deliveryTerms")]
        public string DeliveryTerms { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "interestInvoicingAllowed")]
        public bool InterestInvoicingAllowed { get; set; }
        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }
        [JsonProperty(PropertyName = "modeOfDelivery")]
        public string ModeOfDelivery { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "organisationNumber")]
        public string OrganisationNumber { get; set; }
        [JsonProperty(PropertyName = "paymentTerms")]
        public string PaymentTerms { get; set; }
        [JsonProperty(PropertyName = "pg")]
        public string Pg { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "pricelist")]
        public int Pricelist { get; set; }
        [JsonProperty(PropertyName = "receivableAccount")]
        public string ReceivableAccount { get; set; }
        [JsonProperty(PropertyName = "remindersAllowed")]
        public bool RemindersAllowed { get; set; }
        [JsonProperty(PropertyName = "remindersFeeAllowed")]
        public bool RemindersFeeAllowed { get; set; }
        [JsonProperty(PropertyName = "responsiblePerson")]
        public string ResponsiblePerson { get; set; }
        [JsonProperty(PropertyName = "salesAccount")]
        public string SalesAccount { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "vatCode")]
        public int VatCode { get; set; }
        [JsonProperty(PropertyName = "vatNumber")]
        public string VatNumber { get; set; }
        [JsonProperty(PropertyName = "web")]
        public string Web { get; set; }
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }


        public GetCustomerResponseItem()
        {
            Bg = string.Empty;
            Box = string.Empty;
            Category = string.Empty;
            City = string.Empty;
            Comment = string.Empty;
            Country = string.Empty;
            Currency = string.Empty;
            DeliveryTerms = string.Empty;
            Email = string.Empty;
            Fax = string.Empty;
            Id = string.Empty;
            Mobile = string.Empty;
            ModeOfDelivery = string.Empty;
            Name = string.Empty;
            OrganisationNumber = string.Empty;
            PaymentTerms = string.Empty;
            Pg = string.Empty;
            Phone = string.Empty;
            ReceivableAccount = string.Empty;
            ResponsiblePerson = string.Empty;
            SalesAccount = string.Empty;
            Street = string.Empty;
            VatNumber = string.Empty;
            Web = string.Empty;
            YourReference = string.Empty;
            Zip = string.Empty;
        }
    }
}
