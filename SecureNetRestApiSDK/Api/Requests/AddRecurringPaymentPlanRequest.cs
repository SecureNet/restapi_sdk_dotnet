using System;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class AddRecurringPaymentPlanRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public RecurringPaymentPlan Plan { get; set; }
        public bool IncludeRawObjects { get; set; }
        public bool IncludeRequest { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentSchedules/Recurring", CustomerId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
