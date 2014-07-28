using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecureNetRestApiSDK.Api.Models
{
    public class VaultCustomer
    {
        #region Properties

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("sendEmailReceipts")]
        public bool SendEmailReceipts { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("userDefinedFields")]
        public List<UserDefinedField> UserDefinedFields { get; set; }

        [JsonProperty("paymentMethods")]
        public List<PaymentMethod> PaymentMethods { get; set; }

        [JsonProperty("primaryPaymentMethodId")]
        public string PrimaryPaymentMethodId { get; set; }

        [JsonProperty("variablePaymentPlans")]
        public List<VariablePaymentPlan> VariablePaymentPlans { get; set; }

        [JsonProperty("recurringPaymentPlans")]
        public List<RecurringPaymentPlan> RecurringPaymentPlans { get; set; }

        [JsonProperty("installmentPaymentPlans")]
        public List<InstallmentPaymentPlan> InstallmentPaymentPlans { get; set; }

        #endregion
    }
}
