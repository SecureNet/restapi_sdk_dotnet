using System;
using System.Collections.Generic;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class UpdatePaymentMethodRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public string PaymentMethodId { get; set; }
        public Card Card { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public bool Primary { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentMethod/{1}", CustomerId, PaymentMethodId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.PUT;
        }

        #endregion
    }
}
