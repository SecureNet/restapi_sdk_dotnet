using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureNetRestApiSDK.Api.Controllers;
using SecureNetRestApiSDK.Api.Models;
using SecureNetRestApiSDK.Api.Requests;
using SecureNetRestApiSDK.Api.Responses;
using SNET.Core;

namespace SecureNetRestApiSDK_UnitTest.Controllers
{
    [TestClass]
    public class TransactionsControllerTests
    {
        #region Transaction Reporting And Management

        /// <summary>
        /// Successful response returned from a Search Transaction request.
        /// https://apidocs.securenet.com/docs/transactions.html?lang=csharp#search
        /// </summary>
        [TestMethod]
        public void Transaction_Reporting_And_Management_Search_Transaction_Request_Returns_Successfully()
        {

            var paymentsController = new PaymentsControllerTests();
            int transactionId = paymentsController.Credit_Card_Present_AuthorizationOnly_Request_Returns_Successfully();
            // Arramge
            var request = new TransactionSearchRequest
            {
                TransactionId = transactionId,
                StartDate = DateTime.UtcNow.AddDays(-1),
                EndDate = DateTime.UtcNow.AddDays(1),
                Amount = 11.00m,
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new TransactionsController();

            // Act
            var response = controller.ProcessRequest<TransactionSearchResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Retrieve Transaction request.
        /// https://apidocs.securenet.com/docs/transactions.html?lang=csharp#retrieve
        /// </summary>
        [TestMethod]
        public void Transaction_Reporting_And_Management_Retrieve_Transaction_Request_Returns_Successfully()
        {
            var paymentsController = new PaymentsControllerTests();
            int transactionId = paymentsController.Credit_Card_Present_AuthorizationOnly_Request_Returns_Successfully();
            // Arrange
            var request = new TransactionRetrieveRequest
            {
                TransactionId = transactionId 
            };

            var apiContext = new APIContext();
            var controller = new TransactionsController();

            // Act
            var response = controller.ProcessRequest<TransactionRetrieveResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from an Update Transaction request.
        /// https://apidocs.securenet.com/docs/transactions.html?lang=csharp#update
        /// </summary>
        [TestMethod]
        public void Transaction_Reporting_And_Management_Update_Transaction_Request_Returns_Successfully()
        {
            // Arrange
            var request = new TransactionUpdateRequest
            {
                ReferenceTransactionId = 111995104, 
                DutyAmount = "2.07",
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new TransactionsController();

            // Act
            var response = controller.ProcessRequest<TransactionUpdateResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion
    }
}
