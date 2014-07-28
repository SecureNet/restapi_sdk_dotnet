using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Contains Level Two transaction data.
    /// </summary>
    public class LevelTwoData
    {
        #region Properties

        /// <summary>
        /// Date of the transaction.
        /// </summary>
        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Purchase order number associated with the transaction
        /// </summary>
        [JsonProperty("purchaseOrder")]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Duty amount included in the transaction.
        /// </summary>
        [JsonProperty("dutyAmount")]
        public decimal DutyAmount { get; set; }

        /// <summary>
        /// Freight amount included in the transaction.
        /// </summary>
        [JsonProperty("freightAmount")]
        public decimal FreightAmount { get; set; }

        /// <summary>
        /// Lane number at which the transaction was completed in a retail environment.
        /// </summary>
        [JsonProperty("retailLaneNumber")]
        public int RetailLaneNumber { get; set; }

        /// <summary>
        /// Tax amount for the transaction.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Tax status of the transaction.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion
    }
}
