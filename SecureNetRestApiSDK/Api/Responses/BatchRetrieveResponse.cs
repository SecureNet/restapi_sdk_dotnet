using System.Collections.Generic;
using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class BatchRetrieveResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("batchId")]
        public string BatchId { get; set; }

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("batchCount")]
        public int BatchCount { get; set; }

        #endregion
    }
}
