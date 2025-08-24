using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.BillingTransactionEventPublisher;
using Roblox.EventLog;
using Roblox.LiveGamer;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Users;

namespace Roblox.Platform.Billing;

public static class MembershipExtensions
{
	public static bool UseTestMode => Roblox.Billing.Properties.Settings.Default.UseTestMode;

	private static bool LimitCcPurchaseByIp => Roblox.Platform.Billing.Properties.Settings.Default.LimitCCPurchaseByIP;

	public static void ClearShoppingCart(this IUser user)
	{
		ShoppingCart.RetrieveCart(Convert.ToInt32(user.AccountId)).RemoveAll();
	}

	public static CountryCurrency GetCountryCurrency(this IUser user)
	{
		return CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, Roblox.Billing.Business_Logic_Layer.CurrencyType.GetUSDCurrencyTypeID);
	}

	public static LiveGamerTransactionResult ProcessLiveGamerTransaction(this IUser user, LiveGamerTransactionInfo transactionInfo)
	{
		return LiveGamerProviderFactory.GetLiveGamerProvider(user).Finalize(transactionInfo);
	}

	public static ITransactionResult BuyWithCreditCard(this IUser user, BillingDomainFactories billingDomainFactories, ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, ILogger logger, AuditLogDelegates.CheckoutSessionAuditLogFunc checkoutSessionAuditLogFunc, CancelExistingActiveMembershipSaleHandler cancelExistingRecurringMembershipSale, long? checkoutSessionId, CreditCardProviderFactory creditCardProviderFactory, IEmailSender emailSender, byte platformTypeId, string sessionId = null)
	{
		if (checkoutSessionAuditLogFunc == null)
		{
			throw new PlatformArgumentNullException("checkoutSessionAuditLogFunc");
		}
		if (creditCardProviderFactory == null)
		{
			throw new PlatformArgumentNullException("creditCardProviderFactory");
		}
		if (emailSender == null)
		{
			throw new PlatformArgumentNullException("emailSender");
		}
		List<int> productIds = lineItems.Select((LineItem p) => p.ProductPrice.GetProduct().ID).ToList();
		checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Starting double purchase detection.");
		if (!creditCardTransactionInfo.DoublePurchaseConfirmed && user.HasPurchasedWithinTimeSpan(productIds, Roblox.Platform.Billing.Properties.Settings.Default.DoublePurchaseVerificationTimeSpan))
		{
			throw new DoublePurchaseException();
		}
		checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Starting purchase lock detection.");
		checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Starting purchase limit detection.");
		decimal totalPurchaseAmount = lineItems.GetTotalActualPrice();
		try
		{
			user.CheckPurchaseLimits(creditCardTransactionInfo.CreditCardPaymentInfo.ClientIP, creditCardTransactionInfo.CreditCardPaymentInfo.Email, totalPurchaseAmount);
		}
		catch (BlockedPurchaseException ex3)
		{
			user.LogFailedTransaction(creditCardTransactionInfo, lineItems, PaymentStatusChangeReasonType.Get(ex3.PaymentStatusChangeReasonTypeID), PaymentStatusChangeReasonType.Get(ex3.PaymentStatusChangeReasonTypeID).Value);
			throw;
		}
		if (user != null)
		{
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Starting fraud detection for user.");
			string maskedCreditCardNumber = CreditCardPaymentProvider.MaskCreditCardNumber(creditCardTransactionInfo.CreditCardPaymentInfo.AccountNumber);
			RobloxFraudDetectorResult fraudCheckResult = (RobloxFraudDetectorResult)FraudDetectorFactory.GetFraudDetector().IsTransactionFraudulent(user, totalPurchaseAmount, maskedCreditCardNumber, creditCardTransactionInfo.CreditCardPaymentInfo.Email, creditCardTransactionInfo.CreditCardPaymentInfo.AddressLine1, creditCardTransactionInfo.CreditCardPaymentInfo.City, creditCardTransactionInfo.CreditCardPaymentInfo.PostalCode, creditCardTransactionInfo.CreditCardPaymentInfo.Country, PaymentType.CreditCard);
			if (fraudCheckResult.IsFraudulent)
			{
				FraudDetectedException ex2 = new FraudDetectedException($"Blocked by fraud detector: {Enum.GetName(typeof(FraudDetectorResultType), fraudCheckResult.FraudDetectorResultType)}");
				user.LogFailedTransaction(creditCardTransactionInfo, lineItems, PaymentStatusChangeReasonType.Get(PaymentStatusChangeReasonType.DeclinedByFraudDetector.ID), ex2.Message);
				throw ex2;
			}
		}
		ICreditCardProvider creditCardProvider = ((user != null) ? creditCardProviderFactory.GetCreditCardProvider(billingDomainFactories, user) : creditCardProviderFactory.GetCreditCardProvider(billingDomainFactories, creditCardTransactionInfo.BrowserTrackerId));
		ITransactionResult creditCardTransactionResult;
		try
		{
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Starting legacy credit card provider processing.");
			creditCardTransactionResult = creditCardProvider.Process(lineItems, creditCardTransactionInfo, fraudDetectionAction, logger, cancelExistingRecurringMembershipSale, checkoutSessionId, platformTypeId, sessionId);
		}
		catch (BlockedPurchaseException ex)
		{
			user.LogFailedTransaction(creditCardTransactionInfo, lineItems, PaymentStatusChangeReasonType.Get(ex.PaymentStatusChangeReasonTypeID), PaymentStatusChangeReasonType.Get(ex.PaymentStatusChangeReasonTypeID).Value);
			throw;
		}
		if (creditCardTransactionResult.IsSuccess)
		{
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Successful credit card transaction result detected.");
			if (LimitCcPurchaseByIp && creditCardTransactionResult.Sale != null)
			{
				IPAddress ipAddressEntity = IPAddress.GetOrCreate(creditCardTransactionInfo.CreditCardPaymentInfo.ClientIP);
				SaleIPAddress saleIPAddress = new SaleIPAddress();
				saleIPAddress.IPAddressID = ipAddressEntity.ID;
				saleIPAddress.SaleID = creditCardTransactionResult.Sale.Id;
				saleIPAddress.Save();
			}
			if (lineItems.IsGiftCardPurchase() && creditCardTransactionResult.Sale != null)
			{
				SaleProduct saleProduct = SaleProduct.GetSaleProductsBySaleID(creditCardTransactionResult.Sale.Id).FirstOrDefault((SaleProduct sp) => GiftCard.IsGiftCardProduct(sp.Product));
				if (saleProduct != null)
				{
					GiftCard bySaleProductID = GiftCard.GetBySaleProductID(saleProduct.ID);
					bySaleProductID.PurchaserEmail = creditCardTransactionInfo.CreditCardPaymentInfo.Email;
					bySaleProductID.Save();
				}
			}
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Sending email receipt.");
			ReceiptEmail receiptEmail = new ReceiptEmail(lineItems, creditCardTransactionInfo, creditCardTransactionResult, user);
			emailSender.SendEmail(receiptEmail.GenerateMimeEmail());
			if (creditCardTransactionResult.Sale != null)
			{
				checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Publishing billing transaction event.");
				Roblox.Billing.Sale sale = Roblox.Billing.Sale.Get(creditCardTransactionResult.Sale.Id);
				User purchaserUser = (sale.PurchaserAccountID.HasValue ? User.GetByAccountID(sale.PurchaserAccountID.Value) : null);
				Roblox.BillingTransactionEventPublisher.BillingTransactionEventPublisher.PublishStatically(new BillingTransactionMessage
				{
					Amount = sale.DiscountedPriceTotal,
					CurrencyTypeID = (sale.CurrencyTypeID ?? 0),
					PaymentDate = sale.Payments.First().PaymentDate,
					PaymentID = sale.Payments.First().ID,
					PaymentProviderTypeID = Roblox.Billing.PaymentProviderType.CreditCard.ID,
					ProductIDs = sale.Products.Select((SaleProduct p) => p.ProductID).ToList(),
					PurchaserUserID = Convert.ToInt32(purchaserUser?.ID ?? 0),
					TransactionType = BillingTransactionType.NewPurchase
				});
				checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Successfully published billing transaction event.");
			}
		}
		else
		{
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Handling failed transaction.");
			user.HandleFailedTransaction(creditCardTransactionInfo.CreditCardPaymentInfo.ClientIP);
			checkoutSessionAuditLogFunc(checkoutSessionId, 1, "Successfully handled failed transaction.");
		}
		return creditCardTransactionResult;
	}

	public static bool HasPurchasedWithinTimeSpan(this IUser user, IEnumerable<int> productIds, TimeSpan timeSpan)
	{
		if (user == null)
		{
			return false;
		}
		DateTime threshold = DateTime.Now.Subtract(timeSpan);
		return (from x in Roblox.Billing.Sale.GetSalesByPurchaser(Convert.ToInt32(user.AccountId))
			where x.Updated >= threshold && (x.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Complete.ID || x.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Pending.ID || x.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Recurring.ID)
			select x).Any((Roblox.Billing.Sale s) => s.Products.Any((SaleProduct y) => productIds.Contains(y.ProductID)));
	}

	/// <summary>
	/// Determines whether or not a given user has made a purchase in the last <paramref name="days" /> number of days.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to check.</param>
	/// <param name="days">The number of days in the past to evaluate.</param>
	/// <returns>True if <paramref name="user" /> has made a purchase, false otherwise.</returns>
	public static bool HasPaidInLastNDays(this IUser user, uint days)
	{
		if (user == null)
		{
			return false;
		}
		DateTime threshold = DateTime.Now.AddDays(0L - (long)days);
		return (from x in Roblox.Billing.Sale.GetSalesByPurchaser(Convert.ToInt32(user.AccountId))
			where x.Updated >= threshold && (x.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Complete.ID || x.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Recurring.ID)
			select x).Any();
	}

	public static bool IsPaidUser(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		ICollection<Roblox.Billing.Sale> salesByPurchaserAndStatus_Paged = Roblox.Billing.Sale.GetSalesByPurchaserAndStatus_Paged(Convert.ToInt32(user.AccountId), Roblox.Billing.SaleStatusType.Complete.ID, 0, 1);
		ICollection<Roblox.Billing.Sale> recurringSales = Roblox.Billing.Sale.GetSalesByPurchaserAndStatus_Paged(Convert.ToInt32(user.AccountId), Roblox.Billing.SaleStatusType.Recurring.ID, 0, 1);
		if (salesByPurchaserAndStatus_Paged.Count <= 0)
		{
			return recurringSales.Count > 0;
		}
		return true;
	}

	private static void LogFailedTransaction(this IUser user, CreditCardTransactionInfo creditCardTransactionInfo, ICollection<LineItem> listItems, PaymentStatusChangeReasonType paymentStatusChangeReasonType, string message)
	{
		int? accountId = null;
		if (user != null)
		{
			accountId = Convert.ToInt32(user.AccountId);
		}
		decimal totalActualPrice = listItems.GetTotalActualPrice();
		byte currencyTypeId = creditCardTransactionInfo.CurrencyType.Translate().ID;
		Roblox.Billing.Sale sale = Roblox.Billing.Sale.CreateNew(Roblox.Billing.SaleStatusType.Blocked.ID, accountId, listItems.GetTotalListPrice(), totalActualPrice, null, null, creditCardTransactionInfo.PlatformTypeId, currencyTypeId);
		Payment payment = Payment.CreateNew(sale.ID, Roblox.Billing.PaymentProviderType.CreditCard.ID, Roblox.Billing.PaymentStatusType.Blocked.ID, DateTime.Now, totalActualPrice, currencyTypeId);
		PaymentStatusChangeReason.CreateNew(PaymentStatusChange.CreateNew(payment.ID, null, Roblox.Billing.PaymentStatusType.Blocked.ID).ID, accountId, paymentStatusChangeReasonType.ID, string.Empty);
		user.LogBlockedTransaction(creditCardTransactionInfo.CreditCardPaymentInfo, payment, sale, message);
	}

	private static void LogBlockedTransaction(this IUser user, CreditCardPaymentInfo paymentInfo, Payment payment, Roblox.Billing.Sale sale, string message)
	{
		TransactionLog transactionLog = new TransactionLog();
		transactionLog.PaymentID = payment.ID;
		transactionLog.UserAccountID = sale.PurchaserAccountID;
		transactionLog.TransactionID = null;
		transactionLog.TransactionType = (sale.RecurringPrice.HasValue ? "recurring" : "sale");
		transactionLog.AuthCode = null;
		transactionLog.AvsCode = null;
		transactionLog.SaleID = sale.ID;
		transactionLog.Number = CreditCardPaymentProvider.MaskCreditCardNumber(paymentInfo.AccountNumber);
		transactionLog.Amount = payment.Amount;
		transactionLog.Year = int.Parse(paymentInfo.ExpirationYear);
		transactionLog.Month = int.Parse(paymentInfo.ExpirationMonth);
		transactionLog.Address = paymentInfo.AddressLine1;
		transactionLog.Address2 = paymentInfo.AddressLine2;
		transactionLog.City = paymentInfo.City;
		transactionLog.Country = paymentInfo.Country;
		transactionLog.Email = paymentInfo.Email;
		transactionLog.FirstName = paymentInfo.FirstName;
		transactionLog.LastName = paymentInfo.LastName;
		transactionLog.Phone = paymentInfo.Phone;
		transactionLog.StateProvince = paymentInfo.State;
		transactionLog.ZipPostal = paymentInfo.PostalCode;
		transactionLog.ClientIP = paymentInfo.ClientIP;
		transactionLog.TransactionDate = DateTime.Now;
		transactionLog.PaymentStatusTypeID = payment.PaymentStatusTypeID;
		transactionLog.ErrorMessage = message;
		transactionLog.Code = null;
		transactionLog.Description = message;
		transactionLog.AccountID = ((user != null) ? user.Name : "");
		transactionLog.Save();
	}

	private static void HandleFailedTransaction(this IUser user, string ipAddress)
	{
		((user != null) ? FloodCheckers.GetDeclinedCardByUserFloodChecker(user.Id) : FloodCheckers.GetDeclinedCardByIPFloodChecker(ipAddress)).UpdateCount();
	}
}
