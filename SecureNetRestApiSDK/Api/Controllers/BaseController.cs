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

            string payLoad = JsonConvert.SerializeObject(secureNetRequest);

            apiContext.Config = new Dictionary<string, string>
            {
                {"secureNetId", ConfigurationManager.AppSettings["secureNetId"]},
                {"secureKey", ConfigurationManager.AppSettings["secureKey"]},
                {"mode", ConfigurationManager.AppSettings["mode"]},
                {"endpoint", ConfigurationManager.AppSettings["endpoint"]},
                {"timeout", ConfigurationManager.AppSettings["timeout"]},
                {"connectionTimeout", ConfigurationManager.AppSettings["connectionTimeout"]},
                  {"developerId", ConfigurationManager.AppSettings["developerId"]},
                    {"versionId", ConfigurationManager.AppSettings["versionId"]}
            };

            return Helper.ConfigureAndExecute<T>(apiContext, secureNetRequest.GetMethod(), secureNetRequest.GetUri(), payLoad);
        }

        #endregion
    }
}
