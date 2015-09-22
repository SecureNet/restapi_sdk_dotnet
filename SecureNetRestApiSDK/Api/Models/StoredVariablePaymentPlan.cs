﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SecureNetRestApiSDK.Api.Models
{
    public class StoredVariablePaymentPlan
    {
        #region Properties

        [JsonProperty("planStartDate")]
        public DateTime PlanStartDate { get; set; }

        [JsonProperty("scheduledPayments")]
        public List<StoredScheduledVariablePaymentPlan> ScheduledPayments { get; set; }

        [JsonProperty("maxRetries")]
        public int MaxRetries { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        #endregion
    }
}
