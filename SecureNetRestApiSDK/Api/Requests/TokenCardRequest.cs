using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    public class TokenCardRequest : SecureNetRequest
    {
        #region Properties

        public string PublicKey { get; set; }
        public Card Card { get; set; }
        public DeveloperApplication DeveloperApplication { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/PreVault/Card";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
