using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class BatchCurrentResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("batchId")]
        public string BatchId { get; set; }

        [JsonProperty("transactions")]
        public object Transactions { get; set; }

        [JsonProperty("batchCount")]
        public int BatchCount { get; set; }

        #endregion
    }
}
