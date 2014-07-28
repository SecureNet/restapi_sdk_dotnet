using System;
using System.Configuration;
using System.Collections.Generic;
using SecureNetRestApiSDK.Api.Requests;
using Newtonsoft.Json;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Controllers
{
    public abstract class BaseController
    {
        #region Attributes
        #endregion

        #region Methods

        public T ProcessRequest<T>(APIContext apiContext, SecureNetRequest secureNetRequest)
        {
            if (secureNetRequest == null)
            {
                throw new ArgumentNullException("secureNetRequest");
            }

            object[] parameters = null;
            string resourcePath = SDKUtil.FormatURIPath(secureNetRequest.GetUri(), parameters);

            string payLoad = JsonConvert.SerializeObject(secureNetRequest);
           
            apiContext.Config = new Dictionary<string, string>
            {
                {"secureNetId", ConfigurationManager.AppSettings["secureNetId"]},
                {"secureKey", ConfigurationManager.AppSettings["secureKey"]},
                {"mode", ConfigurationManager.AppSettings["mode"]},
                {"endpoint", ConfigurationManager.AppSettings["endpoint"]},
                {"timeout", ConfigurationManager.AppSettings["timeout"]},
                {"connectiontimeout", ConfigurationManager.AppSettings["connectiontimeout"]}
            };

            return Helper.ConfigureAndExecute<T>(apiContext, secureNetRequest.GetMethod(), resourcePath, payLoad);
        }

        #endregion
    }
}
