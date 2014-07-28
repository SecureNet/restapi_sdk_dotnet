using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Additional data to assist in reporting, ecommerce or moto transactions, and level 2 or level 3 processing.
    /// </summary>
    public class ExtendedInformation
    {
        #region Properties

        /// <summary>
        ///  Type of goods that are being purchased. Valid values are DIGITAL or PHYSICAL. 
        /// </summary>
        [JsonProperty("typeOfGoods")]
        public String TypeOfGoods { get; set; }

        /// <summary>
        /// Additional terminal information. Required to process checks when using the SEC code POINT_OF_SALE.
        /// </summary>
        [JsonProperty("additionalTerminalInfo")]
        public AdditionalTerminalInfo AdditionalTerminalInfo { get; set; }

        /// <summary>
        /// Information related to level two processing.
        /// </summary>
        [JsonProperty("levelTwoData")]
        public LevelTwoData LevelTwoData { get; set; }

        /// <summary>
        /// Information related to level three processing.
        /// </summary>
        [JsonProperty("levelThreeData")]
        public LevelThreeData LevelThreeData { get; set; }

        /// <summary>
        /// Device code of the device where the transaction originated.
        /// </summary>
        [JsonProperty("deviceCode")]
        public String DeviceCode { get; set; }

        /// <summary>
        /// Entry source of the transaction.
        /// </summary>
        [JsonProperty("entrySource")]
        public String EntrySource { get; set; }

        /// <summary>
        /// Additional data for remote orders. Required in the case of a mail, phone, or ecommerce transaction.
        /// </summary>
        [JsonProperty("mailOrTelephoneData")]
        public MailOrTelephoneData MailOrTelephoneData { get; set; }

        /// <summary>
        /// Restaurant-related transaction information.
        /// </summary>
        [JsonProperty("serviceData")]
        public ServiceData ServiceData { get; set; }

        /// <summary>
        /// Custom user-defined fields that can be sent with the transaction for reporting purposes.
        /// </summary>
        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        /// <summary>
        /// Notes associated with the transaction.
        /// </summary>
        [JsonProperty("notes")]
        public String Notes { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        [JsonProperty("invoiceNumber")]
        public String InvoiceNumber { get; set; }

        /// <summary>
        /// Invoice description.
        /// </summary>
        [JsonProperty("invoiceDescription")]
        public String InvoiceDescription { get; set; }

        #endregion
    }
}
