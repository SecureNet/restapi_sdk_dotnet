using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class MailOrTelephoneData
    {
        #region Properties

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("totalNumberOfInstallments")]
        public String TotalNumberOfInstallments { get; set; }

        [JsonProperty("currentInstallment")]
        public String CurrentInstallment { get; set; }

        #endregion
    }
}
