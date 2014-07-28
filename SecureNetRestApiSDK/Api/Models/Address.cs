using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Account holder address details.
    /// </summary>
    public class Address
    {
        #region Properties

        /// <summary>
        /// Street address.
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 { get; set; }
        
        /// <summary>
        /// City where address is located.
        /// </summary>
        [JsonProperty("city")]
        
        public string City { get; set; }

        /// <summary>
        /// State where address is located; valid values are 2-character state abbreviations.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 5- or 9-digit zip code.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
        
        /// <summary>
        /// Country name. Defaults to US.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        #endregion
    }
}
