﻿using SCB.Open.API.Net.Authentication.Models;
using SCB.Open.API.Net.Authentication.Services;
using SCB.Open.API.Net.Customer.Information.Models;
using SCB.Open.API.Net.Customer.Information.Services;
using SCB.Open.API.Net.LoanOrigination.Models;
using SCB.Open.API.Net.LoanOrigination.Services;
using SCB.Open.API.Net.Payments.BScanC.Models;
using SCB.Open.API.Net.Payments.BScanC.Services;
using SCB.Open.API.Net.Payments.EWallets.Models;
using SCB.Open.API.Net.Payments.EWallets.Services;
using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Models;
using SCB.Open.API.Net.Payments.SCBEasyAppPayment.Services;
using System.Threading.Tasks;

namespace SCB.Open.API.Net
{
    public class SCBOpenAPI
    {
        #region Authentication services
        public class Authentication
        {
            private readonly AuthenticationService _oauthService = new AuthenticationService();
            /// <summary>
            /// Create your request header authorize
            /// </summary>
            public AuthorizeRequestHeader CreateAuthorizeRequestHeader = new AuthorizeRequestHeader();
            /// <summary>
            /// Create your request header token.
            /// </summary>
            public TokenRequestHeader CreateTokenRequestHeader = new TokenRequestHeader();
            /// <summary>
            /// Create your request body token.
            /// </summary>
            public TokenRequestBody CreateTokenRequestBody = new TokenRequestBody();
            /// <summary>
            /// Create your request body token refresh.
            /// </summary>
            public TokenRefreshRequestBody CreateTokenRefreshRequestBody = new TokenRefreshRequestBody();
            /// <summary>
            /// This endpoint authorize whether the application is valid, allow the login to proceed by returning login redirection URL.
            /// </summary>
            /// <param name="authorizeRequestHeader">Request Header</param>
            /// <returns>Authorize</returns>
            public AuthorizeResponseData GetAuthorize(AuthorizeRequestHeader authorizeRequestHeader)
            {
                return _oauthService.GetAuthorize(authorizeRequestHeader);
            }
            /// <summary>
            /// This endpoint authorize whether the application is valid, allow the login to proceed by returning login redirection URL.
            /// </summary>
            /// <param name="authorizeRequestHeader">Request Header</param>
            /// <returns>Authorize</returns>
            public async Task<AuthorizeResponseData> GetAuthorizeAsync(AuthorizeRequestHeader authorizeRequestHeader)
            {
                return await _oauthService.GetAuthorizeAsync(authorizeRequestHeader);
            }
            /// <summary>
            /// This endpoint generates the access token, which is used to access any consented resource of the user on SCB Developer platform.
            /// Required: TokenRequestHeader, TokenRequestBody 
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRequestBody">Request Body</param>
            /// <returns>Access token</returns>
            public TokenResponseData GetToken(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
            {
                return _oauthService.GetToken(tokenRequestHeader, tokenRequestBody);
            }
            /// <summary>
            /// This endpoint generates the access token, which is used to access any consented resource of the user on SCB Developer platform.
            /// Required: TokenRequestHeader, TokenRequestBody 
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRequestBody">Request Body</param>
            /// <returns>Access token</returns>
            public async Task<TokenResponseData> GetTokenAsync(TokenRequestHeader tokenRequestHeader, TokenRequestBody tokenRequestBody)
            {
                return await _oauthService.GetTokenAsync(tokenRequestHeader, tokenRequestBody);
            }
            /// <summary>
            /// This endpoint refresh the expired access token, generating a new set of the access token with the same access right as the previously generated prior.
            /// Required: TokenRequestHeader, TokenRefreshRequestBody
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRefreshRequestBody">Request Body</param>
            /// <returns>A new set of the access token</returns>
            public TokenRefreshResponseData GetTokenRefresh(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
            {
                return _oauthService.GetTokenRefresh(tokenRequestHeader, tokenRefreshRequestBody);
            }
            /// <summary>
            /// This endpoint refresh the expired access token, generating a new set of the access token with the same access right as the previously generated prior.
            /// Required: TokenRequestHeader, TokenRefreshRequestBody
            /// </summary>
            /// <param name="tokenRequestHeader">Request Header</param>
            /// <param name="tokenRefreshRequestBody">Request Body</param>
            /// <returns>A new set of the access token</returns>
            public async Task<TokenRefreshResponseData> GetTokenRefreshAsync(TokenRequestHeader tokenRequestHeader, TokenRefreshRequestBody tokenRefreshRequestBody)
            {
                return await _oauthService.GetTokenRefreshAsync(tokenRequestHeader, tokenRefreshRequestBody);
            }
        }
        #endregion

        #region Payments services
        public class Payments
        {
            public class SCBEasyAppPayment
            {
                private readonly SCBEasyAppPaymentService _scbEasyAppPaymentService = new SCBEasyAppPaymentService();
                /// <summary>
                /// Create your request header deeplink transactions.
                /// </summary>
                public DeepLinkTransactionsRequestHeader CreateDeepLinkTransactionsRequestHeader = new DeepLinkTransactionsRequestHeader();
                /// <summary>
                /// Create your request body deeplink transactions.
                /// </summary>
                public DeepLinkTransactionsRequestBody CreateDeepLinkTransactionsRequestBody = new DeepLinkTransactionsRequestBody();
                /// <summary>
                /// Create your request header transactions.
                /// </summary>
                public TransactionsRequestHeader CreateTransactionsRequestHeader = new TransactionsRequestHeader();
                /// <summary>
                /// This endpoint creates a transaction record with deeplink URL. Partners who would like to initiate a purchase process to be completed via deeplink integration with partner channel for SCB customer must first log the details of this transaction.
                /// </summary>
                /// <param name="deepLinkTransactionsRequestHeader">Request Header</param>
                /// <param name="deepLinkTransactionsRequestBody">Request Body</param>
                /// <returns>Creates a transaction record with deeplink URL</returns>
                public DeepLinkTransactionsResponseData GetDeepLinkTransactions(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
                {
                    return _scbEasyAppPaymentService.GetDeepLinkTransactions(deepLinkTransactionsRequestHeader, deepLinkTransactionsRequestBody);
                }
                /// <summary>
                /// This endpoint creates a transaction record with deeplink URL. Partners who would like to initiate a purchase process to be completed via deeplink integration with partner channel for SCB customer must first log the details of this transaction.
                /// </summary>
                /// <param name="deepLinkTransactionsRequestHeader">Request Header</param>
                /// <param name="deepLinkTransactionsRequestBody">Request Body</param>
                /// <returns>Creates a transaction record with deeplink URL</returns>
                public async Task<DeepLinkTransactionsResponseData> GetDeepLinkTransactionsAsync(DeepLinkTransactionsRequestHeader deepLinkTransactionsRequestHeader, DeepLinkTransactionsRequestBody deepLinkTransactionsRequestBody)
                {
                    return await _scbEasyAppPaymentService.GetDeepLinkTransactionsAsync(deepLinkTransactionsRequestHeader, deepLinkTransactionsRequestBody);
                }
                /// <summary>
                /// This endpoint retrieves the details of a specific transaction given a transaction ID
                /// </summary>
                /// <param name="transactionsRequestHeader">Request Header</param>
                /// <param name="transactionId">ID from the transaction which was created in v3/deeplink/transactions</param>
                /// <returns>Transaction details</returns>
                public TransactionsResponseData GetTransactions(TransactionsRequestHeader transactionsRequestHeader, string transactionId)
                {
                    return _scbEasyAppPaymentService.GetTransactions(transactionsRequestHeader, transactionId);
                }
                /// <summary>
                /// This endpoint retrieves the details of a specific transaction given a transaction ID
                /// </summary>
                /// <param name="transactionsRequestHeader">Request Header</param>
                /// <param name="transactionId">ID from the transaction which was created in v3/deeplink/transactions</param>
                /// <returns>Transaction details</returns>
                public async Task<TransactionsResponseData> GetTransactionsAsync(TransactionsRequestHeader transactionsRequestHeader, string transactionId)
                {
                    return await _scbEasyAppPaymentService.GetTransactionsAsync(transactionsRequestHeader, transactionId);
                }
            }

            public class BScanC
            {
                private readonly BScanCService _bScanCService = new BScanCService();
                /// <summary>
                /// Create your request header mercharnt rtp confirm.
                /// </summary>
                public MerchantRtpConfirmRequestHeader CreateMerchantRtpConfirmRequestHeader = new MerchantRtpConfirmRequestHeader();
                /// <summary>
                /// Create your request body merchant rtp confirm.
                /// </summary>
                public MerchantRtpConfirmRequestBody CreateMerchantRtpConfirmRequestBody = new MerchantRtpConfirmRequestBody();
                /// <summary>
                /// Create your request header mercharnt rtp refund.
                /// </summary>
                public MerchantRtpRefundRequestHeader CreateMerchantRtpRefundRequestHeader = new MerchantRtpRefundRequestHeader();
                /// <summary>
                /// Create your request body merchant rtp refund.
                /// </summary>
                public MerchantRtpRefundRequestBody CreateMerchantRtpRefundRequestBody = new MerchantRtpRefundRequestBody();
                /// <summary>
                /// This endpoint support the B Scan C Payment API.
                /// </summary>
                /// <param name="merchantRtpConfirmRequestHeader">Request Header</param>
                /// <param name="merchantRtpConfirmRequestBody">Request Body</param>
                /// <returns>Merchant rtp confirm details</returns>
                public MerchantRtpConfirmResponseData GetMerchantRtpConfirm(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody)
                {
                    return _bScanCService.GetMerchantRtpConfirm(merchantRtpConfirmRequestHeader, merchantRtpConfirmRequestBody);
                }
                /// <summary>
                /// This endpoint support the B Scan C Payment API.
                /// </summary>
                /// <param name="merchantRtpConfirmRequestHeader">Request Header</param>
                /// <param name="merchantRtpConfirmRequestBody">Request Body</param>
                /// <returns>Merchant rtp confirm details</returns>
                public async Task<MerchantRtpConfirmResponseData> GetMerchantRtpConfirmAsync(MerchantRtpConfirmRequestHeader merchantRtpConfirmRequestHeader, MerchantRtpConfirmRequestBody merchantRtpConfirmRequestBody)
                {
                    return await _bScanCService.GetMerchantRtpConfirmAsync(merchantRtpConfirmRequestHeader, merchantRtpConfirmRequestBody);
                }
                /// <summary>
                /// This endpoint support the B Scan C Refund API The refund API can be use within 23:00 of original transaction date and only full amount refund is supported.
                /// </summary>
                /// <param name="merchantRtpRefundRequestHeader">Request Header</param>
                /// <param name="merchantRtpRefundRequestBody">Request Body</param>
                /// <returns>Merchant rtp refund details</returns>
                public MerchantRtpRefundResponseData GetMerchantRtpRefund(MerchantRtpRefundRequestHeader merchantRtpRefundRequestHeader, MerchantRtpRefundRequestBody merchantRtpRefundRequestBody)
                {
                    return _bScanCService.GetMerchantRtpRefund(merchantRtpRefundRequestHeader, merchantRtpRefundRequestBody);
                }
                /// <summary>
                /// This endpoint support the B Scan C Refund API The refund API can be use within 23:00 of original transaction date and only full amount refund is supported.
                /// </summary>
                /// <param name="merchantRtpRefundRequestHeader">Request Header</param>
                /// <param name="merchantRtpRefundRequestBody">Request Body</param>
                /// <returns>Merchant rtp refund details</returns>
                public async Task<MerchantRtpRefundResponseData> GetMerchantRtpRefundAsync(MerchantRtpRefundRequestHeader merchantRtpRefundRequestHeader, MerchantRtpRefundRequestBody merchantRtpRefundRequestBody)
                {
                    return await _bScanCService.GetMerchantRtpRefundAsync(merchantRtpRefundRequestHeader, merchantRtpRefundRequestBody);
                }
            }

            /// <summary>
            /// Alipay or WeChatPay
            /// </summary>
            public class EWallets
            {
                private readonly EWalletsService _eWalletsService = new EWalletsService();
                /// <summary>
                /// Create your request header qr code create.
                /// </summary>
                public QRCodeCreateRequestHeader CreateQRCodeCreateRequestHeader = new QRCodeCreateRequestHeader();
                /// <summary>
                /// Create your request body qr code create.
                /// </summary>
                public QRCodeCreateRequestBody CreateQRCodeCreateRequestBody = new QRCodeCreateRequestBody();
                /// <summary>
                /// Create your request header inquire.
                /// </summary>
                public InquireRequestHeader CreateInquireRequestHeader = new InquireRequestHeader();
                /// <summary>
                /// Create your request body inquire.
                /// </summary>
                public InquireRequestBody CreateInquireRequestBody = new InquireRequestBody();
                /// <summary>
                /// Create your request header cancel.
                /// </summary>
                public CancelRequestHeader CreateCancelRequestHeader = new CancelRequestHeader();
                /// <summary>
                /// Create your request body cancel.
                /// </summary>
                public CancelRequestBody CreateCancelRequestBody = new CancelRequestBody();
                /// <summary>
                /// Not Support Alipay
                /// Create your request header refund.
                /// </summary>
                public RefundRequestHeader CreateRefundRequestHeader = new RefundRequestHeader();
                /// <summary>
                /// Not Support Alipay
                /// Create your request body refund.
                /// </summary>
                public RefundRequestBody CreateRefundRequestBody = new RefundRequestBody();
                /// <summary>
                /// Not Support Alipay
                /// Create your request header qr code cancel.
                /// </summary>
                public QRCodeCancelRequestHeader CreateQRCodeCancelRequestHeader = new QRCodeCancelRequestHeader();
                /// <summary>
                /// Not Support Alipay
                /// Create your request body qr code cancel.
                /// </summary>
                public QRCodeCancelRequestBody CreateQRCodeCancelRequestBody = new QRCodeCancelRequestBody();
                /// <summary>
                /// Create your request header pay.
                /// </summary>
                public PayRequestHeader CreatePayRequestHeader = new PayRequestHeader();
                /// <summary>
                /// Create your request body pay.
                /// </summary>
                public PayRequestBody CreatePayRequestBody = new PayRequestBody();
                /// <summary>
                /// This endpoint supports the QR code generation of Alipay and WeChatPay. There are 2 use cases.
                /// Generate Alipay QR code, Generate WeChatPay QR code
                /// </summary>
                /// <param name="qRCodeCreateRequestHeader">Request Header</param>
                /// <param name="qRCodeCreateRequestBody">Request Body</param>
                /// <returns>QR code generation of Alipay and WeChatPay.</returns>
                public QRCodeCreateResponseData GetQRCodeCreate(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody)
                {
                    return _eWalletsService.GetQRCodeCreate(qRCodeCreateRequestHeader, qRCodeCreateRequestBody);
                }
                /// <summary>
                /// This endpoint supports the QR code generation of Alipay and WeChatPay. There are 2 use cases.
                /// Generate Alipay QR code, Generate WeChatPay QR code
                /// </summary>
                /// <param name="qRCodeCreateRequestHeader">Request Header</param>
                /// <param name="qRCodeCreateRequestBody">Request Body</param>
                /// <returns>QR code generation of Alipay and WeChatPay.</returns>
                public async Task<QRCodeCreateResponseData> GetQRCodeCreateAsync(QRCodeCreateRequestHeader qRCodeCreateRequestHeader, QRCodeCreateRequestBody qRCodeCreateRequestBody)
                {
                    return await _eWalletsService.GetQRCodeCreateAsync(qRCodeCreateRequestHeader, qRCodeCreateRequestBody);
                }
                /// <summary>
                /// This endpoint supports the inquiry of a transaction made either in Alipay or WeChatPay.
                /// </summary>
                /// <param name="inquireRequestHeader">Request Header</param>
                /// <param name="inquireRequestBody">Request Body</param>
                /// <returns>The inquiry of a transaction made either in Alipay or WeChatPay.</returns>
                public InquireResponseData GetInquire(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody)
                {
                    return _eWalletsService.GetInquire(inquireRequestHeader, inquireRequestBody);
                }
                /// <summary>
                /// This endpoint supports the inquiry of a transaction made either in Alipay or WeChatPay.
                /// </summary>
                /// <param name="inquireRequestHeader">Request Header</param>
                /// <param name="inquireRequestBody">Request Body</param>
                /// <returns>The inquiry of a transaction made either in Alipay or WeChatPay.</returns>
                public async Task<InquireResponseData> GetInquireAsync(InquireRequestHeader inquireRequestHeader, InquireRequestBody inquireRequestBody)
                {
                    return await _eWalletsService.GetInquireAsync(inquireRequestHeader, inquireRequestBody);
                }
                /// <summary>
                /// This endpoint supports the cancellation of a transaction created in Alipay (C Scan B and B Scan C) and WeChatPay (B Scan C).
                /// </summary>
                /// <param name="cancelRequestHeader">Request Header</param>
                /// <param name="cancelRequestBody">Request Body</param>
                /// <returns>Cancellation of a transaction created in Alipay (C Scan B and B Scan C) and WeChatPay (B Scan C)</returns>
                public CancelResponseData GetCancel(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody)
                {
                    return _eWalletsService.GetCancel(cancelRequestHeader, cancelRequestBody);
                }
                /// <summary>
                /// This endpoint supports the cancellation of a transaction created in Alipay (C Scan B and B Scan C) and WeChatPay (B Scan C).
                /// </summary>
                /// <param name="cancelRequestHeader">Request Header</param>
                /// <param name="cancelRequestBody">Request Body</param>
                /// <returns>Cancellation of a transaction created in Alipay (C Scan B and B Scan C) and WeChatPay (B Scan C)</returns>
                public async Task<CancelResponseData> GetCancelAsync(CancelRequestHeader cancelRequestHeader, CancelRequestBody cancelRequestBody)
                {
                    return await _eWalletsService.GetCancelAsync(cancelRequestHeader, cancelRequestBody);
                }
                /// <summary>
                /// Not Support Alipay
                /// This endpoint supports the cancellation of a transaction created in WeChatPay (C Scan B).
                /// </summary>
                /// <param name="refundRequestHeader">Request Header</param>
                /// <param name="refundRequestBody">Request Body</param>
                /// <returns>The cancellation of a transaction created in WeChatPay (C Scan B).</returns>
                public RefundResponseData GetRefund(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody)
                {
                    return _eWalletsService.GetRefund(refundRequestHeader, refundRequestBody);
                }
                /// <summary>
                /// Not Support Alipay
                /// This endpoint supports the cancellation of a transaction created in WeChatPay (C Scan B).
                /// </summary>
                /// <param name="refundRequestHeader">Request Header</param>
                /// <param name="refundRequestBody">Request Body</param>
                /// <returns>The cancellation of a transaction created in WeChatPay (C Scan B).</returns>
                public async Task<RefundResponseData> GetRefundAsync(RefundRequestHeader refundRequestHeader, RefundRequestBody refundRequestBody)
                {
                    return await _eWalletsService.GetRefundAsync(refundRequestHeader, refundRequestBody);
                }
                /// <summary>
                /// Not Support Alipay
                /// This endpoint supports the cancellation of a QR transaction created in WeChat. This API is used when a merchant wants to cancel the QR before it is paid. If the QR is paid, use Refund API to reverse the payment.
                /// </summary>
                /// <param name="qRCodeCancelRequestHeader">Request Header</param>
                /// <param name="qRCodeCancelRequestBody">Request Body</param>
                /// <returns>The cancellation of a QR transaction created in WeChat</returns>
                public QRCodeCancelResponseData GetQRCodeCancel(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody)
                {
                    return _eWalletsService.GetQRCodeCancel(qRCodeCancelRequestHeader, qRCodeCancelRequestBody);
                }
                /// <summary>
                /// Not Support Alipay
                /// This endpoint supports the cancellation of a QR transaction created in WeChat. This API is used when a merchant wants to cancel the QR before it is paid. If the QR is paid, use Refund API to reverse the payment.
                /// </summary>
                /// <param name="qRCodeCancelRequestHeader">Request Header</param>
                /// <param name="qRCodeCancelRequestBody">Request Body</param>
                /// <returns>The cancellation of a QR transaction created in WeChat</returns>
                public async Task<QRCodeCancelResponseData> GetQRCodeCancelAsync(QRCodeCancelRequestHeader qRCodeCancelRequestHeader, QRCodeCancelRequestBody qRCodeCancelRequestBody)
                {
                    return await _eWalletsService.GetQRCodeCancelAsync(qRCodeCancelRequestHeader, qRCodeCancelRequestBody);
                }
                /// <summary>
                /// This endpoint supports QR code generation from the merchant end of Alipay and WeChatPay for consumers to scan and pay (B scan C).
                /// </summary>
                /// <param name="payRequestHeader">Request Header</param>
                /// <param name="payRequestBody">Request Body</param>
                /// <returns>The merchant end of Alipay and WeChatPay for consumers to scan and pay (B scan C)</returns>
                public PayResponseData GetPay(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody)
                {
                    return _eWalletsService.GetPay(payRequestHeader, payRequestBody);
                }
                /// <summary>
                /// This endpoint supports QR code generation from the merchant end of Alipay and WeChatPay for consumers to scan and pay (B scan C).
                /// </summary>
                /// <param name="payRequestHeader">Request Header</param>
                /// <param name="payRequestBody">Request Body</param>
                /// <returns>The merchant end of Alipay and WeChatPay for consumers to scan and pay (B scan C)</returns>
                public async Task<PayResponseData> GetPayAsync(PayRequestHeader payRequestHeader, PayRequestBody payRequestBody)
                {
                    return await _eWalletsService.GetPayAsync(payRequestHeader, payRequestBody);
                }
            }
        }
        #endregion

        #region Customer Information services
        public class CustomerInfo
        {
            private readonly CustomerInfoService _customerInfoService = new CustomerInfoService();
            /// <summary>
            /// Create your request header customer info.
            /// </summary>
            public CustomerInfoRequestHeader CreateCustomerInfoRequestHeader = new CustomerInfoRequestHeader();
            /// <summary>
            /// This endpoint provides the consented user information to the partner application.
            /// </summary>
            /// <param name="customerInfoRequestHeader">Request Header</param>
            /// <returns>User information to the partner application</returns>
            public CustomerInfoResponseData GetProfile(CustomerInfoRequestHeader customerInfoRequestHeader)
            {
                return _customerInfoService.GetProfile(customerInfoRequestHeader);
            }
            /// <summary>
            /// This endpoint provides the consented user information to the partner application.
            /// </summary>
            /// <param name="customerInfoRequestHeader">Request Header</param>
            /// <returns>User information to the partner application</returns>
            public async Task<CustomerInfoResponseData> GetProfileAsync(CustomerInfoRequestHeader customerInfoRequestHeader)
            {
                return await _customerInfoService.GetProfileAsync(customerInfoRequestHeader);
            }
        }
        #endregion

        #region Loan Origination
        public class LoanOrigination
        {
            private readonly ILoanOriginationService _loanOriginationService = new LoanOriginationService();
            /// <summary>
            /// Create your request header simulator calculate.
            /// </summary>
            public SimulatorCalRequestHeader CreateSimulatorCalRequestHeader = new SimulatorCalRequestHeader();
            /// <summary>
            /// Create your request body simulator calculate.
            /// </summary>
            public SimulatorCalRequestBody CreateSimulatorCalRequestBody = new SimulatorCalRequestBody();
            /// <summary>
            /// Create your request header initiate applications.
            /// </summary>
            public InitiateApplicationsRequestHeader CreateInitiateApplicationsRequestHeader = new InitiateApplicationsRequestHeader();
            /// <summary>
            /// Create your request body initiate applications.
            /// </summary>
            public InitiateApplicationsRequestBody CreateInitiateApplicationsRequestBody = new InitiateApplicationsRequestBody();
            /// <summary>
            /// Create your request header single application.
            /// </summary>
            public SingleApplicationsRequestHeader CreateSingleApplicationsRequestHeader = new SingleApplicationsRequestHeader();
            /// <summary>
            /// This endpoint calculates for loan installment amount or loan tenor from given loan amount, repayment frequency and repayment start date.
            /// </summary>
            /// <param name="simulatorCalRequestHeader">Request Header</param>
            /// <param name="simulatorCalRequestBody">Request Body</param>
            /// <returns>Calculates for loan installment amount or loan tenor from given loan amount, repayment frequency and repayment start date</returns>
            public SimulatorCalResponseData GetSimulatorCal(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody)
            {
                return _loanOriginationService.GetSimulatorCal(simulatorCalRequestHeader, simulatorCalRequestBody);
            }
            /// <summary>
            /// This endpoint calculates for loan installment amount or loan tenor from given loan amount, repayment frequency and repayment start date.
            /// </summary>
            /// <param name="simulatorCalRequestHeader">Request Header</param>
            /// <param name="simulatorCalRequestBody">Request Body</param>
            /// <returns>Calculates for loan installment amount or loan tenor from given loan amount, repayment frequency and repayment start date</returns>
            public async Task<SimulatorCalResponseData> GetSimulatorCalAsync(SimulatorCalRequestHeader simulatorCalRequestHeader, SimulatorCalRequestBody simulatorCalRequestBody)
            {
                return await _loanOriginationService.GetSimulatorCalAsync(simulatorCalRequestHeader, simulatorCalRequestBody);
            }
            /// <summary>
            /// This endpoint requests loan application initiate.
            /// </summary>
            /// <param name="initiateApplicationsRequestHeader">Request Header</param>
            /// <param name="initiateApplicationsRequestBody">Request Body</param>
            /// <returns>Loan application initiate</returns>
            public InitiateApplicationsResponseData GetInitiateApplications(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody)
            {
                return _loanOriginationService.GetInitiateApplications(initiateApplicationsRequestHeader, initiateApplicationsRequestBody);
            }
            /// <summary>
            /// This endpoint requests loan application initiate.
            /// </summary>
            /// <param name="initiateApplicationsRequestHeader">Request Header</param>
            /// <param name="initiateApplicationsRequestBody">Request Body</param>
            /// <returns>Loan application initiate</returns>
            public async Task<InitiateApplicationsResponseData> GetInitiateApplicationsAsync(InitiateApplicationsRequestHeader initiateApplicationsRequestHeader, InitiateApplicationsRequestBody initiateApplicationsRequestBody)
            {
                return await _loanOriginationService.GetInitiateApplicationsAsync(initiateApplicationsRequestHeader, initiateApplicationsRequestBody);
            }
            /// <summary>
            /// This endpoint retrieves a single loan application information.
            /// </summary>
            /// <param name="singleApplicationsRequestHeader">Request Header</param>
            /// <param name="applicationId">Application ID</param>
            /// <returns>A single loan application information</returns>
            public SingleApplicationsResponseData GetSingleApplications(SingleApplicationsRequestHeader singleApplicationsRequestHeader, string applicationId)
            {
                return _loanOriginationService.GetSingleApplications(singleApplicationsRequestHeader, applicationId);
            }
            /// <summary>
            /// This endpoint retrieves a single loan application information.
            /// </summary>
            /// <param name="singleApplicationsRequestHeader">Request Header</param>
            /// <param name="applicationId">Application ID</param>
            /// <returns>A single loan application information</returns>
            public async Task<SingleApplicationsResponseData> GetSingleApplicationsAsync(SingleApplicationsRequestHeader singleApplicationsRequestHeader, string applicationId)
            {
                return await _loanOriginationService.GetSingleApplicationsAsync(singleApplicationsRequestHeader, applicationId);
            }
        }
        #endregion
    }
}
