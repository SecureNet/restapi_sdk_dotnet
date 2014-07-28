using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    /// <summary>
    /// Base class for all SecureNet requests.
    /// </summary>
    public abstract class SecureNetRequest
    {
        #region Properties  
        #endregion

        #region Methods

        public abstract string GetUri();

        public abstract HttpMethodEnum GetMethod();

        #endregion
    }
}
