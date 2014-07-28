
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class Check
    {
        #region Properties

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("checkType")]
        public string CheckType { get; set; }

        [JsonProperty("routingNumber")]
        public string RoutingNumber { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("checkNumber")]
        public string CheckNumber { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }

        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("verification")]
        public string Verification { get; set; }

        #endregion
    }
}
