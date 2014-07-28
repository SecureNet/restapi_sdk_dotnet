using System.Collections.Generic;
using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class TransactionSearchResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        #endregion
    }
}
