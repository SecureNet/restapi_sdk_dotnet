using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class AddInstallmentPaymentPlanResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("storedInstallmentPaymentPlan")]
        public StoredInstallmentPaymentPlan StoredInstallmentPaymentPlan { get; set; }

        [JsonProperty("storedRecurringPaymentPlan")]
        public object StoredRecurringPaymentPlan { get; set; }

        [JsonProperty("storedVariablePaymentPlan")]
        public object StoredVariablePaymentPlan { get; set; }

        #endregion
    }
}
