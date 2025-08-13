using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using PayPal.Payments.Common.Utility;
using PayPal.Payments.DataObjects;
using PayPal.Payments.Transactions;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Exceptions;
using Roblox.Billing.Properties;
using Roblox.Billing.Providers;
using Roblox.Common.Properties;
using Roblox.EphemeralCounters;
using Roblox.PayPal.Common.Properties;
using Roblox.Platform.Email.Delivery;

namespace Roblox.Billing;

public static class PayPalHelper
{
	public enum SubscriptionPaymentStatus
	{
		Current,
		Delinquent,
		Pending
	}

	public struct RecurringBillingAttempt
	{
		public string Tender;

		public string Amount;

		public string TransactionState;

		public string PaymentNetworkReferenceID;

		public string TransactionTime;

		public string Result;

		public RecurringBillingAttempt(string tender, string amount, string transactionState, string paymentNetworkReferenceId, string transactionTime, string result)
		{
			Tender = tender;
			Amount = amount;
			TransactionState = transactionState;
			PaymentNetworkReferenceID = paymentNetworkReferenceId;
			TransactionTime = transactionTime;
			Result = result;
		}
	}

	private const string _PayPalGetRecurringInfoErrorCounter = "PayPalGetRecurringInfoError";

	private const string _PayPalGetRecurringInfoSuccessCounter = "PayPalGetRecurringInfoSuccess";

	private const string _PayPalGetRecurringInfoResponseDurationCounter = "PayPalGetRecurringInfoResponseDuration";

	private const string _PayPalRenewalAttemptCounter = "PayPalRenewal_Attempt";

	private const string _PayPalRenewalSuccessCounter = "PayPalRenewal_Success";

	private const string _PayPalRenewalFailureCounter = "PayPalRenewal_Failure";

	private const string _PayPalRenewalErrorCounter = "PayPalRenewal_Error";

	private static readonly object _ThrottleLock = new object();

	private static long _NextTransactionMinTime = DateTime.MinValue.Ticks;

	private static int NewPaypalRenewalModulus => Roblox.Billing.Properties.Settings.Default.NewPaypalRenewalModulus;

	private static bool ThrottleEnabled => Roblox.Billing.Properties.Settings.Default.PayPal_ThrottleEnabled;

	private static int ThrottleMaxPerMinute => Roblox.Billing.Properties.Settings.Default.PayPal_ThrottleMaxPerMinute;

	private static int ThrottleMaxWaitBeforeException => Roblox.Billing.Properties.Settings.Default.PayPal_ThrottleMaxWaitInMsBeforeException;

	private static long ThrottleIntervalInTicks
	{
		get
		{
			if (ThrottleEnabled && ThrottleMaxPerMinute > 0)
			{
				return Convert.ToInt64(Math.Ceiling(1.0 / (double)ThrottleMaxPerMinute * 600000000.0));
			}
			return 0L;
		}
	}

	private static string _EnvironmentIdentifier => Roblox.Common.Properties.Settings.Default.EnvironmentIdentifier;

	private static string _RobloxEmailLogo => Roblox.Billing.Properties.Settings.Default.RobloxEmailLogo;

	private static string EmailBody => $"<p><img src=\"http://{_EnvironmentIdentifier}/{_RobloxEmailLogo}\"/></p>" + "<p style=\"font-size: 12px\">We are cancelling your {0} Membership effective " + $"- {DateTime.Now.ToShortDateString()} because of a payment failure when we attempted to renew " + "the membership.</p><p style=\"font-size: 12px\">If you'd like to renew your membership you can " + $"do so <a href= \"https://{_EnvironmentIdentifier}/premium/membership \">here</a>. We hope you " + "enjoyed your membership.</p>";

	private static TimeSpan DarkOrdersWindow => TimeSpan.FromDays((int)DarkOrdersWindowInDays);

	public static string CredentialsPartner => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_Partner;

	public static string CredentialsPassword => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_Password;

	public static string CredentialsUser => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_UserName;

	public static string CredentialsVendor => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_Vendor;

	public static string Connection => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_Connection;

	public static int PayPalDefaultHostPort => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_DefaultHostPort;

	public static int PayPalDefaultTimeOutSeconds => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_DefaultTimeOutSeconds;

	public static int NumDaysToRetry => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_NumDaysToRetry;

	public static byte DarkOrdersWindowInDays => Roblox.Billing.Properties.Settings.Default.DarkOrdersWindowInDays;

	public static int MonitorSleepTimeInMinutes => Roblox.Billing.Properties.Settings.Default.MonitorSleepTimeInMinutes;

	public static TimeSpan MonitorLeasedLockDuration => Roblox.Billing.Properties.Settings.Default.MonitorLeasedLockDuration;

	public static string ReturnUrl => Roblox.PayPal.Common.Properties.Settings.Default.WebSiteBaseUrl + Roblox.PayPal.Common.Properties.Settings.Default.PayPal_ReturnPage;

	public static string RobloxLogo => Roblox.PayPal.Common.Properties.Settings.Default.WebSiteBaseUrl + Roblox.PayPal.Common.Properties.Settings.Default.PayPal_RobloxLogo;

	public static string CancelUrl => Roblox.PayPal.Common.Properties.Settings.Default.WebSiteBaseUrl + Roblox.PayPal.Common.Properties.Settings.Default.PayPal_CancelPage;

	public static string MerchantInformation => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_MerchantInformation;

	public static string MerchantName => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_MerchantName;

	public static string ExpressCheckoutUrl => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_ExpressCheckoutURL;

	public static bool UseTestMode => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_UseTestMode;

	public static bool IsCorrectPayflowMappingEnabled => Roblox.PayPal.Common.Properties.Settings.Default.PayPal_IsCorrectPayflowMappingEnabled;

	public static bool PayPalInternationalEnabled => Roblox.PayPal.Common.Properties.Settings.Default.PayPalInternationalEnabled;

	public static event Action<string, int, string> PaypalResponseReceived;

	public static int GetThrottleWaitTime()
	{
		int waitTime = 0;
		if (ThrottleEnabled && UseTestMode)
		{
			try
			{
				lock (_ThrottleLock)
				{
					long timeRightNow = DateTime.Now.Ticks;
					if (timeRightNow > _NextTransactionMinTime)
					{
						_NextTransactionMinTime = timeRightNow + ThrottleIntervalInTicks;
					}
					else
					{
						waitTime = Convert.ToInt32((_NextTransactionMinTime - timeRightNow) / 10000);
						_NextTransactionMinTime += ThrottleIntervalInTicks;
					}
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		return waitTime;
	}

	public static void WaitForThrottle()
	{
		if (ThrottleEnabled && UseTestMode)
		{
			int waitTime = GetThrottleWaitTime();
			if (waitTime > ThrottleMaxWaitBeforeException)
			{
				throw new Exception("Sorry, there are currently too many requests to PayPal pending.  Please wait 10 minutes and try again.", new Exception("PayPal throttle: MaxWaitInMsBeforeException exceeded.  Current wait: " + waitTime + ", Max wait: " + ThrottleMaxWaitBeforeException));
			}
			if (waitTime > 0)
			{
				Thread.Sleep(waitTime);
			}
		}
	}

	public static bool UseNewRenewal(long? accountID)
	{
		if (NewPaypalRenewalModulus == 0)
		{
			return false;
		}
		if (accountID.HasValue && accountID.Value % NewPaypalRenewalModulus == 0L)
		{
			return true;
		}
		return false;
	}

	private static ICollection<RecurringBillingAttempt> ConstructRecurringBillingAttempts(Hashtable inquiryParams)
	{
		if (!IsCorrectPayflowMappingEnabled)
		{
			return ConstructRecurringBillingAttemptsV1(inquiryParams);
		}
		return ConstructRecurringBillingAttemptsV2(inquiryParams);
	}

	private static ICollection<RecurringBillingAttempt> ConstructRecurringBillingAttemptsV2(Hashtable inquiryParams)
	{
		ICollection<RecurringBillingAttempt> recurringBillingAttempts = new List<RecurringBillingAttempt>();
		foreach (string inquiryParam in inquiryParams.Keys)
		{
			if (inquiryParam.StartsWith("P_PNREF"))
			{
				string index = inquiryParam.Replace("P_PNREF", "");
				string tender = $"P_TENDER{index}";
				string amount = $"P_AMT{index}";
				string transtate = $"P_TRANSTATE{index}";
				string pnref = $"P_PNREF{index}";
				string transtime = $"P_TRANSTIME{index}";
				string result = $"P_RESULT{index}";
				recurringBillingAttempts.Add(new RecurringBillingAttempt((string)inquiryParams[tender], (string)inquiryParams[amount], (string)inquiryParams[transtate], (string)inquiryParams[pnref], (string)inquiryParams[transtime], (string)inquiryParams[result]));
			}
		}
		return recurringBillingAttempts;
	}

	private static ICollection<RecurringBillingAttempt> ConstructRecurringBillingAttemptsV1(Hashtable inquiryParams)
	{
		int recordCount = 1;
		ICollection<RecurringBillingAttempt> recurringBillingAttempts = new List<RecurringBillingAttempt>();
		while (true)
		{
			string count = recordCount.ToString();
			string tender = $"P_TENDER{count}";
			string amount = $"P_AMT{count}";
			string transtate = $"P_TRANSTATE{count}";
			string pnref = $"P_PNREF{count}";
			string transtime = $"P_TRANSTIME{count}";
			string result = $"P_RESULT{count}";
			if (inquiryParams[tender] == null && inquiryParams[amount] == null && inquiryParams[transtate] == null && inquiryParams[pnref] == null && inquiryParams[transtime] == null && inquiryParams[result] == null)
			{
				break;
			}
			RecurringBillingAttempt billingAttempt = new RecurringBillingAttempt((string)inquiryParams[tender], (string)inquiryParams[amount], (string)inquiryParams[transtate], (string)inquiryParams[pnref], (string)inquiryParams[transtime], (string)inquiryParams[result]);
			recurringBillingAttempts.Add(billingAttempt);
			recordCount++;
		}
		return recurringBillingAttempts;
	}

	public static void CancelPreviousRecurringPaymentOnUpgrade(Sale sale)
	{
		List<Sale> recurringBcSalesNotIncludingCurrent = (from x in Sale.GetRecurringSalesForAccount(sale.PurchaserAccountID.Value, ProductGroup.BC.ID)
			where x.ID != sale.ID
			select x).ToList();
		if (recurringBcSalesNotIncludingCurrent.Any())
		{
			Sale sale2 = recurringBcSalesNotIncludingCurrent.First();
			CancelRenewals(sale2);
			CancellationAuditLog.CreateNew(sale2.ID, "upgrade");
		}
	}

	public static Cancellation CancelRenewals(Sale sale)
	{
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID)?.FirstOrDefault();
		if (mostRecentPayment == null)
		{
			throw new Exception($"No Payments associated with SaleID: {sale.ID}");
		}
		TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(mostRecentPayment.ID);
		if (associatedTransactionLog == null)
		{
			throw new Exception($"No Transaction Log associated with PaymentID: {mostRecentPayment.ID}");
		}
		Cancellation cancellation = Cancellation.CreateNew(sale.ID, associatedTransactionLog.AccountID);
		if (cancellation != null)
		{
			sale.RenewalDate = null;
			sale.SaleStatusTypeID = SaleStatusType.Cancelled.ID;
			sale.Save();
		}
		return cancellation;
	}

	public static ICollection<RecurringBillingAttempt> GetRecurringBillingAttempts(Sale sale, AuditLogDelegates.SaleAuditLogFunc saleAuditLogFunc, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (sale == null)
		{
			throw new ApplicationException("Required value not specified: Order.");
		}
		if (saleAuditLogFunc == null)
		{
			throw new ArgumentNullException("saleAuditLogFunc");
		}
		saleAuditLogFunc(sale.ID, 1, "Getting recurring billing attempts for sale.");
		Payment obj = Payment.GetPaymentsBySale(sale.ID)?.FirstOrDefault();
		if (obj == null)
		{
			saleAuditLogFunc(sale.ID, 3, "Failed to find payment record for sale.");
			throw new ApplicationException($"Could not retrieve a payment record for Sale ID {sale.ID}");
		}
		TransactionLog byPaymentID = TransactionLog.GetByPaymentID(obj.ID);
		saleAuditLogFunc(sale.ID, 1, "Recurring billing attempts for PayPal account ID - Started.");
		ICollection<RecurringBillingAttempt> recurringBillingAttempts = GetRecurringBillingAttempts(byPaymentID.AccountID, ephemeralCounterFactory);
		saleAuditLogFunc(sale.ID, 1, "Recurring billing attempts for PayPal account ID - Ended.");
		return recurringBillingAttempts;
	}

	public static ICollection<RecurringBillingAttempt> GetRecurringBillingAttempts(string accountId, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		Response payPalResponse = GetPaypalInfo(accountId, ephemeralCounterFactory, getPaymentHistory: true);
		PayPalHelper.PaypalResponseReceived?.Invoke(accountId, payPalResponse.TransactionResponse.Result, payPalResponse.ResponseString);
		TransactionResponse transactionResponse = payPalResponse.TransactionResponse;
		if (transactionResponse == null || transactionResponse.Result != 0)
		{
			if (Roblox.Billing.Properties.Settings.Default.HandlePaypalRecurringErrorCodeEnabled && transactionResponse != null && transactionResponse.Result == 12)
			{
				throw new PaypalRecurringPaymentException($"PayflowPro Error: Attempt to perform Inquiry for AccountID: {accountId} failed because recurring account info saved is invalid.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}.");
			}
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalGetRecurringInfoError");
			throw new ApplicationException($"PayflowPro Error: Attempt to perform Inquiry for AccountID: {accountId} failed.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}.");
		}
		IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalGetRecurringInfoSuccess");
		RecurringResponse recurringResponse = payPalResponse.RecurringResponse;
		ICollection<RecurringBillingAttempt> recurringBillingAttempts = new List<RecurringBillingAttempt>();
		if (recurringResponse != null && recurringResponse.InquiryParams.Count >= 6)
		{
			recurringBillingAttempts = ConstructRecurringBillingAttempts(recurringResponse.InquiryParams);
		}
		return recurringBillingAttempts;
	}

	public static SubscriptionPaymentStatus GetSubscriptionPaymentStatus(Sale sale, AuditLogDelegates.SaleAuditLogFunc saleAuditLogFunc, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (saleAuditLogFunc == null)
		{
			throw new ArgumentNullException("saleAuditLogFunc");
		}
		if (sale == null)
		{
			throw new ApplicationException("Required value not specified: Sale.");
		}
		saleAuditLogFunc(sale.ID, 1, "Getting subscription payment status.");
		DateTime? renewalDate = sale.RenewalDate;
		if (renewalDate.HasValue && DateTime.Now > renewalDate.Value.Add(DarkOrdersWindow))
		{
			saleAuditLogFunc(sale.ID, 1, "Subscription status is delinquent.");
			return SubscriptionPaymentStatus.Delinquent;
		}
		ICollection<RecurringBillingAttempt> recurringBillingAttempts = GetRecurringBillingAttempts(sale, saleAuditLogFunc, ephemeralCounterFactory);
		saleAuditLogFunc(sale.ID, 1, $"Received {recurringBillingAttempts.Count} recurring billing attempts.");
		long renewalPeriodInMonths = 0L;
		if (sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			renewalPeriodInMonths = 1L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			renewalPeriodInMonths = 3L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			renewalPeriodInMonths = 6L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			renewalPeriodInMonths = 12L;
		}
		long windowInTicks = 25920000000000L * renewalPeriodInMonths / 2;
		foreach (RecurringBillingAttempt billingAttempt in recurringBillingAttempts)
		{
			DateTime billingAttemptTransactionTime = Convert.ToDateTime(billingAttempt.TransactionTime);
			if (sale.RenewalDate > billingAttemptTransactionTime.AddTicks(-1 * windowInTicks))
			{
				DateTime? renewalDate2 = sale.RenewalDate;
				DateTime dateTime = billingAttemptTransactionTime.AddTicks(windowInTicks);
				if (renewalDate2.HasValue && renewalDate2.GetValueOrDefault() < dateTime && Convert.ToInt32(billingAttempt.Result) == 0 && (Convert.ToInt32(billingAttempt.TransactionState) == 8 || Convert.ToInt32(billingAttempt.TransactionState) == 108))
				{
					saleAuditLogFunc(sale.ID, 1, "Subscription status is current.");
					return SubscriptionPaymentStatus.Current;
				}
			}
		}
		saleAuditLogFunc(sale.ID, 1, "Subscription status is pending.");
		return SubscriptionPaymentStatus.Pending;
	}

	public static void ProcessRenewal(Sale sale, Payment payment, TransactionLog log, AuditLogDelegates.SaleAuditLogFunc saleAuditLogFunc, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (saleAuditLogFunc == null)
		{
			throw new ArgumentNullException("saleAuditLogFunc");
		}
		saleAuditLogFunc(sale.ID, 1, "Calculating sale's new renewal date.");
		if (sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(1);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(3);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(6);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(12);
		}
		string transactionId = null;
		if (UseNewRenewal(log.UserAccountID))
		{
			Response nextPaymentFromPaypal = GetNextPaymentFromPaypal(sale, saleAuditLogFunc, ephemeralCounterFactory);
			RecurringResponse paypalRecurringResponse = nextPaymentFromPaypal.RecurringResponse;
			DateTime paypalNextRenewalDate = DateTime.Now;
			if (paypalRecurringResponse.NextPayment != null)
			{
				paypalNextRenewalDate = DateTime.Parse(paypalRecurringResponse.NextPayment.Insert(2, "/").Insert(5, "/"));
			}
			else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
			{
				paypalNextRenewalDate = DateTime.Now.AddMonths(1);
			}
			else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
			{
				paypalNextRenewalDate = DateTime.Now.AddMonths(3);
			}
			else if (sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
			{
				paypalNextRenewalDate = DateTime.Now.AddMonths(6);
			}
			else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
			{
				paypalNextRenewalDate = DateTime.Now.AddMonths(12);
			}
			if (sale.RenewalDate.Value.Subtract(paypalNextRenewalDate).Duration() < Roblox.Billing.Properties.Settings.Default.NewPaypalSanityOffsetLimit)
			{
				sale.RenewalDate = paypalNextRenewalDate;
			}
			transactionId = nextPaymentFromPaypal.TransactionResponse.Pnref;
		}
		sale.Save();
		saleAuditLogFunc(sale.ID, 1, "Saved changes to sale's renewal date.");
		SaleProduct recurringItem = sale.Products.First((SaleProduct x) => x.RecurringPrice.HasValue);
		saleAuditLogFunc(sale.ID, 1, $"Adding new task to SaleProductPremiumFeatureQueue for SaleProduct with product ID '{recurringItem.ProductID}'.");
		SaleProductPremiumFeatureQueue.CreateNew(recurringItem);
		saleAuditLogFunc(sale.ID, 1, "Successfully added task to SaleProductPremiumFeatureQueue.");
		byte paymentProviderTypeId = ((sale.Payments == null || sale.Payments.Count <= 0) ? PaymentProviderType.CreditCard.ID : sale.Payments[0].PaymentProviderTypeID);
		saleAuditLogFunc(sale.ID, 1, "Creating new payment record.");
		Payment newPayment = Payment.CreateNew(sale.ID, paymentProviderTypeId, PaymentStatusType.Complete.ID, DateTime.Now, sale.RecurringPrice.Value, sale.CurrencyTypeID);
		saleAuditLogFunc(sale.ID, 1, "Creating new transaction log record.");
		TransactionLog transactionLog = new TransactionLog();
		transactionLog.PaymentID = newPayment.ID;
		transactionLog.SaleID = log.SaleID;
		transactionLog.TransactionType = "recurring";
		transactionLog.UserAccountID = log.UserAccountID;
		transactionLog.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
		transactionLog.Amount = sale.RecurringPrice;
		transactionLog.AccountID = log.AccountID;
		transactionLog.Number = log.Number;
		transactionLog.Month = log.Month;
		transactionLog.Year = log.Year;
		transactionLog.FirstName = log.FirstName;
		transactionLog.LastName = log.LastName;
		transactionLog.Address = log.Address;
		transactionLog.City = log.City;
		transactionLog.StateProvince = log.StateProvince;
		transactionLog.ZipPostal = log.ZipPostal;
		transactionLog.TransactionDate = DateTime.Now;
		transactionLog.TransactionID = transactionId;
		transactionLog.Save();
		saleAuditLogFunc(sale.ID, 1, "Publishing renewal event to SNS.");
		RenewalProviderBase.PublishRenewalEvent(sale);
		saleAuditLogFunc(sale.ID, 1, "Ending ProcessRenewal flow.");
	}

	public static void RenewOrder(int saleId, AuditLogDelegates.SaleAuditLogFunc saleAuditLogFunc, IEphemeralCounterFactory ephemeralCounterFactory, IEmailSender emailSender)
	{
		IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Attempt");
		if (saleAuditLogFunc == null)
		{
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Error");
			throw new ArgumentNullException("saleAuditLogFunc");
		}
		Sale sale = Sale.Get(saleId);
		if (sale == null)
		{
			saleAuditLogFunc(saleId, 3, "Failed to find sale from sale ID.");
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Error");
			return;
		}
		try
		{
			SubscriptionPaymentStatus subscriptionPaymentStatus = GetSubscriptionPaymentStatus(sale, saleAuditLogFunc, ephemeralCounterFactory);
			saleAuditLogFunc(sale.ID, 1, $"Handling {subscriptionPaymentStatus} subscription status.");
			switch (subscriptionPaymentStatus)
			{
			case SubscriptionPaymentStatus.Current:
			{
				Payment mostRecentPayment2 = Payment.GetPaymentsBySale(saleId).FirstOrDefault();
				if (mostRecentPayment2 == null)
				{
					saleAuditLogFunc(sale.ID, 3, "Failed to find payment for recurring sale.");
					throw new Exception($"No Payments associated with SaleID: {saleId}");
				}
				TransactionLog associatedTransactionLog2 = TransactionLog.GetByPaymentID(mostRecentPayment2.ID);
				if (associatedTransactionLog2 == null)
				{
					saleAuditLogFunc(sale.ID, 3, "Failed to find transaction log entry for sale's most recent payment.");
					throw new Exception($"No TransactionLog associated with PaymentID: {mostRecentPayment2.ID}");
				}
				ProcessRenewal(sale, mostRecentPayment2, associatedTransactionLog2, saleAuditLogFunc, ephemeralCounterFactory);
				IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Success");
				break;
			}
			case SubscriptionPaymentStatus.Delinquent:
				saleAuditLogFunc(sale.ID, 2, "Cancelling sale due to delinquent payment status.");
				IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Failure");
				CancelRenewals(sale);
				CancellationAuditLog.CreateNew(sale.ID, "paypal");
				break;
			}
		}
		catch (PaypalRecurringPaymentException)
		{
			saleAuditLogFunc(sale.ID, 2, "Cancelling sale due to PayPalRecurringPaymentException.");
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Failure");
			CancelRenewals(sale);
			CancellationAuditLog.CreateNew(sale.ID, "paypal");
			string membershipTitle = (PremiumFeatureHelper.IsAnyBuildersClubMember(sale.PurchaserAccountID.Value) ? "Builders Club" : "Premium");
			string emailBody = string.Format(EmailBody, membershipTitle);
			Payment mostRecentPayment = Payment.GetPaymentsBySale(saleId).FirstOrDefault();
			if (mostRecentPayment != null)
			{
				TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(mostRecentPayment.ID);
				Email email = new Email("no-reply@roblox.com", associatedTransactionLog.Email, $"Roblox - {membershipTitle} Membership Cancelled", EmailBodyType.Plain, string.Format("{0}MembershipCancellation", membershipTitle.Replace(" ", string.Empty)), emailBody);
				emailSender.SendEmail(email);
			}
		}
		catch (Exception)
		{
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalRenewal_Error");
			throw;
		}
	}

	public static Response GetNextPaymentFromPaypal(Sale sale, AuditLogDelegates.SaleAuditLogFunc saleAuditLogFunc, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (saleAuditLogFunc == null)
		{
			throw new ArgumentNullException("saleAuditLogFunc");
		}
		string paypalAccountId = GetPaypalAccountID(sale);
		saleAuditLogFunc(sale.ID, 1, "Getting PayPal info.");
		Response payPalResponse;
		try
		{
			payPalResponse = GetPaypalInfo(paypalAccountId, ephemeralCounterFactory);
		}
		catch (Exception e)
		{
			saleAuditLogFunc(sale.ID, 3, $"Exception thrown by GetPaypalInfo - {e}");
			throw;
		}
		if (payPalResponse == null)
		{
			saleAuditLogFunc(sale.ID, 3, "Failed to get response from PayPal.");
			throw new Exception("No response from Paypal on sale: " + sale.ID);
		}
		TransactionResponse transactionResponse = payPalResponse.TransactionResponse;
		if (transactionResponse == null)
		{
			saleAuditLogFunc(sale.ID, 3, "Obtained PayPal response, but transaction response is null.");
			throw new Exception("Error getting transactionResponse from Paypal on SaleID: " + sale.ID + " Transaction response is null.");
		}
		if (transactionResponse.Result != 0)
		{
			if (Roblox.Billing.Properties.Settings.Default.HandlePaypalRecurringErrorCodeEnabled && transactionResponse.Result == 12)
			{
				saleAuditLogFunc(sale.ID, 2, "PayPal indicates registered credit card has expired.");
				throw new PaypalRecurringPaymentException("Registered credit card with Paypal is expired. Transaction can not be completed for SaleID: " + sale.ID + " " + transactionResponse.RespMsg);
			}
			saleAuditLogFunc(sale.ID, 2, $"Obtained non-zero response code from PayPal: {transactionResponse.Result}");
			throw new Exception("Error getting transactionResponse from Paypal on SaleID: " + sale.ID + " " + transactionResponse.RespMsg);
		}
		return payPalResponse;
	}

	public static string GetPaypalAccountID(Sale sale)
	{
		if (sale == null)
		{
			throw new Exception("Required value not specified: Order.");
		}
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).First();
		if (mostRecentPayment == null)
		{
			throw new Exception($"Could not retrieve a payment record for Sale ID {sale.ID}");
		}
		TransactionLog obj = TransactionLog.GetByPaymentID(mostRecentPayment.ID) ?? throw new Exception($"No transaction log for payment {mostRecentPayment.ID} on sale {sale.ID}.");
		if (obj.AccountID.Trim().Length == 0)
		{
			throw new Exception("Required value not specified: AccountID");
		}
		return obj.AccountID.Trim();
	}

	public static Response GetPaypalInfo(string paypalAccountId, IEphemeralCounterFactory ephemeralCounterFactory, bool getPaymentHistory = false)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0085: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (paypalAccountId.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: AccountID");
		}
		PayflowConnectionData payflowConnectionData = (Roblox.Billing.Properties.Settings.Default.UseConfigurablePayPalConnectionValues ? new PayflowConnectionData(Connection, PayPalDefaultHostPort, PayPalDefaultTimeOutSeconds) : new PayflowConnectionData(Connection));
		UserInfo val = new UserInfo(CredentialsUser, CredentialsVendor, CredentialsPartner, CredentialsPassword);
		RecurringInfo recurringInfo = new RecurringInfo
		{
			OrigProfileId = paypalAccountId
		};
		if (getPaymentHistory)
		{
			recurringInfo.PaymentHistory = "Y";
		}
		RecurringInquiryTransaction val2 = new RecurringInquiryTransaction(val, payflowConnectionData, recurringInfo, PayflowUtility.RequestId);
		Stopwatch stopWatch = new Stopwatch();
		stopWatch.Start();
		Response obj = ((BaseTransaction)val2).SubmitTransaction();
		stopWatch.Stop();
		IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalGetRecurringInfoResponseDuration", (int)stopWatch.ElapsedMilliseconds);
		if (obj == null)
		{
			IncrementEphemeralCounter(ephemeralCounterFactory, "PayPalGetRecurringInfoError");
			throw new Exception($"Attempt to perform Inquiry failed for AccountID: {paypalAccountId}.  Unable to obtain response from PayPal.");
		}
		return obj;
	}

	public static string GetCurrencyCode(byte? currencyTypeID = null)
	{
		string currencyCode = "USD";
		if (PayPalInternationalEnabled && currencyTypeID.HasValue)
		{
			CurrencyType currencyType = CurrencyType.Get(currencyTypeID.Value);
			if (currencyType != null)
			{
				currencyCode = currencyType.Code;
			}
		}
		return currencyCode;
	}

	public static string GetInvoiceDescriptionByCurrencyCode(string currencyCode)
	{
		if (!(currencyCode == "CAD"))
		{
			if (currencyCode == "USD")
			{
				return "US $";
			}
			return currencyCode + " ";
		}
		return "CAD $";
	}

	private static void IncrementEphemeralCounter(IEphemeralCounterFactory ephemeralCounterFactory, string counterName, int amount = 1)
	{
		ephemeralCounterFactory.GetCounter(counterName).IncrementInBackground(amount);
	}
}
