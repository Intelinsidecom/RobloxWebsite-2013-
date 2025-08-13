using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class Sale : IRobloxEntity<int, SaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private SaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "BillingSale", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public byte SaleStatusTypeID
	{
		get
		{
			return _EntityDAL.SaleStatusTypeID;
		}
		set
		{
			_EntityDAL.SaleStatusTypeID = value;
		}
	}

	public long? PurchaserAccountID
	{
		get
		{
			return _EntityDAL.PurchaserAccountID;
		}
		set
		{
			_EntityDAL.PurchaserAccountID = value;
		}
	}

	public decimal ListPriceTotal
	{
		get
		{
			return _EntityDAL.ListPriceTotal;
		}
		set
		{
			_EntityDAL.ListPriceTotal = value;
		}
	}

	public decimal DiscountedPriceTotal
	{
		get
		{
			return _EntityDAL.DiscountedPriceTotal;
		}
		set
		{
			_EntityDAL.DiscountedPriceTotal = value;
		}
	}

	public decimal? RecurringPrice
	{
		get
		{
			return _EntityDAL.RecurringPrice;
		}
		set
		{
			_EntityDAL.RecurringPrice = value;
		}
	}

	public DateTime? RenewalDate
	{
		get
		{
			return _EntityDAL.RenewalDate;
		}
		set
		{
			_EntityDAL.RenewalDate = value;
		}
	}

	public byte? CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public List<Payment> Payments => (List<Payment>)Payment.GetPaymentsBySale(ID);

	public ICollection<SaleProduct> Products => SaleProduct.GetSaleProductsBySaleID(ID);

	public byte RenewalPeriodTypeID
	{
		get
		{
			if (RecurringPrice.HasValue)
			{
				return Products.Where((SaleProduct x) => x.Product.IsRenewable).First().Product.RenewalPeriodTypeID.Value;
			}
			return 0;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Sale()
	{
		_EntityDAL = new SaleDAL();
	}

	public Sale(SaleDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	private static Sale DoGet(int id)
	{
		return EntityHelper.DoGet<int, SaleDAL, Sale>(() => SaleDAL.Get(id), id);
	}

	public static Sale Get(int id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static ICollection<Sale> GetSalesByPurchaser(long purchaserId)
	{
		string collectionId = $"GetSalesByPurchaser_PurchaserID:{purchaserId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserAccountID:{purchaserId}"), collectionId, () => SaleDAL.GetSaleIDsByPurchaserAccountID(purchaserId), Get);
	}

	public static ICollection<Sale> GetSalesByPurchaserAndStatus(long purchaserId, byte saleStatusTypeId)
	{
		string collectionId = $"GetSalesByPurchaserAndStatus_PurchaserID:{purchaserId}_SaleStatusTypeID:{saleStatusTypeId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserAccountID:{purchaserId}_SaleStatusTypeID:{saleStatusTypeId}"), collectionId, () => SaleDAL.GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID(purchaserId, saleStatusTypeId), Get);
	}

	public static ICollection<Sale> GetSalesByPurchaserAndStatus_Paged(long? purchaserId, byte saleStatusTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetSalesByPurchaserAndStatus_Paged_PurchaserID:{purchaserId}_SaleStatusTypeID:{saleStatusTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserAccountID:{purchaserId}_SaleStatusTypeID:{saleStatusTypeId}"), collectionId, () => SaleDAL.GetSaleIDsByPurchaserAccountIDAndSaleStatusTypeID_Paged(purchaserId, saleStatusTypeId, startRowIndex + 1, maximumRows), Get);
	}

	internal static int GetTotalNumberOfSalesBySaleStatusTypeIdAndPurchaserAccountId(byte saleStatusTypeID, long? purchaserAccountID)
	{
		string countId = $"GetTotalNumberOfSalesBySaleStatusTypeIdAndPurchaserAccountId_SaleStatusTypeID:{saleStatusTypeID}_PurchaserAccountID:{purchaserAccountID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleStatusTypeIDPurchaserAccountID(saleStatusTypeID, purchaserAccountID)), countId, () => SaleDAL.GetTotalNumberOfSalesBySaleStatusTypeIDAndPurchaserAccountID(saleStatusTypeID, purchaserAccountID));
	}

	public static Sale CreateNew(byte saleStatusTypeID, long? purchaserAccountID, decimal listPriceTotal, decimal discountedPriceTotal, decimal? recurringPrice, DateTime? renewalDate, byte? platformTypeId, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		Sale entity = new Sale
		{
			SaleStatusTypeID = saleStatusTypeID,
			PurchaserAccountID = purchaserAccountID,
			ListPriceTotal = listPriceTotal,
			DiscountedPriceTotal = discountedPriceTotal,
			RecurringPrice = recurringPrice,
			RenewalDate = renewalDate,
			CurrencyTypeID = currencyTypeID
		};
		entity.Save();
		if (platformTypeId.HasValue)
		{
			PlatformSale.Log(entity.ID, platformTypeId.Value);
		}
		return entity;
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

	public string GenerateComment1Field(string username)
	{
		string productData = "";
		string productNames = "";
		foreach (SaleProduct product in Products)
		{
			productData += $"{product.ProductID}-{product.DiscountedPrice:#.##},";
			productNames = productNames + product.Product.Name + ",";
		}
		productData = productData.TrimEnd(',');
		productNames = productNames.TrimEnd(',');
		bool isCombo = Products.Count((SaleProduct a) => a.DiscountedPrice > 0m) > 1;
		ICollection<GiftCard> giftCards = GiftCard.GetGiftCardsForSale(ID);
		string purchaseCategory = ((giftCards != null && giftCards.Count > 0) ? "gift" : ((!isCombo) ? "normal" : "combo"));
		return $"[{purchaseCategory}]  {username},SaleID={ID},ProductData=[{productData}],ProductNames=[{productNames}]";
	}

	/// <summary>
	/// Retrieves an active, recurring sale containing at least 1 recurring product of the specified productGroupID 
	/// </summary>
	public static Sale GetMostRecentRecurringSaleForAccount(long accountId, byte? recurringProductGroupId = null)
	{
		foreach (Sale sale in GetRecurringSalesForAccount(accountId))
		{
			if (SaleProduct.GetSaleProductsBySaleID(sale.ID).Any((SaleProduct sp) => sp.RecurringPrice.HasValue && (!recurringProductGroupId.HasValue || sp.Product.ProductGroupID == recurringProductGroupId)))
			{
				return sale;
			}
		}
		return null;
	}

	public static Sale GetOldestRecurringSaleForAccount(long accountId, byte recurringProductGroupId)
	{
		return GetRecurringSalesForAccount(accountId).LastOrDefault((Sale s) => SaleProduct.GetSaleProductsBySaleID(s.ID).Any((SaleProduct sp) => sp.RecurringPrice.HasValue && sp.Product.ProductGroupID == recurringProductGroupId));
	}

	public static Sale GetMostRecentCancelledRecurringSaleForAccount(long accountId, byte recurringProductGroupId)
	{
		foreach (Sale sale in GetSalesByPurchaserAndStatus(accountId, SaleStatusType.Cancelled.ID))
		{
			if (SaleProduct.GetSaleProductsBySaleID(sale.ID).Any((SaleProduct sp) => sp.RecurringPrice.HasValue && sp.Product.ProductGroupID == recurringProductGroupId && sp.Product.IsRenewable))
			{
				return sale;
			}
		}
		return null;
	}

	public static Sale GetMostRecentSaleForAccount(long accountId)
	{
		ICollection<Sale> salesForAccount = GetSalesByPurchaserAndStatus_Paged(accountId, SaleStatusType.Complete.ID, 0, 1);
		if (salesForAccount != null && salesForAccount.Count > 0)
		{
			return salesForAccount.First();
		}
		return null;
	}

	private static ICollection<Sale> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SaleDAL, Sale>(ids, EntityCacheInfo, SaleDAL.MultiGet);
	}

	internal static ICollection<Sale> GetSalesByPurchaserAccountIDPaged(long? purchaserAccountID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetSalesByPurchaserAccountIDPaged_PurchaserAccountID:{purchaserAccountID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByPurchaserAccountID(purchaserAccountID)), collectionId, () => SaleDAL.GetSaleIDsByPurchaserAccountIDPaged(purchaserAccountID, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static int GetTotalNumberOfSalesByPurchaseAccountID(long? purchaserAccountId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserAccountID:{purchaserAccountId}"), $"GetTotalNumberOfSalesByPurchaserAccountID_PurchaserAccountID:{purchaserAccountId}", () => SaleDAL.GetTotalNumberOfSalesByPurchaserAccountID(purchaserAccountId));
	}

	/// <summary>
	/// Gets all recurring sales for an account containing a product of the product group id specified.
	/// This will generally return a list of 0 or 1 sales - but in certain cases (i.e. upgrades) it may return more.
	/// </summary>
	/// <returns></returns>
	public static List<Sale> GetRecurringSalesForAccount(long accountId, byte recurringProductGroupId)
	{
		List<Sale> sales = new List<Sale>();
		foreach (Sale sale in GetRecurringSalesForAccount(accountId))
		{
			if (sale.Products.Where((SaleProduct y) => y.RecurringPrice.HasValue && y.Product.ProductGroupID == recurringProductGroupId).Any())
			{
				sales.Add(sale);
			}
		}
		return sales;
	}

	public static ICollection<int> GetSaleIDsUpForRenewal()
	{
		return SaleDAL.GetSaleIDsUpForRenewal();
	}

	public static ICollection<int> GetRecurringSaleIDsUpForRenewal(int count, int exclusiveStartSaleID)
	{
		return SaleDAL.GetRecurringSaleIDsUpForRenewal(count, exclusiveStartSaleID);
	}

	public void Construct(SaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (PurchaserAccountID.HasValue)
		{
			yield return new StateToken($"PurchaserAccountID:{PurchaserAccountID}");
			yield return new StateToken(GetLookupCacheKeysBySaleStatusTypeIDPurchaserAccountID(SaleStatusTypeID, PurchaserAccountID));
		}
	}

	/// <summary>
	/// Returns the old recurring purchases using SaleStatusType.Complete and the new recurring subscriptions using SaleStatusType.Recurring
	/// </summary>
	/// <param name="accountId"></param>
	private static List<Sale> GetRecurringSalesForAccount(long accountId)
	{
		List<Sale> list = new List<Sale>();
		IEnumerable<Sale> completedSales = GetSalesByPurchaserAndStatus(accountId, SaleStatusType.Complete.ID)?.Where((Sale x) => x.RenewalDate.HasValue) ?? Enumerable.Empty<Sale>();
		IEnumerable<Sale> recurringSales = GetSalesByPurchaserAndStatus(accountId, SaleStatusType.Recurring.ID)?.Where((Sale x) => x.RenewalDate.HasValue) ?? Enumerable.Empty<Sale>();
		list.AddRange(completedSales);
		list.AddRange(recurringSales);
		return list;
	}

	private static string GetLookupCacheKeysByPurchaserAccountID(long? purchaserAccountID)
	{
		return $"PurchaserAccountID:{purchaserAccountID}";
	}

	private static string GetLookupCacheKeysBySaleStatusTypeIDPurchaserAccountID(byte saleStatusTypeID, long? purchaserAccountID)
	{
		return $"PurchaserAccountID:{purchaserAccountID}_SaleStatusTypeID:{saleStatusTypeID}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
