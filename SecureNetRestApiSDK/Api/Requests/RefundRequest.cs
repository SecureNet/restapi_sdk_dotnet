using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class RefundRequest : SecureNetRequest
    {
        #region Properties

        public int TransactionId { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/Payments/Refund";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
