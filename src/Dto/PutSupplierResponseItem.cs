using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class PutSupplierResponseItem
    {
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }
        [JsonProperty(PropertyName = "bg")]
        public string Bg { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "costAccount")]
        public string CostAccount { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        [JsonProperty(PropertyName = "defaultOcr")]
        public string DefaultOcr { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "organisationId")]
        public string OrganisationId { get; set; }
        [JsonProperty(PropertyName = "paymentTerms")]
        public string PaymentTerms { get; set; }
        [JsonProperty(PropertyName = "pg")]
        public string Pg { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "receivableAccount")]
        public string ReceivableAccount { get; set; }
        [JsonProperty(PropertyName = "vatCode")]
        public int VatCode { get; set; }
        [JsonProperty(PropertyName = "vatNr")]
        public string VatNr { get; set; }
        [JsonProperty(PropertyName = "web")]
        public string Web { get; set; }
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }
        [JsonProperty(PropertyName = "zipCode")]
        public string Zipcode { get; set; }

        public PutSupplierResponseItem()
        {
            Address1 = string.Empty;
            Address2 = string.Empty;
            Bg = string.Empty;
            Category = string.Empty;
            City = string.Empty;
            Comment = string.Empty;
            CostAccount = string.Empty;
            Country = string.Empty;
            Currency = string.Empty;
            DefaultOcr = string.Empty;
            Email = string.Empty;
            Fax = string.Empty;
            Id = string.Empty;
            Name = string.Empty;
            OrganisationId = string.Empty;
            PaymentTerms = string.Empty;
            Pg = string.Empty;
            Phone = string.Empty;
            ReceivableAccount = string.Empty;
            VatNr = string.Empty;
            Web = string.Empty;
            YourReference = string.Empty;
            Zipcode = string.Empty;
        }
    }
}