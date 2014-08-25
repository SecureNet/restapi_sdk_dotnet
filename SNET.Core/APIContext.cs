using System;
using System.Collections.Generic;

namespace SNET.Core
{
    public class APIContext
    {
        private string requestId;
        private Dictionary<string, string> dynamicConfig;
        private Dictionary<string, string> httpHeaders;

        public string RequestId
        {
            get
            {
                string str = (string)null;

                if (string.IsNullOrEmpty(this.requestId))
                    this.requestId = Convert.ToString((object)Guid.NewGuid());
                str = this.requestId;
                return str;
            }
        }

        public Dictionary<string, string> Config
        {
            get
            {
                return this.dynamicConfig;
            }
            set
            {
                this.dynamicConfig = value;
            }
        }

        public Dictionary<string, string> HTTPHeaders
        {
            get
            {
                return this.httpHeaders;
            }
            set
            {
                this.httpHeaders = value;
            }
        }

   


        public APIContext()
        {
           
        }

    }
}
