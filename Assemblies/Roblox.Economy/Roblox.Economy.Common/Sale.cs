using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Common.Properties;

namespace Roblox.Economy.Common;

public class Sale : IRobloxEntity<long, SaleDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public delegate void EntityCreatedEventHandler(Sale sender, EventArgs e);

	public delegate void EntityDeletedEventHandler(Sale sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(Sale sender, EventArgs e);

	private SaleDAL _EntityDAL;

	private static readonly TimeSpan _TotalRevenueExpiration = Settings.Default.TotalRevenueExpiration;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Sale", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PurchaserID
	{
		get
		{
			return _EntityDAL.PurchaserID;
		}
		set
		{
			_EntityDAL.PurchaserID = value;
		}
	}

	public long? SellerID
	{
		get
		{
			return _EntityDAL.SellerID;
		}
		set
		{
			_EntityDAL.SellerID = value;
		}
	}

	public long ProductID
	{
		get
		{
			return _EntityDAL.ProductID;
		}
		set
		{
			_EntityDAL.ProductID = value;
		}
	}

	public Product Product
	{
		get
		{
			return Product.Get(ProductID);
		}
		set
		{
			if (value != null)
			{
				ProductID = value.ID;
			}
			else
			{
				ProductID = 0L;
			}
		}
	}

	public int Quantity
	{
		get
		{
			return _EntityDAL.Quantity;
		}
		set
		{
			_EntityDAL.Quantity = value;
		}
	}

	public byte CurrencyTypeID
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

	public long UnitPrice
	{
		get
		{
			return _EntityDAL.UnitPrice;
		}
		set
		{
			_EntityDAL.UnitPrice = value;
		}
	}

	public long Discount
	{
		get
		{
			return _EntityDAL.Discount;
		}
		set
		{
			_EntityDAL.Discount = value;
		}
	}

	public long TotalPrice
	{
		get
		{
			return _EntityDAL.TotalPrice;
		}
		set
		{
			_EntityDAL.TotalPrice = value;
		}
	}

	public long MarketplaceFee
	{
		get
		{
			return _EntityDAL.MarketplaceFee;
		}
		set
		{
			_EntityDAL.MarketplaceFee = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityDeletedEventHandler EntityDeleted;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public Sale()
	{
		_EntityDAL = new SaleDAL();
	}

	public Sale(SaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
			OnEntityCreated(this, EventArgs.Empty);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
			OnEntityUpdated(this, EventArgs.Empty);
		});
	}

	private static Sale DoGet(long id)
	{
		return EntityHelper.DoGet<long, SaleDAL, Sale>(() => SaleDAL.Get(id), id);
	}

	public static Sale CreateNew(long purchaserId, long sellerId, Product product, byte currencyTypeId, int quantity, long unitPrice, long discount, long totalPrice, long marketplaceFee)
	{
		Sale sale = new Sale();
		sale.PurchaserID = purchaserId;
		sale.SellerID = sellerId;
		sale.Product = product;
		sale.Quantity = quantity;
		sale.CurrencyTypeID = currencyTypeId;
		sale.UnitPrice = unitPrice;
		sale.Discount = discount;
		sale.TotalPrice = totalPrice;
		sale.MarketplaceFee = marketplaceFee;
		sale.Save();
		return sale;
	}

	public static Sale Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Sale Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<Sale> GetSales(long exclusiveStartId, int maxRows)
	{
		string collectionId = $"GetSales:ExclusiveStartId:{exclusiveStartId}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(), collectionId, () => SaleDAL.GetSaleIDs(exclusiveStartId, maxRows), Get);
	}

	public static ICollection<Sale> GetSalesByProductIDPaged(long productId, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetSalesByProductIDPaged:ProductID:{productId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductID:{productId}"), collectionId, () => SaleDAL.GetSaleIDsByProductIDPaged(productId, startRowIndex + 1, maxRows), Get);
	}

	public static ICollection<Sale> GetSalesByPurchaserPaged(long purchaserId, int startRowIndex, int maximumRows)
	{
		if (purchaserId == 0L)
		{
			throw new ApplicationException("Required value purchaserId not supplied: " + purchaserId);
		}
		string collectionId = $"GetSalesByPurchaserPaged_PurchaserID:{purchaserId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserID:{purchaserId}"), collectionId, () => SaleDAL.GetSaleIDsByPurchaserPaged(purchaserId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<Sale> GetSalesBySellerPaged(long sellerId, int startRowIndex, int maximumRows)
	{
		if (sellerId == 0L)
		{
			throw new ApplicationException("Required value sellerId not supplied: " + sellerId);
		}
		string collectionId = $"GetSalesByPurchaserPaged_SellerID:{sellerId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SellerID:{sellerId}"), collectionId, () => SaleDAL.GetSaleIDsBySellerPaged(sellerId, startRowIndex + 1, maximumRows), Get);
	}

	public static long GetTotalNumberOfSalesBySeller(long sellerId)
	{
		if (sellerId == 0L)
		{
			throw new ApplicationException("Required value sellerId not supplied: " + sellerId);
		}
		string countId = $"GetTotalNumberOfSalesBySeller_sellerId:{sellerId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SellerID:{sellerId}"), countId, () => SaleDAL.GetTotalNumberOfSalesBySellerID(sellerId));
	}

	public static long GetTotalNumberOfSalesByPurchaser(long purchaserId)
	{
		if (purchaserId == 0L)
		{
			throw new ApplicationException("Required value purchaserId not supplied: " + purchaserId);
		}
		string countId = $"GetTotalNumberOfSalesByPurchaser_purchaserId:{purchaserId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PurchaserID:{purchaserId}"), countId, () => SaleDAL.GetTotalNumberOfSalesByPurchaserID(purchaserId));
	}

	public static long GetSumOfTotalPriceByProductIDCurrencyTypeIDFromDate(long productId, byte currencyTypeID, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_TotalRevenueExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _TotalRevenueExpiration);
		}
		string countId = $"GetSumOfTotalPriceByProductIDCurrencyTypeIDFromDate_ProductID:{productId}_CurrencyTypeID:{currencyTypeID}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"ProductID:{productId}_CurrencyTypeID:{currencyTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => SaleDAL.GetSumOfTotalPriceByProductIDCurrencyTypeIDFromDate(productId, currencyTypeID, snappedFromDateTime));
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
		yield return new StateToken($"AssetID:{Product.TargetID}");
		yield return new StateToken($"PurchaserID:{PurchaserID}");
		yield return new StateToken($"ProductID:{ProductID}");
		if (SellerID.HasValue)
		{
			yield return new StateToken($"SellerID:{SellerID}");
		}
		yield return new StateToken($"ProductID:{ProductID}_CurrencyTypeID:{CurrencyTypeID}");
	}

	private static void OnEntityCreated(Sale entity, EventArgs e)
	{
		if (Sale.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Sale.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityDeleted(Sale entity, EventArgs e)
	{
		if (Sale.EntityDeleted != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Sale.EntityDeleted(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(Sale entity, EventArgs e)
	{
		if (Sale.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				Sale.EntityUpdated(entity, e);
			});
		}
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
