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
            return "api/transactions/Search";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
