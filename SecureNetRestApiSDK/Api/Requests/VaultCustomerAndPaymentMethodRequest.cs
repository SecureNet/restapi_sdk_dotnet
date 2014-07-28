using System.Collections.Generic;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class VaultCustomerAndPaymentMethodRequest : SecureNetRequest
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public string EmailAddress { get; set; }
        public bool SendEmailReceipts { get; set; }
        public string Company { get; set; }
        public string Notes { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }
        public int CustomerDuplicateCheckIndicator { get; set; }
        public Card Card { get; set; }
        public string Phone { get; set; }
        public bool Primary { get; set; }
        public int AccountDuplicateCheckIndicator { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/Customers/Payments";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
