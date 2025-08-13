using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Demographics;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

public class ShoppingCart : IRobloxEntity<int, ShoppingCartDAL>, ICacheableObject<int>, ICacheableObject
{
	private ShoppingCartDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.ShoppingCart", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public List<ShoppingCartProduct> Contents => (List<ShoppingCartProduct>)ShoppingCartProduct.GetShoppingCartProductsByShoppingCartID(ID);

	public decimal TotalListPrice
	{
		get
		{
			decimal price = default(decimal);
			foreach (ShoppingCartProduct prod in Contents)
			{
				price += prod.ListPrice;
			}
			return price;
		}
	}

	public decimal TotalPrice
	{
		get
		{
			decimal price = default(decimal);
			foreach (ShoppingCartProduct prod in Contents)
			{
				price += prod.Price;
			}
			return price;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ShoppingCart()
	{
		_EntityDAL = new ShoppingCartDAL();
	}

	private static ShoppingCart _GetOrCreateBrowserTrackerShoppingCart(long browserTrackerId)
	{
		if (browserTrackerId == 0L)
		{
			throw new ApplicationException("Browser Tracker ID required to retrieve Guest Shopping Cart");
		}
		BrowserTrackerShoppingCart browserShoppingCart = BrowserTrackerShoppingCart.GetByBrowserTrackerID(browserTrackerId);
		ShoppingCart shoppingCart;
		if (browserShoppingCart != null)
		{
			shoppingCart = Get(browserShoppingCart.ShoppingCartID);
		}
		else
		{
			shoppingCart = CreateNew();
			BrowserTrackerShoppingCart.CreateNew(browserTrackerId, shoppingCart.ID);
		}
		return shoppingCart;
	}

	private static ShoppingCart _GetOrCreateAccountShoppingCart(long accountId)
	{
		AccountShoppingCart accountShoppingCart = AccountShoppingCart.GetByAccountID(accountId);
		ShoppingCart shoppingCart;
		if (accountShoppingCart != null)
		{
			shoppingCart = Get(accountShoppingCart.ShoppingCartID);
		}
		else
		{
			shoppingCart = CreateNew();
			AccountShoppingCart.CreateNew(accountId, shoppingCart.ID);
		}
		return shoppingCart;
	}

	public static ShoppingCart RetrieveCart(long accountId)
	{
		return RetrieveCart(accountId, 0L);
	}

	public static ShoppingCart RetrieveCart(long? accountId, long browserTrackerId)
	{
		if (Settings.Default.GuestShoppingCartEnabled)
		{
			return (!accountId.HasValue) ? _GetOrCreateBrowserTrackerShoppingCart(browserTrackerId) : _GetOrCreateAccountShoppingCart(accountId.Value);
		}
		if (!accountId.HasValue)
		{
			throw new ApplicationException("Guest Shopping Cart is not enabled.");
		}
		return _GetOrCreateAccountShoppingCart(accountId.Value);
	}

	/// <summary>
	/// Creates a sale and saleproducts in a pending state, ready to pass to a payment provider
	/// if no bool is provided, default behaviour runs purchase limit check
	/// </summary>
	/// <returns></returns>
	public Sale CheckOut(byte platformTypeId, bool performPurchaseLimitCheck = true, byte? currencyTypeId = null)
	{
		if (!currencyTypeId.HasValue)
		{
			currencyTypeId = CurrencyType.GetUSDCurrencyTypeID;
		}
		if (Contents.Count == 0)
		{
			throw new ApplicationException("Your cart is empty.");
		}
		long? saleAccountId = null;
		AccountShoppingCart accountShoppingCart = AccountShoppingCart.GetByShoppingCartID(ID);
		if (accountShoppingCart != null)
		{
			saleAccountId = accountShoppingCart.AccountID;
		}
		if (!BillingHelper.UseTestMode && saleAccountId.HasValue)
		{
			if (performPurchaseLimitCheck)
			{
				PaymentHelper.PerformPurchaseLimitCheck_UserAccount(saleAccountId.Value, TotalPrice);
			}
			PaymentHelper.PerformDoublePurchaseCheck_UserAccount(saleAccountId.Value, Contents);
		}
		Sale sale = Sale.CreateNew(SaleStatusType.Pending.ID, saleAccountId, TotalListPrice, TotalPrice, null, null, platformTypeId, currencyTypeId);
		decimal recurringPrice = default(decimal);
		foreach (ShoppingCartProduct product in Contents)
		{
			try
			{
				EnforceLifetimeMembershipPurchaseRules(product.Product);
			}
			catch (ApplicationException ex)
			{
				sale.SaleStatusTypeID = SaleStatusType.Error.ID;
				sale.Save();
				throw ex;
			}
			if (GiftCard.IsGiftCardProduct(product))
			{
				GiftCard giftCard = GiftCard.GetByShoppingCartProductID(product.ID);
				SaleProduct saleProduct = SaleProduct.CreateNew(sale.ID, product.ProductID, giftCard.Value, giftCard.Value, saleAccountId, currencyTypeId);
				giftCard.SaleProductID = saleProduct.ID;
				giftCard.Save();
			}
			else if (product.RenewalPeriodTypeID.HasValue)
			{
				SaleProduct.CreateRecurring(sale.ID, product.ProductID, product.ListPrice, product.Price, saleAccountId, product.ListPrice, currencyTypeId);
				recurringPrice += product.ListPrice;
			}
			else
			{
				SaleProduct.CreateNew(sale.ID, product.ProductID, product.ListPrice, product.Price, saleAccountId, currencyTypeId);
			}
		}
		if (recurringPrice > 0m)
		{
			sale.RecurringPrice = recurringPrice;
			sale.Save();
		}
		return sale;
	}

	/// <summary>
	/// Shopping cart check out, which creates a sale object.
	/// </summary>
	/// <param name="countryId">Country ID to determine country currency</param>
	/// <param name="paymentProviderTypeID">Payment provider ID used to determine product list price as well as </param>
	/// <param name="platformTypeId">Used when creating a sale</param>
	/// <param name="performPurchaseLimitCheck">Optional Parameter to determine wether to perform purchase limit check, defaut to true</param>
	/// <param name="currencyTypeId">Optional parameter, if nothing returns by country id, currencyTypeId will be used to determine country currency.</param>
	/// <param name="isCountryCurrencyFallbackToUSD">Optional parameter used only when checking out with PayPal, indicating whether currency has been adjusted to PayPal supported one</param>
	/// <returns>Sale object</returns>
	internal Sale CheckOut(byte countryId, byte paymentProviderTypeID, byte platformTypeId, bool performPurchaseLimitCheck = true, byte? currencyTypeId = null, bool isCountryCurrencyFallbackToUSD = false)
	{
		if (Contents.Count == 0)
		{
			throw new ApplicationException("Your cart is empty.");
		}
		ICollection<CountryCurrency> countryCurrencyList = CountryCurrency.GetCountryCurrenciesByCountryID_Paged(0, 1, countryId);
		CountryCurrency countryCurrency;
		if (countryCurrencyList.Any())
		{
			countryCurrency = countryCurrencyList.First();
			currencyTypeId = countryCurrency.CurrencyTypeID;
		}
		else
		{
			currencyTypeId = currencyTypeId ?? CurrencyType.GetUSDCurrencyTypeID;
			countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(countryId, currencyTypeId.Value);
		}
		long? saleAccountId = null;
		AccountShoppingCart accountShoppingCart = AccountShoppingCart.GetByShoppingCartID(ID);
		if (accountShoppingCart != null)
		{
			saleAccountId = accountShoppingCart.AccountID;
		}
		decimal? totalPriceInUSD = GetTotalPriceInUSDByPaymentProviderTypeId(paymentProviderTypeID);
		if (!BillingHelper.UseTestMode && saleAccountId.HasValue)
		{
			if (performPurchaseLimitCheck)
			{
				PaymentHelper.PerformPurchaseLimitCheck_UserAccount(saleAccountId.Value, totalPriceInUSD ?? TotalPrice);
			}
			PaymentHelper.PerformDoublePurchaseCheck_UserAccount(saleAccountId.Value, Contents);
		}
		decimal totalPrice = TotalPrice;
		if (isCountryCurrencyFallbackToUSD && paymentProviderTypeID == PaymentProviderType.Paypal.ID && totalPriceInUSD.HasValue)
		{
			totalPrice = totalPriceInUSD.Value;
		}
		Sale sale = Sale.CreateNew(SaleStatusType.Pending.ID, saleAccountId, TotalListPriceWithNewPricesTable(paymentProviderTypeID, countryCurrency.ID), totalPrice, null, null, platformTypeId, currencyTypeId);
		decimal recurringPrice = default(decimal);
		foreach (ShoppingCartProduct product in Contents)
		{
			try
			{
				EnforceLifetimeMembershipPurchaseRules(product.Product);
			}
			catch (ApplicationException ex)
			{
				sale.SaleStatusTypeID = SaleStatusType.Error.ID;
				sale.Save();
				throw ex;
			}
			if (GiftCard.IsGiftCardProduct(product))
			{
				GiftCard giftCard = GiftCard.GetByShoppingCartProductID(product.ID);
				SaleProduct saleProduct = SaleProduct.CreateNew(sale.ID, product.ProductID, giftCard.Value, giftCard.Value, saleAccountId, currencyTypeId);
				giftCard.SaleProductID = saleProduct.ID;
				giftCard.Save();
				continue;
			}
			decimal? listPrice = BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderTypeID, countryCurrency.ID, product.ProductID);
			if (!listPrice.HasValue)
			{
				throw new ApplicationException($"Product {product.Product.Name} is not for sale in your country through {PaymentProviderType.Get(paymentProviderTypeID).Value}.");
			}
			if (product.RenewalPeriodTypeID.HasValue)
			{
				SaleProduct.CreateRecurring(sale.ID, product.ProductID, listPrice.Value, product.Price, saleAccountId, listPrice, currencyTypeId);
				recurringPrice += listPrice.Value;
			}
			else
			{
				SaleProduct.CreateNew(sale.ID, product.ProductID, listPrice.Value, product.Price, saleAccountId, currencyTypeId);
			}
		}
		if (recurringPrice > 0m)
		{
			sale.RecurringPrice = recurringPrice;
			sale.Save();
		}
		return sale;
	}

	private decimal TotalListPriceWithNewPricesTable(byte paymentProviderTypeID, int countryCurrencyId)
	{
		decimal price = default(decimal);
		decimal? productPrice = null;
		foreach (ShoppingCartProduct prod in Contents)
		{
			productPrice = BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderTypeID, countryCurrencyId, prod.ProductID);
			if (!productPrice.HasValue)
			{
				throw new ApplicationException($"Product {prod.Product.Name} is not for sale in country currency id {countryCurrencyId} through Payment provider Typeid {paymentProviderTypeID}.");
			}
			price += productPrice.Value;
		}
		return price;
	}

	public decimal? GetTotalPriceInUSDByPaymentProviderTypeId(byte paymentProviderId)
	{
		int usdCountryCurrencyId = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID).ID;
		if (Contents != null)
		{
			return Contents.Sum((ShoppingCartProduct product) => BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderId, usdCountryCurrencyId, product.ProductID));
		}
		return default(decimal);
	}

	public ShoppingCartProduct AddToCart(int productId, decimal price, byte? currencyTypeId = null)
	{
		Product product = Product.Get(productId);
		currencyTypeId = currencyTypeId ?? CurrencyType.GetUSDCurrencyTypeID;
		EnforceLifetimeMembershipPurchaseRules(product);
		long? accountId = AccountShoppingCart.GetByShoppingCartID(ID)?.AccountID;
		return ShoppingCartProduct.CreateNew(ID, product.ID, accountId, price, currencyTypeId);
	}

	private void EnforceLifetimeMembershipPurchaseRules(Product product)
	{
		AccountShoppingCart accountShoppingCart = AccountShoppingCart.GetByShoppingCartID(ID);
		if (accountShoppingCart == null)
		{
			return;
		}
		AccountAddOn BCMembership = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountShoppingCart.AccountID);
		if (BCMembership != null && BCMembership.IsLifetime && product.ProductGroupID == ProductGroup.BC.ID && !(BCMembership.Expiration < DateTime.Now))
		{
			if (BCMembership.PremiumFeatureID == PremiumFeature.BCLifetime.ID && product.PremiumFeatureID != PremiumFeature.TBCLifetime.ID && product.PremiumFeatureID != PremiumFeature.OBCLifetime.ID)
			{
				throw new ApplicationException("User attempted to purchase an item which is invalid for their account.");
			}
			if (BCMembership.PremiumFeatureID == PremiumFeature.TBCLifetime.ID && product.PremiumFeatureID != PremiumFeature.OBCLifetime.ID)
			{
				throw new ApplicationException("User attempted to purchase an item which is invalid for their account.");
			}
			if (BCMembership.PremiumFeatureID == PremiumFeature.OBCLifetime.ID)
			{
				throw new ApplicationException("User attempted to purchase an item which is invalid for their account.");
			}
		}
	}

	public void RemoveAll()
	{
		foreach (ShoppingCartProduct content in Contents)
		{
			content.RemoveFromCart();
		}
	}

	public static ShoppingCart Get(int id)
	{
		return EntityHelper.DoGet<int, ShoppingCartDAL, ShoppingCart>(() => ShoppingCartDAL.Get(id), id);
	}

	public static ShoppingCart CreateNew()
	{
		ShoppingCart shoppingCart = new ShoppingCart();
		shoppingCart.Save();
		return shoppingCart;
	}

	public static ShoppingCart CreateNew(long accountId)
	{
		ShoppingCart shoppingCart = new ShoppingCart();
		shoppingCart.Save();
		return shoppingCart;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Construct(ShoppingCartDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
