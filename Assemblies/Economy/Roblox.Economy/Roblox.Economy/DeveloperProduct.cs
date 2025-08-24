using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class DeveloperProduct : IRobloxEntity<long, DeveloperProductDAL>, ICacheableObject<long>, ICacheableObject
{
	private DeveloperProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(DeveloperProduct).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long ShopID
	{
		get
		{
			return _EntityDAL.ShopID;
		}
		set
		{
			_EntityDAL.ShopID = value;
		}
	}

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public long? IconImageAssetID
	{
		get
		{
			return _EntityDAL.IconImageAssetID;
		}
		set
		{
			_EntityDAL.IconImageAssetID = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public DeveloperProduct()
	{
		_EntityDAL = new DeveloperProductDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static DeveloperProduct CreateNew(long shopid, string name, string description, long? iconimageassetid)
	{
		DeveloperProduct developerProduct = new DeveloperProduct();
		developerProduct.ShopID = shopid;
		developerProduct.Name = name;
		developerProduct.Description = description;
		developerProduct.IconImageAssetID = iconimageassetid;
		developerProduct.Save();
		return developerProduct;
	}

	public static DeveloperProduct Get(long id)
	{
		return EntityHelper.GetEntity<long, DeveloperProductDAL, DeveloperProduct>(EntityCacheInfo, id, () => DeveloperProductDAL.Get(id));
	}

	public static DeveloperProduct GetByShopIDAndName(long shopId, string name)
	{
		return EntityHelper.GetEntityByLookup<long, DeveloperProductDAL, DeveloperProduct>(EntityCacheInfo, $"ShopID:{shopId}Name:{name}", () => DeveloperProductDAL.GetByShopIDAndName(shopId, name));
	}

	public static ICollection<DeveloperProduct> GetDeveloperProductsByShopID_Paged(long shopId, long startRowIndex, long maxRows)
	{
		if (shopId == 0L)
		{
			throw new ApplicationException("Required value shopId not supplied: " + shopId);
		}
		string collectionId = $"GetDeveloperProductsByShopID_ShopID:{shopId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ShopID:{shopId}"), collectionId, () => DeveloperProductDAL.GetDeveloperProductIDsByShopID_Paged(shopId, startRowIndex + 1, maxRows), Get);
	}

	public static long GetTotalNumberOfDeveloperProductsByShopID(long shopId)
	{
		if (shopId == 0L)
		{
			throw new ApplicationException("Required value shopId not supplied: " + shopId);
		}
		string countId = $"GetTotalNumberOfDeveloperProductsByShopID_ShopID:{shopId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ShopID:{shopId}"), countId, () => DeveloperProductDAL.GetTotalNumberOfDeveloperProductsByShopID(shopId));
	}

	public void Construct(DeveloperProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"ShopID:{ShopID}Name:{Name}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ShopID:{ShopID}");
	}
}
