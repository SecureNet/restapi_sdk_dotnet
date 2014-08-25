using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;

namespace SNET.Core
{
    public abstract class Helper
    {
        public static T ConfigureAndExecute<T>(APIContext apiContext, HttpMethodEnum httpMethod, string resource, string payload)
        {
            if (apiContext == null)
                throw new Exception("APIContext object is null");

            Dictionary<string, string> config = apiContext.Config;
            string resourcePath = resource;
            Dictionary<string, string> httpHeaders = apiContext.HTTPHeaders;
            string requestId = apiContext.RequestId;
            IAPICallPreHandler iApiCallPreHandler = Helper.CreateIAPICallPreHandler(config, httpHeaders, requestId, payload);
            return Helper.ConfigureAndExecute<T>(config, iApiCallPreHandler, httpMethod, resourcePath);
        }


        private static IAPICallPreHandler CreateIAPICallPreHandler(Dictionary<string, string> config, Dictionary<string, string> headersMap, string requestId, string payLoad)
        {
            return (IAPICallPreHandler)new RestApiCallPreHandler(config, headersMap)
            {
                RequestId = requestId,
                Payload = payLoad
            };
        }

        private static T ConfigureAndExecute<T>(Dictionary<string, string> config, IAPICallPreHandler apiCallPreHandler, HttpMethodEnum httpMethod, string resourcePath)
        {
            try
            {
                Uri result = (Uri)null;
                Dictionary<string, string> headerMap = apiCallPreHandler.GetHeaderMap();
                Uri baseUri = new Uri(apiCallPreHandler.GetEndpoint());
                if (!Uri.TryCreate(baseUri, resourcePath, out result))
                    throw null; 
                ConnectionManager instance = ConnectionManager.Instance;
                instance.GetConnection(config, result.ToString());

                HttpWebRequest connection = CreateHttpWebRequestConnection(config, httpMethod, result, instance);

                SetHttpHeaders(headerMap, connection);
             
                string str = new HttpConnection(config).Execute(apiCallPreHandler.GetPayload(), connection);
                if (typeof(T).Name.Equals("Object"))
                    return default(T);
                if (typeof(T).Name.Equals("String"))
                    return (T)Convert.ChangeType((object)str, typeof(T));
                else
                    return JsonConvert.DeserializeObject<T>(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static void SetHttpHeaders(Dictionary<string, string> headerMap, HttpWebRequest connection)
        {
            if (headerMap != null && headerMap.ContainsKey("Content-Type"))
            {
                connection.ContentType = headerMap["Content-Type"].Trim();
                headerMap.Remove("Content-Type");
            }
            else
                connection.ContentType = "application/json";
            if (headerMap.ContainsKey("User-Agent"))
            {
                connection.UserAgent = headerMap["User-Agent"];
                headerMap.Remove("User-Agent");
            }
            foreach (KeyValuePair<string, string> keyValuePair in headerMap)
                ((NameValueCollection)connection.Headers).Add(keyValuePair.Key, keyValuePair.Value);
        }

        private static HttpWebRequest CreateHttpWebRequestConnection(Dictionary<string, string> config, HttpMethodEnum httpMethod, Uri result, ConnectionManager instance)
        {
            HttpWebRequest connection = instance.GetConnection(config, result.ToString());
            connection.Method = ((object)httpMethod).ToString();
            connection.Timeout = int.Parse(config["connectionTimeout"].ToString());
            connection.ContinueTimeout = int.Parse(config["connectionTimeout"].ToString());
            return connection;
        }
    }


}
