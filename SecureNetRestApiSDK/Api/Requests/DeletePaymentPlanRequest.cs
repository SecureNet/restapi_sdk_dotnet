using System;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class DeletePaymentPlanRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public string PlanId { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentSchedules/{1}", CustomerId, PlanId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.DELETE;
        }

        #endregion
    }
}
