using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class ProductGenreMapping : IRobloxEntity<long, ProductGenreMappingDAL>, ICacheableObject<long>, ICacheableObject
{
	private ProductGenreMappingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.ProductGenreMapping", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long ProductID
	{
		get
		{
			return _EntityDAL.ProductID;
		}
		private set
		{
			_EntityDAL.ProductID = value;
		}
	}

	public byte AssetGenreID
	{
		get
		{
			return _EntityDAL.AssetGenreID;
		}
		private set
		{
			_EntityDAL.AssetGenreID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		private set
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
		private set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ProductGenreMapping()
	{
		_EntityDAL = new ProductGenreMappingDAL();
	}

	public static ProductGenreMapping CreateNew(long productid, byte assetgenreid)
	{
		ProductGenreMapping productGenreMapping = new ProductGenreMapping();
		productGenreMapping.ProductID = productid;
		productGenreMapping.AssetGenreID = assetgenreid;
		productGenreMapping.Save();
		return productGenreMapping;
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

	public static ProductGenreMapping Get(long id)
	{
		return EntityHelper.GetEntity<long, ProductGenreMappingDAL, ProductGenreMapping>(EntityCacheInfo, id, () => ProductGenreMappingDAL.Get(id));
	}

	public static ProductGenreMapping GetByProductID(long productId)
	{
		return EntityHelper.GetEntityByLookup<long, ProductGenreMappingDAL, ProductGenreMapping>(EntityCacheInfo, $"ProductID:{productId}", () => ProductGenreMappingDAL.GetByProductID(productId));
	}

	public static long GetTotalNumberOfProductGenreMappingsByGenre(byte assetGenreID)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetGenreID:{assetGenreID}"), $"GetTotalNumberOfProductGenreMappingsByGenre_AssetGenreID:{assetGenreID}", () => ProductGenreMappingDAL.GetTotalNumberOfProductGenreMappingsByGenre(assetGenreID));
	}

	public static ICollection<ProductGenreMapping> GetProductGenreMappingsByGenre(byte assetGenreID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetProductGenreMappingsByGenre_AssetGenreID:{assetGenreID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetGenreID:{assetGenreID}"), collectionId, () => ProductGenreMappingDAL.GetProductGenreIDsByGenreSortedAndPaged(assetGenreID, startRowIndex, maximumRows), Get);
	}

	public void Construct(ProductGenreMappingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ProductID:{ProductID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"AssetGenreID:{AssetGenreID}")
		};
	}
}
