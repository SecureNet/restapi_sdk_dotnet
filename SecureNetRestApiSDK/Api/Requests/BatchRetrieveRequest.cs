using System;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class BatchRetrieveRequest : SecureNetRequest
    {
        #region Properties

        public int Id { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return String.Format("api/batches/{0}", Id);
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.GET;
        }

        #endregion
    }
}
