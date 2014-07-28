using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class DeletePaymentPlanResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("planId")]
        public object PlanId { get; set; }

        [JsonProperty("customerId")]
        public object CustomerId { get; set; }

        [JsonProperty("storedInstallmentPaymentPlan")]
        public object StoredInstallmentPaymentPlan { get; set; }

        [JsonProperty("storedRecurringPaymentPlan")]
        public object StoredRecurringPaymentPlan { get; set; }

        [JsonProperty("storedVariablePaymentPlan")]
        public object StoredVariablePaymentPlan { get; set; }

        #endregion
    }
}
