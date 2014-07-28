using System;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class RetrieveCustomerRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}", CustomerId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.GET;
        }

        #endregion
    }
}

