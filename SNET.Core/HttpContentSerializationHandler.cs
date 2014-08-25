using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SNET.Core
{
    public class HttpContentSerializationHandler : DelegatingHandler
    {
        public HttpContentSerializationHandler()
        {
        }

        public HttpContentSerializationHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.Content = ConvertToStreamContent(request.Content);

            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>((responseTask) =>
            {
                HttpResponseMessage response = responseTask.Result;
                response.Content = ConvertToStreamContent(response.Content);

                return response;
            });
        }

        private StreamContent ConvertToStreamContent(HttpContent originalContent)
        {
            if (originalContent == null)
            {
                return null;
            }

            StreamContent streamContent = originalContent as StreamContent;

            if (streamContent != null)
            {
                return streamContent;
            }

            MemoryStream ms = new MemoryStream();
            originalContent.CopyToAsync(ms).Wait();

              ms.Position = 0;

            streamContent = new StreamContent(ms);

             foreach (KeyValuePair<string, IEnumerable<string>> header in originalContent.Headers)
            {
                streamContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            return streamContent;
        }
    }
}
