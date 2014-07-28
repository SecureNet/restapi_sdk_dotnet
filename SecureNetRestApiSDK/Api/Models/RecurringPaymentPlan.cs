using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class RecurringPaymentPlan
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

        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("planId")]
        public int PlanId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("nextPaymentDate")]
        public DateTime NextPaymentDate { get; set; }

        [JsonProperty("maxRetries")]
        public int MaxRetries { get; set; }

        [JsonProperty("primaryPaymentMethodId")]
        public string PrimaryPaymentMethodId { get; set; }

        [JsonProperty("secondaryPaymentMethodId")]
        public string SecondaryPaymentMethodId { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        #endregion
    }
}
