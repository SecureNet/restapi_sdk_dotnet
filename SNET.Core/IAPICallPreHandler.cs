using System.Collections.Generic;

namespace SNET.Core
{
    public interface IAPICallPreHandler
    {
        Dictionary<string, string> GetHeaderMap();

        string GetPayload();

        string GetEndpoint();

     
    }
}
