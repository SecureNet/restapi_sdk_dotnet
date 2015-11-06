using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class BatchCloseRequest : SecureNetRequest
    {

        public DeveloperApplication DeveloperApplication { get; set; }

        #region Methods

        public override string GetUri()
        {
            return "api/batches/Close";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
