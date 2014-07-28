using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class InstallmentPaymentPlan
    {
        #region Properties

        [JsonProperty("cycleType")]
        public string CycleType { get; set; }

        [JsonProperty("dayOfTheMonth")]
        public int DayOfTheMonth { get; set; }

        [JsonProperty("dayOfTheWeek")]
        public int DayOfTheWeek { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty("numberOfPayments")]
        public int NumberOfPayments { get; set; }

        [JsonProperty("installmentAmount")]
        public decimal InstallmentAmount { get; set; }

        [JsonProperty("balloonAmount")]
        public decimal BalloonAmount { get; set; }

        [JsonProperty("balloonPaymentAddedTo")]
        public string BalloonPaymentAddedTo { get; set; }

        [JsonProperty("remainderAmount")]
        public decimal RemainderAmount { get; set; }

        [JsonProperty("remainderAmountAddedTo")]
        public string RemainderAmountAddedTo { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("planId")]
        public int PlanId { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

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
