using System;
using System.Collections.Generic;
using System.Text;

namespace SNET.Core
{

    public class RestApiCallPreHandler : IAPICallPreHandler
    {
        private string requestId;
        private Dictionary<string, string> config;
        public string payLoad;
        private Dictionary<string, string> headersMap;

        public string RequestId
        {
            private get
            {
                return this.requestId;
            }
            set
            {
                this.requestId = value;
            }
        }

        public string Payload
        {
            get
            {
                return this.payLoad;
            }
            set
            {
                this.payLoad = value;
            }
        }

        public RestApiCallPreHandler(Dictionary<string, string> config, Dictionary<string, string> headersMap)
        {
            this.config = config;
            this.headersMap = headersMap == null ? new Dictionary<string, string>() : headersMap;
        }

        public Dictionary<string, string> GetHeaderMap()
        {
            return this.GetProcessedHeadersMap();
        }

        public string GetPayload()
        {
            return this.GetProcessedPayload();
        }

        public string GetEndpoint()
        {
            return this.GetProcessedEndPoint();
        }


        protected Dictionary<string, string> GetProcessedHeadersMap()
        {
            Dictionary<string, string> dictionaryMap = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(this.GetSecureNetId()) && !string.IsNullOrEmpty(this.GetSecureKey()))
                dictionaryMap.Add("Authorization", "Basic " + this.EncodeToBase64(this.GetSecureNetId(), this.GetSecureKey()));
            if (!string.IsNullOrEmpty(this.RequestId))
                dictionaryMap.Add("SecureNet-Request-Id", this.RequestId);
            Dictionary<string, string> dictionaryMapAgent = this.FormUserAgentHeader(this.GetDeveloperId(), this.GetDeveloperId());
            if (dictionaryMapAgent != null && dictionaryMapAgent.Count > 0)
            {
                foreach (KeyValuePair<string, string> keyValuePair in dictionaryMapAgent)
                    dictionaryMap.Add(keyValuePair.Key, keyValuePair.Value);
            }
            if (this.headersMap != null && this.headersMap.Count > 0)
            {
                foreach (KeyValuePair<string, string> keyValuePair in this.headersMap)
                    dictionaryMap.Add(keyValuePair.Key, keyValuePair.Value);
            }
            return dictionaryMap;
        }

        protected string GetProcessedPayload()
        {
            return this.Payload;
        }

        protected string GetProcessedEndPoint()
        {
            string str = (string)null;
            if (this.config.ContainsKey("endpoint"))
                str = this.config["endpoint"];
            else if (this.config.ContainsKey("mode"))
            {
                switch (this.config["mode"])
                {
                    case "live":
                        str = "https://gwapi.demo.securenet.com/";
                        break;
                    case "sandbox":
                        str = "https://gwapi.demo.securenet.com/";
                        break;
                }
            }
            if (!str.EndsWith("/"))
                str = str + "/";
            return str;
        }

        protected Dictionary<string, string> FormUserAgentHeader(string developerId, string versionId)
        {
            return new UserAgentHeader(developerId, versionId).GetHeader();
        }

        private string GetSecureNetId()
        {
            if (!this.config.ContainsKey("secureNetId"))
                return (string)null;
            else
                return this.config["secureNetId"];
        }

        private string GetSecureKey()
        {
            if (!this.config.ContainsKey("secureKey"))
                return (string)null;
            else
                return this.config["secureKey"];
        }

        private string GetDeveloperId()
        {
            if (!this.config.ContainsKey("developerId"))
                return (string)null;
            else
                return this.config["developerId"];
        }

        private string GetVersionId()
        {
            if (!this.config.ContainsKey("versionId"))
                return (string)null;
            else
                return this.config["versionid"];
        }

        private string EncodeToBase64(string secureNetId, string secureKey)
        {
            try
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(secureNetId + ":" + secureKey));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
