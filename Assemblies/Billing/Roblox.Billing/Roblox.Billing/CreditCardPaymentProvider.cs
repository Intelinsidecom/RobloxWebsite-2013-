using System;
using System.Collections.Generic;
using System.Linq;
using PayPal.Payments.Common.Utility;
using PayPal.Payments.DataObjects;
using PayPal.Payments.Transactions;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Billing.Providers;
using Roblox.EventLog;

namespace Roblox.Billing;

public class CreditCardPaymentProvider : PaymentProviderBase, ISynchronousPaymentProvider, IPaymentProvider
{
	private CreditCardPaymentInfo _PaymentInfo;

	private string _RecurringAccountID = string.Empty;

	private bool _TestMode;

	private TransactionResponse _TransactionResponse;

	private string _UserName = string.Empty;

	private string _SessionId;

	private readonly ILogger _Logger;

	private FraudDetectionProvider _FraudDetectionProvider;

	private Sale _Sale;

	private bool _IsFreeTransaction
	{
		get
		{
			if (_Sale.DiscountedPriceTotal == 0m)
			{
				return !_Sale.RecurringPrice.HasValue;
			}
			return false;
		}
	}

	private bool _IsPaypalDelayedCaptureEnabled
	{
		get
		{
			User user = User.Get(_UserName);
			if (Settings.Default.PayPalDelayedCapturePercentageRollout != 100 && (user == null || user.ID % 100 >= Settings.Default.PayPalDelayedCapturePercentageRollout))
			{
				if (user != null && user.TestIsSoothsayer())
				{
					return Settings.Default.PayPalDelayedCaptureEnabledForSoothsayers;
				}
				return false;
			}
			return true;
		}
	}

	public bool TestMode => _TestMode;

	public static PaymentProviderType Type => PaymentProviderType.CreditCard;

	public bool Enabled => true;

	public Payment InitialCharge { get; set; }

	public bool NetSuccessOrFailure { get; set; }

	public Sale Sale => _Sale;

	public bool SupportsRecurringBilling => true;

	public static event Func<string, string, PaymentType, IFraudDetectorResult> OnTransactionFailed;

	public static event Action<FraudDetectionData> OnSaleCompleted;

	public CreditCardPaymentProvider(ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		_Logger = logger;
	}

	public CreditCardPaymentProvider(ILogger logger, CreditCardPaymentInfo paymentInfo, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, string sessionId = null)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		_Logger = logger;
		_PaymentInfo = paymentInfo;
		_SessionId = sessionId;
		_FraudDetectionProvider = new FraudDetectionProvider(fraudDetectionAction);
	}

	public CreditCardPaymentProvider(ILogger logger, CreditCardPaymentInfo paymentInfo, bool isTestMode, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, string sessionId = null)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		_Logger = logger;
		_PaymentInfo = paymentInfo;
		_TestMode = isTestMode;
		_SessionId = sessionId;
		_FraudDetectionProvider = new FraudDetectionProvider(fraudDetectionAction);
	}

	private void TransactionFailed(string sessionId, string transactionId)
	{
		CreditCardPaymentProvider.OnTransactionFailed?.Invoke(sessionId, transactionId, PaymentType.CreditCard);
	}

	private void SaleCompleted(FraudDetectionData fraudDetectionData)
	{
		CreditCardPaymentProvider.OnSaleCompleted?.Invoke(fraudDetectionData);
	}

	private void CompleteFreeTransaction()
	{
		NetSuccessOrFailure = true;
		_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		_Sale.Save();
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
		if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			CancelExistingRecurringMembershipSale(_Sale);
		}
	}

	private void LogTransaction(string transactionId, string transactionResponseMessage, string transactionResultCode)
	{
		TransactionLog t = new TransactionLog();
		t.PaymentID = InitialCharge.ID;
		t.UserAccountID = _Sale.PurchaserAccountID;
		t.TransactionID = transactionId;
		t.TransactionType = (_Sale.RecurringPrice.HasValue ? "recurring" : "sale");
		t.AuthCode = ((_TransactionResponse == null) ? null : _TransactionResponse.AuthCode);
		t.AvsCode = ((_TransactionResponse == null) ? null : (_TransactionResponse.AVSAddr + _TransactionResponse.AVSZip + _TransactionResponse.IAVS));
		t.SaleID = _Sale.ID;
		t.Number = MaskCreditCardNumber(_PaymentInfo.AccountNumber);
		t.Amount = InitialCharge.Amount;
		t.Year = int.Parse(_PaymentInfo.ExpirationYear);
		t.Month = int.Parse(_PaymentInfo.ExpirationMonth);
		t.Address = _PaymentInfo.AddressLine1;
		t.Address2 = _PaymentInfo.AddressLine2;
		t.City = _PaymentInfo.City;
		t.Country = _PaymentInfo.Country;
		t.Email = _PaymentInfo.Email;
		t.FirstName = _PaymentInfo.FirstName;
		t.LastName = _PaymentInfo.LastName;
		t.Phone = _PaymentInfo.Phone;
		t.StateProvince = _PaymentInfo.State;
		t.ZipPostal = _PaymentInfo.PostalCode;
		t.ClientIP = _PaymentInfo.ClientIP;
		t.TransactionDate = DateTime.Now;
		t.PaymentStatusTypeID = InitialCharge.PaymentStatusTypeID;
		string errorMessage = (t.Description = transactionResponseMessage);
		t.ErrorMessage = errorMessage;
		t.Code = ((_TransactionResponse == null) ? null : _TransactionResponse.CVV2Match);
		t.ErrorMessage = transactionResponseMessage;
		if (!string.IsNullOrEmpty(_RecurringAccountID))
		{
			t.AccountID = _RecurringAccountID;
		}
		else
		{
			t.AccountID = _UserName;
		}
		t.Save();
	}

	/// <summary>
	/// Whether the card is Visa (4) or MasterCard (5).
	/// No one else seems to support Paypal's preauth call.
	/// </summary>
	/// <param name="accountNumber">A string containing the credit card number.</param>
	/// <returns></returns>
	private bool TransactionSupportsPreauth(string accountNumber)
	{
		if (accountNumber.First() != '4')
		{
			return accountNumber.First() == '5';
		}
		return true;
	}

	private bool Pay()
	{
		if (_IsFreeTransaction || TestMode)
		{
			CompleteFreeTransaction();
			return true;
		}
		if (_Sale.Products.Count((SaleProduct x) => x.RecurringPrice.HasValue) > 1)
		{
			throw new NotImplementedException("Only one recurring product per cart has been implemented.");
		}
		_Sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		_Sale.Save();
		TryToPublishBillingTransaction(_Sale, _Logger, null);
		InitialCharge = new Payment();
		InitialCharge.PaymentDate = DateTime.Now;
		InitialCharge.PaymentProviderTypeID = PaymentProviderType.CreditCard.ID;
		InitialCharge.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
		InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		InitialCharge.SaleID = _Sale.ID;
		InitialCharge.Save();
		try
		{
			PayPalHelper.WaitForThrottle();
			if (_IsPaypalDelayedCaptureEnabled && (!_Sale.RecurringPrice.HasValue || Settings.Default.PayPalDeplyedCaptureEnabledForRecurringPayments))
			{
				if (TransactionSupportsPreauth(_PaymentInfo.AccountNumber))
				{
					ProcessCreditCardWithDelayedCapture();
				}
				else
				{
					ProcessCreditCardWithFraudProtectionOnly();
				}
			}
			else
			{
				ProcessCreditCard();
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			if (InitialCharge != null)
			{
				InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				InitialCharge.Save();
			}
			_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
			_Sale.Save();
			TryToPublishBillingTransaction(_Sale, _Logger, null);
			NetSuccessOrFailure = false;
			throw new ApplicationException("Credit card transaction suffered an unexpected error:", ex);
		}
		if (!NetSuccessOrFailure)
		{
			return false;
		}
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
		GiftCard.ActivateGiftCardsForSale(_Sale.ID);
		if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			CancelExistingRecurringMembershipSale(_Sale);
		}
		return true;
	}

	private CardTender GetCardTender(BillTo billTo, Invoice invoice)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		billTo.FirstName = _PaymentInfo.FirstName;
		billTo.LastName = _PaymentInfo.LastName;
		billTo.Street = _PaymentInfo.AddressLine1;
		if (!string.IsNullOrEmpty(_PaymentInfo.AddressLine2))
		{
			billTo.BillToStreet2 = _PaymentInfo.AddressLine2;
		}
		billTo.City = _PaymentInfo.City;
		billTo.State = _PaymentInfo.State;
		billTo.Zip = _PaymentInfo.PostalCode;
		billTo.BillToCountry = _PaymentInfo.Country;
		billTo.Email = _PaymentInfo.Email;
		billTo.PhoneNum = _PaymentInfo.Phone;
		invoice.BillTo = billTo;
		invoice.InvNum = _Sale.ID.ToString();
		invoice.Comment1 = _Sale.GenerateComment1Field(_UserName);
		return new CardTender(new CreditCard(_PaymentInfo.AccountNumber, _PaymentInfo.ExpirationMonth + _PaymentInfo.ExpirationYear)
		{
			Cvv2 = _PaymentInfo.SecurityCode
		});
	}

	private CreditCardTransactionInfo ProcessPreauthorization(UserInfo userInfo, PayflowConnectionData payflowConnection, BillTo billTo, Invoice invoice, CardTender cardTender)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		AuthorizationTransaction preauthorizationTransaction = new AuthorizationTransaction(userInfo, payflowConnection, invoice, (BaseTender)(object)cardTender, PayflowUtility.RequestId);
		((BaseTransaction)preauthorizationTransaction).SubmitTransaction();
		_TransactionResponse = ((BaseTransaction)preauthorizationTransaction).Response.TransactionResponse;
		CreditCardTransactionInfo result = default(CreditCardTransactionInfo);
		result.TransactionType = CreditCardTransactionType.Preauthorization;
		result.TransactionId = ((BaseTransaction)preauthorizationTransaction).Response.TransactionResponse.Pnref;
		result.TransactionResult = ((BaseTransaction)preauthorizationTransaction).Response.TransactionResponse.Result;
		result.TransactionResponseMessage = ((BaseTransaction)preauthorizationTransaction).Response.TransactionResponse.RespMsg;
		return result;
	}

	private CreditCardTransactionInfo ProcessVoidTransaction(UserInfo userInfo, PayflowConnectionData payflowConnection, BillTo billTo, Invoice invoice, CardTender cardTender, string origId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		VoidTransaction voidTransaction = new VoidTransaction(origId, userInfo, payflowConnection, invoice, PayflowUtility.RequestId);
		((BaseTransaction)voidTransaction).SubmitTransaction();
		_TransactionResponse = ((BaseTransaction)voidTransaction).Response.TransactionResponse;
		CreditCardTransactionInfo result = default(CreditCardTransactionInfo);
		result.TransactionType = CreditCardTransactionType.Void;
		result.TransactionId = ((BaseTransaction)voidTransaction).Response.TransactionResponse.Pnref;
		result.TransactionResult = ((BaseTransaction)voidTransaction).Response.TransactionResponse.Result;
		result.TransactionResponseMessage = ((BaseTransaction)voidTransaction).Response.TransactionResponse.RespMsg;
		return result;
	}

	private CreditCardTransactionInfo ProcessCaptureTrasaction(UserInfo userInfo, PayflowConnectionData payflowConnection, BillTo billTo, Invoice invoice, CardTender cardTender, string origId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		CaptureTransaction captureTransaction = new CaptureTransaction(origId, userInfo, payflowConnection, invoice, PayflowUtility.RequestId);
		((BaseTransaction)captureTransaction).SubmitTransaction();
		_TransactionResponse = ((BaseTransaction)captureTransaction).Response.TransactionResponse;
		CreditCardTransactionInfo result = default(CreditCardTransactionInfo);
		result.TransactionType = CreditCardTransactionType.Capture;
		result.TransactionId = ((BaseTransaction)captureTransaction).Response.TransactionResponse.Pnref;
		result.TransactionResult = ((BaseTransaction)captureTransaction).Response.TransactionResponse.Result;
		result.TransactionResponseMessage = ((BaseTransaction)captureTransaction).Response.TransactionResponse.RespMsg;
		return result;
	}

	private CreditCardTransactionInfo ProcessRecurringTransaction(UserInfo userInfo, PayflowConnectionData payflowConnection, BillTo billTo, Invoice invoice, CardTender cardTender, string currencyCode, string origId = null)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		RecurringInfo recurringInfo = GetRecurringInfo(currencyCode);
		RecurringAddTransaction recurringTransaction = new RecurringAddTransaction(userInfo, payflowConnection, invoice, (BaseTender)(object)cardTender, recurringInfo, PayflowUtility.RequestId);
		if (!string.IsNullOrEmpty(origId))
		{
			recurringTransaction.OrigId = origId;
		}
		((BaseTransaction)recurringTransaction).SubmitTransaction();
		_TransactionResponse = ((BaseTransaction)recurringTransaction).Response.TransactionResponse;
		_RecurringAccountID = ((BaseTransaction)recurringTransaction).Response.RecurringResponse.ProfileId;
		CreditCardTransactionInfo result = default(CreditCardTransactionInfo);
		result.TransactionType = CreditCardTransactionType.Recurring;
		result.TransactionId = ((BaseTransaction)recurringTransaction).Response.RecurringResponse.RPRef;
		result.TransactionResult = ((BaseTransaction)recurringTransaction).Response.TransactionResponse.Result;
		result.TransactionResponseMessage = ((BaseTransaction)recurringTransaction).Response.TransactionResponse.RespMsg;
		return result;
	}

	private RecurringInfo GetRecurringInfo(string currencyCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		RecurringInfo recurringInfo = new RecurringInfo();
		recurringInfo.Start = _Sale.RenewalDate.Value.ToString("MMddyyyy");
		recurringInfo.ProfileName = _UserName;
		recurringInfo.Term = 0L;
		recurringInfo.RetryNumDays = PayPalHelper.NumDaysToRetry;
		if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			recurringInfo.PayPeriod = "MONT";
		}
		else if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			recurringInfo.PayPeriod = "QTER";
		}
		else if (_Sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			recurringInfo.PayPeriod = "SMYR";
		}
		else
		{
			if (_Sale.RenewalPeriodTypeID != RenewalPeriodType.Annual.ID)
			{
				throw new ApplicationException($"Invalid renewal period type ID specified for Sale {_Sale.ID}");
			}
			recurringInfo.PayPeriod = "YEAR";
		}
		if (_Sale.DiscountedPriceTotal > 0m)
		{
			recurringInfo.OptionalTrx = "S";
			recurringInfo.OptionalTrxAmt = new Currency(decimal.Round(_Sale.DiscountedPriceTotal, 2), currencyCode);
		}
		else
		{
			recurringInfo.OptionalTrx = "A";
		}
		return recurringInfo;
	}

	private CreditCardTransactionInfo ProcessSaleTransaction(UserInfo userInfo, PayflowConnectionData payflowConnection, BillTo billTo, Invoice invoice, CardTender cardTender)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		SaleTransaction saleTransaction = new SaleTransaction(userInfo, payflowConnection, invoice, (BaseTender)(object)cardTender, PayflowUtility.RequestId);
		((BaseTransaction)saleTransaction).SubmitTransaction();
		_TransactionResponse = ((BaseTransaction)saleTransaction).Response.TransactionResponse;
		CreditCardTransactionInfo result = default(CreditCardTransactionInfo);
		result.TransactionType = CreditCardTransactionType.Sale;
		result.TransactionId = ((BaseTransaction)saleTransaction).Response.TransactionResponse.Pnref;
		result.TransactionResult = ((BaseTransaction)saleTransaction).Response.TransactionResponse.Result;
		result.TransactionResponseMessage = ((BaseTransaction)saleTransaction).Response.TransactionResponse.RespMsg;
		return result;
	}

	/// <summary>         
	/// DelayedCapture allows the payment process to inject FraudDetection before finalizing the authorization
	/// This also checks the validity of the CC first so that we don't even have to check Fraud for the transactions that will fail anyway.
	/// </summary>
	private void ProcessCreditCardWithDelayedCapture()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019b: Expected O, but got Unknown
		SaleStatusType saleStatusType = null;
		PaymentStatusType paymentStatusType = null;
		CreditCardTransactionInfo? transactionInfo = null;
		PayflowConnectionData payflowConnection = new PayflowConnectionData(PayPalHelper.Connection);
		UserInfo userInfo = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
		string currencyCode = PayPalHelper.GetCurrencyCode(_Sale.CurrencyTypeID);
		decimal preauthAmount = (_Sale.RecurringPrice.HasValue ? 0m : _Sale.DiscountedPriceTotal);
		Invoice invoice = new Invoice
		{
			Amt = new Currency(decimal.Round(preauthAmount, 2), currencyCode)
		};
		BillTo billTo = new BillTo();
		CardTender cardTender = GetCardTender(billTo, invoice);
		CreditCardTransactionInfo preauthTransaction = ProcessPreauthorization(userInfo, payflowConnection, billTo, invoice, cardTender);
		if (preauthTransaction.TransactionResult == 0)
		{
			IFraudDetectorResult fraudDetectorResult = _FraudDetectionProvider.GetFraudDetectionResult(_UserName, _Sale, _SessionId, _PaymentInfo);
			string origId = preauthTransaction.TransactionId;
			if (fraudDetectorResult != null && fraudDetectorResult.IsFraudulent)
			{
				transactionInfo = ProcessVoidTransaction(userInfo, payflowConnection, billTo, invoice, cardTender, origId);
				saleStatusType = SaleStatusType.Blocked;
				paymentStatusType = PaymentStatusType.Blocked;
			}
			else
			{
				if (_Sale.RecurringPrice.HasValue)
				{
					invoice = new Invoice
					{
						Amt = new Currency(decimal.Round(_Sale.RecurringPrice.Value, 2), currencyCode)
					};
					transactionInfo = ProcessRecurringTransaction(userInfo, payflowConnection, billTo, invoice, cardTender, currencyCode, origId);
				}
				else
				{
					transactionInfo = ProcessCaptureTrasaction(userInfo, payflowConnection, billTo, invoice, cardTender, origId);
				}
				saleStatusType = SaleStatusType.Complete;
				paymentStatusType = PaymentStatusType.Complete;
			}
			if (transactionInfo.Value.TransactionResult == 0)
			{
				if (InitialCharge != null)
				{
					InitialCharge.PaymentStatusTypeID = paymentStatusType.ID;
					InitialCharge.Save();
				}
			}
			else
			{
				if (GlobalProperties.IsTestingSite && transactionInfo.HasValue)
				{
					_Logger.Error(string.Concat(transactionInfo.Value.TransactionType, "TransactionResult: ", transactionInfo.Value.TransactionResult));
					_Logger.Error(string.Concat(transactionInfo.Value.TransactionType, "TransactionResponseMessage: ", transactionInfo.Value.TransactionResponseMessage));
				}
				saleStatusType = SaleStatusType.Error;
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					TransactionFailed(_SessionId, fraudDetectorResult.TransactionId);
				});
			}
		}
		else
		{
			transactionInfo = preauthTransaction;
			saleStatusType = SaleStatusType.Error;
			if (GlobalProperties.IsTestingSite && transactionInfo.HasValue)
			{
				_Logger.Error("PreauthTransactionResult: " + transactionInfo.Value.TransactionResult);
				_Logger.Error("PreauthTransactionResponseMessage: " + transactionInfo.Value.TransactionResponseMessage);
			}
		}
		_Sale.SaleStatusTypeID = saleStatusType.ID;
		_Sale.Save();
		NetSuccessOrFailure = paymentStatusType == PaymentStatusType.Complete && transactionInfo.Value.TransactionResult == 0;
		LogTransaction(transactionInfo.Value.TransactionId, transactionInfo.Value.TransactionResponseMessage, transactionInfo.Value.TransactionResult.ToString());
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
			{
				UserName = _UserName,
				Sale = _Sale,
				SessionId = _SessionId,
				PaymentInfo = _PaymentInfo,
				TransactionId = transactionInfo.Value.TransactionId,
				TransactionAmount = InitialCharge.Amount,
				TranactionStatus = ((!NetSuccessOrFailure) ? TransactionStatus.Failure : TransactionStatus.Success)
			}));
		});
	}

	/// <summary>         
	/// DelayedCapture allows the payment process to inject FraudDetection before finalizing the authorization
	/// This does not check the validity of the CC beforehand, and should only be used for card providers who don't support PayPal's preauth call (otherwise use ProcessCreditCardWithDelayedCapture)
	/// </summary>
	private void ProcessCreditCardWithFraudProtectionOnly()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		CreditCardTransactionInfo? transactionInfo = null;
		SaleStatusType saleStatusType = null;
		PaymentStatusType paymentStatusType = null;
		PayflowConnectionData payflowConnection = new PayflowConnectionData(PayPalHelper.Connection);
		UserInfo userInfo = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
		BillTo billTo = new BillTo();
		Invoice invoice = new Invoice();
		CardTender cardTender = GetCardTender(billTo, invoice);
		string currencyCode = PayPalHelper.GetCurrencyCode(_Sale.CurrencyTypeID);
		IFraudDetectorResult fraudDetectorResult = _FraudDetectionProvider.GetFraudDetectionResult(_UserName, _Sale, _SessionId, _PaymentInfo);
		if (fraudDetectorResult != null && fraudDetectorResult.IsFraudulent)
		{
			saleStatusType = SaleStatusType.Blocked;
			paymentStatusType = PaymentStatusType.Blocked;
			NetSuccessOrFailure = false;
			LogTransaction(null, null, "Blocked by third party fraud providers.");
		}
		else
		{
			decimal amount;
			if (!_Sale.RecurringPrice.HasValue)
			{
				amount = decimal.Round(_Sale.DiscountedPriceTotal, 2);
				invoice.Amt = new Currency(amount, currencyCode);
				transactionInfo = ProcessSaleTransaction(userInfo, payflowConnection, billTo, invoice, cardTender);
			}
			else
			{
				amount = decimal.Round(_Sale.RecurringPrice.Value, 2);
				invoice.Amt = new Currency(amount, currencyCode);
				transactionInfo = ProcessRecurringTransaction(userInfo, payflowConnection, billTo, invoice, cardTender, currencyCode);
			}
			paymentStatusType = PaymentStatusType.Complete;
			if (transactionInfo.Value.TransactionResult == 0)
			{
				if (InitialCharge != null)
				{
					InitialCharge.PaymentStatusTypeID = paymentStatusType.ID;
					InitialCharge.Save();
				}
				saleStatusType = SaleStatusType.Complete;
				NetSuccessOrFailure = true;
			}
			else
			{
				if (InitialCharge != null)
				{
					InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
					InitialCharge.Save();
				}
				if (GlobalProperties.IsTestingSite && transactionInfo.HasValue)
				{
					_Logger.Error("TransactionResult: " + transactionInfo.Value.TransactionResult);
					_Logger.Error("TransactionResponseMessage: " + transactionInfo.Value.TransactionResponseMessage);
				}
				saleStatusType = SaleStatusType.Error;
				NetSuccessOrFailure = false;
				RobloxThreadPool.QueueUserWorkItem(delegate
				{
					TransactionFailed(_SessionId, fraudDetectorResult.TransactionId);
				});
			}
			LogTransaction(transactionInfo.Value.TransactionId, transactionInfo.Value.TransactionResponseMessage, transactionInfo.Value.TransactionResult.ToString());
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				SaleCompleted(_FraudDetectionProvider.GetFraudDetectionData(new FraudDetectionDataParam
				{
					UserName = _UserName,
					Sale = _Sale,
					SessionId = _SessionId,
					PaymentInfo = _PaymentInfo,
					TransactionId = transactionInfo.Value.TransactionId,
					TransactionAmount = amount,
					TranactionStatus = ((!NetSuccessOrFailure) ? TransactionStatus.Failure : TransactionStatus.Success)
				}));
			});
		}
		_Sale.SaleStatusTypeID = saleStatusType.ID;
		_Sale.Save();
	}

	/// <summary>
	/// Simple CreditCard process. Process then submit to 3rd Party Fraud Detectors.
	/// </summary>
	private void ProcessCreditCard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		CreditCardTransactionInfo? transactionInfo = null;
		SaleStatusType saleStatusType = null;
		PayflowConnectionData payflowConnection = new PayflowConnectionData(PayPalHelper.Connection);
		UserInfo userInfo = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
		BillTo billTo = new BillTo();
		Invoice invoice = new Invoice();
		CardTender cardTender = GetCardTender(billTo, invoice);
		string currencyCode = PayPalHelper.GetCurrencyCode(_Sale.CurrencyTypeID);
		if (!_Sale.RecurringPrice.HasValue)
		{
			invoice.Amt = new Currency(decimal.Round(_Sale.DiscountedPriceTotal, 2), currencyCode);
			transactionInfo = ProcessSaleTransaction(userInfo, payflowConnection, billTo, invoice, cardTender);
		}
		else
		{
			invoice.Amt = new Currency(decimal.Round(_Sale.RecurringPrice.Value, 2), currencyCode);
			transactionInfo = ProcessRecurringTransaction(userInfo, payflowConnection, billTo, invoice, cardTender, currencyCode);
		}
		if (transactionInfo.Value.TransactionResult == 0)
		{
			if (InitialCharge != null)
			{
				InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
				InitialCharge.Save();
				_FraudDetectionProvider.GetFraudDetectionResult(_UserName, _Sale, _SessionId, _PaymentInfo);
			}
			saleStatusType = SaleStatusType.Complete;
			NetSuccessOrFailure = true;
		}
		else
		{
			if (InitialCharge != null)
			{
				InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				InitialCharge.Save();
			}
			if (GlobalProperties.IsTestingSite)
			{
				_Logger.Error("TransactionResult: " + transactionInfo.Value.TransactionResult);
				_Logger.Error("TransactionResponseMessage: " + transactionInfo.Value.TransactionResponseMessage);
			}
			saleStatusType = SaleStatusType.Error;
			NetSuccessOrFailure = false;
		}
		_Sale.SaleStatusTypeID = saleStatusType.ID;
		_Sale.Save();
		LogTransaction(transactionInfo.Value.TransactionId, transactionInfo.Value.TransactionResponseMessage, transactionInfo.Value.TransactionResult.ToString());
	}

	public static string MaskCreditCardNumber(string creditCardNumber)
	{
		if (creditCardNumber.Length > 7)
		{
			return $"{creditCardNumber.Substring(0, 4).PadRight(creditCardNumber.Length - 8, 'X')}{creditCardNumber.Substring(creditCardNumber.Length - 4, 4)}";
		}
		return creditCardNumber;
	}

	public static void UpdatePaymentInfo(Sale saleToUpdate, CreditCardPaymentInfo creditCardInfo, ILogger logger)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		if (!saleToUpdate.RenewalDate.HasValue)
		{
			throw new ApplicationException("Unable to update sale: must be an active, recurring charge.");
		}
		string transactionResponseMessage = string.Empty;
		TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(((List<Payment>)Payment.GetPaymentsBySale(saleToUpdate.ID))[0].ID);
		try
		{
			PayflowConnectionData payflowConnectionData = new PayflowConnectionData(PayPalHelper.Connection);
			UserInfo userInfo = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
			RecurringInfo recurringInfo = new RecurringInfo();
			recurringInfo.OrigProfileId = associatedTransactionLog.AccountID;
			BillTo billTo = new BillTo();
			billTo.FirstName = creditCardInfo.FirstName;
			billTo.LastName = creditCardInfo.LastName;
			billTo.Street = creditCardInfo.AddressLine1;
			billTo.BillToStreet2 = creditCardInfo.AddressLine2;
			billTo.City = creditCardInfo.City;
			billTo.State = creditCardInfo.State;
			billTo.Zip = creditCardInfo.PostalCode;
			billTo.BillToCountry = creditCardInfo.Country;
			billTo.Email = creditCardInfo.Email;
			billTo.PhoneNum = creditCardInfo.Phone;
			Invoice invoice = new Invoice();
			invoice.BillTo = billTo;
			invoice.Amt = new Currency(0.01m, PayPalHelper.GetCurrencyCode());
			CardTender cardTender = new CardTender(new CreditCard(creditCardInfo.AccountNumber, creditCardInfo.ExpirationMonth + creditCardInfo.ExpirationYear)
			{
				Cvv2 = creditCardInfo.SecurityCode
			});
			Response authResponse = ((BaseTransaction)new AuthorizationTransaction(userInfo, payflowConnectionData, invoice, (BaseTender)(object)cardTender, PayflowUtility.RequestId)).SubmitTransaction();
			TransactionResponse authTransactionResponse = authResponse.TransactionResponse;
			if (authTransactionResponse != null && authTransactionResponse.Result == 0)
			{
				TransactionResponse voidTransactionResponse = ((BaseTransaction)new VoidTransaction(authResponse.TransactionResponse.Pnref, userInfo, payflowConnectionData, PayflowUtility.RequestId)).SubmitTransaction().TransactionResponse;
				int voidtransactionResult = -1;
				string voidResponseMesage = "No transaction reponse from PayPal!";
				if (voidTransactionResponse != null)
				{
					voidResponseMesage = voidTransactionResponse.RespMsg;
					voidtransactionResult = voidTransactionResponse.Result;
				}
				if (voidtransactionResult != 0)
				{
					logger.Error(voidResponseMesage);
				}
				Invoice recurringInvoice = new Invoice();
				recurringInvoice.BillTo = billTo;
				TransactionResponse transactionResponse = ((BaseTransaction)new RecurringModifyTransaction(userInfo, payflowConnectionData, recurringInfo, recurringInvoice, (BaseTender)(object)cardTender, PayflowUtility.RequestId)).SubmitTransaction().TransactionResponse;
				int transactionResult = -1;
				if (transactionResponse != null)
				{
					transactionResponseMessage = transactionResponse.RespMsg;
					transactionResult = transactionResponse.Result;
				}
				if (transactionResult != 0)
				{
					throw new ApplicationException(transactionResponseMessage);
				}
				associatedTransactionLog.Number = MaskCreditCardNumber(creditCardInfo.AccountNumber);
				associatedTransactionLog.Year = int.Parse(creditCardInfo.ExpirationYear);
				associatedTransactionLog.Month = int.Parse(creditCardInfo.ExpirationMonth);
				associatedTransactionLog.Address = creditCardInfo.AddressLine1;
				associatedTransactionLog.Address2 = creditCardInfo.AddressLine2;
				associatedTransactionLog.City = creditCardInfo.City;
				associatedTransactionLog.Country = creditCardInfo.Country;
				associatedTransactionLog.Email = creditCardInfo.Email;
				associatedTransactionLog.FirstName = creditCardInfo.FirstName;
				associatedTransactionLog.LastName = creditCardInfo.LastName;
				associatedTransactionLog.Phone = creditCardInfo.Phone;
				associatedTransactionLog.StateProvince = creditCardInfo.State;
				associatedTransactionLog.ZipPostal = creditCardInfo.PostalCode;
				associatedTransactionLog.ClientIP = creditCardInfo.ClientIP;
				associatedTransactionLog.AuthCode = transactionResponse.AuthCode;
				associatedTransactionLog.AvsCode = transactionResponse.AVSAddr + transactionResponse.AVSZip + transactionResponse.IAVS;
				associatedTransactionLog.Code = transactionResponse.CVV2Match;
				string errorMessage = (associatedTransactionLog.Description = transactionResponseMessage);
				associatedTransactionLog.ErrorMessage = errorMessage;
				associatedTransactionLog.Save();
				return;
			}
			throw new ApplicationException(authTransactionResponse.RespMsg);
		}
		catch (Exception ex)
		{
			logger.Error(ex);
			throw new ApplicationException("Credit card transaction suffered an unexpected error: " + ex.Message, ex);
		}
	}

	public bool CheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId)
	{
		return CheckOut(shoppingCart, userName, adminOverride: false, platformTypeId);
	}

	public bool CheckOut(ShoppingCart shoppingCart, string userName, bool adminOverride, byte platformTypeId)
	{
		_UserName = userName;
		if (!adminOverride && !PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using a credit card. Please use another payment method.");
		}
		if (shoppingCart.TotalPrice > 0m)
		{
			PaymentHelper.PerformPurchaseLimitCheck_CreditCard(_PaymentInfo.AccountNumber, shoppingCart.TotalPrice);
		}
		if (shoppingCart.Contents.Where((ShoppingCartProduct x) => x.IsRenewable).Count() > 0)
		{
			throw new ApplicationException("Use CheckOut(shoppingCart, renewalDate) for carts containing a recurring item.");
		}
		_Sale = shoppingCart.CheckOut(platformTypeId);
		return Pay();
	}

	public bool CheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, byte platformTypeId)
	{
		_UserName = userName;
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using a credit card. Please use another payment method.");
		}
		if (shoppingCart.TotalPrice > 0m)
		{
			PaymentHelper.PerformPurchaseLimitCheck_CreditCard(_PaymentInfo.AccountNumber, shoppingCart.TotalPrice);
		}
		_Sale = shoppingCart.CheckOut(platformTypeId);
		_Sale.RenewalDate = renewalDate;
		_Sale.Save();
		return Pay();
	}

	public bool CheckOut(ShoppingCart shoppingCart, string userName, bool adminOverride, byte countryId, byte? currencyType, byte platformTypeId)
	{
		_UserName = userName;
		if (!adminOverride && !PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using a credit card. Please use another payment method.");
		}
		if (shoppingCart.TotalPrice > 0m)
		{
			PaymentHelper.PerformPurchaseLimitCheck_CreditCard(_PaymentInfo.AccountNumber, shoppingCart.TotalPrice);
		}
		if (shoppingCart.Contents.Where((ShoppingCartProduct x) => x.IsRenewable).Count() > 0)
		{
			throw new ApplicationException("Use CheckOut(shoppingCart, renewalDate) for carts containing a recurring item.");
		}
		byte currencyTypeId = currencyType ?? CurrencyType.GetUSDCurrencyTypeID;
		_Sale = shoppingCart.CheckOut(countryId, Type.ID, platformTypeId, performPurchaseLimitCheck: true, currencyTypeId);
		if (currencyType.HasValue)
		{
			_Sale.CurrencyTypeID = currencyType.Value;
			_Sale.Save();
		}
		return Pay();
	}

	public bool CheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, byte countryId, byte? currencyType, byte platformTypeId)
	{
		_UserName = userName;
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using a credit card. Please use another payment method.");
		}
		if (shoppingCart.TotalPrice > 0m)
		{
			PaymentHelper.PerformPurchaseLimitCheck_CreditCard(_PaymentInfo.AccountNumber, shoppingCart.TotalPrice);
		}
		byte currencyTypeId = currencyType ?? CurrencyType.GetUSDCurrencyTypeID;
		_Sale = shoppingCart.CheckOut(countryId, Type.ID, platformTypeId, performPurchaseLimitCheck: true, currencyTypeId);
		_Sale.RenewalDate = renewalDate;
		if (currencyType.HasValue)
		{
			_Sale.CurrencyTypeID = currencyType.Value;
		}
		_Sale.Save();
		return Pay();
	}
}
