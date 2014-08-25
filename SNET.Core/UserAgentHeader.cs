using System;
using System.Collections.Generic;
using System.Text;

namespace SNET.Core
{

    internal class UserAgentHeader
    {
        private static string dotNetHeader = UserAgentHeader.DotNetVersionHeader;
        private static string osHeader = UserAgentHeader.GetOSHeader();

        private string developerId;
        private string developerVersion;

        private static string DotNetVersionHeader
        {
            get
            {
                return "language=DOTNET;v=" + ((object)Environment.Version).ToString().Trim();
            }
        }

        static UserAgentHeader()
        {
        }

        public UserAgentHeader(string developerId, string developerVersion)
        {
            this.developerId = string.IsNullOrEmpty(developerId) ? "" : developerId;
            this.developerVersion = string.IsNullOrEmpty(developerVersion) ? "" : developerVersion;
        }

        public Dictionary<string, string> GetHeader()
        {
            return new Dictionary<string, string>()
      {
        {
          "User-Agent",
          this.FormUserAgentHeader()
        }
      };
        }

        private string FormUserAgentHeader()
        {
            StringBuilder stringBuilder = new StringBuilder("SecureNetRestApiSDK/" + this.developerId + "/" + this.developerVersion + " ");
            stringBuilder.Append(";").Append(UserAgentHeader.dotNetHeader);
            if (!string.IsNullOrEmpty(UserAgentHeader.osHeader))
                stringBuilder.Append(";").Append(UserAgentHeader.osHeader);
            return ((object)stringBuilder).ToString();
        }

        private static string GetOSHeader()
        {
            string str1 = string.Empty;
            string str2;
            if (Environment.Is64BitOperatingSystem)
                str2 = string.Concat(new object[4]
        {
          (object) str1,
          (object) "bit=",
          (object) 64,
          (object) ";"
        });
            else
                str2 = string.Concat(new object[4]
        {
          (object) str1,
          (object) "bit=",
          (object) 32,
          (object) ";"
        });
            return str2 + (object)"os=" +  Environment.OSVersion.Version.ToString() + ";";
        }
    }

}
