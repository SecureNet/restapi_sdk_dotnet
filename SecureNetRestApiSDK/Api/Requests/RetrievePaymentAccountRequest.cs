using System;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class RetrievePaymentAccountRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public string PaymentMethodId { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentMethod/{1}", CustomerId, PaymentMethodId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.GET;
        }

        #endregion
    }
}

