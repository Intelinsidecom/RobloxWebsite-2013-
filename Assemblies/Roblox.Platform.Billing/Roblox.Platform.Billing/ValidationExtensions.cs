using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Properties;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public static class ValidationExtensions
{
	private const string OverLimitUnverifiedMessage = "You must verify your email address before you can complete this transaction. Please visit the <a target='_blank' href='/My/Account.aspx?confirmemail=1'>Account</a> page to verify your email.";

	private const string OverPurchaseLimitMessage = "Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.";

	private const string DeclinedCardMessage = "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by email at info@roblox.com.";

	private const string TooManyAttemptsMessage = "You have made too many purchase attempts. Please try again later.";

	private const string CodeDailyPerAccount = "ACO";

	private const string CodeDailyPerCreditCard = "DCC";

	private const string CodeMonthlyPerAccount = "MAO";

	private const string CodeMonthlyPerCreditCard = "MCC";

	private const string CodeMonthlyPerBilling = "POM";

	private const string CodeByIpAddress = "IAL";

	private const string CodeNewAccounts = "NAO";

	private const string CodeNewUnverifiedAccounts = "UNA";

	public static bool UseTestMode => Roblox.Billing.Properties.Settings.Default.UseTestMode;

	private static byte NewAccountPeriodInDays => Roblox.Platform.Billing.Properties.Settings.Default.NewAccountPeriodInDays;

	private static int DailyCreditCardTransactionCountLimit => Roblox.Platform.Billing.Properties.Settings.Default.CreditCardTransactionCountLimit_Daily;

	private static decimal DailyCreditCardChargeLimit => Roblox.Platform.Billing.Properties.Settings.Default.CreditCardChargeLimit_Daily;

	private static decimal DailyUserChargeLimit => Roblox.Platform.Billing.Properties.Settings.Default.UserChargeLimit_Daily;

	private static decimal NewAccountPurchaseLimit => Roblox.Platform.Billing.Properties.Settings.Default.NewAccountPurchaseLimit;

	private static decimal MonthlyCreditCardChargeLimit => Roblox.Platform.Billing.Properties.Settings.Default.CreditCardChargeLimit_Monthly;

	private static decimal MonthlyUserChargeLimit => Roblox.Platform.Billing.Properties.Settings.Default.UserChargeLimit_Monthly;

	private static decimal DailyPurchaseLimitIp => Roblox.Platform.Billing.Properties.Settings.Default.DailyPurchaseLimitVolumePerIP;

	private static decimal MonthlyPurchaseLimitIp => Roblox.Platform.Billing.Properties.Settings.Default.MonthlyPurchaseLimitVolumePerIP;

	private static decimal NewUnverifiedAccountLimit => Roblox.Platform.Billing.Properties.Settings.Default.CreditCardNewUnverifiedAccountLimit;

	private static int NewUnverifiedAccountLimitPeriodInDays => Roblox.Platform.Billing.Properties.Settings.Default.CreditCardNewUnverifiedAccountLimitPeriodInDays;

	private static bool LimitCcPurchaseByIp => Roblox.Platform.Billing.Properties.Settings.Default.LimitCCPurchaseByIP;

	public static void CheckPurchaseLimits(this IUser user, string ipAddress, string emailAddress, decimal totalPurchaseAmount)
	{
		if (user != null)
		{
			IFloodChecker purchaseAttemptByUserFloodChecker = FloodCheckers.GetPurchaseAttemptByUserFloodChecker(user.Id);
			if (purchaseAttemptByUserFloodChecker.IsFlooded())
			{
				throw new PurchaseLimitException("You have made too many purchase attempts. Please try again later.");
			}
			purchaseAttemptByUserFloodChecker.UpdateCount();
			if (FloodCheckers.GetDeclinedCardByUserFloodChecker(user.Id).IsFlooded())
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.DeclinedCardByUserFloodchecker.ID, "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by email at info@roblox.com.");
			}
			if (!UseTestMode)
			{
				user.PerformPurchaseLimitCheck_UserAccount(totalPurchaseAmount);
				user.PerformPurchaseLimitCheck_AccountAge(totalPurchaseAmount);
			}
		}
		else
		{
			IFloodChecker purchaseAttemptByIPFloodChecker = FloodCheckers.GetPurchaseAttemptByIPFloodChecker(ipAddress);
			if (purchaseAttemptByIPFloodChecker.IsFlooded())
			{
				throw new PurchaseLimitException("You have made too many purchase attempts. Please try again later.");
			}
			purchaseAttemptByIPFloodChecker.UpdateCount();
			if (FloodCheckers.GetDeclinedCardByIPFloodChecker(ipAddress).IsFlooded())
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.DeclinedCardByIPFloodchecker.ID, "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by email at info@roblox.com.");
			}
		}
		if (!UseTestMode && !string.IsNullOrEmpty(emailAddress))
		{
			PerformPurchaseLimitCheck_EmailAddress(emailAddress, totalPurchaseAmount);
		}
		if (LimitCcPurchaseByIp)
		{
			PerformPurchaseLimitCheck_IpLimit(ipAddress, totalPurchaseAmount);
		}
	}

	private static void PerformPurchaseLimitCheck_UserAccount(this IUser user, decimal purchaseAmount)
	{
		IEnumerable<ITransactionLog> transactionsInLastMonth = new TransactionsProvider().GetCompletedTransactionsInTheLastMonthExcludingStoreCreditByAccountId(Convert.ToInt32(user.AccountId));
		decimal todaysTotal = purchaseAmount;
		foreach (ITransactionLog transaction2 in transactionsInLastMonth.Where((ITransactionLog x) => x.TransactionDate.Value >= DateTime.Now.AddDays(-1.0)))
		{
			if (transaction2.Amount.HasValue)
			{
				todaysTotal += transaction2.Amount.Value;
			}
			if (todaysTotal >= DailyUserChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountDaily.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "ACO"));
			}
		}
		decimal thisMonthsTotal = purchaseAmount;
		foreach (ITransactionLog transaction in transactionsInLastMonth)
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += transaction.Amount.Value;
			}
			if (thisMonthsTotal >= MonthlyUserChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountMonthly.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "MAO"));
			}
		}
	}

	private static void PerformPurchaseLimitCheck_AccountAge(this IUser user, decimal purchaseAmount)
	{
		string overLimitMessage;
		string overLimitCode;
		int accountMinAgeInDays;
		decimal accountPurchaseLimit;
		if (Roblox.Platform.Billing.Properties.Settings.Default.CreditCardNewUnverifiedAccountLimitEnabled && !user.HasVerifiedEmail())
		{
			overLimitMessage = "You must verify your email address before you can complete this transaction. Please visit the <a target='_blank' href='/My/Account.aspx?confirmemail=1'>Account</a> page to verify your email.";
			overLimitCode = "UNA";
			accountMinAgeInDays = NewUnverifiedAccountLimitPeriodInDays;
			accountPurchaseLimit = NewUnverifiedAccountLimit;
		}
		else
		{
			overLimitMessage = "Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.";
			overLimitCode = "NAO";
			accountMinAgeInDays = NewAccountPeriodInDays;
			accountPurchaseLimit = NewAccountPurchaseLimit;
		}
		if (user.UserExceedsPurchaseLimitForAccountAge(purchaseAmount, accountMinAgeInDays, accountPurchaseLimit))
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckNewUserAccount.ID, string.Format(overLimitMessage, overLimitCode));
		}
	}

	private static bool UserExceedsPurchaseLimitForAccountAge(this IUser user, decimal purchaseAmount, int accountMinAgeInDays, decimal accountPurchaseLimit)
	{
		TimeSpan newAccountPeriod = new TimeSpan(accountMinAgeInDays, 0, 0, 0);
		DateTime newAccountDate = DateTime.Now.Subtract(newAccountPeriod);
		if (user.Created < newAccountDate)
		{
			return false;
		}
		if (purchaseAmount >= accountPurchaseLimit)
		{
			return true;
		}
		decimal newAccountTotal = purchaseAmount;
		foreach (ITransactionLog transaction in user.CompletedTransactionsInTheLastXDaysExcludingStoreCredit(accountMinAgeInDays))
		{
			if (transaction.Amount.HasValue)
			{
				newAccountTotal += transaction.Amount.Value;
			}
			if (newAccountTotal >= accountPurchaseLimit)
			{
				return true;
			}
		}
		return false;
	}

	internal static void PerformPurchaseLimitCheck_CreditCard(this CreditCardPaymentInfo creditCardPaymentInfo, decimal totalPurchaseAmount)
	{
		if (BillingHelper.UseTestMode)
		{
			return;
		}
		string creditCardNumber = CreditCardPaymentProvider.MaskCreditCardNumber(creditCardPaymentInfo.AccountNumber);
		if ((from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(creditCardNumber, DateTime.Today)
			where (x.PaymentStatusTypeID == Roblox.Billing.PaymentStatusType.Complete.ID || x.PaymentStatusTypeID == Roblox.Billing.PaymentStatusType.Pending.ID) && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Today
			select x).Count() >= DailyCreditCardTransactionCountLimit)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseCountCheckCreditCardDaily.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "DCC"));
		}
		decimal todaysTotal = totalPurchaseAmount;
		foreach (TransactionLog transaction2 in from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(creditCardNumber, DateTime.Now.AddDays(-1.0))
			where x.PaymentStatusTypeID == Roblox.Billing.PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddDays(-1.0)
			select x)
		{
			if (transaction2.Amount.HasValue)
			{
				todaysTotal += transaction2.Amount.Value;
			}
			if (todaysTotal >= DailyCreditCardChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckCreditCardDaily.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "DCC"));
			}
		}
		decimal thisMonthsTotal = totalPurchaseAmount;
		foreach (TransactionLog transaction in from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(creditCardNumber, DateTime.Now.AddMonths(-1))
			where x.PaymentStatusTypeID == Roblox.Billing.PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddMonths(-1)
			select x)
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += transaction.Amount.Value;
			}
			if (thisMonthsTotal >= MonthlyCreditCardChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckCreditCardMonthly.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "MCC"));
			}
		}
	}

	private static void PerformPurchaseLimitCheck_IpLimit(string ipAddress, decimal totalPurchaseAmount)
	{
		IPAddress orCreate = IPAddress.GetOrCreate(ipAddress);
		PerformPurchaseLimitCheck_IPDaily(orCreate.ID, totalPurchaseAmount);
		PerformPurchaseLimitCheck_IPMonthly(orCreate.ID, totalPurchaseAmount);
	}

	public static void PerformPurchaseLimitCheck_IPDaily(int ipAddressID, decimal purchaseAmount)
	{
		DateTime oneDayPreviously = DateTime.Now.AddDays(-1.0);
		IEnumerable<Roblox.Billing.Sale> completedSalesToday = from x in SaleIPAddress.GetSaleIPAddressIDsByIPAddressID_Paged(ipAddressID, 0, 2147483646)
			where x.Created > oneDayPreviously
			select x into saleIPAddress
			select Roblox.Billing.Sale.Get(saleIPAddress.SaleID) into sale
			where sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Complete.ID || sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Pending.ID || sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Recurring.ID
			select sale;
		if (purchaseAmount + completedSalesToday.Select((Roblox.Billing.Sale sale) => sale.DiscountedPriceTotal).Sum() >= DailyPurchaseLimitIp)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckIPDaily.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "IAL"));
		}
	}

	public static void PerformPurchaseLimitCheck_IPMonthly(int ipAddressID, decimal purchaseAmount)
	{
		DateTime oneMonthPreviously = DateTime.Now.AddMonths(-1);
		IEnumerable<Roblox.Billing.Sale> completedSalesThisMonth = from x in SaleIPAddress.GetSaleIPAddressIDsByIPAddressID_Paged(ipAddressID, 0, 2147483646)
			where x.Created > oneMonthPreviously
			select x into saleIPAddress
			select Roblox.Billing.Sale.Get(saleIPAddress.SaleID) into sale
			where sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Complete.ID || sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Pending.ID || sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Recurring.ID
			select sale;
		if (purchaseAmount + completedSalesThisMonth.Select((Roblox.Billing.Sale sale) => sale.DiscountedPriceTotal).Sum() >= MonthlyPurchaseLimitIp)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckIPMonthly.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "IAL"));
		}
	}

	private static void PerformPurchaseLimitCheck_EmailAddress(string emailAddress, decimal purchaseAmount)
	{
		decimal thisMonthsTotal = purchaseAmount;
		TransactionsProvider transactionProvider = new TransactionsProvider();
		foreach (ITransactionLog transaction in transactionProvider.GetTransactionLogsByEmailAndCreatedAfterDate(emailAddress, DateTime.Now.AddMonths(-1)).Where(transactionProvider.IsPaymentCompleteAndNotPaidWithStoreCredit))
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += transaction.Amount.Value;
			}
			if (thisMonthsTotal >= Roblox.Platform.Billing.Properties.Settings.Default.EmailChargeLimit_Monthly)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckEmailAddressMonthly.ID, string.Format("Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.", "POM"));
			}
		}
	}

	/// <summary>
	/// Check if a user can buy the product bundle
	/// </summary>
	/// <param name="user">The given <see cref="T:Roblox.User" /></param>
	/// <param name="mainProductId">The main product id</param>
	/// <param name="upsellProductId">The upsell product id</param>
	/// <param name="productDisplayModelProvider">The given <see cref="T:Roblox.Platform.Billing.IProductDisplayModelProvider" /></param>
	/// <returns>True if the user is enabled to buy the product bundle, otherwise false</returns>
	public static bool CanBuyProductBundle(this IUser user, int mainProductId, int upsellProductId, IProductDisplayModelProvider productDisplayModelProvider, bool isPremiumUser)
	{
		Product mainProduct = Product.Get(mainProductId);
		ProductDisplayModel productDisplay = productDisplayModelProvider.GetByProductId(mainProductId);
		if (mainProduct == null || productDisplay == null)
		{
			return false;
		}
		Product upsellProduct = Product.Get(upsellProductId);
		if (user == null)
		{
			if (mainProduct.ProductGroupID == ProductGroup.GiftCard.ID)
			{
				return upsellProduct == null;
			}
			return false;
		}
		if (upsellProduct == null)
		{
			return user.MeetsProductRequirements(mainProduct, isPremiumUser);
		}
		if ((mainProduct.ProductGroupID == ProductGroup.Robux.ID && productDisplayModelProvider.IsUpsellBcProduct(upsellProductId)) || (mainProduct.ProductGroupID == ProductGroup.BC.ID && productDisplayModelProvider.IsUpsellRobuxProduct(upsellProductId)))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Check if a user meets the product requirements to purchase the give product
	/// </summary>
	/// <param name="user">The given <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="product">The <see cref="T:Roblox.Billing.Product" /> to purchase</param>
	/// <param name="isPremiumUser">If user is premium</param>
	/// <returns>True if the user meets requirements to purchase to product, otherwise false</returns>
	public static bool MeetsProductRequirements(this IUser user, Product product, bool isPremiumUser)
	{
		if (product != null && ((BillingHelper.IsExclusiveToBuildersClub(product) && !UserHasBCMembership(user)) || (BillingHelper.IsExclusiveToPremium(product) && !isPremiumUser)))
		{
			return false;
		}
		return true;
	}

	private static bool UserHasBCMembership(IUser user)
	{
		return user?.IsBCMember() ?? false;
	}
}
