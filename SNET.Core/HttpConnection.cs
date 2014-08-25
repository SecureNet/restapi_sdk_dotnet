using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;

namespace SNET.Core
{
    public class HttpConnection
    {
        private Dictionary<string, string> config;

        public HttpConnection(Dictionary<string, string> config)
        {
            this.config = config;
        }


        public string Execute(string payLoad, HttpWebRequest httpRequest)
        {
           
            try
            {
                if (!string.IsNullOrEmpty(payLoad))
                {
                    switch (httpRequest.Method)
                    {
                        case "POST":
                        case "PUT":
                        case "DELETE":
                            using (StreamWriter streamWriter = new StreamWriter(((WebRequest)httpRequest).GetRequestStream()))
                            {
                                if (!string.IsNullOrEmpty(payLoad))
                                {
                                    streamWriter.Write(payLoad);
                                    ((TextWriter)streamWriter).Flush();
                                    streamWriter.Close();

                                    break;
                                }
                                else
                                    break;
                            }
                    }
                }
                using (WebResponse response = httpRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        string message = streamReader.ReadToEnd().Trim();
                        return message;
                    }
                }
            }
            catch (WebException ex)
            {
                string response = (string)null;
                if (ex.Response is HttpWebResponse)
                {
                    HttpStatusCode statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    using (StreamReader streamReader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd().Trim();
                        return response;
                    }
                }
            }

            return null;
        }

    }
}
