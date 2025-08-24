using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class SaleProduct : IRobloxEntity<long, SaleProductDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private SaleProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.SaleProduct", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public int ProductID
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

	public decimal ListPrice
	{
		get
		{
			return _EntityDAL.ListPrice;
		}
		set
		{
			_EntityDAL.ListPrice = value;
		}
	}

	public decimal DiscountedPrice
	{
		get
		{
			return _EntityDAL.DiscountedPrice;
		}
		set
		{
			_EntityDAL.DiscountedPrice = value;
		}
	}

	public long? RecipientAccountID
	{
		get
		{
			return _EntityDAL.RecipientAccountID;
		}
		set
		{
			_EntityDAL.RecipientAccountID = value;
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

	public Product Product => Product.Get(ProductID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SaleProduct()
	{
		_EntityDAL = new SaleProductDAL();
	}

	public SaleProduct(SaleProductDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public static SaleProduct Get(long id)
	{
		return EntityHelper.GetEntity<long, SaleProductDAL, SaleProduct>(EntityCacheInfo, id, () => SaleProductDAL.Get(id));
	}

	public static SaleProduct CreateNew(int saleid, int productid, decimal listprice, decimal discountedprice, long? recipientaccountid, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		SaleProduct saleProduct = new SaleProduct();
		saleProduct.SaleID = saleid;
		saleProduct.ProductID = productid;
		saleProduct.ListPrice = listprice;
		saleProduct.DiscountedPrice = discountedprice;
		saleProduct.RecipientAccountID = recipientaccountid;
		saleProduct.CurrencyTypeID = currencyTypeID;
		saleProduct.Save();
		return saleProduct;
	}

	public static SaleProduct CreateRecurring(int saleid, int productid, decimal listprice, decimal discountedprice, long? recipientaccountid, decimal? recurringprice, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		SaleProduct saleProduct = new SaleProduct();
		saleProduct.SaleID = saleid;
		saleProduct.ProductID = productid;
		saleProduct.ListPrice = listprice;
		saleProduct.DiscountedPrice = discountedprice;
		saleProduct.RecipientAccountID = recipientaccountid;
		saleProduct.RecurringPrice = recurringprice;
		saleProduct.CurrencyTypeID = currencyTypeID;
		saleProduct.Save();
		return saleProduct;
	}

	public static ICollection<SaleProduct> GetSaleProductsBySaleID(int saleID)
	{
		string collectionId = $"GetSaleProductsBySaleID:{saleID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"SaleID:{saleID}"), collectionId, () => SaleProductDAL.GetIDsBySaleID(saleID), Get);
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

	private static ICollection<SaleProduct> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, SaleProductDAL, SaleProduct>(ids, EntityCacheInfo, SaleProductDAL.MultiGet);
	}

	internal static ICollection<SaleProduct> GetSaleProductsBySaleIDPaged(int saleID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetSaleProductsBySaleIDPaged_SaleID:{saleID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleID(saleID)), collectionId, () => SaleProductDAL.GetSaleProductIDsBySaleIDPaged(saleID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfSaleProductsBySaleID(int saleID)
	{
		string countId = $"GetTotalNumberOfSaleProductsBySaleId_SaleID:{saleID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysBySaleID(saleID)), countId, () => SaleProductDAL.GetTotalNumberOfSaleProductsBySaleID(saleID));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(SaleProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysBySaleID(SaleID));
	}

	private static string GetLookupCacheKeysBySaleID(int saleID)
	{
		return $"SaleID:{saleID}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
