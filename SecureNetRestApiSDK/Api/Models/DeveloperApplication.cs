using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Contains information related to the integration.
    /// </summary>
    public class DeveloperApplication
    {
        #region Properties

        /// <summary>
        /// Developer ID of integrator as assigned by SecureNet.
        /// </summary>
        [JsonProperty("developerId")]
        public int DeveloperId { get; set; }

        /// <summary>
        /// Version number of the integrator's application.
        /// </summary>
        [JsonProperty("version")]
        public String Version { get; set; }

        #endregion
    }
}
