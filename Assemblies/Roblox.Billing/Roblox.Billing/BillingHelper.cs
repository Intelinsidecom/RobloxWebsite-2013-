using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Billing.Properties;
using Roblox.EventLog;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

public static class BillingHelper
{
	public static Dictionary<int, int> AccountProductPremiumFeatureMappings;

	private static float TbctoBcConversionFactor => Settings.Default.TBCToBCConversionFactor;

	private static float ObctoBcConversionFactor => Settings.Default.OBCtoBCConversionFactor;

	private static float ObctoTbcConversionFactor => Settings.Default.OBCtoTBCConversionFactor;

	public static string RixtyUser => Settings.Default.RixtyUser;

	public static string RixtyPassword => Settings.Default.RixtyPassword;

	public static string RixtySignature => Settings.Default.RixtySignature;

	public static string RixtyURL => Settings.Default.RixtyURL;

	public static string RixtyReturnURL => Settings.Default.RixtyReturnURL;

	public static string RixtyCancelURL => Settings.Default.RixtyCancelURL;

	public static int RobuxPerDollar => Settings.Default.RobuxPerDollar;

	public static int RixtyTopupProductID => Settings.Default.RixtyTopupProductID;

	public static bool RixtyIsEnabled => Settings.Default.RixtyIsEnabled;

	public static string BokuServiceID => Settings.Default.BokuServiceID;

	public static string BokuTestNumber => Settings.Default.BokuTestNumber;

	public static bool CreditIsEnabled => Settings.Default.CreditIsEnabled;

	public static bool PayPalRecurringIsEnabled => Settings.Default.PayPalRecurringIsEnabled;

	public static bool UseTestMode => Settings.Default.UseTestMode;

	public static bool TransactionLogCachingEnabled => Settings.Default.TransactionLogCachingEnabled;

	public static bool GiftCardsEnabled => Settings.Default.GiftCardsEnabled;

	public static bool GiftCardAssetAwardEnabled => Settings.Default.GiftCardAssetAwardEnabled;

	public static long GiftCardAssetAwardID => Settings.Default.GiftCardAssetAwardID;

	public static bool Enabled => Settings.Default.BillingIsParallel;

	public static string GameCardTestPin => Settings.Default.GameCardTestPin;

	public static string RixtyTestPin => Settings.Default.RixtyTestPin;

	internal static int MaxCancellationsPerDay => Settings.Default.MaxCancellationsPerDay;

	private static DateTime GetExpandedExpirationForMembershipConversion(DateTime currentMembershipExpiration, float conversionFactor)
	{
		DateTime now = DateTime.Now;
		long currentMembershipTimeRemainingInTicks = currentMembershipExpiration.Subtract(now).Ticks;
		if (currentMembershipTimeRemainingInTicks < 1)
		{
			return now;
		}
		long expandedExpirationInTicks = (long)((float)currentMembershipTimeRemainingInTicks * conversionFactor);
		return now.AddTicks(expandedExpirationInTicks);
	}

	private static DateTime GetCompressedExpirationForMembershipConversion(DateTime currentMembershipExpiration, float conversionFactor)
	{
		DateTime now = DateTime.Now;
		long currentMembershipTimeRemainingInTicks = currentMembershipExpiration.Subtract(now).Ticks;
		if (currentMembershipTimeRemainingInTicks < 1)
		{
			return now;
		}
		long compressedExpirationInTicks = (long)((float)currentMembershipTimeRemainingInTicks / conversionFactor);
		return now.AddTicks(compressedExpirationInTicks);
	}

	public static void ActivateTaskWorkers(ILogger logger, ParallelTaskWorker.Configuration parallelTaskWorkerConfiguration, int leaseDurationInMinutes, int numberOfTasks, IPremiumFeatureActivationTaskFactory premiumFeatureActivationTaskFactory)
	{
		if (!Enabled)
		{
			return;
		}
		try
		{
			ParallelTaskWorker.Start("BillingPremiumFeaturesGrantRequest", parallelTaskWorkerConfiguration, delegate
			{
				ICollection<IParallelWorkTask> collection2 = BillingPremiumFeaturesGrantRequestTask.LeaseWorkItems(ParallelTaskWorker.ID, numberOfTasks, leaseDurationInMinutes, logger, premiumFeatureActivationTaskFactory);
				ParallelTaskWorker.LeaseResult result2 = default(ParallelTaskWorker.LeaseResult);
				result2.Tasks = collection2;
				result2.AreMoreExpected = collection2.Count >= numberOfTasks;
				return result2;
			});
			ParallelTaskWorker.Start("PayPalCancellation", parallelTaskWorkerConfiguration, delegate
			{
				ICollection<IParallelWorkTask> collection = Cancellation.LeaseWorkItems(ParallelTaskWorker.ID, numberOfTasks, leaseDurationInMinutes, MaxCancellationsPerDay, logger);
				ParallelTaskWorker.LeaseResult result = default(ParallelTaskWorker.LeaseResult);
				result.Tasks = collection;
				result.AreMoreExpected = collection.Count >= numberOfTasks;
				return result;
			});
		}
		catch (Exception ex)
		{
			logger.Error(ex);
			Environment.FailFast(ex.ToString());
		}
	}

	public static int GetBillingProductIDByAccountProductID(int accountProductId)
	{
		try
		{
			if (AccountProductPremiumFeatureMappings == null)
			{
				AccountProductPremiumFeatureMappings = AccountProductPremiumFeatureMapping.GetAccountProductPremiumFeatureMappingsFromDB();
			}
			AccountProductPremiumFeatureMappings.TryGetValue(accountProductId, out var premiumFeatureId);
			if (premiumFeatureId == 0)
			{
				return 0;
			}
			return Product.GetByPremiumFeatureID(premiumFeatureId).ID;
		}
		catch (Exception)
		{
			return 0;
		}
	}

	/// <summary>
	/// Checks if an existing user accountID is using the new billing system (otherwise they're using the old one or haven't yet been assigned to one.)
	/// </summary>
	public static BillingSystem GetBillingSystemForAccount(Account account)
	{
		if (BillingAccount.GetByAccountID(account.ID) != null)
		{
			return BillingSystem.New;
		}
		BillingAccount.CreateNew(account.ID);
		return BillingSystem.New;
	}

	public static bool UserHasRecurringBC(long userAccountID)
	{
		return Sale.GetMostRecentRecurringSaleForAccount(userAccountID, ProductGroup.BC.ID) != null;
	}

	public static DateTime GetExpirationForBuildersClubToTurboBuildersClubConversion(DateTime buildersClubExpiration)
	{
		return GetCompressedExpirationForMembershipConversion(buildersClubExpiration, TbctoBcConversionFactor);
	}

	public static DateTime GetExpirationForBuildersClubToOutrageousBuildersClubConversion(DateTime buildersClubExpiration)
	{
		return GetCompressedExpirationForMembershipConversion(buildersClubExpiration, ObctoBcConversionFactor);
	}

	public static DateTime GetExpirationForTurboBuildersClubToBuildersClubConversion(DateTime turboBuildersClubExpiration)
	{
		return GetExpandedExpirationForMembershipConversion(turboBuildersClubExpiration, TbctoBcConversionFactor);
	}

	public static DateTime GetExpirationForTurboBuildersClubToOutrageousBuildersClubConversion(DateTime turboBuildersClubExpiration)
	{
		return GetCompressedExpirationForMembershipConversion(turboBuildersClubExpiration, ObctoTbcConversionFactor);
	}

	public static DateTime GetExpirationForOutrageousBuildersClubToBuildersClubConversion(DateTime outrageousBuildersClubExpiration)
	{
		return GetExpandedExpirationForMembershipConversion(outrageousBuildersClubExpiration, ObctoBcConversionFactor);
	}

	public static DateTime GetExpirationForOutrageousBuildersClubToTurboBuildersClubConversion(DateTime outrageousBuildersClubExpiration)
	{
		return GetExpandedExpirationForMembershipConversion(outrageousBuildersClubExpiration, ObctoTbcConversionFactor);
	}

	public static void CreateSaleTrackingCookie(HttpContext context, int saleId)
	{
		RobloxCookie orCreate = RobloxCookie.GetOrCreate(context, "LastSale");
		orCreate.Value = saleId.ToString();
		orCreate.Expires = DateTime.Now.AddHours(1.0);
		orCreate.AppendToResponse();
	}

	public static int GetSaleIDFromTrackingCookie(HttpContext context)
	{
		RobloxCookie robloxCookie = RobloxCookie.Get(context, "LastSale");
		if (robloxCookie == null)
		{
			return -1;
		}
		context.Response.Cookies.Remove("LastSale");
		return Convert.ToInt32(robloxCookie.Value);
	}

	public static int GetPremiumFeatureIDByAccountProductID(int accountProductId)
	{
		if (AccountProductPremiumFeatureMappings == null)
		{
			AccountProductPremiumFeatureMappings = AccountProductPremiumFeatureMapping.GetAccountProductPremiumFeatureMappingsFromDB();
		}
		AccountProductPremiumFeatureMappings.TryGetValue(accountProductId, out var premiumFeatureId);
		return premiumFeatureId;
	}

	public static void UpgradeUser(User user)
	{
	}

	public static void MigrateUser(User user)
	{
		if (Settings.Default.BillingAutoMigrationEnabled)
		{
			UpgradeUser(user);
		}
	}

	public static DateTime CalculateFirstRenewalDate(long accountID, int premiumFeatureID, IAccountAddOnActivationTaskFactory accountAddOnActivationTaskFactory)
	{
		if (accountAddOnActivationTaskFactory == null)
		{
			throw new ArgumentNullException("accountAddOnActivationTaskFactory");
		}
		return PremiumFeatureHelper.CalculateGracePeriodAwareUnpaddedExpiration(accountAddOnActivationTaskFactory.CalculateBuildersClubUpgradeExpiration(AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountID), premiumFeatureID), isRenewal: true);
	}

	public static TransactionLog GetMostRecentCCTransactionByUserAccountID(long userAccountID)
	{
		return (Settings.Default.TransactionLogCachingEnabled ? TransactionLog.GetTransactionLogsByUserAccountID(userAccountID) : TransactionLog.GetTransactionLogsByUserAccountID(userAccountID, DateTime.Now.AddYears(-20))).FirstOrDefault((TransactionLog t) => !string.IsNullOrEmpty(t.Description) && t.ErrorMessage == "Approved" && !string.IsNullOrEmpty(t.Number) && !string.IsNullOrEmpty(t.Email));
	}

	public static bool UserAcceptedBCPrepaidPromoWithinDayWindow(long userAccountID, int dayWindow)
	{
		return TransactionLog.GetTransactionLogsByUserAccountID(userAccountID, DateTime.Now.AddDays(-1 * dayWindow)).Any((TransactionLog t) => t.Amount.HasValue && t.Amount.Equals(new decimal(0.01)));
	}

	public static bool IsExclusiveToBuildersClub(Product upgrade)
	{
		if (upgrade.ID != Product.Get("450 ROBUX").ID && upgrade.ID != Product.Get("1000 ROBUX").ID && upgrade.ID != Product.Get("1500 ROBUX").ID && upgrade.ID != Product.Get("2750 ROBUX").ID && upgrade.ID != Product.Get("6000 ROBUX").ID && upgrade.ID != Product.Get("15000 ROBUX").ID && upgrade.ID != Product.Get("35000 ROBUX").ID && upgrade.ID != Product.Get("100000 ROBUX").ID && upgrade.ID != Product.Get("900 ROBUX").ID && upgrade.ID != Product.Get("2400 ROBUX").ID && upgrade.ID != Product.Get("5000 ROBUX").ID && upgrade.ID != Product.Get("11000 ROBUX").ID)
		{
			return upgrade.ID == Product.Get("25000 ROBUX").ID;
		}
		return true;
	}

	public static bool IsExclusiveToPremium(Product product)
	{
		if (!(product.Name == "Premium 440 Subscribed") && !(product.Name == "Premium 880 Subscribed") && !(product.Name == "Premium 1870 Subscribed") && !(product.Name == "Premium 4950 Subscribed"))
		{
			return product.Name == "Premium 11000 Subscribed";
		}
		return true;
	}

	public static bool IsExclusiveToBuildersClub(IProduct upgrade)
	{
		if (Settings.Default.IsRobuxTextCaseInsensitiveEnabled)
		{
			if (!(upgrade.Name == "450 ROBUX") && !(upgrade.Name == "1000 ROBUX") && !(upgrade.Name == "1500 ROBUX") && !(upgrade.Name == "2750 ROBUX") && !(upgrade.Name == "6000 ROBUX") && !(upgrade.Name == "15000 ROBUX") && !(upgrade.Name == "35000 ROBUX") && !(upgrade.Name == "100000 ROBUX") && !(upgrade.Name == "450 Robux") && !(upgrade.Name == "1000 Robux") && !(upgrade.Name == "1500 Robux") && !(upgrade.Name == "2750 Robux") && !(upgrade.Name == "6000 Robux") && !(upgrade.Name == "15000 Robux") && !(upgrade.Name == "35000 Robux") && !(upgrade.Name == "100000 Robux") && !(upgrade.Name == "900 Robux") && !(upgrade.Name == "2400 Robux") && !(upgrade.Name == "5000 Robux") && !(upgrade.Name == "11000 Robux"))
			{
				return upgrade.Name == "25000 Robux";
			}
			return true;
		}
		if (!(upgrade.Name == "450 ROBUX") && !(upgrade.Name == "1000 ROBUX") && !(upgrade.Name == "1500 ROBUX") && !(upgrade.Name == "2750 ROBUX") && !(upgrade.Name == "6000 ROBUX") && !(upgrade.Name == "15000 ROBUX") && !(upgrade.Name == "35000 ROBUX") && !(upgrade.Name == "100000 ROBUX") && !(upgrade.Name == "900 ROBUX") && !(upgrade.Name == "2400 ROBUX") && !(upgrade.Name == "5000 ROBUX") && !(upgrade.Name == "11000 ROBUX"))
		{
			return upgrade.Name == "25000 ROBUX";
		}
		return true;
	}

	/// <summary>
	/// Currently only supports recurring BC sales
	/// </summary>
	public static DateTime? GetCreditCardExpirationDate(long accountId)
	{
		Sale recurringSale = Sale.GetMostRecentRecurringSaleForAccount(accountId, ProductGroup.BC.ID);
		if (recurringSale == null)
		{
			return null;
		}
		TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(Payment.GetPaymentsBySale(recurringSale.ID).First().ID);
		if (associatedTransactionLog == null || !associatedTransactionLog.Year.HasValue || !associatedTransactionLog.Month.HasValue)
		{
			return null;
		}
		int year = associatedTransactionLog.Year.Value + 2000;
		int actualMonth = associatedTransactionLog.Month.Value;
		int lastDayOfMonth = DateTime.DaysInMonth(year, actualMonth);
		return new DateTime(year, actualMonth, lastDayOfMonth);
	}

	public static string GetTestVisaNumber()
	{
		string[] testVisaCreditCardNumbers = new string[10] { "4024007150608148", "4916320476623944", "4532227575572563", "4532716367598117", "4485381055735799", "4554044664665502", "4716675623601735", "4539315701020269", "4416596820242870", "4485987788221483" };
		return testVisaCreditCardNumbers[new Random().Next(0, testVisaCreditCardNumbers.Length)];
	}

	public static string MakeRandomAmExNumber()
	{
		string toReturn = "37";
		int luhn = 8;
		Random ran = new Random();
		int nextDigit;
		for (int i = 2; i < 14; i++)
		{
			nextDigit = ran.Next(0, 10);
			toReturn += nextDigit;
			luhn = ((i % 2 != 1) ? (luhn + nextDigit) : ((nextDigit < 5) ? (luhn + nextDigit * 2) : (luhn + nextDigit * 2 - 9)));
		}
		nextDigit = 10 - luhn % 10;
		if (nextDigit == 10)
		{
			nextDigit = 0;
		}
		toReturn += nextDigit;
		if (toReturn.Equals("378282246310005"))
		{
			toReturn = MakeRandomAmExNumber();
		}
		return toReturn;
	}

	public static List<Product> GetProductsByPaymentProviderTypeID(byte paymentProviderTypeID)
	{
		return (from pppt in ProductPaymentProviderType.GetProductPaymentProviderTypesByPaymentProviderTypeID(paymentProviderTypeID)
			select Product.Get(pppt.ProductID)).ToList();
	}

	public static decimal? GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(byte paymentProviderTypeID, int countryCurrencyID, int productID)
	{
		if (paymentProviderTypeID == 0 || countryCurrencyID == 0 || productID == 0)
		{
			return null;
		}
		CountryCurrency countryCurrency = CountryCurrency.Get(countryCurrencyID);
		if (countryCurrency == null)
		{
			return null;
		}
		ProductPaymentProviderType productPaymentProviderType = ProductPaymentProviderType.GetByProductIDAndPaymentProviderTypeID(productID, paymentProviderTypeID);
		if (productPaymentProviderType == null)
		{
			return null;
		}
		return ProductPrice.GetByProductPaymentProviderTypeIDAndCountryCurrencyID(productPaymentProviderType.ID, countryCurrency.ID)?.Price;
	}

	public static decimal? GetProductPriceByPaymentProviderTypeIDAndCountryID(byte paymentProviderTypeID, byte countryID, int productID)
	{
		if (paymentProviderTypeID == 0 || countryID == 0 || productID == 0)
		{
			return null;
		}
		CountryCurrency countryCurrency = CountryCurrency.GetCountryCurrenciesByCountryID_Paged(0, 100, countryID).FirstOrDefault();
		if (countryCurrency != null)
		{
			return GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderTypeID, countryCurrency.ID, productID);
		}
		return null;
	}

	[Obsolete("Use overloaded long")]
	public static bool UseNewPricingTable(User user)
	{
		int modulus = Settings.Default.UseNewPricingTableModulus;
		switch (modulus)
		{
		case 0:
			return false;
		case 1:
			return true;
		default:
			if (user != null)
			{
				return user.AccountID % modulus == 0;
			}
			return false;
		}
	}

	public static bool UseNewPricingTable(long accountId)
	{
		int modulus = Settings.Default.UseNewPricingTableModulus;
		return modulus switch
		{
			0 => false, 
			1 => true, 
			_ => accountId % modulus == 0, 
		};
	}

	/// <summary>
	/// Determines if a currency is supported by the payment provider
	/// </summary>
	/// <param name="currencyCode">Code of the currency the sale is in.</param>
	/// <returns>
	///     <c>True</c> if the currency is supported <c>false</c> otherwise.
	/// </returns>
	public static bool IsCurrencySupportedForDesktop(string currencyCode)
	{
		return Settings.Default.DesktopLocalPricingSupportedCurrencies.Contains(currencyCode.ToUpper());
	}
}
