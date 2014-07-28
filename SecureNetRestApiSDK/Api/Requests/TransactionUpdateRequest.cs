using System;
using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class TransactionUpdateRequest : SecureNetRequest
    {
        #region Properties

        public int ReferenceTransactionId { get; set; }
        public string DutyAmount { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/transactions/{0}", ReferenceTransactionId);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.PUT;
        }

        #endregion
    }
}
