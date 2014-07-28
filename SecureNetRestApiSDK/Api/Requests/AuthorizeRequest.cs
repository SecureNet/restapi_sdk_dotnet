using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    /// <summary>
    /// Request class used for authorizing a transaction.
    /// </summary>
    public class AuthorizeRequest : SecureNetRequest
    {
        #region Properties

        /// <summary>
        /// Amount of the charge to be authorized.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Credit-card-specific data. In the case of a card-present transaction, track data from a swiped transaction is the most commonly used property. Required for credit card charges.
        /// </summary>
        public Card Card { get; set; }

        /// <summary>
        /// Contains developer Id and version information related to the integration.
        /// </summary>
        public DeveloperApplication DeveloperApplication { get; set; }

        /// <summary>
        /// Data from a Vault payment account. Required for transactions where a Vault token is sent in the place of card or check data.
        /// </summary>
        public PaymentVaultToken PaymentVaultToken { get; set; }

        /// <summary>
        /// Indicates whether the card object is to be added to the vault to be stored as a token.
        /// </summary>
        public bool AddToVault { get; set; }

        /// <summary>
        /// Indicates whether the card object is to be added to the vault to be stored as a token even if the attempted authorization is declined.
        /// </summary>
        public bool AddToVaultOnFailure { get; set; }

        /// <summary>
        /// Typically used as an optional field for pin debit processing. The value of cashBackAmount indicates the amount in cash to be given back to the customer during card processing.
        /// </summary>
        public decimal CashBackAmount { get; set; }

        /// <summary>
        /// Indicates whether it is permissible to authorize less than the total balance available on a prepaid card.
        /// </summary>
        public bool AllowPartialChanges { get; set; }

        /// <summary>
        /// Indicates how checks for duplicate transactions should behave. Duplicates are evaluated on the basis of amount, card number, and order ID; these evaluation criteria can be 
        /// extended to also include customer ID, invoice number, or a user-defined field. Valid values for this parameter are:
        /// 0 - No duplicate check 
        /// 1 - Exception code is returned in case of duplicate
        /// 2 - Previously existing transaction is returned in case of duplicate
        /// 3 - Check is performed as above but without using order ID, and exception code is returned in case of duplicate 
        /// The transactionDuplicateCheckIndicator parameter must be enabled in the Virtual Terminal under Tools->Duplicate Transactions. Duplicates are checked only for APPROVED transactions.
        /// </summary>
        public int TransactionDuplicateCheckIndicator { get; set; }

        /// <summary>
        /// Client-generated unique ID for each transaction, used as a way to prevent the processing of duplicate transactions. The orderId must be unique to the merchant's SecureNet ID; 
        /// however, uniqueness is only evaluated for APPROVED transactions and only for the last 30 days. If a transaction is declined, the corresponding orderId may be used again. 
        /// (NOTE: orderId is not used in Prior Auth Capture.) 
        /// The orderId is limited to 25 characters; e.g., “CUSTOMERID MMddyyyyHHmmss”.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Encryption mode for the transaction. Required when using device-based encryption.
        /// </summary>
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Additional data to assist in reporting, ecommerce or moto transactions, and level 2 or level 3 processing. Includes user-defined fields and invoice-related information.
        /// </summary>
        public ExtendedInformation ExtendedInformation { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/Payments/Authorize";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
