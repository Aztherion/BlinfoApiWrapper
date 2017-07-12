using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BlInfoApiWrapper.Dto
{
    public class GetArticleResponseItem
    {
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }
        [JsonProperty(PropertyName = "availableStock")]
        public int AvailableStock { get; set; }
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }
        [JsonProperty(PropertyName = "closed")]
        public bool Closed { get; set; }
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        [JsonProperty(PropertyName = "costPrice")]
        public decimal CostPrice { get; set; }
        [JsonProperty(PropertyName = "descriptionDE")]
        public string DescriptionDE { get; set; }
        [JsonProperty(PropertyName = "descriptionES")]
        public string DescriptionES { get; set; }
        [JsonProperty(PropertyName = "descriptionFR")]
        public string DescriptionFR { get; set; }
        [JsonProperty(PropertyName = "descriptionIT")]
        public string DescriptionIT { get; set; }
        [JsonProperty(PropertyName = "descriptionUK")]
        public string DescriptionUK { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "orderingPoint")]
        public decimal OrderingPoint { get; set; }
        [JsonProperty(PropertyName = "orderingQuantity")]
        public decimal OrderingQuantity { get; set; }
        [JsonProperty(PropertyName = "physicalStock")]
        public decimal PhysicalStock { get; set; }
        [JsonProperty(PropertyName = "sellPrice1")]
        public decimal SellPrice1 { get; set; }
        [JsonProperty(PropertyName = "sellPrice2")]
        public decimal SellPrice2 { get; set; }
        [JsonProperty(PropertyName = "sellPrice3")]
        public decimal SellPrice3 { get; set; }
        [JsonProperty(PropertyName = "sellPrice4")]
        public decimal SellPrice4 { get; set; }
        [JsonProperty(PropertyName = "sellPrice5")]
        public decimal SellPrice5 { get; set; }
        [JsonProperty(PropertyName = "sellPriceIncVat")]
        public decimal SellPriceIncVat { get; set; }
        [JsonProperty(PropertyName = "supplierArticleId")]
        public string SupplierArticleId { get; set; }
        [JsonProperty(PropertyName = "supplierId")]
        public string SupplierId { get; set; }
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
        [JsonProperty(PropertyName = "unitCostPrice")]
        public string UnitCostPrice { get; set; }
        [JsonProperty(PropertyName = "unitSellPrice1")]
        public string UnitSellPrice1 { get; set; }
        [JsonProperty(PropertyName = "unitSellPrice2")]
        public string UnitSellPrice2 { get; set; }
        [JsonProperty(PropertyName = "unitSellPrice3")]
        public string UnitSellPrice3 { get; set; }
        [JsonProperty(PropertyName = "unitSellPrice4")]
        public string UnitSellPrice4 { get; set; }
        [JsonProperty(PropertyName = "unitSellPrice5")]
        public string UnitSellPrice5 { get; set; }
        [JsonProperty(PropertyName = "vatCode")]
        public string VatCode { get; set; }
        [JsonProperty(PropertyName = "volume")]
        public decimal Volume { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public decimal Weight { get; set; }

        public GetArticleResponseItem()
        {
            Account = string.Empty;
            Barcode = string.Empty;
            Comment = string.Empty;
            DescriptionDE = string.Empty;
            DescriptionES = string.Empty;
            DescriptionFR = string.Empty;
            DescriptionIT = string.Empty;
            DescriptionUK = string.Empty;
            Id = string.Empty;
            Name = string.Empty;
            SupplierArticleId = string.Empty;
            SupplierId = string.Empty;
            UnitCostPrice = string.Empty;
            UnitSellPrice1 = string.Empty;
            UnitSellPrice2 = string.Empty;
            UnitSellPrice3 = string.Empty;
            UnitSellPrice4 = string.Empty;
            UnitSellPrice5 = string.Empty;
            VatCode = string.Empty;
        }
    }
}
