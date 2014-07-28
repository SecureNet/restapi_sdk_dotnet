using System;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class AddInstallmentPaymentPlanRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public InstallmentPaymentPlan Plan { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentSchedules/Installment", CustomerId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
