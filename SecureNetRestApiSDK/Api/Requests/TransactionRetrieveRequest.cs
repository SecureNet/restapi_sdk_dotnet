using System;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class TransactionRetrieveRequest : SecureNetRequest
    {
        #region Properties

        public int TransactionId { get; set; }

        #endregion

        #region Methods


        public override string GetUri()
        {
            return String.Format("api/transactions/{0}", TransactionId);
        }





        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.GET;
        }

        #endregion
    }
}
