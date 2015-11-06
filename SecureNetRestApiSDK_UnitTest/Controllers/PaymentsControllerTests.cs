using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecureNetRestApiSDK.Api.Controllers;
using SecureNetRestApiSDK.Api.Models;
using SecureNetRestApiSDK.Api.Requests;
using SecureNetRestApiSDK.Api.Responses;
using SNET.Core;

namespace SecureNetRestApiSDK_UnitTest.Controllers
{
    [TestClass]
    public class PaymentsControllerTests
    {
        #region Credit Card Present

        /// <summary>
        /// Unit Tests for an AuthorizationOnly request and a subsequent PriorAuthCapture request. Tests combined in one method to pass the
        /// required transaction identifier and guaranteee the order of operation.
        /// </summary>
        [TestMethod]
        public void Credit_Card_Present_AuthorizationOnly_And_PriorAuthCapture_Requests_Returns_Successfully()
        {
            int transactionId = Credit_Card_Present_AuthorizationOnly_Request_Returns_Successfully();
            
            Credit_Card_Present_PriorAuthCapture_Request_Returns_Successfully(transactionId);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Authorization Only request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#authonly
        /// </summary>
        public int Credit_Card_Present_AuthorizationOnly_Request_Returns_Successfully()
        {
            // Arrange
            var request = new AuthorizeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    TrackData = "%B4444333322221111^SECURENET^16041015432112345678?;4444333322221111=16041015432112345678?",
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<AuthorizeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.IsNotNull(response.Transaction);
            Assert.IsTrue(response.Transaction.TransactionId > 0);

            return response.Transaction.TransactionId;
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present PriorAuthCapture request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#priorauth
        /// </summary>
        public void Credit_Card_Present_PriorAuthCapture_Request_Returns_Successfully(int transactionId)
        {
            // Arrange
            var request = new PriorAuthCaptureRequest
            {
                Amount = 11.00m,
                TransactionId = transactionId, 
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                },
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<PriorAuthCaptureResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Charge request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#charge
        /// </summary>
        [TestMethod]
        public void Credit_Card_Present_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    TrackData = "%B4444333322221111^SECURENET^16041015432112345678?;4444333322221111=16041015432112345678?"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Unit Tests for an IncludeTip AuthorizationOnly request and a subsequent PriorAuthCapture request. Tests combined in one method to pass the
        /// required transaction identifier and guaranteee the order of operation.
        /// </summary>
        [TestMethod]
        public void Credit_Card_Present_IncludeTip_AuthorizationOnly_And_PriorAuthCapture_Requests_Returns_Successfully()
        {
            int transactionId = Credit_Card_Present_IncludeTip_AuthorizationOnly_Request_Returns_Successfully();

            Credit_Card_Present_IncludeTip_PriorAuthCapture_Request_Returns_Successfully(transactionId);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Include Tip AuthorizationOnly request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#includetip
        /// </summary>
        public int Credit_Card_Present_IncludeTip_AuthorizationOnly_Request_Returns_Successfully()
        {
            // Arrange
            var request = new AuthorizeRequest
            {
                Amount = 17.00m,
                Card = new Card
                {
                    TrackData = "%B4444333322221111^SECURENET^16041015432112345678?;4444333322221111=16041015432112345678?"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<AuthorizeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.IsNotNull(response.Transaction);
            Assert.IsTrue(response.Transaction.TransactionId > 0);

            return response.Transaction.TransactionId;
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present IncludTip PriorAuthCapture request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#includetip
        /// </summary>
        public void Credit_Card_Present_IncludeTip_PriorAuthCapture_Request_Returns_Successfully(int transactionId)
        {
            // Arrange
            var request = new PriorAuthCaptureRequest
            {
                Amount = 13.25m,
                TransactionId = transactionId, 
                ExtendedInformation = new ExtendedInformation
                {
                    ServiceData = new ServiceData
                    {
                        GratuityAmount = 1.75m,
                    },
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                },
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<PriorAuthCaptureResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Charge request that includes the address.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#includeaddress
        /// </summary>
        [TestMethod]
        public void Credit_Card_Present_Charge_Request_Including_Address_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    Number = "4444 3333 2222 1111",
                    Cvv = "999",
                    ExpirationDate = "04/2016",
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
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }


        #endregion

        #region Credit Card Not Present

        /// <summary>
        /// Unit Tests for an AuthorizationOnly request and a subsequent PriorAuthCapture request. Tests combined in one method to pass the
        /// required transaction identifier and guaranteee the order of operation.
        /// </summary>
        [TestMethod]
        public void Credit_Card_Not_Present_AuthorizationOnly_And_PriorAuthCapture_Requests_Returns_Successfully()
        {
            int transactionId = Credit_Card_Not_Present_AuthorizationOnly_Request_Returns_Successfully();

            Credit_Card_Not_Present_PriorAuthCapture_Request_Returns_Successfully(transactionId);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Not Present Authorization Only request.
        /// https://apidocs.securenet.com/docs/creditcardnotpresent.html?lang=JSON#authonly
        /// </summary>
        public int Credit_Card_Not_Present_AuthorizationOnly_Request_Returns_Successfully()
        {
            // Arrange
            var request = new AuthorizeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    Number = "4444 3333 2222 1111",
                    Cvv = "999",
                    ExpirationDate = "04/2016",
                    Address = new Address
                    {
                        Line1 = "123 Main St.",
                        City = "Austin",
                        State = "TX",
                        Zip = "78759"
                    },
                    FirstName = "Jack",
                    LastName = "Test"
                },
                ExtendedInformation = new ExtendedInformation
                {
                    TypeOfGoods = "PHYSICAL"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<AuthorizeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.IsNotNull(response.Transaction);
            Assert.IsTrue(response.Transaction.TransactionId > 0);

            return response.Transaction.TransactionId;
        }

        /// <summary>
        /// Successful response returned from a Credit Card Not Present PriorAuthCapture request.
        /// https://apidocs.securenet.com/docs/creditcardnotpresent.html?lang=JSON#priorauth
        /// </summary>
        public void Credit_Card_Not_Present_PriorAuthCapture_Request_Returns_Successfully(int transactionId)
        {
            // Arrange
            var request = new PriorAuthCaptureRequest
            {
                Amount = 11.00m,
                TransactionId = transactionId,
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<PriorAuthCaptureResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from a Charge-Authorization and Capture request.
        /// https://apidocs.securenet.com/docs/creditcardnotpresent.html?lang=JSON#charge
        /// </summary>
        [TestMethod]
        public void Credit_Card_Not_Present_Charge_Authorization_And_Capture_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    Number = "4444 3333 2222 1111",
                    Cvv = "999",
                    ExpirationDate = "04/2016",
                    Address = new Address
                    {
                        Line1 = "123 Main St.",
                        City = "Austin",
                        State = "TX",
                        Zip = "78759"
                    }
                },
                ExtendedInformation = new ExtendedInformation
                {
                    TypeOfGoods = "PHYSICAL"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from an Include Address request.
        /// https://apidocs.securenet.com/docs/creditcardnotpresent.html?lang=JSON#includeaddress
        /// </summary>
        [TestMethod]
        public void Credit_Card_Not_Present_Include_Addres_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    Number = "4444 3333 2222 1111",
                    Cvv = "999",
                    ExpirationDate = "04/2016",
                    Address = new Address
                    {
                        Line1 = "123 Main St.",
                        City = "Austin",
                        State = "TX",
                        Zip = "78759"
                    }
                },
                ExtendedInformation = new ExtendedInformation
                {
                    TypeOfGoods = "PHYSICAL"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }


   
        /// <summary>
        /// Successful response returned from an Charge using Tokenization request.
        /// https://apidocs.securenet.com/docs/creditcardnotpresent.html?lang=csharp#tokenization
        /// </summary>
        public void Credit_Card_Not_Present_Charge_Using_Tokenization_Request_Returns_Successfully(string token)
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 10.00m,
                PaymentVaultToken = new PaymentVaultToken
                {
                    PaymentMethodId = token,
                    PublicKey = "278DCC4B-85FE-485D-AFDD-9927AC4CA229"
                },
                AddToVault = true,
                ExtendedInformation = new ExtendedInformation
                {
                    TypeOfGoods = "PHYSICAL"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion

        #region ACH

        /// <summary>
        /// Successful response returned from an ACH Pay By Check Charge request.
        /// https://apidocs.securenet.com/docs/ach.html?lang=csharp#charge
        /// </summary>
        [TestMethod]
        public void ACH_Pay_By_Check_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 10.00m,
                Check = new Check
                {
                    FirstName = "Jack",
                    LastName = "Test",
                    RoutingNumber = "222371863",
                    AccountNumber = "123456"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from an ACH POS Charge request.
        /// https://apidocs.securenet.com/docs/ach.html?lang=csharp#chargepos
        /// </summary>
        [TestMethod]
        public void ACH_Charge_Account_Using_POS_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Check = new Check
                {
                    FirstName = "Jack",
                    LastName = "Test",
                    RoutingNumber = "222371863",
                    AccountNumber = "147852",
                    CheckNumber = "107",
                    AccountType = "SAVINGS",
                    CheckType = "POINT_OF_SALE",
                    Verification = "NONE",
                },
                ExtendedInformation = new ExtendedInformation
                {
                    AdditionalTerminalInfo = new AdditionalTerminalInfo
                    {
                        TerminalId = "1234",
                        TerminalCity = "Austin",
                        TerminalState = "TX",
                        TerminalLocation = "Office",
                        StoreNumber = "452"
                    }
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from an ACH Add Billing Address Charge request.
        /// https://apidocs.securenet.com/docs/ach.html?lang=csharp#billaddress
        /// </summary>
        [TestMethod]
        public void ACH_Add_Billing_Address_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 10.00m,
                Check = new Check
                {
                    FirstName = "Jack",
                    LastName = "Test",
                    RoutingNumber = "222371863",
                    AccountNumber = "123456",
                    Address = new Address
                    {
                        Line1 = "123 Main St.",
                        City = "Austin",
                        State = "TX",
                        Zip = "78759"
                    },
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        /// <summary>
        /// Successful response returned from an ACH Paying By Check with Verification Charge request.
        /// https://apidocs.securenet.com/docs/ach.html?lang=csharp#verification
        /// </summary>
        [TestMethod]
        public void ACH_Paying_By_Check_With_Verification_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 10.00m,
                Check = new Check
                {
                    FirstName = "Jack",
                    LastName = "Test",
                    RoutingNumber = "222371863",
                    AccountNumber = "123456",
                    Verification = "ACH_PROVIDER"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion

        #region Credits

        /// <summary>
        /// Successful response returned from a Credit An Account request.
        /// https://apidocs.securenet.com/docs/credits.html?lang=csharp
        /// </summary>
        [TestMethod]
        public void Credits_Credit_An_Account_Request_Returns_Successfully()
        {
            // Arrange
            var request = new CreditRequest
            {
                Amount = 1.05m,
                Card = new Card
                {
                    Number = "4111 1111 1111 1111",
                    ExpirationDate = "01/2017"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<CreditResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion

        #region Refunds

        /// <summary>
        /// Unit Tests for a Charge request and a subsequent Refund request. Tests combined in one method to pass the
        /// required transaction identifier and guaranteee the order of operation.
        /// </summary>
        [TestMethod]
        public void Refunds_Charge_And_Refund_Requests_Returns_Successfully()
        {
            int transactionId = Refunds_Charge_Request_Returns_Successfully();

            Refunds_Refund_Transaction_Request_Returns_Successfully(transactionId);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Charge request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#charge
        /// </summary>
        public int Refunds_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    TrackData = "%B4444333322221111^SECURENET^16041015432112345678?;4444333322221111=16041015432112345678?"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.IsNotNull(response.Transaction);
            Assert.IsTrue(response.Transaction.TransactionId > 0);

            return response.Transaction.TransactionId;
        }

        /// <summary>
        /// Successful response returned from a Refund Transaction request.
        /// https://apidocs.securenet.com/docs/refunds.html?lang=csharp
        /// </summary>
        public void Refunds_Refund_Transaction_Request_Returns_Successfully(int transactionId)
        {
            // Arrange
            var request = new RefundRequest
            {
                TransactionId = transactionId,
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<RefundResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion

        #region Voids

        /// <summary>
        /// Unit Tests for a Chrage request and a subsequent Void request. Tests combined in one method to pass the
        /// required transaction identifier and guaranteee the order of operation.
        /// </summary>
        [TestMethod]
        public void Voids_Charge_And_Void_Requests_Returns_Successfully()
        {
            int transactionId = Voids_Charge_Request_Returns_Successfully();

            Voids_Void_Transaction_Request_Returns_Successfully(transactionId);
        }

        /// <summary>
        /// Successful response returned from a Credit Card Present Charge request.
        /// https://apidocs.securenet.com/docs/creditcardpresent.html?lang=JSON#charge
        /// </summary>
        public int Voids_Charge_Request_Returns_Successfully()
        {
            // Arrange
            var request = new ChargeRequest
            {
                Amount = 11.00m,
                Card = new Card
                {
                    TrackData = "%B4444333322221111^SECURENET^16041015432112345678?;4444333322221111=16041015432112345678?"
                },
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<ChargeResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.IsNotNull(response.Transaction);
            Assert.IsTrue(response.Transaction.TransactionId > 0);

            return response.Transaction.TransactionId;
        }

        /// <summary>
        /// Successful response returned from a Void Transaction request.
        /// https://apidocs.securenet.com/docs/voids.html?lang=csharp
        /// </summary>
        public void Voids_Void_Transaction_Request_Returns_Successfully(int transactionId)
        {
            // Arrange
            var request = new VoidRequest
            {
                TransactionId = transactionId,
                DeveloperApplication = new DeveloperApplication
                {
                    DeveloperId = 12345678,
                    Version = "1.2"
                }
            };

            var apiContext = new APIContext();
            var controller = new PaymentsController();

            // Act
            var response = controller.ProcessRequest<VoidResponse>(apiContext, request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        #endregion
    }
}
