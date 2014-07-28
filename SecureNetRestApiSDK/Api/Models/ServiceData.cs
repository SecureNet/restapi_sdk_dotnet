
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Stores information on gratuity and the server name.
    /// </summary>
    public class ServiceData
    {
        #region Properties

        /// <summary>
        /// Tip amount.
        /// </summary>
        [JsonProperty("gratuityAmount")]
        public decimal GratuityAmount { get; set; }

        /// <summary>
        /// Server number (used in restaurant transactions).
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

        #endregion
    }
}
