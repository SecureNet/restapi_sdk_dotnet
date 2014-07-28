
using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class RetrievePaymentAccountResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("vaultPaymentMethod")]
        public VaultPaymentMethod VaultPaymentMethod { get; set; }

        #endregion
    }
}
