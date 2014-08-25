using System;
using System.Collections.Generic;
using System.Net;

namespace SNET.Core
{
    public sealed class ConnectionManager
    {      
        private static readonly Lazy<ConnectionManager> laze = new Lazy<ConnectionManager>((Func<ConnectionManager>)(() => new ConnectionManager()));

        public static ConnectionManager Instance
        {
            get
            {
                return ConnectionManager.laze.Value;
            }
        }

        public HttpWebRequest GetConnection(Dictionary<string, string> config, string url)
        {
            HttpWebRequest httpWebRequest;
            try
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Timeout = int.Parse(config["connectionTimeout"].ToString()); 
            }
            catch (UriFormatException ex)
            {
                throw ex;
            }
           
            return httpWebRequest;
        }
    }
}
