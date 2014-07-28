using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class Schedule
    {
        #region Properties

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("installmentDate")]
        public string InstallmentDate { get; set; }

        [JsonProperty("installmentNum")]
        public int InstallmentNum { get; set; }

        [JsonProperty("numOfRetries")]
        public int NumOfRetries { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("paymentdate")]
        public object Paymentdate { get; set; }

        [JsonProperty("paymentMethodId")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("processed")]
        public bool Processed { get; set; }

        [JsonProperty("scheduleId")]
        public int ScheduleId { get; set; }

        [JsonProperty("transcationId")]
        public int TranscationId { get; set; }

        #endregion
    }
}
