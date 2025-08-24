using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Exceptions;
using Roblox.Billing.Metrics;
using Roblox.Billing.Properties;
using Roblox.Demographics;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

internal abstract class AppStorePaymentProviderBase
{
	protected const int InformationLogLevel = 1;

	protected const int WarningLogLevel = 2;

	private readonly ICountryFactory _CountryFactory = new CountryFactory();

	private readonly IUserFactory _UserFactory = new UserFactory();

	private bool IsLocalPricingEnabled => Settings.Default.IsLocalPricingEnabled;

	private string MobileLocalPricingSupportedCurrencies => Settings.Default.MobileLocalPricingSupportedCurrencies;

	private bool IsBillingTransactionEventForAppPaymentEnabled => Settings.Default.BillingTransactionEventForAppPaymentEnabled;

	protected abstract PaymentProviderType _PaymentProviderType { get; }

	public byte Id => _PaymentProviderType.ID;

	public string Name => _PaymentProviderType.Value;

	protected virtual void LogPurchaseAttempt(bool isRetry)
	{
	}

	protected virtual void LogPurchaseSuccess(bool isRetry)
	{
	}

	protected virtual void LogPurchaseError(bool isRetry)
	{
	}

	protected void AwardProducts(Sale sale)
	{
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(sale.Products);
	}

	protected void CheckPurchaseEligibility(IPurchase purchase)
	{
		foreach (IPurchaseProduct purchaseProduct in purchase.PurchaseProducts)
		{
			IProduct product = purchaseProduct.Product;
			if (!IsSupported(product))
			{
				throw new ApplicationException("Product " + product.Name + " is not supported by PaymentProvider " + Name);
			}
		}
	}

	protected void CheckPurchaseWellformedness(IPurchase purchase)
	{
		if (!purchase.PurchaseProducts.Any())
		{
			throw new ApplicationException("No items purchased.");
		}
	}

	protected bool ContainsBCProducts(IPurchase purchase)
	{
		return purchase.PurchaseProducts.Where((IPurchaseProduct x) => x.Product.ProductGroup.Id == ProductGroup.BC.ID).Any();
	}

	protected Payment CreatePayment(Sale sale, bool isPending = false)
	{
		byte statusTypeId = (isPending ? PaymentStatusType.Pending.ID : ((sale.SaleStatusTypeID == SaleStatusType.Complete.ID) ? PaymentStatusType.Complete.ID : PaymentStatusType.Error.ID));
		return Payment.CreateNew(sale.ID, Id, statusTypeId, DateTime.Now, sale.DiscountedPriceTotal, sale.CurrencyTypeID);
	}

	protected Sale CreateSale(IPurchaser purchaser, IPurchase purchase, byte platformTypeId, bool isPending = false, IBillingStatisticsTracker billingStatisticsTracker = null, IUserFactory userFactory = null, CountryCurrency countryCurrency = null)
	{
		decimal listPriceTotal = default(decimal);
		decimal discountedPriceTotal = default(decimal);
		IEnumerable<IPurchaseProduct> purchaseProducts = new List<IPurchaseProduct>();
		byte saleStatusTypeId = SaleStatusType.Error.ID;
		if (purchase != null)
		{
			saleStatusTypeId = (isPending ? SaleStatusType.Pending.ID : SaleStatusType.Complete.ID);
			purchaseProducts = purchase.PurchaseProducts;
		}
		foreach (IPurchaseProduct purchaseProduct2 in purchaseProducts)
		{
			IProduct product2 = purchaseProduct2.Product;
			listPriceTotal += product2.Price;
			discountedPriceTotal += purchaseProduct2.DiscountedPrice;
		}
		HashSet<string> mobileEnabledCurrencies = new HashSet<string>(MobileLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
		if (IsLocalPricingEnabled && (mobileEnabledCurrencies.Any() || countryCurrency != null))
		{
			try
			{
				IAccountCountry accountCountry = AccountCountryAccessorFactory.GetAccountCountryAccessor(userFactory ?? _UserFactory).GetAccountCountry(purchaser.Id);
				if (accountCountry?.CountryId != null && countryCurrency == null)
				{
					ICollection<CountryCurrency> countryCurrenciesByCountryID_Paged = CountryCurrency.GetCountryCurrenciesByCountryID_Paged(0, 1, accountCountry.CountryId.Id);
					HashSet<byte> enabledCurrencyTypeIds = new HashSet<byte>(from ct in CurrencyType.GetAllCurrencyTypes()
						where mobileEnabledCurrencies.Contains(ct.Code)
						select ct.ID);
					countryCurrency = countryCurrenciesByCountryID_Paged?.FirstOrDefault((CountryCurrency cc) => enabledCurrencyTypeIds.Contains(cc.CurrencyTypeID));
				}
				if (billingStatisticsTracker != null && accountCountry?.CountryId != null)
				{
					ICountry country = _CountryFactory.Get(accountCountry.CountryId.Id);
					billingStatisticsTracker.OnPurchase(country, _PaymentProviderType);
				}
			}
			catch (Exception)
			{
				countryCurrency = null;
			}
		}
		Sale saleEntity = Sale.CreateNew(saleStatusTypeId, purchaser.Id, listPriceTotal, discountedPriceTotal, null, null, platformTypeId, countryCurrency?.CurrencyTypeID);
		foreach (IPurchaseProduct purchaseProduct in purchaseProducts)
		{
			IProduct product = purchaseProduct.Product;
			SaleProduct.CreateNew(saleEntity.ID, product.Id, product.Price, purchaseProduct.DiscountedPrice, purchaser.Id, countryCurrency?.CurrencyTypeID);
		}
		return saleEntity;
	}

	/// <summary>
	/// Determines whether or not a current payment status matches an existing payment status.
	/// </summary>
	/// <param name="isCurrentPaymentSuccessful">Whether or not the current payment was successful.</param>
	/// <param name="existingPaymentStatusTypeId">The ID of the existing payment's PaymentStatusType.</param>
	/// <returns>Whether or not the current payment status matches the existing payment status.</returns>
	protected bool HasDuplicateStatusRecord(bool isCurrentPaymentSuccessful, byte existingPaymentStatusTypeId)
	{
		if (isCurrentPaymentSuccessful)
		{
			if (existingPaymentStatusTypeId != PaymentStatusType.Complete.ID && existingPaymentStatusTypeId != PaymentStatusType.ChargedBack.ID)
			{
				return existingPaymentStatusTypeId == PaymentStatusType.Refunded.ID;
			}
			return true;
		}
		if (existingPaymentStatusTypeId != PaymentStatusType.Blocked.ID && existingPaymentStatusTypeId != PaymentStatusType.Error.ID)
		{
			return existingPaymentStatusTypeId == PaymentStatusType.Pending.ID;
		}
		return true;
	}

	protected bool IsPurchasersFirstBC(IPurchaser purchaser)
	{
		foreach (Sale item in Sale.GetSalesByPurchaserAndStatus(purchaser.Id, SaleStatusType.Complete.ID))
		{
			if (item.Products.Where((SaleProduct saleProduct) => saleProduct.Product.ProductGroupID == ProductGroup.BC.ID).Any())
			{
				return false;
			}
		}
		foreach (Sale item2 in Sale.GetSalesByPurchaserAndStatus(purchaser.Id, SaleStatusType.Cancelled.ID))
		{
			if (item2.Products.Where((SaleProduct saleProduct) => saleProduct.Product.ProductGroupID == ProductGroup.BC.ID).Any())
			{
				return false;
			}
		}
		return true;
	}

	private Sale LogTransaction(IPurchaser purchaser, IPurchase purchase, byte platformTypeId, Action<Payment> logPaymentForPaymentProvider, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IBillingStatisticsTracker billingStatisticsTracker = null, IUserFactory userFactory = null, CountryCurrency countryCurrency = null)
	{
		Sale sale = CreateSale(purchaser, purchase, platformTypeId, isPending: false, billingStatisticsTracker, userFactory, countryCurrency);
		saleLogger(sale.ID, 1, "Sale entry was created");
		Payment payment = CreatePayment(sale);
		paymentLogger(payment.ID, 1, "Payment entry was created.");
		logPaymentForPaymentProvider(payment);
		return sale;
	}

	protected Sale FinalizeAndLogTransaction(Sale pendingSale, Payment pendingPayment, bool wasSuccessful, ILogger logger = null)
	{
		pendingSale.SaleStatusTypeID = (wasSuccessful ? SaleStatusType.Complete.ID : SaleStatusType.Error.ID);
		pendingSale.Save();
		pendingPayment.PaymentStatusTypeID = (wasSuccessful ? PaymentStatusType.Complete.ID : PaymentStatusType.Error.ID);
		pendingPayment.Save();
		if (IsBillingTransactionEventForAppPaymentEnabled)
		{
			PaymentProviderBase.TryToPublishBillingTransactionEvent(pendingSale, logger);
		}
		return pendingSale;
	}

	public bool IsSupported(IProduct product)
	{
		return ProductPaymentProviderType.IsValidPaymentProviderType(product.Id, Id);
	}

	protected IPurchase AddFirstTimeBcBonusIfNeeded(IPurchase purchase, IPurchaser purchaser)
	{
		bool num = ContainsBCProducts(purchase);
		bool isPurchasersFirstBC = IsPurchasersFirstBC(purchaser);
		if (num && isPurchasersFirstBC)
		{
			IProduct robuxBonus = ProductFactory.Singleton.GetProduct("100 ROBUX");
			IPurchaseProduct robuxBonusPurchaseProduct = PurchaseProductFactory.Singleton.GetPurchaseProduct(robuxBonus, 1, 0m);
			List<IPurchaseProduct> enhancedPurchaseProducts = new List<IPurchaseProduct>();
			enhancedPurchaseProducts.AddRange(purchase.PurchaseProducts);
			enhancedPurchaseProducts.Add(robuxBonusPurchaseProduct);
			return PurchaseFactory.Singleton.GetPurchase(enhancedPurchaseProducts);
		}
		return purchase;
	}

	public void Process(IPurchaser purchaser, byte platformTypeId, bool isRetry, Func<IPurchase> verifyAndGetPurchase, Func<bool> isPurchaseDuplicate, Action<string, int> checkoutSessionLogger, Action<Payment> logPaymentForPaymentProvider, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSaleAction, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IBillingStatisticsTracker billingStatisticsTracker = null, IUserFactory userFactory = null, ILogger logger = null, Func<IPurchase, CountryCurrency> getCountryCurrency = null)
	{
		if (!Settings.Default.EnableInAppPurchases)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.Technical.ID, "InApp Purchase Disabled");
		}
		LogPurchaseAttempt(isRetry);
		IPurchase purchase = null;
		Sale sale = null;
		bool debounce = false;
		try
		{
			purchase = verifyAndGetPurchase();
			if (Settings.Default.IsBCSigningBonusEnabledForMobile)
			{
				purchase = AddFirstTimeBcBonusIfNeeded(purchase, purchaser);
			}
			CheckPurchaseWellformedness(purchase);
			CheckPurchaseEligibility(purchase);
		}
		catch (Exception ex2)
		{
			checkoutSessionLogger($"Failed to verify and get purchase for purchaser ID = {purchaser.Id}. Exception message = {ex2.Message}", 2);
			throw;
		}
		finally
		{
			try
			{
				debounce = isPurchaseDuplicate();
				if (!debounce)
				{
					CountryCurrency countryCurrency = getCountryCurrency?.Invoke(purchase);
					sale = LogTransaction(purchaser, purchase, platformTypeId, logPaymentForPaymentProvider, saleLogger, paymentLogger, billingStatisticsTracker, userFactory, countryCurrency);
					if (IsBillingTransactionEventForAppPaymentEnabled)
					{
						PaymentProviderBase.TryToPublishBillingTransactionEvent(sale, logger);
					}
				}
			}
			catch (Exception ex)
			{
				if (sale != null)
				{
					saleLogger(sale.ID, 3, "Failed to log sale transaction");
				}
				checkoutSessionLogger($"Failed to log sale transaction - AccountID: {purchaser.Id}. Exception message = {ex.Message}", 2);
				throw;
			}
		}
		if (debounce)
		{
			checkoutSessionLogger($"Debounce is true and process return here - AccountID: {purchaser.Id}.", 2);
			return;
		}
		if (Settings.Default.IsEmptySaleProductCheckEnabled && (sale.Products == null || !sale.Products.Any()))
		{
			List<IPurchaseProduct> purchaseProducts = purchase?.PurchaseProducts?.Where((IPurchaseProduct p) => p?.Product != null).ToList();
			string message = ((purchaseProducts != null && purchaseProducts.Any()) ? string.Format("Sale Products were not created for purchase products {0}", string.Join(", ", purchaseProducts.Select((IPurchaseProduct pp) => pp.Product.Id))) : "Sale Products were not created and purchase products were not found");
			sale.SaleStatusTypeID = SaleStatusType.Error.ID;
			sale.Save();
			saleLogger(sale.ID, 3, message);
			Payment payment = sale.Payments.FirstOrDefault();
			if (payment != null)
			{
				payment.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				payment.Save();
				paymentLogger(payment.ID, 3, $"Payment failed as Sale products were unable to be found: {message}");
			}
			throw new SaleProductsNotFoundException(message);
		}
		LogPurchaseSuccess(isRetry);
		AwardProducts(sale);
		if (sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			if (Settings.Default.IsBillingV2FindAndCancelPurchasesEnabled)
			{
				cancelExistingActiveMembershipSaleAction(sale.ID);
			}
			else
			{
				PayPalHelper.CancelPreviousRecurringPaymentOnUpgrade(sale);
			}
		}
	}

	protected void ProcessInLeasedLock(IPurchaser purchaser, byte platformTypeId, bool isRetry, Func<IPurchase> verifyAndGetPurchase, Func<bool> isPurchaseDuplicate, Action<Payment> logPaymentForPaymentProvider, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSaleAction, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, Action<string, int> checkoutSessionLogger, string leaseLockKey, int leaseDurationInMilliseconds, IBillingStatisticsTracker billingStatisticsTracker = null, IUserFactory userFactory = null, ILogger logger = null, Func<IPurchase, CountryCurrency> getCountryCurrency = null)
	{
		LeasedLock leasedLock = LeasedLock.GetOrCreate(leaseLockKey);
		Guid parallelTaskWorkerId = ParallelTaskWorker.ID;
		try
		{
			if (leasedLock.TryAcquire(parallelTaskWorkerId, leaseDurationInMilliseconds))
			{
				checkoutSessionLogger($"Successfully acquired lock for {leaseLockKey}", 1);
				Process(purchaser, platformTypeId, isRetry, verifyAndGetPurchase, isPurchaseDuplicate, checkoutSessionLogger, logPaymentForPaymentProvider, cancelExistingActiveMembershipSaleAction, saleLogger, paymentLogger, billingStatisticsTracker, userFactory, logger, getCountryCurrency);
				return;
			}
			throw new Exception($"LeasedLock already acquired for {leaseLockKey}");
		}
		finally
		{
			leasedLock.TryRelease(parallelTaskWorkerId);
		}
	}

	/// <summary>
	/// Gets the country currency for a purchaser if it exists in a list of enabled currencies
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="isProviderLocalPricingEnabled"></param>
	/// <param name="providerLocalPricingSupportedCurrencies"></param>
	protected CountryCurrency GetCountryCurrencyForPurchaser(long accountId, bool isProviderLocalPricingEnabled, string providerLocalPricingSupportedCurrencies)
	{
		CountryCurrency countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		HashSet<string> mobileEnabledCurrencies = new HashSet<string>(MobileLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
		HashSet<string> providerEnabledCurrencies = new HashSet<string>(providerLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
		if (IsLocalPricingEnabled && isProviderLocalPricingEnabled && providerEnabledCurrencies.Any())
		{
			countryCurrency = GetCountryCurrencyForPurchaser(accountId, providerEnabledCurrencies, _UserFactory);
		}
		else if (IsLocalPricingEnabled && mobileEnabledCurrencies.Any())
		{
			countryCurrency = GetCountryCurrencyForPurchaser(accountId, mobileEnabledCurrencies, _UserFactory);
		}
		return countryCurrency;
	}

	/// <summary>
	/// Gets the country currency for a purchaser if it exists in a list of enabled currencies
	/// </summary>
	/// <param name="purchaserId"></param>
	/// <param name="localPricingEnabledCurrencies"></param>
	/// <param name="userFactory"></param>
	/// <returns></returns>
	protected CountryCurrency GetCountryCurrencyForPurchaser(long purchaserId, HashSet<string> localPricingEnabledCurrencies, IUserFactory userFactory)
	{
		CountryCurrency countryCurrency = null;
		IAccountCountry accountCountry = AccountCountryAccessorFactory.GetAccountCountryAccessor(userFactory).GetAccountCountry(purchaserId);
		if (accountCountry?.CountryId != null)
		{
			int maxRows = 1;
			ICollection<CountryCurrency> countryCurrenciesByCountryID_Paged = CountryCurrency.GetCountryCurrenciesByCountryID_Paged(0, maxRows, accountCountry.CountryId.Id);
			HashSet<byte> enabledCurrencyTypeIds = new HashSet<byte>(from ct in CurrencyType.GetAllCurrencyTypes()
				where localPricingEnabledCurrencies.Contains(ct.Code)
				select ct.ID);
			countryCurrency = countryCurrenciesByCountryID_Paged?.FirstOrDefault((CountryCurrency cc) => enabledCurrencyTypeIds.Contains(cc.CurrencyTypeID));
		}
		return countryCurrency ?? CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
	}

	/// <summary>
	/// Determines whether the purchase is valid for the payment provider, country, and currency combibnation.
	/// Note that US-USD is the default <see cref="T:Roblox.Billing.CountryCurrency" /> and is a valid localization.
	/// </summary>
	/// <param name="purchase"></param>
	/// <param name="paymentProviderType"></param>
	/// <param name="countryCurrency"></param>
	/// <returns></returns>
	protected bool IsLocalizedPurchase(IPurchase purchase, PaymentProviderType paymentProviderType, CountryCurrency countryCurrency)
	{
		try
		{
			foreach (IPurchaseProduct purchaseProduct in purchase.PurchaseProducts)
			{
				if (ProductPrice.GetByProductPaymentProviderTypeIDAndCountryCurrencyID((ProductPaymentProviderType.GetByProductIDAndPaymentProviderTypeID(purchaseProduct.Product.Id, paymentProviderType.ID) ?? throw new ApplicationException("Product " + purchaseProduct.Product.Name + " is not for sale by payment provider " + paymentProviderType.Value)).ID, countryCurrency.ID) == null)
				{
					return false;
				}
			}
		}
		catch
		{
			return false;
		}
		return true;
	}
}
