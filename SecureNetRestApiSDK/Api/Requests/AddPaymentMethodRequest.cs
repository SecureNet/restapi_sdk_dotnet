using System;
using System.Collections.Generic;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class AddPaymentMethodRequest : SecureNetRequest
    {
        #region Properties

        public string CustomerId { get; set; }
        public Card Card { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public int AccountDuplicateCheckIndicator { get; set; }
        public bool Primary { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/Customers/{0}/PaymentMethod", CustomerId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
