using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.PremiumFeatures.Interfaces;
using Roblox.PremiumFeatures;
using Roblox.Users;

namespace Roblox.Platform.Billing;

public class MobileAppPurchaseValidator : IMobileAppPurchaseValidator
{
	internal enum TransactionTimeWindowType
	{
		Day,
		Month
	}

	protected IGeolocationFactory GeolocationFactory = new GeolocationFactory("MobileAppPurchaseValidator");

	private static readonly string _MobileFraudReasonPrefix = "MobileAppProductValidationResult_";

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly ILogger _Logger;

	private readonly IPremiumFeaturesUser _PremiumFeaturesUser;

	protected virtual bool IsCountryCurrencyClientBlocked => Roblox.Platform.Billing.Properties.Settings.Default.IsCountryCurrencyBlockEnabled;

	protected virtual string BlacklistedCountryCurrencies => Roblox.Platform.Billing.Properties.Settings.Default.BlacklistedCountryCurrencies;

	protected virtual bool IsUserDelayedFromCountryCurrencyBlockEnabled => Roblox.Platform.Billing.Properties.Settings.Default.IsUserDelayedFromCountryCurrencyBlockEnabled;

	protected virtual string BlacklistedCountryCurrenciesBasedOnUserAccountAge => Roblox.Platform.Billing.Properties.Settings.Default.BlacklistedCountryCurrenciesBasedOnUserAccountAge;

	protected virtual int AccountLimitPeriodInDays => Roblox.Platform.Billing.Properties.Settings.Default.AccountLimitPeriodInDays;

	protected virtual string BlacklistedCountriesBasedOnUserAccountAge => Roblox.Platform.Billing.Properties.Settings.Default.BlacklistedCountriesBasedOnUserAccountAge;

	protected virtual bool IsUserDelayedFromCountryBlockEnabled => Roblox.Platform.Billing.Properties.Settings.Default.IsUserDelayedFromCountryBlockEnabled;

	protected virtual string BlacklistedCurrenciesBasedOnUserAccountAge => Roblox.Platform.Billing.Properties.Settings.Default.BlacklistedCurrenciesBasedOnUserAccountAge;

	protected virtual bool IsUserDelayedFromCurrencyBlockEnabled => Roblox.Platform.Billing.Properties.Settings.Default.IsUserDelayedFromCurrencyBlockEnabled;

	protected virtual string BlacklistedCountriesForAppleAppStore => Roblox.Platform.Billing.Properties.Settings.Default.BlacklistedCountriesForAppleAppStore;

	protected virtual bool IsMobilePurchaseVelocityFilterEnabled => Roblox.Platform.Billing.Properties.Settings.Default.IsMobilePurchaseVelocityFilterEnabled;

	protected virtual decimal UserPurchaseAmountVelocityDailyLimit => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityDailyLimit;

	protected virtual decimal UserPurchaseAmountVelocityMonthlyLimit => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityMonthlyLimit;

	protected virtual decimal UserPurchaseAmountVelocityDailyLimit_AppleStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityDailyLimit_AppleStore;

	protected virtual decimal UserPurchaseAmountVelocityDailyLimit_AmazonStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityDailyLimit_AmazonStore;

	protected virtual decimal UserPurchaseAmountVelocityDailyLimit_GooglePlayStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityDailyLimit_GooglePlayStore;

	protected virtual decimal UserPurchaseAmountVelocityMonthlyLimit_AppleStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityMonthlyLimit_AppleStore;

	protected virtual decimal UserPurchaseAmountVelocityMonthlyLimit_AmazonStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityMonthlyLimit_AmazonStore;

	protected virtual decimal UserPurchaseAmountVelocityMonthlyLimit_GooglePlayStore => Roblox.Platform.Billing.Properties.Settings.Default.UserPurchaseAmountVelocityMonthlyLimit_GooglePlayStore;

	private CountryCurrency _USAUSDCountryCurrency => GetUSAUSDCountryCurrency();

	private IReadOnlyDictionary<byte, decimal> _DailyVelocityLimitByPaymentProvider => InitializeDailyVelocityLimitByPaymentProvider();

	private IReadOnlyDictionary<byte, decimal> _MonthlyVelocityLimitByPaymentProvider => InitializeMonthlyVelocityLimitByPaymentProvider();

	private static string _PremiumPurchaseLeasedLockKey => Roblox.Billing.Properties.Settings.Default.PremiumPurchaseLeasedLockKey;

	public MobileAppPurchaseValidator(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger, IPremiumFeaturesUser premiumFeaturesUser)
	{
		_EphemeralCounterFactory = ephemeralCounterFactory.AssignOrThrowIfNull("ephemeralCounterFactory");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_PremiumFeaturesUser = premiumFeaturesUser.AssignOrThrowIfNull("premiumFeaturesUser");
	}

	public MobileAppProductValidationResult ValidateMobilePurchase(IUser user, GetAppSpecificProductFromProductId productGetter, string productId, Roblox.Billing.PaymentProviderType paymentProviderType, string ipAddress, Action<Exception> exceptionHandler, string currencyCode = null)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (productGetter == null)
		{
			throw new PlatformArgumentNullException("productGetter");
		}
		if (string.IsNullOrWhiteSpace(productId))
		{
			throw new PlatformArgumentException("productId");
		}
		MobileAppProductValidationResult result = new MobileAppProductValidationResult();
		if (!string.IsNullOrEmpty(ipAddress) && paymentProviderType != null)
		{
			string countryCode = GetCountryCodeFromIP(ipAddress);
			_Logger.Info($"Country Currency of this purchase are {countryCode} : {currencyCode} on Platform: {paymentProviderType.Value}.");
			_Logger.Info($"Mobile purchase in Country: {countryCode} on Platform: {paymentProviderType.Value}.");
			_Logger.Info($"Mobile purchase with Currency: {currencyCode} on Platform: {paymentProviderType.Value}.");
			_Logger.Info($"Mobile purchase on Platform: {paymentProviderType.Value}.");
		}
		if (IsUserDelayedFromCountryBlockEnabled && !string.IsNullOrEmpty(ipAddress) && paymentProviderType == Roblox.Billing.PaymentProviderType.GooglePlayStore)
		{
			try
			{
				if (!IsUserFromCountryAllowedToPurchase(ipAddress, user))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountry);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountry, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e3)
			{
				exceptionHandler(e3);
			}
		}
		if (IsUserDelayedFromCurrencyBlockEnabled && !string.IsNullOrEmpty(currencyCode) && paymentProviderType == Roblox.Billing.PaymentProviderType.GooglePlayStore)
		{
			try
			{
				if (!IsCurrencyAllowedToPurchase(currencyCode, user))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCurrency);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCurrency, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e5)
			{
				exceptionHandler(e5);
			}
		}
		if (IsUserDelayedFromCountryBlockEnabled && !string.IsNullOrEmpty(ipAddress) && paymentProviderType == Roblox.Billing.PaymentProviderType.AppleAppStore)
		{
			try
			{
				if (!IsUserFromCountryAllowedToPurchaseOnAppleAppStore(ipAddress, user))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountry);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountry, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e7)
			{
				exceptionHandler(e7);
			}
		}
		if (IsCountryCurrencyClientBlocked && !string.IsNullOrEmpty(ipAddress) && !string.IsNullOrEmpty(currencyCode))
		{
			try
			{
				if (!IsCountryCurrencyAllowed(currencyCode, ipAddress))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.CountryCurrencyBlacklisted);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.CountryCurrencyBlacklisted, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e6)
			{
				exceptionHandler(e6);
			}
		}
		if (IsUserDelayedFromCountryCurrencyBlockEnabled && !string.IsNullOrEmpty(ipAddress) && !string.IsNullOrEmpty(currencyCode))
		{
			try
			{
				if (!IsCountryCurrencyAllowedForUser(currencyCode, ipAddress, user))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountryCurrency);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserDelayedFromCountryCurrency, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e4)
			{
				exceptionHandler(e4);
			}
		}
		if (IsMobilePurchaseVelocityFilterEnabled && paymentProviderType != Roblox.Billing.PaymentProviderType.WindowsStore && paymentProviderType != Roblox.Billing.PaymentProviderType.XboxStore)
		{
			try
			{
				decimal? productUSDPrice = GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderType.ID, _USAUSDCountryCurrency.ID, productGetter(productId).Id);
				if (IsMobilePurchaseAmountVelocityExceedsLimit(Convert.ToInt32(user.AccountId), TransactionTimeWindowType.Day, productUSDPrice, productId, paymentProviderType))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserPurchaseAmountVelocityExceedsDailyLimit);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserPurchaseAmountVelocityExceedsDailyLimit, _EphemeralCounterFactory);
					IncrementEphemeralCounterForMobilePaymentProvider(paymentProviderType.Value, TransactionTimeWindowType.Day, _EphemeralCounterFactory);
					return result;
				}
				if (IsMobilePurchaseAmountVelocityExceedsLimit(Convert.ToInt32(user.AccountId), TransactionTimeWindowType.Month, productUSDPrice, productId, paymentProviderType))
				{
					result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserPurchaseAmountVelocityExceedsMonthlyLimit);
					IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserPurchaseAmountVelocityExceedsMonthlyLimit, _EphemeralCounterFactory);
					IncrementEphemeralCounterForMobilePaymentProvider(paymentProviderType.Value, TransactionTimeWindowType.Month, _EphemeralCounterFactory);
					return result;
				}
			}
			catch (Exception e2)
			{
				exceptionHandler(e2);
			}
		}
		IProduct mobileProduct;
		try
		{
			mobileProduct = productGetter(productId);
		}
		catch (ApplicationException)
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable, _EphemeralCounterFactory);
			return result;
		}
		if (mobileProduct == null)
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable, _EphemeralCounterFactory);
			return result;
		}
		if (!IsValidProductPaymentProviderType(mobileProduct, paymentProviderType))
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.ProductUnavailable, _EphemeralCounterFactory);
			return result;
		}
		if (IsUserBcMember(user))
		{
			AccountAddOn bcMembership = AccountAddOn.GetBuildersClubMembershipAccountAddOn(user.AccountId);
			if (bcMembership != null && bcMembership.IsLifetime && mobileProduct.IsRenewable)
			{
				result.AddValidationFailureReason(MobileAppProductValidationFailureReason.MembershipConflict);
				IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.MembershipConflict, _EphemeralCounterFactory);
			}
		}
		else if (BillingHelper.IsExclusiveToBuildersClub(mobileProduct) && !_PremiumFeaturesUser.IsPremiumUser(user.Id))
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.InsufficientMembership);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.InsufficientMembership, _EphemeralCounterFactory);
		}
		if (Roblox.Billing.Properties.Settings.Default.IsRobloxPremiumSubscriptionDuplicatePurchaseValidationEnabled && _PremiumFeaturesUser.IsPremiumUser(user.Id) && IsRobloxPremiumSubscriptionProduct(mobileProduct))
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserIsAlreadyPremium);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserIsAlreadyPremium, _EphemeralCounterFactory);
		}
		if (Roblox.Billing.Properties.Settings.Default.IsRobloxPremiumSubscriptionRapidPurchaseValidationEnabled)
		{
			using RedisLeasedLock redisLeasedLock = new RedisLeasedLock(string.Format(_PremiumPurchaseLeasedLockKey, user.Id), Roblox.Billing.Properties.Settings.Default.PremiumPurchaseLeasedLockDuration, _Logger.Error);
			if (!redisLeasedLock.TryAcquire())
			{
				result.AddValidationFailureReason(MobileAppProductValidationFailureReason.UserRapidSuccessionPurchase);
				IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.UserRapidSuccessionPurchase, _EphemeralCounterFactory);
			}
		}
		try
		{
			VerifyAdditionalLimits(result, ipAddress, user, mobileProduct);
		}
		catch (Exception e)
		{
			exceptionHandler?.Invoke(e);
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.Error);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.Error, _EphemeralCounterFactory);
		}
		return result;
	}

	internal virtual bool IsUserFromCountryAllowedToPurchaseOnAppleAppStore(string ipAddress, IUser user)
	{
		string countryCode = GetCountryCodeFromIP(ipAddress);
		if (string.IsNullOrEmpty(countryCode))
		{
			return true;
		}
		return !BlacklistedCountriesForAppleAppStore.Split(',').Contains(countryCode);
	}

	internal virtual bool IsUserFromCountryAllowedToPurchase(string ipAddress, IUser user)
	{
		string countryCode = GetCountryCodeFromIP(ipAddress);
		if (string.IsNullOrEmpty(countryCode))
		{
			return true;
		}
		if (!BlacklistedCountriesBasedOnUserAccountAge.Split(',').Contains(countryCode))
		{
			return true;
		}
		return !IsNewUserAccount(user, AccountLimitPeriodInDays);
	}

	internal virtual bool IsCurrencyAllowedToPurchase(string currency, IUser user)
	{
		if (!BlacklistedCurrenciesBasedOnUserAccountAge.Split(',').Contains(currency))
		{
			return true;
		}
		return !IsNewUserAccount(user, AccountLimitPeriodInDays);
	}

	internal virtual bool IsCountryCurrencyAllowed(string currencyCode, string ipAddress)
	{
		return IsCountryCurrencyAllowed(currencyCode, ipAddress, BlacklistedCountryCurrencies);
	}

	internal virtual bool IsCountryCurrencyAllowedForUser(string currencyCode, string ipAddress, IUser user, int? accountLimitPeriodInDays = null)
	{
		if (IsNewUserAccount(user, accountLimitPeriodInDays))
		{
			return IsCountryCurrencyAllowed(currencyCode, ipAddress, BlacklistedCountryCurrenciesBasedOnUserAccountAge);
		}
		return true;
	}

	/// <summary>
	/// Checks if the user account is new.
	/// </summary>
	/// <param name="user"></param>
	/// <param name="accountLimitPeriodInDays">User accounts less than this many days old are new. Defaults to the AccountLimitPeriodInDays if this value is null.</param>
	/// <returns></returns>
	private bool IsNewUserAccount(IUser user, int? accountLimitPeriodInDays = null)
	{
		TimeSpan newAccountPeriod = new TimeSpan(accountLimitPeriodInDays ?? AccountLimitPeriodInDays, 0, 0, 0);
		DateTime newAccountDate = DateTime.Now.Subtract(newAccountPeriod);
		return user.Created > newAccountDate;
	}

	private bool IsCountryCurrencyAllowed(string currencyCode, string ipAddress, string blockedCountryCurrencies)
	{
		IEnumerable<Tuple<string, string>> enumerable = blockedCountryCurrencies.Split(',').Select(delegate(string pair)
		{
			string[] array = pair.Split('|');
			return new Tuple<string, string>(array[0].Trim(), array[1].Trim());
		});
		Dictionary<string, ICollection<string>> blocked = new Dictionary<string, ICollection<string>>();
		foreach (Tuple<string, string> pair2 in enumerable)
		{
			if (!blocked.ContainsKey(pair2.Item1))
			{
				blocked[pair2.Item1] = new HashSet<string>();
			}
			blocked[pair2.Item1].Add(pair2.Item2);
		}
		string countryCode = GetCountryCodeFromIP(ipAddress);
		if (string.IsNullOrEmpty(countryCode))
		{
			return true;
		}
		if (blocked.ContainsKey(countryCode))
		{
			return !blocked[countryCode].Contains(currencyCode);
		}
		return true;
	}

	internal virtual bool IsValidProductPaymentProviderType(IProduct product, Roblox.Billing.PaymentProviderType paymentProviderType)
	{
		Product productEntity = Product.Get(product.Id);
		if (productEntity != null)
		{
			return ProductPaymentProviderType.IsValidPaymentProviderType(productEntity.ID, paymentProviderType.ID);
		}
		return false;
	}

	internal virtual bool IsUserBcMember(IUser user)
	{
		return user.IsBCMember();
	}

	internal virtual void VerifyAdditionalLimits(MobileAppProductValidationResult result, string ipAddress, IUser user, IProduct mobileProduct)
	{
		if (PaymentHelper.IsPurchaseDisabledBecauseOfMembership(mobileProduct.Id, Convert.ToInt32(user.AccountId)))
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.MembershipConflict);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.MembershipConflict, _EphemeralCounterFactory);
			return;
		}
		try
		{
			PaymentHelper.PerformPurchaseLimitCheck_NewUserAccount(Convert.ToInt32(user.AccountId), mobileProduct.Price, user.Created);
			user.CheckPurchaseLimits(ipAddress, AccountEmailAddress.GetCurrent(user.AccountId)?.GetEmailAddress().Address, mobileProduct.Price);
		}
		catch (BlockedPurchaseException)
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.PurchasingLimit);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.PurchasingLimit, _EphemeralCounterFactory);
		}
		catch (PurchaseLimitException)
		{
			result.AddValidationFailureReason(MobileAppProductValidationFailureReason.PurchasingLimit);
			IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason.PurchasingLimit, _EphemeralCounterFactory);
		}
	}

	internal virtual CountryCurrency GetUSAUSDCountryCurrency()
	{
		return CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, Roblox.Billing.Business_Logic_Layer.CurrencyType.GetUSDCurrencyTypeID);
	}

	internal virtual bool IsMobilePurchaseAmountVelocityExceedsLimit(int accountId, TransactionTimeWindowType timeWindowType, decimal? productUSDPrice, string productId, Roblox.Billing.PaymentProviderType paymentProviderType)
	{
		if (!productUSDPrice.HasValue)
		{
			throw new PlatformArgumentNullException($"Product of ID {productId} does not have USD price.");
		}
		decimal userTransactionUSDAmountInTimeWindow = GetUserTransactionAmountInUSD(accountId, timeWindowType, productUSDPrice.Value, paymentProviderType);
		decimal velocityThreshold = default(decimal);
		switch (timeWindowType)
		{
		case TransactionTimeWindowType.Day:
			velocityThreshold = (_DailyVelocityLimitByPaymentProvider.ContainsKey(paymentProviderType.ID) ? _DailyVelocityLimitByPaymentProvider[paymentProviderType.ID] : UserPurchaseAmountVelocityDailyLimit);
			break;
		case TransactionTimeWindowType.Month:
			velocityThreshold = (_MonthlyVelocityLimitByPaymentProvider.ContainsKey(paymentProviderType.ID) ? _MonthlyVelocityLimitByPaymentProvider[paymentProviderType.ID] : UserPurchaseAmountVelocityMonthlyLimit);
			break;
		}
		return userTransactionUSDAmountInTimeWindow > velocityThreshold;
	}

	private decimal GetUserTransactionAmountInUSD(int accountId, TransactionTimeWindowType timeWindowType, decimal? productUSDPrice, Roblox.Billing.PaymentProviderType paymentProviderType)
	{
		IEnumerable<Roblox.Billing.Sale> enumerable = from sale in Roblox.Billing.Sale.GetSalesByPurchaser(accountId)
			where sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Complete.ID || sale.SaleStatusTypeID == Roblox.Billing.SaleStatusType.Recurring.ID
			select sale;
		List<SaleProduct> saleProducts = new List<SaleProduct>();
		foreach (Roblox.Billing.Sale item in enumerable)
		{
			ICollection<SaleProduct> saleProductsOfOneSale = SaleProduct.GetSaleProductsBySaleID(item.ID);
			if (saleProductsOfOneSale != null)
			{
				saleProducts.AddRange(saleProductsOfOneSale);
			}
		}
		DateTime startTime = default(DateTime);
		switch (timeWindowType)
		{
		case TransactionTimeWindowType.Day:
			startTime = DateTime.Now.AddDays(-1.0);
			break;
		case TransactionTimeWindowType.Month:
			startTime = DateTime.Now.AddMonths(-1);
			break;
		}
		decimal totalUSDAmount = (productUSDPrice.HasValue ? productUSDPrice.Value : 0m);
		foreach (SaleProduct saleProduct in saleProducts)
		{
			foreach (Payment item2 in from p in Payment.GetPaymentsBySale(saleProduct.SaleID)
				where p.Updated > startTime
				select p)
			{
				byte paymentProviderId = item2.PaymentProviderTypeID;
				if (paymentProviderId == paymentProviderType.ID)
				{
					totalUSDAmount += GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderId, _USAUSDCountryCurrency.ID, saleProduct.ProductID) ?? 0m;
				}
			}
		}
		return totalUSDAmount;
	}

	internal virtual decimal? GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(byte paymentProviderTypeID, int countryCurrencyID, int productID)
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

	private static void IncrementEphemeralCounterForFailureReason(MobileAppProductValidationFailureReason reason, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (ephemeralCounterFactory == null)
		{
			throw new PlatformArgumentNullException("ephemeralCounterFactory");
		}
		string counterNameFormatString = $"{_MobileFraudReasonPrefix}{reason.ToString()}";
		ephemeralCounterFactory.GetCounter(counterNameFormatString).IncrementInBackground();
	}

	private static void IncrementEphemeralCounterForMobilePaymentProvider(string paymentProviderName, TransactionTimeWindowType timeWindowType, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		if (ephemeralCounterFactory == null)
		{
			throw new PlatformArgumentNullException("ephemeralCounterFactory");
		}
		string timeWindow = "";
		switch (timeWindowType)
		{
		case TransactionTimeWindowType.Day:
			timeWindow = "Daily";
			break;
		case TransactionTimeWindowType.Month:
			timeWindow = "Monthly";
			break;
		}
		string counterNameFormatString = $"{paymentProviderName.Replace(' ', '_')}_{timeWindow}_Velocity_Limit_Violation";
		ephemeralCounterFactory.GetCounter(counterNameFormatString).IncrementInBackground();
	}

	private Dictionary<byte, decimal> InitializeDailyVelocityLimitByPaymentProvider()
	{
		return new Dictionary<byte, decimal>
		{
			{
				Roblox.Billing.PaymentProviderType.AppleAppStore.ID,
				UserPurchaseAmountVelocityDailyLimit_AppleStore
			},
			{
				Roblox.Billing.PaymentProviderType.AmazonStore.ID,
				UserPurchaseAmountVelocityDailyLimit_AmazonStore
			},
			{
				Roblox.Billing.PaymentProviderType.GooglePlayStore.ID,
				UserPurchaseAmountVelocityDailyLimit_GooglePlayStore
			}
		};
	}

	private Dictionary<byte, decimal> InitializeMonthlyVelocityLimitByPaymentProvider()
	{
		return new Dictionary<byte, decimal>
		{
			{
				Roblox.Billing.PaymentProviderType.AppleAppStore.ID,
				UserPurchaseAmountVelocityMonthlyLimit_AppleStore
			},
			{
				Roblox.Billing.PaymentProviderType.AmazonStore.ID,
				UserPurchaseAmountVelocityMonthlyLimit_AmazonStore
			},
			{
				Roblox.Billing.PaymentProviderType.GooglePlayStore.ID,
				UserPurchaseAmountVelocityMonthlyLimit_GooglePlayStore
			}
		};
	}

	private string GetCountryCodeFromIP(string ipAddress)
	{
		int? countryId = GeolocationFactory.GetOrCreateGeolocation(ipAddress).CountryId;
		if (!countryId.HasValue)
		{
			return string.Empty;
		}
		return new CountryFactory().Get(new CountryIdentifier(countryId.Value)).Code;
	}

	private bool IsRobloxPremiumSubscriptionProduct(IProduct product)
	{
		if (!(product.Name == "Roblox Premium 450") && !(product.Name == "Roblox Premium 1000") && !(product.Name == "Roblox Premium 2200") && !(product.Name == "Roblox Premium 450 One Month") && !(product.Name == "Roblox Premium 1000 One Month"))
		{
			return product.Name == "Roblox Premium 2200 One Month";
		}
		return true;
	}
}
