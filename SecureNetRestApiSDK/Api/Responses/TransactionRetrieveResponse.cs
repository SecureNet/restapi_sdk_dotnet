using System.Collections.Generic;
using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class TransactionRetrieveResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        #endregion
    }
}
