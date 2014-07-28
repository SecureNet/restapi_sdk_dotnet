using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class VaultCustomerAndPaymentMethodResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("vaultCustomer")]
        public VaultCustomer VaultCustomer { get; set; }

        [JsonProperty("vaultPaymentMethod")]
        public VaultPaymentMethod VaultPaymentMethod { get; set; }

        [JsonProperty("accountResponseCode")]
        public int AccountResponseCode { get; set; }

        [JsonProperty("accountResponseMessage")]
        public object AccountResponseMessage { get; set; }

        [JsonProperty("accountSuccess")]
        public bool AccountSuccess { get; set; }

        [JsonProperty("accountResult")]
        public string AccountResult { get; set; }

        [JsonProperty("accountMessage")]
        public string AccountMessage { get; set; }

        [JsonProperty("customerResponseCode")]
        public int CustomerResponseCode { get; set; }

        [JsonProperty("customerResponseMessage")]
        public object CustomerResponseMessage { get; set; }

        [JsonProperty("customerSuccess")]
        public bool CustomerSuccess { get; set; }

        [JsonProperty("customerResult")]
        public string CustomerResult { get; set; }

        [JsonProperty("customerMessage")]
        public string CustomerMessage { get; set; }

        #endregion
    }
}
