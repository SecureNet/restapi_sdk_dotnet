using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class BatchCurrentRequest : SecureNetRequest
    {
        #region Methods

        public override string GetUri()
        {
            return "api/batches/Current";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.GET;
        }

        #endregion
    }
}
