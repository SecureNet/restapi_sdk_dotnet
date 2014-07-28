using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureNetRestApiSDK.Api.Controllers;
using SecureNetRestApiSDK.Api.Requests;
using SecureNetRestApiSDK.Api.Responses;
using SNET.Core;

namespace SecureNetRestApiSDK_UnitTest.Controllers
{
    [TestClass]
    public class BatchesControllerTests
    {
        #region Settlement

        /// <summary>
        /// Successful response returned from a Settlement Close Batch request.
        /// https://apidocs.securenet.com/docs/settlement.html?lang=csharp#closebatch
        /// </summary>
        [TestMethod]
        public void Settlement_Close_Batch_Request_Returns_Successfully()
        {
            // Arrange
            var request = new BatchCloseRequest();
            var apiContext = new APIContext();
            var controller = new BatchesController();

            // Act
            var response = controller.ProcessRequest<BatchCloseResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Settlement Retrieve Closed Batch request.
        /// https://apidocs.securenet.com/docs/settlement.html?lang=csharp#retrievebatch
        /// </summary>
        [TestMethod]
        public void Settlement_Retrieve_Closed_Batch_Request_Returns_Successfully()
        {
            // Arrange
            var request = new BatchRetrieveRequest
            {
                Id = 12345678
            };
            var apiContext = new APIContext();
            var controller = new BatchesController();

            // Act
            var response = controller.ProcessRequest<BatchRetrieveResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Settlement Retrieve Current Batch request.
        /// https://apidocs.securenet.com/docs/settlement.html?lang=csharp#currentbatch
        /// </summary>
        [TestMethod]
        public void Settlement_Retrieving_Current_Batch_Request_Returns_Successfully()
        {
            // Arrange
            var request = new BatchCurrentRequest();
            var apiContext = new APIContext();
            var controller = new BatchesController();

            // Act
            var response = controller.ProcessRequest<BatchCurrentResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion
    }
}
