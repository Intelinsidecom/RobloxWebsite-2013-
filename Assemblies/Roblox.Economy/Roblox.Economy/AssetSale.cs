using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Common.Properties;

namespace Roblox.Economy;

public class AssetSale : IRobloxEntity<long, AssetSaleDAL>, ICacheableObject<long>, ICacheableObject
{
	private AssetSaleDAL _EntityDAL;

	private static readonly TimeSpan _TotalRevenueExpiration = Settings.Default.TotalRevenueExpiration;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: false, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), "Roblox.Economy.AssetSale", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SaleID
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

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
		}
	}

	public DateTime SaleDate
	{
		get
		{
			return _EntityDAL.SaleDate;
		}
		set
		{
			_EntityDAL.SaleDate = value;
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

	public int CurrencyTypeID
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetSale()
	{
		_EntityDAL = new AssetSaleDAL();
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

	public static AssetSale CreateNew(long saleid, long assetid, int assettypeid, DateTime saledate, long totalprice, int currencytypeid, long? sellerid)
	{
		AssetSale assetSale = new AssetSale();
		assetSale.SaleID = saleid;
		assetSale.AssetID = assetid;
		assetSale.AssetTypeID = assettypeid;
		assetSale.SaleDate = saledate;
		assetSale.TotalPrice = totalprice;
		assetSale.CurrencyTypeID = currencytypeid;
		assetSale.SellerID = sellerid;
		assetSale.Save();
		return assetSale;
	}

	public static AssetSale Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetSaleDAL, AssetSale>(EntityCacheInfo, id, () => AssetSaleDAL.Get(id));
	}

	public static long GetSumOfTotalPriceByAssetIDCurrencyTypeIDFromDate(long assetId, byte currencyTypeId, DateTime fromDateTime)
	{
		DateTime snappedFromDateTime = fromDateTime;
		if (_TotalRevenueExpiration > TimeSpan.Zero)
		{
			snappedFromDateTime = CacheManager.Snap(fromDateTime, _TotalRevenueExpiration);
		}
		string countId = $"GetSumOfTotalPriceByAssetIDCurrencyTypeIDFromDate_AssetID:{assetId}_CurrencyTypeID:{currencyTypeId}_FromDateTime:{snappedFromDateTime}";
		string cachedStateQualifier = $"AssetID:{assetId}_CurrencyTypeID:{currencyTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AssetSaleDAL.GetSumOfTotalPriceByAssetIDCurrencyTypeIDFromDate(assetId, currencyTypeId, snappedFromDateTime));
	}

	public static ICollection<AssetSale> GetAssetSalesByAssetId(long assetId, int count, long exclusiveStartAssetSaleId)
	{
		string collectionId = $"GetAssetSalesByAssetId_AssetId:{assetId}_Count:{count}_ExclusiveStartAssetSaleId:{exclusiveStartAssetSaleId}";
		string cachedStateQualifier = $"AssetId:{assetId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), collectionId, () => AssetSaleDAL.GetAssetSaleIDsByAssetID(assetId, count, exclusiveStartAssetSaleId), MultiGet);
	}

	public static ICollection<AssetSale> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetSaleDAL, AssetSale>(ids, EntityCacheInfo, AssetSaleDAL.MultiGet);
	}

	public void Construct(AssetSaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AssetID:{AssetID}_CurrencyTypeID:{CurrencyTypeID}");
		yield return new StateToken($"AssetID:{AssetID}");
	}
}
