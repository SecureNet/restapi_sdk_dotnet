using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Additional infomation for terminal details.
    /// </summary>
    public class AdditionalTerminalInfo
    {
        #region Properties

        /// <summary>
        ///  Terminal identifier. 
        /// </summary>
        [JsonProperty("terminalId")]
        public string TerminalId { get; set; }

        /// <summary>
        /// City where the terminal is located.
        /// </summary>
        [JsonProperty("terminalCity")]
        public string TerminalCity { get; set; }

        /// <summary>
        /// State where the terminal is located.
        /// </summary>
        [JsonProperty("terminalState")]
        public string TerminalState { get; set; }

        /// <summary>
        /// Additional terminal location information.
        /// </summary>
        [JsonProperty("terminalLocation")]
        public string TerminalLocation { get; set; }

        /// <summary>
        /// Store number where the terminal is located.
        /// </summary>
        [JsonProperty("storeNumber")]
        public string StoreNumber { get; set; }

        #endregion
    }
}
