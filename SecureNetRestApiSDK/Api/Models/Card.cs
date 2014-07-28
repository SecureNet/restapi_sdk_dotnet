using System;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    /// <summary>
    /// Credit Card Specific Data. 
    /// </summary>
    public class Card
    {
        #region Properties

        /// <summary>
        /// Data that has been read from the card's magnetic stripe.
        /// </summary>
        [JsonProperty("trackData")]
        public String TrackData { get; set; }

        /// <summary>
        /// Credit card account number.
        /// </summary>
        [JsonProperty("number")]
        public String Number { get; set; }

        /// <summary>
        /// Card security code.
        /// </summary>
        [JsonProperty("cvv")]
        public String Cvv { get; set; }

        /// <summary>
        /// Expiration date for the card. Format: MM/YYYY.
        /// </summary>
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Unaltered KSN Number from PIN pad. (Debit only.)
        /// </summary>
        [JsonProperty("ksn")]
        public String Ksn { get; set; }

        /// <summary>
        /// Pinblock obtained from the PIN pad. (Debit only.)
        /// </summary>
        [JsonProperty("pinBlock")]
        public String PinBlock { get; set; }

        /// <summary>
        /// First name of the account holder.
        /// </summary>
        [JsonProperty("firstName")]
        public String FirstName { get; set; }

        /// <summary>
        /// Last name of the account holder.
        /// </summary>
        [JsonProperty("lastName")]
        public String LastName { get; set; }

        /// <summary>
        /// Billing address of the account holder.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Image of the signature of the cardholder as completed at the time of the transaction.
        /// </summary>
        [JsonProperty("signature")]
        public byte[] Signature { get; set; }

        #endregion
    }
}
