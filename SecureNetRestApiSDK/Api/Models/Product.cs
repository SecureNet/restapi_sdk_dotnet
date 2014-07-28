using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class Product
    {
        #region Properties

        [JsonProperty("alternateTaxId")]
        public string AlternateTaxId { get; set; }

        [JsonProperty("commodityCode")]
        public string CommodityCode { get; set; }

        [JsonProperty("discountAmount")]
        public decimal DiscountAmount { get; set; }

        [JsonProperty("discountRate")]
        public decimal DiscountRate { get; set; }

        [JsonProperty("discountIndicator")]
        public string DiscountIndicator { get; set; }

        [JsonProperty("grossNetIndicator")]
        public string GrossNetIndicator { get; set; }

        [JsonProperty("itemCode")]
        public string ItemCode { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        [JsonProperty("taxRate")]
        public decimal TaxRate { get; set; }

        [JsonProperty("taxTypeIdentifier")]
        public string TaxTypeIdentifier { get; set; }

        [JsonProperty("taxTypeApplied")]
        public string TaxTypeApplied { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        #endregion
    }
}
