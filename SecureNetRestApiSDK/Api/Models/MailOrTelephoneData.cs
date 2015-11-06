using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class MailOrTelephoneOrderData
    {
        #region Properties

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("totalNumberOfInstallments")]
        public int? TotalNumberOfInstallments { get; set; }

        [JsonProperty("currentInstallment")]
        public int? CurrentInstallment { get; set; }

        #endregion
    }
}
