using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class AddPaymentMethodResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("vaultPaymentMethod")]
        public VaultPaymentMethod VaultPaymentMethod { get; set; }

        #endregion
    }
}
