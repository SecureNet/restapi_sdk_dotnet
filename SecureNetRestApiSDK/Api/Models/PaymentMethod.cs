using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class PaymentMethod
    {
        #region Properties

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("check")]
        public object Check { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("lastAccessDate")]
        public object LastAccessDate { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        #endregion
    }
}
