using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class StoredScheduledVariablePaymentPlan
    {
        #region Properties

        [JsonProperty("scheduleId")]
        public int ScheduleId { get; set; }

        [JsonProperty("paymentDate")]
        public DateTime? PaymentDate { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("transactionId")]
        public int TransactionId { get; set; }

        [JsonProperty("processed")]
        public string Processed { get; set; }

        [JsonProperty("numberOfRetries")]
        public int? NumberOfRetries { get; set; }

        [JsonProperty("scheduledDate")]
        public DateTime ScheduledDate { get; set; }
        #endregion
    }
}
