using System;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class UpdateInstallmentPaymentPlanRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public string PlanId { get; set; }
        public InstallmentPaymentPlan Plan { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/customers/{0}/PaymentSchedules/installment/{1}", CustomerId, PlanId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.PUT;
        }

        #endregion
    }
}
