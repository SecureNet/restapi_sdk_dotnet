using SecureNetRestApiSDK.Api.Models;
using SNET.Core;

namespace SecureNetRestApiSDK.Api.Requests
{
    /// <summary>
    /// Request class used for allowing a previously authorized transaction to be captured for settlement.
    /// </summary>
    public class PriorAuthCaptureRequest : SecureNetRequest
    {
        #region Properties

        /// <summary>
        /// Identifier of the previously authorized transaction to be captured.
        /// </summary>
        public int? TransactionId { get; set; }

        /// <summary>
        /// Contains developer Id and version information related to the integration.
        /// </summary>
        public DeveloperApplication DeveloperApplication { get; set; }

        /// <summary>
        /// Final amount of the transaction. Used in cases where the transaction amount needs to be modified after the original authorization.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Additional data to assist in reporting, ecommerce or moto transactions, and level 2 or level 3 processing. Includes user-defined fields and invoice-related information.  
        /// If a gratuity is to be added to the previously authorized amount, it can be sent in the serviceData object field. 
        /// </summary>
        public ExtendedInformation ExtendedInformation { get; set; }

        #endregion

        #region Methods

        public override string GetUri()
        {
            return "api/Payments/Capture";
        }

        public override HttpMethodEnum GetMethod()
        {
            return HttpMethodEnum.POST;
        }

        #endregion
    }
}
