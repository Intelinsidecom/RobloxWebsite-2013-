using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.Data;
using Roblox.Demographics;
using Roblox.EventLog;
using Roblox.FloodCheckers;
using Roblox.Instrumentation;
using Roblox.Platform.Email.Delivery;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

/// <summary>
/// Utility methods for logging and validating payments.
/// </summary>
public static class PaymentHelper
{
	/// <summary>
	/// The window of time used to calcuate a users transaction sum
	/// </summary>
	internal enum TransactionTimeWindowType
	{
		Day,
		Week,
		Month
	}

	private static readonly ILogger Logger = StaticLoggerRegistry.Instance;

	private static readonly IEmailSender EmailSender = new EmailSender(StaticLoggerRegistry.Instance, StaticCounterRegistry.Instance);

	private const string _EmailType = "CreditCardDailyFloodLimitAlert";

	private const string _OverLimitUnverifiedMessage = "You must verify your email address before you can complete this transaction. Please visit the <a target='_blank' href='/My/Account.aspx?confirmemail=1'>Account</a> page to verify your email.";

	internal static string OverLimitMessage = "Your transaction cannot be completed at this time, as you have reached a transaction limit.  If you have any questions, please contact our Customer Service Team at info@roblox.com and reference error code {0}. Please note Customer Service cannot change or remove these limits.";

	private const string _DeclinedCardMessage = "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by phone at (888) 858-BLOX or by email at info@roblox.com.";

	private const string _OverLimitTitle = "Unable to process transaction";

	internal static string CodeDailyPerAccount = "ACO";

	private const string _CodeDailyPerCreditCard = "DCC";

	internal static string CodeMonthlyPerAccount = "MAO";

	private const string _CodeMonthlyPerCreditCard = "MCC";

	private const string _CodeMonthlyPerBilling = "POM";

	private const string _CodeByIPAddress = "IAL";

	private const string _CodeNewAccounts = "NAO";

	private const string _CodeNewUnverifiedAccounts = "UNA";

	private static byte _NewAccountPeriodInDays => Settings.Default.NewAccountPeriodInDays;

	private static int _DailyCreditCardTransactionCountLimit => Settings.Default.CreditCardTransactionCountLimit_Daily;

	private static decimal _DailyCreditCardChargeLimit => Settings.Default.CreditCardChargeLimit_Daily;

	private static decimal _DailyUserChargeLimit => Settings.Default.UserChargeLimit_Daily;

	private static decimal _NewAccountPurchaseLimit => Settings.Default.NewAccountPurchaseLimit;

	private static decimal _MonthlyCreditCardChargeLimit => Settings.Default.CreditCardChargeLimit_Monthly;

	private static decimal _MonthlyUserChargeLimit => Settings.Default.UserChargeLimit_Monthly;

	private static decimal _MonthlyEmailChargeLimit => Settings.Default.EmailChargeLimit_Monthly;

	private static decimal _DailyPurchaseLimitIP => Settings.Default.DailyPurchaseLimitVolumePerIP;

	private static decimal _MonthlyPurchaseLimitIP => Settings.Default.MonthlyPurchaseLimitVolumePerIP;

	private static bool _NewUnverifiedAccountLimitEnabled => Settings.Default.CreditCardNewUnverifiedAccountLimitEnabled;

	private static decimal _NewUnverifiedAccountLimit => Settings.Default.CreditCardNewUnverifiedAccountLimit;

	private static int _NewUnverifiedAccountLimitPeriodInDays => Settings.Default.CreditCardNewUnverifiedAccountLimitPeriodInDays;

	internal static bool IsValidProductBundle(ShoppingCart shoppingCart, PaymentProviderType type)
	{
		return shoppingCart.Contents.All((ShoppingCartProduct scp) => ProductPaymentProviderType.IsValidPaymentProviderType(scp.ProductID, type.ID));
	}

	internal static void PerformPurchaseLimitCheck_CreditCard(string creditCardNumber, decimal purchaseAmount)
	{
		if (BillingHelper.UseTestMode)
		{
			return;
		}
		string maskedCreditCardNumber = CreditCardPaymentProvider.MaskCreditCardNumber(creditCardNumber);
		if ((from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(maskedCreditCardNumber, DateTime.Today)
			where (x.PaymentStatusTypeID == PaymentStatusType.Complete.ID || x.PaymentStatusTypeID == PaymentStatusType.Pending.ID) && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Today
			select x).Count() >= _DailyCreditCardTransactionCountLimit)
		{
			if (Settings.Default.SendCCDailyLimitFloodCheckEmail)
			{
				try
				{
					Email email = new Email("no-reply@roblox.com", "isaiah@roblox.com", "CC Daily Limit Flood Check Alert", EmailBodyType.Plain, "CreditCardDailyFloodLimitAlert", "Masked CC Number: " + maskedCreditCardNumber);
					EmailSender.SendEmail(email);
				}
				catch (Exception ex)
				{
					ExceptionHandler.LogException(ex);
				}
			}
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseCountCheckCreditCardDaily.ID, string.Format(OverLimitMessage, "DCC"));
		}
		decimal todaysTotal = purchaseAmount;
		foreach (TransactionLog transaction2 in from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(maskedCreditCardNumber, DateTime.Now.AddDays(-1.0))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddDays(-1.0)
			select x)
		{
			if (transaction2.Amount.HasValue)
			{
				todaysTotal += transaction2.Amount.Value;
			}
			if (todaysTotal >= _DailyCreditCardChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckCreditCardDaily.ID, string.Format(OverLimitMessage, "DCC"));
			}
		}
		decimal thisMonthsTotal = purchaseAmount;
		foreach (TransactionLog transaction in from x in TransactionLog.GetTransactionLogsByMaskedCreditCardNumber(maskedCreditCardNumber, DateTime.Now.AddMonths(-1))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddMonths(-1)
			select x)
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += transaction.Amount.Value;
			}
			if (thisMonthsTotal >= _MonthlyCreditCardChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckCreditCardMonthly.ID, string.Format(OverLimitMessage, "MCC"));
			}
		}
	}

	/// <summary>
	/// Calculates the sum the user has spent in the specified time period
	/// </summary>
	/// <param name="accountId">The account ID of the user to check</param>
	/// <param name="purchaseAmount">Purchase amount the user is currently trying to buy.</param>
	/// <param name="transactionTimeWindowType">Window of time to pull transactions from.</param>
	/// <returns>Amount the user has spent in the specified time</returns>
	internal static decimal UsersTransactionAmount(long accountId, TransactionTimeWindowType transactionTimeWindowType, decimal purchaseAmount = 0m)
	{
		DateTime startDate = default(DateTime);
		switch (transactionTimeWindowType)
		{
		case TransactionTimeWindowType.Day:
			startDate = DateTime.Now.AddDays(-1.0);
			break;
		case TransactionTimeWindowType.Week:
			startDate = DateTime.Now.AddDays(-7.0);
			break;
		case TransactionTimeWindowType.Month:
			startDate = DateTime.Now.AddMonths(-1);
			break;
		}
		IEnumerable<TransactionLog> transactions = from x in TransactionLog.GetTransactionLogsByUserAccountID(accountId, startDate)
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= startDate
			select x;
		transactions = transactions.Where((TransactionLog x) => Payment.Get(x.PaymentID).PaymentProviderTypeID != PaymentProviderType.Credit.ID);
		return purchaseAmount + transactions.Where((TransactionLog transaction) => transaction.Amount.HasValue).Sum((TransactionLog transaction) => GetTransactionAmountInUSD(transaction) ?? transaction.Amount.Value);
	}

	internal static void PerformPurchaseLimitCheck_UserAccount(long accountId, decimal? purchaseAmount)
	{
		decimal todaysTotal = purchaseAmount ?? 0m;
		foreach (TransactionLog transaction2 in from x in TransactionLog.GetTransactionLogsByUserAccountID(accountId, DateTime.Now.AddMonths(-1))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddDays(-1.0)
			where Payment.Get(x.PaymentID).PaymentProviderTypeID != PaymentProviderType.Credit.ID
			select x)
		{
			if (transaction2.Amount.HasValue)
			{
				todaysTotal += GetTransactionAmountInUSD(transaction2) ?? 0m;
			}
			if (todaysTotal >= _DailyUserChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountDaily.ID, string.Format(OverLimitMessage, CodeDailyPerAccount));
			}
		}
		decimal thisMonthsTotal = purchaseAmount ?? 0m;
		foreach (TransactionLog transaction in from x in TransactionLog.GetTransactionLogsByUserAccountID(accountId, DateTime.Now.AddMonths(-1))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddMonths(-1)
			where Payment.Get(x.PaymentID).PaymentProviderTypeID != PaymentProviderType.Credit.ID
			select x)
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += GetTransactionAmountInUSD(transaction) ?? 0m;
			}
			if (thisMonthsTotal >= _MonthlyUserChargeLimit)
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckUserAccountMonthly.ID, string.Format(OverLimitMessage, CodeMonthlyPerAccount));
			}
		}
	}

	public static void PerformPurchaseLimitCheck_NewUserAccount(long accountId, decimal purchaseAmount, DateTime accountCreation)
	{
		bool isVerified = AccountEmailAddress.GetCurrent(accountId)?.IsVerified ?? false;
		string overLimitMessage;
		string overLimitCode;
		int accountMinAgeInDays;
		decimal accountPurchaseLimit;
		if (_NewUnverifiedAccountLimitEnabled && !isVerified)
		{
			overLimitMessage = "You must verify your email address before you can complete this transaction. Please visit the <a target='_blank' href='/My/Account.aspx?confirmemail=1'>Account</a> page to verify your email.";
			overLimitCode = "UNA";
			accountMinAgeInDays = _NewUnverifiedAccountLimitPeriodInDays;
			accountPurchaseLimit = _NewUnverifiedAccountLimit;
		}
		else
		{
			overLimitMessage = OverLimitMessage;
			overLimitCode = "NAO";
			accountMinAgeInDays = _NewAccountPeriodInDays;
			accountPurchaseLimit = _NewAccountPurchaseLimit;
		}
		if (UserExceedsPurchaseLimitForAccountAge(accountId, purchaseAmount, accountCreation, accountMinAgeInDays, accountPurchaseLimit))
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckNewUserAccount.ID, string.Format(overLimitMessage, overLimitCode));
		}
	}

	private static bool UserExceedsPurchaseLimitForAccountAge(long accountId, decimal purchaseAmount, DateTime accountCreation, int accountMinAgeInDays, decimal accountPurchaseLimit)
	{
		TimeSpan newAccountPeriod = new TimeSpan(accountMinAgeInDays, 0, 0, 0);
		DateTime newAccountDate = DateTime.Now.Subtract(newAccountPeriod);
		if (accountCreation < newAccountDate)
		{
			return false;
		}
		if (purchaseAmount >= accountPurchaseLimit)
		{
			return true;
		}
		decimal newAccountTotal = purchaseAmount;
		foreach (TransactionLog transaction in from x in TransactionLog.GetTransactionLogsByUserAccountID(accountId, DateTime.Now.AddDays(-accountMinAgeInDays))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue
			where Payment.Get(x.PaymentID).PaymentProviderTypeID != PaymentProviderType.Credit.ID
			select x)
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

	public static void PerformPurchaseLimitCheck_EmailAddress(string emailAddress, decimal purchaseAmount)
	{
		decimal thisMonthsTotal = purchaseAmount;
		foreach (TransactionLog transaction in from x in TransactionLog.GetTransactionLogsByEmail(emailAddress, DateTime.Now.AddMonths(-1))
			where x.PaymentStatusTypeID == PaymentStatusType.Complete.ID && x.TransactionDate.HasValue && x.TransactionDate.Value >= DateTime.Now.AddMonths(-1)
			where Payment.Get(x.PaymentID).PaymentProviderTypeID != PaymentProviderType.Credit.ID
			select x)
		{
			if (transaction.Amount.HasValue)
			{
				thisMonthsTotal += transaction.Amount.Value;
			}
			if (thisMonthsTotal >= _MonthlyEmailChargeLimit)
			{
				string message = string.Format(OverLimitMessage, "POM");
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckEmailAddressMonthly.ID, message);
			}
		}
	}

	internal static void PerformDoublePurchaseCheck_UserAccount(long accountId, List<ShoppingCartProduct> products)
	{
		IEnumerable<Sale> source = from x in Sale.GetSalesByPurchaser(accountId)
			where x.Updated > DateTime.Now.AddHours(-1.0) && (x.SaleStatusTypeID == SaleStatusType.Complete.ID || x.SaleStatusTypeID == SaleStatusType.Pending.ID)
			select x;
		List<int> productIds = products.Select((ShoppingCartProduct p) => p.ProductID).ToList();
		if (source.Any((Sale s) => s.Products.Count((SaleProduct y) => productIds.Contains(y.ProductID)) > 3))
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.DoublePurchaseCheckUserAccount.ID, OverLimitMessage);
		}
	}

	public static void PerformPurchaseLimitCheck_IPDaily(int ipAddressID, decimal purchaseAmount)
	{
		DateTime oneDayPreviously = DateTime.Now.AddDays(-1.0);
		IEnumerable<Sale> completedSalesToday = from x in SaleIPAddress.GetSaleIPAddressIDsByIPAddressID_Paged(ipAddressID, 0, 2147483646)
			where x.Created > oneDayPreviously
			select x into saleIPAddress
			select Sale.Get(saleIPAddress.SaleID) into sale
			where sale.SaleStatusTypeID == SaleStatusType.Complete.ID || sale.SaleStatusTypeID == SaleStatusType.Pending.ID
			select sale;
		if (purchaseAmount + completedSalesToday.Select((Sale sale) => sale.DiscountedPriceTotal).Sum() >= _DailyPurchaseLimitIP)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckIPDaily.ID, string.Format(OverLimitMessage, "IAL"));
		}
	}

	public static void PerformPurchaseLimitCheck_IPMonthly(int ipAddressID, decimal purchaseAmount)
	{
		DateTime oneMonthPreviously = DateTime.Now.AddMonths(-1);
		SaleIPAddress.GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter(ipAddressID, oneMonthPreviously);
		IEnumerable<Sale> salesThisMonth = from x in SaleIPAddress.GetSaleIPAddressIDsByIPAddressID_Paged(ipAddressID, 0, 2147483646)
			where x.Created > oneMonthPreviously
			select x into saleIPAddress
			select Sale.Get(saleIPAddress.SaleID);
		salesThisMonth.Where((Sale sale) => sale.SaleStatusTypeID == SaleStatusType.Complete.ID || sale.SaleStatusTypeID == SaleStatusType.Pending.ID);
		if (purchaseAmount + salesThisMonth.Select((Sale sale) => sale.DiscountedPriceTotal).Sum() >= _MonthlyPurchaseLimitIP)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.PurchaseLimitCheckIPMonthly.ID, string.Format(OverLimitMessage, "IAL"));
		}
	}

	public static void PerformDeclinedCardCheck()
	{
		User authenticatedUser = User.GetCurrent();
		if (authenticatedUser != null)
		{
			if (new DeclinedCardByUserFloodChecker(authenticatedUser.ID).IsFlooded())
			{
				throw new BlockedPurchaseException(PaymentStatusChangeReasonType.DeclinedCardByUserFloodchecker.ID, "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by phone at (888) 858-BLOX or by email at info@roblox.com.");
			}
		}
		else if (new DeclinedCardByIPFloodChecker(HttpContext.Current.GetOriginIP()).IsFlooded())
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.DeclinedCardByIPFloodchecker.ID, "Too many credit card failures, if you wish to make a purchase, please contact Customer Support by phone at (888) 858-BLOX or by email at info@roblox.com.");
		}
	}

	public static bool Validate(IPaymentProvider pendingPayment)
	{
		return true;
	}

	/// <summary>
	/// Checks to see if the current shopping cart contains items
	/// purchased within the last five minutes.
	/// </summary>
	/// <param name="accountId">The accountId of the purchaser</param>
	/// <param name="shoppingCart">The current shopping cart of the account associated with accountId</param>
	/// <returns>True if any items in the cart have been purchased in the last 5 mins, false otherwise</returns>
	public static bool IsDoublePurchase(long accountId, ShoppingCart shoppingCart)
	{
		IEnumerable<Sale> source = from x in Sale.GetSalesByPurchaser(accountId)
			where x.Updated >= DateTime.Now.AddMinutes(-5.0) && (x.SaleStatusTypeID == SaleStatusType.Complete.ID || x.SaleStatusTypeID == SaleStatusType.Pending.ID)
			select x;
		List<int> productIds = shoppingCart.Contents.Select((ShoppingCartProduct p) => p.ProductID).ToList();
		return source.Any((Sale s) => s.Products.Any((SaleProduct y) => productIds.Contains(y.ProductID)));
	}

	public static bool IsPurchaseDisabledBecauseOfMembership(int productId, long accountId)
	{
		AccountAddOn bcMembership = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (UserHasRenewalBC(bcMembership) && IsBCRenewalPending(accountId))
		{
			return true;
		}
		if (bcMembership == null || !bcMembership.IsLifetime)
		{
			return false;
		}
		PremiumFeature currentPremiumFeature;
		try
		{
			currentPremiumFeature = bcMembership.GetPremiumFeature();
		}
		catch (DataIntegrityException ex)
		{
			ExceptionHandler.LogException(ex);
			return true;
		}
		if (currentPremiumFeature == null)
		{
			return false;
		}
		if (currentPremiumFeature.IsOutrageousBuildersClub)
		{
			if (productId != Product.OBCLifetimeID && productId != Product.BCLifetimeID)
			{
				return productId == Product.TBCLifetimeID;
			}
			return true;
		}
		if (currentPremiumFeature.IsTurboBuildersClub)
		{
			if (productId != Product.BCLifetimeID)
			{
				return productId == Product.TBCLifetimeID;
			}
			return true;
		}
		if (currentPremiumFeature.IsBuildersClub)
		{
			return productId == Product.BCLifetimeID;
		}
		return false;
	}

	private static bool UserHasRenewalBC(AccountAddOn bcMembership)
	{
		if (bcMembership != null)
		{
			return BillingHelper.UserHasRecurringBC(bcMembership.AccountID);
		}
		return false;
	}

	private static bool IsBCRenewalPending(long accountId)
	{
		Sale mostRecentSale = Sale.GetMostRecentRecurringSaleForAccount(accountId, ProductGroup.BC.ID);
		if (mostRecentSale != null)
		{
			if (mostRecentSale.RenewalDate.HasValue)
			{
				return mostRecentSale.RenewalDate.Value.Date <= DateTime.Now.Date;
			}
			return false;
		}
		return false;
	}

	/// <summary>
	/// Get the amount in USD of a transaction.
	/// Please be aware that this method is currently only used when validating payment made through PayPal.
	/// </summary>
	/// <param name="transaction">The transaction log of a sale</param>
	/// <returns>Total amount of a transaction in USD</returns>
	private static decimal? GetTransactionAmountInUSD(ITransactionLog transaction)
	{
		int saleID = transaction.SaleID;
		byte paymentProviderId = Payment.Get(transaction.PaymentID).PaymentProviderTypeID;
		int usdCountryCurrencyId = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID).ID;
		ICollection<SaleProduct> saleProducts = SaleProduct.GetSaleProductsBySaleID(saleID);
		if (saleProducts != null)
		{
			return saleProducts.Sum((SaleProduct saleProduct) => BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderId, usdCountryCurrencyId, saleProduct.ProductID));
		}
		return default(decimal);
	}
}
