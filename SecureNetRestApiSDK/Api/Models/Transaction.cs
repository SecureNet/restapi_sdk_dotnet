using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class Transaction
    {
        #region Properties

        [JsonProperty("secureNetId")]
        public int SecureNetId { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("transactionId")]
        public int TransactionId { get; set; }

        [JsonProperty("authorizationCode")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("authorizedAmount")]
        public double AuthorizedAmount { get; set; }

        [JsonProperty("allowedPartialCharges")]
        public bool AllowedPartialCharges { get; set; }

        [JsonProperty("paymentTypeCode")]
        public string PaymentTypeCode { get; set; }

        [JsonProperty("paymentTypeResult")]
        public string PaymentTypeResult { get; set; }

        [JsonProperty("level2Valid")]
        public bool Level2Valid { get; set; }

        [JsonProperty("level3Valid")]
        public bool Level3Valid { get; set; }

        [JsonProperty("transactionData")]
        public TransactionData TransactionData { get; set; }

        [JsonProperty("settlementData")]
        public object SettlementData { get; set; }

        [JsonProperty("vaultData")]
        public object VaultData { get; set; }

        [JsonProperty("creditCardType")]
        public string CreditCardType { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("avsCode")]
        public string AvsCode { get; set; }

        [JsonProperty("avsResult")]
        public string AvsResult { get; set; }

        [JsonProperty("cardHolder_FirstName")]
        public string CardHolderFirstName { get; set; }

        [JsonProperty("cardHolder_LastName")]
        public string CardHolderLastName { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("billAddress")]
        public Address BillAddress { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("company")]
        public object Company { get; set; }

        [JsonProperty("cardCodeCode")]
        public string CardCodeCode { get; set; }

        [JsonProperty("cardCodeResult")]
        public string CardCodeResult { get; set; }

        [JsonProperty("accountName")]
        public object AccountName { get; set; }

        [JsonProperty("accountType")]
        public object AccountType { get; set; }

        [JsonProperty("accountNumber")]
        public object AccountNumber { get; set; }

        [JsonProperty("checkNumber")]
        public object CheckNumber { get; set; }

        [JsonProperty("traceNumber")]
        public object TraceNumber { get; set; }

        [JsonProperty("surchargeAmount")]
        public double SurchargeAmount { get; set; }

        [JsonProperty("cashbackAmount")]
        public double CashbackAmount { get; set; }

        [JsonProperty("fnsNumber")]
        public object FnsNumber { get; set; }

        [JsonProperty("voucherNumber")]
        public object VoucherNumber { get; set; }

        [JsonProperty("fleetCardInfo")]
        public object FleetCardInfo { get; set; }

        [JsonProperty("gratuity")]
        public double Gratuity { get; set; }

        [JsonProperty("industrySpecificData")]
        public string IndustrySpecificData { get; set; }

        [JsonProperty("marketSpecificData")]
        public string MarketSpecificData { get; set; }

        [JsonProperty("networkCode")]
        public string NetworkCode { get; set; }

        [JsonProperty("additionalAmount")]
        public double AdditionalAmount { get; set; }

        [JsonProperty("additionalData1")]
        public object AdditionalData1 { get; set; }

        [JsonProperty("additionalData2")]
        public object AdditionalData2 { get; set; }

        [JsonProperty("additionalData3")]
        public object AdditionalData3 { get; set; }

        [JsonProperty("additionalData4")]
        public string AdditionalData4 { get; set; }

        [JsonProperty("additionalData5")]
        public string AdditionalData5 { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("imageResult")]
        public object ImageResult { get; set; }

        #endregion
    }
}
