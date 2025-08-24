using System;
using System.Linq;
using System.Web;
using PayPal.Payments.Common.Utility;
using PayPal.Payments.DataObjects;
using PayPal.Payments.Transactions;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Exceptions;
using Roblox.Billing.Properties;
using Roblox.Billing.Providers;
using Roblox.Common;
using Roblox.Demographics;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.PayPal.Client;
using Roblox.Users;

namespace Roblox.Billing;

public class PayPalPaymentProvider : PaymentProviderBase, IAsyncPaymentProvider, IPaymentProvider
{
	private const string _PayPalError11607 = "11607";

	private const string _PayPalError10486 = "10486";

	private bool _IsTestMode;

	private bool _NetSuccessOrFailure;

	private string _UserName = string.Empty;

	private PayPalPaymentInfo _PaymentInfo;

	private FraudDetectionProvider _FraudDetectionProvider;

	private string _SessionId;

	private ILogger _Logger;

	private readonly EphemeralCounterFactory _EphemeralCounterFactory;

	private const string _InitialTransactionFailureCounter = "PayPalInitialTransactionFailure";

	private const string _RecurringProfileFailureCounter = "RecurringProfileCreationFailure";

	private const string _PayPalErrorCode11607Counter = "PayPalFailureErrorCode11607";

	private const string _PayPalErrorCode10486Counter = "PayPalFailureErrorCode10486";

	private Payment _InitialCharge;

	private Sale _Sale;

	public static PaymentProviderType Type => PaymentProviderType.Paypal;

	private CountryCurrency _CountryCurrency { get; set; }

	private bool _IsCountryCurrencyFallbackToUSD { get; set; }

	private string _PayPalSupportedCurrencyCodes => Settings.Default.PayPalSupportedCurrencyCode;

	private decimal DailyChargeLimitForPayPalExpress => Settings.Default.PayPalExpressUserChargeLimit_Daily;

	private decimal MonthlyChargeLimitForPayPalExpress => Settings.Default.PayPalExpressUserChargeLimit_Monthly;

	public bool Enabled => true;

	public Payment InitialCharge
	{
		get
		{
			return _InitialCharge;
		}
		set
		{
			_InitialCharge = value;
		}
	}

	public bool NetSuccessOrFailure => _NetSuccessOrFailure;

	public Sale Sale => _Sale;

	public bool SupportsRecurringBilling => BillingHelper.PayPalRecurringIsEnabled;

	public static event Func<string, string, PaymentType, IFraudDetectorResult> OnTransactionFailed;

	public static event Action<FraudDetectionData> OnSaleCompleted;

	public PayPalPaymentProvider(CountryCurrency countryCurrency, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, EphemeralCounterFactory ephemeralCounterFactory, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, ILogger logger)
		: base(cancelExistingActiveMembershipSale, logger, ephemeralCounterFactory)
	{
		_CountryCurrency = GetPayPalSupportedCountryCurrency(countryCurrency, _PayPalSupportedCurrencyCodes);
		_IsCountryCurrencyFallbackToUSD = countryCurrency.ID != _CountryCurrency.ID;
		_FraudDetectionProvider = new FraudDetectionProvider(fraudDetectionAction);
		_EphemeralCounterFactory = ephemeralCounterFactory;
		_Logger = logger;
	}

	public PayPalPaymentProvider(Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, EphemeralCounterFactory ephemeralCounterFactory, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, ILogger logger)
		: base(cancelExistingActiveMembershipSale, logger, ephemeralCounterFactory)
	{
		_CountryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Roblox.Users.Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		_FraudDetectionProvider = new FraudDetectionProvider(fraudDetectionAction);
		_EphemeralCounterFactory = ephemeralCounterFactory;
	}

	private void TransactionFailed(string sessionId, string transactionId)
	{
		PayPalPaymentProvider.OnTransactionFailed?.Invoke(sessionId, transactionId, PaymentType.PayPal);
	}

	private void SaleCompleted(FraudDetectionData fraudDetectionData)
	{
		PayPalPaymentProvider.OnSaleCompleted?.Invoke(fraudDetectionData);
	}

	/// <summary>
	/// Sets up a pending paypal transaction. Returns a URL where user will go to pay for their purchase
	/// </summary>
	/// <returns>The paypal url to complete the payment</returns>
	private string BeginPay()
	{
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031f: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		PayPalHelper.WaitForThrottle();
		if (_Sale.DiscountedPriceTotal == 0m)
		{
			throw new ApplicationException("Cannot use PayPal for free product giveaway.");
		}
		if (_Sale.Products.Where((SaleProduct x) => x.RecurringPrice.HasValue).Count() > 1)
		{
			throw new NotImplementedException("Only one recurring product per cart has been implemented.");
		}
		_Sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		_Sale.Save();
		_InitialCharge = new Payment();
		_InitialCharge.PaymentDate = DateTime.Now;
		_InitialCharge.PaymentProviderTypeID = PaymentProviderType.Paypal.ID;
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
		_InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		_InitialCharge.SaleID = _Sale.ID;
		_InitialCharge.CurrencyTypeID = _Sale.CurrencyTypeID;
		_InitialCharge.Save();
		if (_IsTestMode)
		{
			return string.Empty;
		}
		string orderCode = InitialCharge.ID.ToString();
		string comment = _Sale.GenerateComment1Field(_UserName);
		string currencyCode = PayPalHelper.GetCurrencyCode(_InitialCharge.CurrencyTypeID);
		if (BillingHelper.PayPalRecurringIsEnabled && _Sale.RecurringPrice.HasValue)
		{
			return BeginRecurringPay(orderCode, comment, InitialCharge.Amount, _Sale.RecurringPrice.Value, currencyCode);
		}
		BrowserInfo browserInfo = new BrowserInfo
		{
			Custom = orderCode
		};
		Invoice invoice = new Invoice();
		invoice.Comment1 = comment;
		string invoiceDescCurrency = PayPalHelper.GetInvoiceDescriptionByCurrencyCode(currencyCode);
		foreach (SaleProduct saleProduct in _Sale.Products)
		{
			LineItem lineItem = new LineItem();
			lineItem.Amt = new Currency(decimal.Round(saleProduct.DiscountedPrice, 2), currencyCode);
			lineItem.Desc = $"{saleProduct.Product.Name} (User: {_UserName})";
			invoice.AddLineItem(lineItem);
		}
		invoice.BrowserInfo = browserInfo;
		invoice.MerchDescr = PayPalHelper.MerchantName;
		invoice.MerchSvc = PayPalHelper.MerchantInformation;
		invoice.Amt = new Currency(decimal.Round(InitialCharge.Amount, 2), currencyCode);
		invoice.OrderDesc = $"{invoiceDescCurrency}{invoice.Amt} for Roblox Products.";
		ECSetRequest ecSetRequest = new ECSetRequest(string.Format(PayPalHelper.ReturnUrl, orderCode), string.Format(PayPalHelper.CancelUrl, orderCode));
		ecSetRequest.ReqConfirmShipping = "0";
		ecSetRequest.NoShipping = "1";
		ecSetRequest.HeaderImage = PayPalHelper.RobloxLogo;
		UserInfo val = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
		PayflowConnectionData payflowConnectionData = new PayflowConnectionData(PayPalHelper.Connection);
		PayPalTender tender = new PayPalTender((ExpressCheckoutRequest)(object)ecSetRequest);
		SaleTransaction saleTransaction = new SaleTransaction(val, payflowConnectionData, invoice, (BaseTender)(object)tender, orderCode);
		((BaseTransaction)saleTransaction).SubmitTransaction();
		InitialCharge.Save();
		_NetSuccessOrFailure = ((BaseTransaction)saleTransaction).Response.TransactionResponse.Result == 0;
		if (!NetSuccessOrFailure)
		{
			throw new PaypalException($"An unexpected error occurred when trying to initiate a PayPal transaction: {((BaseTransaction)saleTransaction).Response.TransactionResponse.RespMsg}");
		}
		return $"{PayPalHelper.ExpressCheckoutUrl}{((BaseTransaction)saleTransaction).Response.ExpressCheckoutSetResponse.Token}&Billing=new";
	}

	public string BeginRecurringPay(string orderCode, string comment, decimal invoiceAmt, decimal recurringAmt, string currencyCode)
	{
		if (!BillingHelper.PayPalRecurringIsEnabled)
		{
			throw new ApplicationException("Roblox.Billing - BeginRecurringPay is currently disabled");
		}
		if (!_Sale.RecurringPrice.HasValue)
		{
			throw new ApplicationException("Begin Recurring called by a Non-Recurring Sale Item");
		}
		InitiateRecurringResult response = PayPalAuthorityFactory.Singleton.GetPayPalAuthority(Settings.Default.BillingLibraryApiKey).GetInitialRecurringPaymentUrl(orderCode, comment, invoiceAmt, recurringAmt, string.Empty, string.Empty, GetRecurringPayPeriod(), currencyCode);
		_NetSuccessOrFailure = response.NetSuccessOrFailure;
		if (!_NetSuccessOrFailure)
		{
			throw new ApplicationException("Error while trying to checkout a renewable item using PayPal Recurring Service. Msg: " + response.ResponseMsg);
		}
		return response.RedirectUrl;
	}

	/// <summary>
	/// Used to finalize (submit/checkout) a recurring payment with PayPal.
	/// </summary>
	/// <param name="paymentId">The ROBLOX Payment ID.</param>
	/// <param name="token">The PayPal authentication token to use.</param>
	/// <param name="currencyCode">The currency code</param>
	/// <param name="ipAddress">Ip address of the user</param>
	/// <param name="isRetryPaypalOnError">Retry Paypal on error</param>
	/// <param name="isPaypalError11607">Parameter to indicate to the consumer of this method that an earlier transaction has already succeeded and the Sale, Payment and TransactionLogs will not be overwriten.</param>
	/// <returns>A boolean representing if the payment was successfully finalized/submitted.</returns>
	public bool FinalizeRecurringPay(long paymentId, string token, string currencyCode, string ipAddress, out bool isRetryPaypalOnError, out bool isPaypalError11607)
	{
		if (!BillingHelper.PayPalRecurringIsEnabled)
		{
			throw new ApplicationException("This feature is currently disabled.");
		}
		if (!_Sale.RecurringPrice.HasValue)
		{
			throw new ApplicationException("Finalize Recurring called by a Non-Recurring Sale Item");
		}
		isRetryPaypalOnError = false;
		isPaypalError11607 = false;
		_InitialCharge = Payment.Get(paymentId);
		_Sale = Sale.Get(_InitialCharge.SaleID);
		string transactionLogAccountID = _UserName;
		IPayPalAuthority payPalClient = PayPalAuthorityFactory.Singleton.GetPayPalAuthority(Settings.Default.BillingLibraryApiKey);
		IFraudDetectorResult fraudDetectorResult = null;
		FinalizeRecurringResult finalizeRecurringResult;
		if (Settings.Default.PayPalRecurringGetTransactionInformationEnabled)
		{
			TransactionInformationResult transactionInformation = payPalClient.GetTransactionInformation(paymentId, token);
			if (!transactionInformation.NetSuccessOrFailure)
			{
				_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				_InitialCharge.Save();
				_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
				_Sale.Save();
				LogTransaction(transactionInformation.RPRef, "PayPal Failure", $"ECGetRequest fails. Message returned: {transactionInformation.TransactionMessage}", transactionLogAccountID);
				_NetSuccessOrFailure = false;
				return _NetSuccessOrFailure;
			}
			_PaymentInfo = new PayPalPaymentInfo
			{
				PayerId = transactionInformation.PayerId,
				FirstName = transactionInformation.FirstName,
				LastName = transactionInformation.LastName,
				Email = transactionInformation.Email,
				Country = transactionInformation.Country,
				Phone = transactionInformation.Phone,
				ClientIP = ipAddress
			};
			fraudDetectorResult = _FraudDetectionProvider.GetFraudDetectionResult(_UserName, _Sale, _SessionId, _PaymentInfo);
			if (fraudDetectorResult != null && fraudDetectorResult.IsFraudulent)
			{
				_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Blocked.ID;
				_InitialCharge.Save();
				_Sale.SaleStatusTypeID = SaleStatusType.Blocked.ID;
				_Sale.Save();
				LogTransaction(transactionInformation.RPRef, "Blocked by third party fraud providers", "Fraudulent", transactionLogAccountID);
				_NetSuccessOrFailure = false;
				return _NetSuccessOrFailure;
			}
			finalizeRecurringResult = payPalClient.FinalizeRecurringTransaction(paymentId, token, _PaymentInfo.PayerId, _UserName, _Sale.GenerateComment1Field(_UserName), _Sale.RecurringPrice.Value, GetRecurringPayPeriod(), _Sale.RenewalDate.Value, currencyCode, _Sale.DiscountedPriceTotal);
		}
		else
		{
			finalizeRecurringResult = payPalClient.FinalizeRecurringPayment(paymentId, token, _UserName, _Sale.GenerateComment1Field(_UserName), _Sale.RecurringPrice.Value, GetRecurringPayPeriod(), _Sale.RenewalDate.Value, currencyCode, _Sale.DiscountedPriceTotal);
		}
		if (!finalizeRecurringResult.IsInitialTransactionSuccess || (!Settings.Default.GrantProductOnRecurringProfileCreationFailureEnabled && !finalizeRecurringResult.NetSuccessOrFailure))
		{
			string transactionMessage = $"Authorization failed. Message returned: {finalizeRecurringResult.TransactionMessage}";
			if (Settings.Default.RetryPaypalOn10486ErrorEnabled && transactionMessage != null && transactionMessage.Contains("10486"))
			{
				IncrementCounter("PayPalFailureErrorCode10486");
				isRetryPaypalOnError = true;
			}
			else
			{
				if (Settings.Default.DoNotProceedOnPaypalError11607Enabled && transactionMessage != null && transactionMessage.Contains("11607"))
				{
					IncrementCounter("PayPalFailureErrorCode11607");
					isPaypalError11607 = true;
					return false;
				}
				_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				_InitialCharge.Save();
				_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
				_Sale.Save();
			}
			LogTransaction(finalizeRecurringResult.RPRef, "PayPal Failure", transactionMessage, transactionLogAccountID);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
				{
					UserName = _UserName,
					Sale = _Sale,
					SessionId = _SessionId,
					PaymentInfo = _PaymentInfo,
					TransactionId = finalizeRecurringResult.RPRef,
					TransactionAmount = _InitialCharge.Amount,
					TranactionStatus = TransactionStatus.Failure
				}));
			});
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				TransactionFailed(_SessionId, fraudDetectorResult.TransactionId);
			});
			if (!finalizeRecurringResult.IsInitialTransactionSuccess)
			{
				IncrementCounter("PayPalInitialTransactionFailure");
			}
			else if (!finalizeRecurringResult.IsCreatingRecurringProfileSuccess)
			{
				IncrementCounter("RecurringProfileCreationFailure");
			}
			_NetSuccessOrFailure = false;
			return _NetSuccessOrFailure;
		}
		if (!string.IsNullOrEmpty(finalizeRecurringResult.RecurringProfileID))
		{
			transactionLogAccountID = finalizeRecurringResult.RecurringProfileID;
		}
		int? payPalBillingAgreementId = null;
		if (!string.IsNullOrEmpty(finalizeRecurringResult.BillingAgreementID))
		{
			PayPalBillingAgreement payPalBillingAgreement = PayPalBillingAgreement.CreateNew(Account.Get(_UserName).ID, finalizeRecurringResult.BillingAgreementID, isactive: true);
			payPalBillingAgreementId = payPalBillingAgreement.ID;
		}
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
		_InitialCharge.Save();
		_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		_Sale.Save();
		_NetSuccessOrFailure = true;
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
		if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			CancelExistingRecurringMembershipSale(_Sale);
		}
		TryToPublishBillingTransaction(_Sale, _Logger, null);
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
			{
				UserName = _UserName,
				Sale = _Sale,
				SessionId = _SessionId,
				PaymentInfo = _PaymentInfo,
				TransactionId = finalizeRecurringResult.RPRef,
				TransactionAmount = _InitialCharge.Amount,
				TranactionStatus = TransactionStatus.Success
			}));
		});
		if (finalizeRecurringResult.IsCreatingRecurringProfileSuccess)
		{
			LogTransaction(finalizeRecurringResult.RPRef, "PayPal - Recurring Success", finalizeRecurringResult.TransactionMessage, transactionLogAccountID, payPalBillingAgreementId);
		}
		else
		{
			LogTransaction(finalizeRecurringResult.RPRef, "PayPal - First Sale OK but Creating Recurring Profile Failure", finalizeRecurringResult.TransactionMessage, transactionLogAccountID, payPalBillingAgreementId);
			IncrementCounter("RecurringProfileCreationFailure");
		}
		return _NetSuccessOrFailure;
	}

	/// <summary>
	/// Call from website with orderCode passed back from PayPal.
	/// Asks paypal if transaction was paid for, and if so updates the logs and requests premium feature grants.
	/// If recurring product, use the initial transaction to create a recurring profile.
	/// </summary>
	/// <param name="paymentId"></param>
	/// <param name="token">paypal transaction token</param>
	/// <param name="username"></param>
	/// <param name="isRetryPaypalOnError">Out retry Paypal parameter</param>
	/// <param name="isPaypalError11607">Parameter to indicate to the consumer of this method that an earlier transaction has already succeeded and the Sale, Payment and TransactionLogs will not be overwriten.</param>
	/// <param name="sessionId">Optional Session ID for Fraud detection purpose. (if null, we don't send to Kount)</param>
	/// <param name="ipAddress">Optional IP Address for Fraud detection purpose. (if null, we set default value required by Kount)</param>
	/// <returns>bool - true for success</returns>
	public bool FinalizePay(long paymentId, string token, out bool isRetryPaypalOnError, out bool isPaypalError11607, string sessionId = null, string ipAddress = null)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		_SessionId = sessionId;
		_InitialCharge = Payment.Get(paymentId);
		_Sale = Sale.Get(_InitialCharge.SaleID);
		Account userAccount = Account.Get(_Sale.PurchaserAccountID);
		_UserName = userAccount.UserName;
		isRetryPaypalOnError = false;
		isPaypalError11607 = false;
		string currencyCode = PayPalHelper.GetCurrencyCode(_InitialCharge.CurrencyTypeID);
		if (BillingHelper.PayPalRecurringIsEnabled && _Sale.RecurringPrice.HasValue)
		{
			return FinalizeRecurringPay(paymentId, token, currencyCode, ipAddress, out isRetryPaypalOnError, out isPaypalError11607);
		}
		UserInfo userInfo = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
		PayflowConnectionData payflowConnectionData = new PayflowConnectionData(PayPalHelper.Connection);
		PayPalTender payPalTender = new PayPalTender((ExpressCheckoutRequest)new ECGetRequest(token));
		SaleTransaction saleTransaction = new SaleTransaction(userInfo, payflowConnectionData, (Invoice)null, (BaseTender)(object)payPalTender, PayflowUtility.RequestId);
		((BaseTransaction)saleTransaction).SubmitTransaction();
		_PaymentInfo = new PayPalPaymentInfo
		{
			PayerId = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.PayerId,
			FirstName = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.FirstName,
			LastName = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.LastName,
			Email = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.Payer,
			Country = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.CountryCode,
			Phone = ((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.PhoneNum,
			ClientIP = (ipAddress ?? "10.0.0.1")
		};
		if (string.IsNullOrWhiteSpace(((BaseTransaction)saleTransaction).Response.ExpressCheckoutGetResponse.PayerId) && Settings.Default.IsPaypalRequestErrorRetryEnabled)
		{
			isRetryPaypalOnError = true;
			return false;
		}
		IFraudDetectorResult fraudDetectorResult = null;
		fraudDetectorResult = _FraudDetectionProvider.GetFraudDetectionResult(_UserName, _Sale, _SessionId, _PaymentInfo);
		if (fraudDetectorResult != null && fraudDetectorResult.IsFraudulent)
		{
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Blocked.ID;
			_InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Blocked.ID;
			_Sale.Save();
			LogTransaction(((BaseTransaction)saleTransaction).Response.TransactionResponse.Pnref, "Blocked by third party fraud providers.", "Fraudulent", _UserName);
			_NetSuccessOrFailure = false;
			return _NetSuccessOrFailure;
		}
		BrowserInfo browserInfo = new BrowserInfo
		{
			Custom = paymentId.ToString()
		};
		payPalTender = new PayPalTender((ExpressCheckoutRequest)new ECDoRequest(token, _PaymentInfo.PayerId));
		Invoice invoice = new Invoice();
		invoice.Comment1 = _Sale.GenerateComment1Field(_UserName);
		invoice.BrowserInfo = browserInfo;
		invoice.Amt = new Currency(Convert.ToDecimal(Convert.ToDouble(_InitialCharge.Amount)), currencyCode);
		saleTransaction = new SaleTransaction(userInfo, payflowConnectionData, invoice, (BaseTender)(object)payPalTender, PayflowUtility.RequestId);
		((BaseTransaction)saleTransaction).SubmitTransaction();
		BaseTransaction transaction = (BaseTransaction)(object)saleTransaction;
		string transactionId = transaction.Response.TransactionResponse.Pnref;
		string accountId = _UserName;
		if (transaction.Response.TransactionResponse.Result != 0)
		{
			string transactionResult3 = "PayPal Failure";
			string transactionMessage3 = $"Authorization failed.  The following message was returned: {transaction.Response.TransactionResponse.RespMsg}";
			if (Settings.Default.RetryPaypalOn10486ErrorEnabled && transactionMessage3 != null && transactionMessage3.Contains("10486"))
			{
				IncrementCounter("PayPalFailureErrorCode10486");
				isRetryPaypalOnError = true;
			}
			else
			{
				if (Settings.Default.DoNotProceedOnPaypalError11607Enabled && transactionMessage3 != null && transactionMessage3.Contains("11607"))
				{
					IncrementCounter("PayPalFailureErrorCode11607");
					isPaypalError11607 = true;
					return false;
				}
				_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				_InitialCharge.Save();
				_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
				_Sale.Save();
			}
			LogTransaction(transactionId, transactionResult3, transactionMessage3, accountId);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
				{
					UserName = _UserName,
					Sale = _Sale,
					SessionId = _SessionId,
					PaymentInfo = _PaymentInfo,
					TransactionId = transactionId,
					TranactionStatus = TransactionStatus.Failure
				}));
			});
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				TransactionFailed(_SessionId, fraudDetectorResult.TransactionId);
			});
			_NetSuccessOrFailure = false;
			return _NetSuccessOrFailure;
		}
		if (transaction.Response.TransactionResponse.PendingReason == "none" || transaction.Response.TransactionResponse.PendingReason == "completed")
		{
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
			_InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
			_Sale.Save();
			string transactionResult = "PayPal Success";
			string transactionMessage = "";
			LogTransaction(transactionId, transactionResult, transactionMessage, accountId);
			_NetSuccessOrFailure = true;
			SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
			if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
			{
				CancelExistingRecurringMembershipSale(_Sale);
			}
			TryToPublishBillingTransaction(_Sale, _Logger, null);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
				{
					UserName = _UserName,
					Sale = _Sale,
					SessionId = _SessionId,
					PaymentInfo = _PaymentInfo,
					TransactionId = transactionId,
					TransactionAmount = _InitialCharge.Amount,
					TranactionStatus = TransactionStatus.Success
				}));
			});
			return _NetSuccessOrFailure;
		}
		_InitialCharge.Save();
		string transactionResult2 = "PayPal Pending";
		string transactionMessage2 = "";
		LogTransaction(transactionId, transactionResult2, transactionMessage2, accountId);
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
			{
				UserName = _UserName,
				Sale = _Sale,
				SessionId = _SessionId,
				PaymentInfo = _PaymentInfo,
				TransactionId = transactionId,
				TransactionAmount = _InitialCharge.Amount,
				TranactionStatus = TransactionStatus.Pending
			}));
		});
		_NetSuccessOrFailure = false;
		return _NetSuccessOrFailure;
	}

	/// <summary>
	/// Just tests the logging / premium feature grant using data returned by paypal. Not a full integration test. 
	/// Only use on successful payment result.
	/// </summary>
	public bool FinalizePayInTestMode(int paymentId, string transactionId)
	{
		_InitialCharge = Payment.Get(paymentId);
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
		_InitialCharge.Save();
		_Sale = Sale.Get(_InitialCharge.SaleID);
		_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		_Sale.Save();
		string transactionResult = "PayPal Success";
		string transactionMessage = "";
		LogTransaction(transactionId, transactionResult, transactionMessage, _UserName);
		_NetSuccessOrFailure = true;
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
		if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			CancelExistingRecurringMembershipSale(_Sale);
		}
		TryToPublishBillingTransaction(_Sale, _Logger, null);
		return _NetSuccessOrFailure;
	}

	/// <summary>
	/// Gets the recurring profile information from PayPal for a given account. Optionally fetches the history.
	/// </summary>
	/// <param name="sale">the recurring sale</param>
	/// <param name="getPaymentHistory">true if we want to fetch the payment history</param>
	/// <returns>GetRecurringInfoResult</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="paypalAccountId" /></exception>
	/// <exception cref="T:System.ApplicationException">If there was an error fetching the recurring profile from PayPal</exception>
	public GetRecurringInfoResult GetRecurringInfo(Sale sale, bool getPaymentHistory = false)
	{
		if (sale == null)
		{
			throw new ArgumentNullException("sale");
		}
		GetRecurringInfoResult response = PayPalAuthorityFactory.Singleton.GetPayPalAuthority(Settings.Default.BillingLibraryApiKey).GetRecurringInfo(GetAccountId(sale), getPaymentHistory);
		if (!response.NetSuccess)
		{
			throw new ApplicationException($"Error while trying to get the recurring profile info from PayPal with result = {response.Result} and message = {response.ResponseString}");
		}
		return response;
	}

	/// <summary>
	/// Gets the paypal account identifier for a sale from the transaction log.
	/// </summary>
	/// <param name="sale"></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="sale" /></exception>
	/// <exception cref="T:System.ApplicationException">When the sale has no payments, couldn't retreive the transaction log for the payment or the transaction log lacks an account id</exception>
	/// <returns>The paypal account id</returns>
	private string GetAccountId(Sale sale)
	{
		if (sale == null)
		{
			throw new ArgumentNullException("sale");
		}
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID)?.FirstOrDefault();
		if (mostRecentPayment == null)
		{
			throw new ApplicationException($"Could not retrieve a payment record for Sale ID {sale.ID}");
		}
		TransactionLog obj = TransactionLog.GetByPaymentID(mostRecentPayment.ID) ?? throw new ApplicationException($"No transaction log for payment {mostRecentPayment.ID} on sale {sale.ID}.");
		if (string.IsNullOrWhiteSpace(obj.AccountID))
		{
			throw new ApplicationException("Required value not specified: AccountID");
		}
		return obj.AccountID.Trim();
	}

	private void LogTransaction(string transactionId, string transactionResult, string transactionMessage, string accountId, int? paypalBillingAgreementID = null)
	{
		TransactionLog transactionLog = TransactionLog.GetByPaymentID(_InitialCharge.ID);
		if (transactionLog == null)
		{
			transactionLog = new TransactionLog();
		}
		transactionLog.Amount = _Sale.DiscountedPriceTotal;
		transactionLog.UserAccountID = _Sale.PurchaserAccountID;
		transactionLog.ClientIP = HttpContext.Current.GetOriginIP();
		transactionLog.TransactionType = transactionResult;
		transactionLog.TransactionID = transactionId;
		transactionLog.SaleID = _Sale.ID;
		transactionLog.PaymentID = _InitialCharge.ID;
		transactionLog.PaymentStatusTypeID = _InitialCharge.PaymentStatusTypeID;
		transactionLog.TransactionDate = DateTime.Now;
		TransactionLog transactionLog2 = transactionLog;
		string errorMessage = (transactionLog.Description = transactionMessage);
		transactionLog2.ErrorMessage = errorMessage;
		transactionLog.AccountID = accountId;
		transactionLog.PayPalBillingAgreementID = paypalBillingAgreementID;
		transactionLog.Save();
	}

	private string GetRecurringPayPeriod()
	{
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			return "MONT";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			return "QTER";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			return "SMYR";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			return "YEAR";
		}
		throw new ApplicationException($"Invalid renewal period type ID specified for Sale {_Sale.ID}");
	}

	private string GetHumanReadableRecurringPayPeriod()
	{
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			return "month";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			return "3 months";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			return "6 months";
		}
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			return "year";
		}
		throw new ApplicationException($"Invalid renewal period type ID specified for Sale {_Sale.ID}");
	}

	private void IncrementCounter(string counterName)
	{
		if (_EphemeralCounterFactory != null && Settings.Default.IncrementCounterOnPayPalFailureEnabled)
		{
			ICounter counter = _EphemeralCounterFactory.GetCounter(counterName);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				counter.Increment();
			});
		}
	}

	private CountryCurrency GetPayPalSupportedCountryCurrency(CountryCurrency countryCurrency, string payPalSupportedCurrencyCodes)
	{
		CountryCurrency usaCountryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Roblox.Demographics.Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		if (countryCurrency == null || countryCurrency.ID == usaCountryCurrency.ID)
		{
			return usaCountryCurrency;
		}
		string currencyCode = CurrencyType.Get(countryCurrency.CurrencyTypeID).Code;
		if (currencyCode == null || !payPalSupportedCurrencyCodes.Contains(currencyCode))
		{
			return usaCountryCurrency;
		}
		return countryCurrency;
	}

	public string BeginCheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId, string sessionId = null)
	{
		ValidateCheckout(shoppingCart);
		_UserName = userName;
		_SessionId = sessionId;
		_Sale = shoppingCart.CheckOut(_CountryCurrency.CountryTypeID, PaymentProviderType.Paypal.ID, platformTypeId, performPurchaseLimitCheck: true, _CountryCurrency.CurrencyTypeID, _IsCountryCurrencyFallbackToUSD);
		_Sale.CurrencyTypeID = _CountryCurrency.CurrencyTypeID;
		_Sale.Save();
		return BeginPay();
	}

	public string BeginCheckOut(ShoppingCart shoppingCart, string userName, bool isTestMode, byte platformTypeId, string sessionId = null)
	{
		ValidateCheckout(shoppingCart);
		_IsTestMode = isTestMode;
		_UserName = userName;
		_SessionId = sessionId;
		_Sale = shoppingCart.CheckOut(_CountryCurrency.CountryTypeID, PaymentProviderType.Paypal.ID, platformTypeId, performPurchaseLimitCheck: true, _CountryCurrency.CurrencyTypeID, _IsCountryCurrencyFallbackToUSD);
		return BeginPay();
	}

	public string BeginCheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, byte platformTypeId, string sessionId = null)
	{
		_UserName = userName;
		_SessionId = sessionId;
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using a PayPal. Please use another payment method.");
		}
		_Sale = shoppingCart.CheckOut(_CountryCurrency.CountryTypeID, PaymentProviderType.Paypal.ID, platformTypeId, performPurchaseLimitCheck: true, _CountryCurrency.CurrencyTypeID, _IsCountryCurrencyFallbackToUSD);
		_Sale.RenewalDate = renewalDate;
		_Sale.CurrencyTypeID = _CountryCurrency.CurrencyTypeID;
		_Sale.Save();
		return BeginPay();
	}

	public string BeginCheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, bool isTestMode, byte platformTypeId, string sessionId = null)
	{
		_IsTestMode = isTestMode;
		return BeginCheckOut(shoppingCart, renewalDate, userName, platformTypeId, sessionId);
	}

	/// <summary>
	/// Validate that hopping Cart contents are available to be purchased by user.
	/// </summary>
	/// <param name="shoppingCart">Shopping cart contents to be validated</param>
	/// <exception cref="T:Roblox.Billing.BlockedPurchaseException">Throws if user is spending more than set limit.</exception>
	private void ValidateCheckout(ShoppingCart shoppingCart)
	{
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using PayPal. Please use another payment method.");
		}
		if (shoppingCart.Contents.Where((ShoppingCartProduct x) => x.IsRenewable).Count() > 0)
		{
			if (!BillingHelper.PayPalRecurringIsEnabled)
			{
				throw new ApplicationException("Recurring billing has not been implemented for PayPal. Use credit card.");
			}
			throw new ApplicationException("Use CheckOut(shoppingCart, renewalDate) for carts containing a recurring item.");
		}
		long accountId = AccountShoppingCart.GetByShoppingCartID(shoppingCart.ID)?.AccountID ?? 0;
		if (PaymentHelper.UsersTransactionAmount(accountId, PaymentHelper.TransactionTimeWindowType.Day, shoppingCart.GetTotalPriceInUSDByPaymentProviderTypeId(PaymentProviderType.Paypal.ID) ?? 0m) >= DailyChargeLimitForPayPalExpress)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountDaily.ID, string.Format(PaymentHelper.OverLimitMessage, PaymentHelper.CodeDailyPerAccount));
		}
		if (PaymentHelper.UsersTransactionAmount(accountId, PaymentHelper.TransactionTimeWindowType.Month, shoppingCart.GetTotalPriceInUSDByPaymentProviderTypeId(PaymentProviderType.Paypal.ID) ?? 0m) >= MonthlyChargeLimitForPayPalExpress)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountDaily.ID, string.Format(PaymentHelper.OverLimitMessage, PaymentHelper.CodeMonthlyPerAccount));
		}
	}
}
