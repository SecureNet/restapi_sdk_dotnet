
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class UserDefinedField
    {
        #region Properties

        [JsonProperty("udfName")]
        public string UdfName { get; set; }

        [JsonProperty("udfValue")]
        public string UdfValue { get; set; }

        #endregion
    }
}
