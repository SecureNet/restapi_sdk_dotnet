using System;
using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Enums;

namespace SecureNetRestApiSDK.Api.Models
{
    public class Encryption
    {
        #region Properties

        [JsonProperty("encryptionMode")]
        public String EncryptionMode = EncryptionModeType.NONE.ToString(); // default to no encryption

        #endregion

        #region Methods

        public Encryption SetEncryptionMode(String passIn)
        {
            if (string.IsNullOrEmpty(passIn))
            {
                EncryptionMode = EncryptionModeType.NONE.ToString();
                return this;
            }
            
            if (passIn.ToUpper().Trim() == "IDTECH_MSR")
            {
                EncryptionMode = EncryptionModeType.IDTECH_MSR.ToString();
            }
            else if (passIn.ToUpper().Trim() == "MAGTEK_MSR")
            {
                EncryptionMode = EncryptionModeType.MAGTEK_MSR.ToString();
            }
            else if (passIn.ToUpper().Trim() == "MAGTEK_IPAD")
            {
                EncryptionMode = EncryptionModeType.MAGTEK_IPAD.ToString();
            }
            return this;
        }

        #endregion
    }
}
