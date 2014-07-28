using System.Collections.Generic;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class CreateCustomerRequest : SecureNetRequest
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public object SendEmailReceipts { get; set; }
        public string Notes { get; set; }
        public object Address { get; set; }
        public string Company { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/Customers";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
