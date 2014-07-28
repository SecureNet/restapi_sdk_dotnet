using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureNetRestApiSDK.Api.Controllers;
using SecureNetRestApiSDK.Api.Models;
using SecureNetRestApiSDK.Api.Requests;
using SecureNetRestApiSDK.Api.Responses;
using SNET.Core;

namespace SecureNetRestApiSDK_UnitTest.Controllers
{
    [TestClass]
    public class PreVaultControllerTests
    {
        #region Tokenization

        /// <summary>
        /// Successful response returned from a Create Token Using Credit Card request.
        /// https://apidocs.securenet.com/docs/tokenization.html?lang=csharp#tokencard
        /// </summary>
        [TestMethod]
        public void Tokenization_Create_Token_Using_Credit_Card_Request_Returns_Successfully()
        {
            // Arrange
            var request = new TokenCardRequest
            {
                PublicKey = "278DCC4B-85FE-485D-AFDD-9927AC4CA229",
                Card = new Card
                {
                    Number = "4111 1111 1111 1111",
                    ExpirationDate = "01/2017",
                    Address = new Address
                    {
                        Line1 = "123 Main St.",
                        City = "Austin",
                        State = "TX",
                        Zip = "78759"
                    }
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PreVaultController();

            // Act
            var response = controller.ProcessRequest<TokenCardResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Create Token Using Credit Card request.
        /// https://apidocs.securenet.com/docs/tokenization.html?lang=csharp#tokencheck
        /// </summary>
        [TestMethod]
        public void Tokenization_Create_Token_Using_Checking_Information_Request_Returns_Successfully()
        {
            // Arrange
            var request = new TokenCheckRequest
            {
                PublicKey = "278DCC4B-85FE-485D-AFDD-9927AC4CA229",
                Check = new Check
                {
                    FirstName = "John",
                    LastName = "Smith",
                    RoutingNumber = "222371863",
                    AccountNumber = "123456",
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PreVaultController();

            // Act
            var response = controller.ProcessRequest<TokenCheckResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion
    }
}
