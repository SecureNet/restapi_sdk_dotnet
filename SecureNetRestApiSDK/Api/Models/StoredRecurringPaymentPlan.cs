using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class StoredRecurringPaymentPlan
    {
        #region Properties

        [JsonProperty("cycleType")]
        public string CycleType { get; set; }

        [JsonProperty("dayOfTheMonth")]
        public int DayOfTheMonth { get; set; }

        [JsonProperty("dayOfTheWeek")]
        public int DayOfTheWeek { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("planId")]
        public int PlanId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("nextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [JsonProperty("maxRetries")]
        public int MaxRetries { get; set; }

        [JsonProperty("primaryPaymentMethodId")]
        public string PrimaryPaymentMethodId { get; set; }

        [JsonProperty("secondaryPaymentMethodId")]
        public string SecondaryPaymentMethodId { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        [JsonProperty("schedules")]
        public List<Schedule> Schedules { get; set; }

        #endregion
    }
}
