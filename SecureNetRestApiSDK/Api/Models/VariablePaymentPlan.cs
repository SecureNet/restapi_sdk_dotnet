using System;
using System.Collections.Generic;

namespace SecureNetRestApiSDK.Api.Models
{
    public class VariablePaymentPlan : StoredVariablePaymentPlan
    {
        #region Properties

        public DateTime PlanEndDate { get; set; }
        public string PrimaryPaymentMethodId { get; set; }
        public string SecondaryPaymentMethodId { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }

        #endregion
    }
}
