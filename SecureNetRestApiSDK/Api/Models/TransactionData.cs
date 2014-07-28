using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class TransactionData
    {
        #region Properties

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        #endregion
    }
}
