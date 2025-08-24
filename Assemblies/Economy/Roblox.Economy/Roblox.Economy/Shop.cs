using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class Shop : IRobloxEntity<long, ShopDAL>, ICacheableObject<long>, ICacheableObject
{
	private ShopDAL _EntityDAL;

	private long? _OriginalCreatorTargetID;

	private int? _OriginalCreatorTypeID;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(Shop).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long CreatorTargetID
	{
		get
		{
			return _EntityDAL.CreatorTargetID;
		}
		set
		{
			if (_OriginalCreatorTargetID.HasValue)
			{
				_OriginalCreatorTargetID = _EntityDAL.CreatorTargetID;
			}
			_EntityDAL.CreatorTargetID = value;
		}
	}

	public int CreatorTypeID
	{
		get
		{
			return _EntityDAL.CreatorTypeID;
		}
		set
		{
			if (_OriginalCreatorTypeID.HasValue)
			{
				_OriginalCreatorTypeID = _EntityDAL.CreatorTypeID;
			}
			_EntityDAL.CreatorTypeID = value;
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

	public Shop()
	{
		_EntityDAL = new ShopDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
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
		_OriginalCreatorTargetID = null;
		_OriginalCreatorTypeID = null;
	}

	public static Shop CreateNew(long creatorTargetId, int creatorTypeId)
	{
		Shop shop = new Shop();
		shop.CreatorTargetID = creatorTargetId;
		shop.CreatorTypeID = creatorTypeId;
		shop.Save();
		return shop;
	}

	public static Shop Get(long id)
	{
		return EntityHelper.GetEntity<long, ShopDAL, Shop>(EntityCacheInfo, id, () => ShopDAL.Get(id));
	}

	public static ICollection<Shop> GetShopsByCreatorTypeIDAndCreatorTargetID_Paged(int creatorTypeId, long creatorTargetId, long startRowIndex, long maxRows)
	{
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value creatorTypeId not supplied: " + creatorTypeId);
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value creatorTargetId not supplied: " + creatorTargetId);
		}
		string collectionId = $"GetShopsByCreatorTypeIDAndCreatorTargetID_CreatorTypeID:{creatorTypeId}_CreatorTargetID:{creatorTargetId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CreatorTypeID:{creatorTypeId}_CreatorTargetID:{creatorTargetId}"), collectionId, () => ShopDAL.GetShopIDsByCreatorTypeIDAndCreatorTargetID_Paged(creatorTypeId, creatorTargetId, startRowIndex + 1, maxRows), Get);
	}

	public static long GetTotalNumberOfShopsByCreatorTypeIDAndCreatorTargetID(int creatorTypeId, long creatorTargetId)
	{
		if (creatorTypeId == 0)
		{
			throw new ApplicationException("Required value creatorTypeId not supplied: " + creatorTypeId);
		}
		if (creatorTargetId == 0L)
		{
			throw new ApplicationException("Required value creatorTargetId not supplied: " + creatorTargetId);
		}
		string countId = $"GetTotalNumberOfShopsByCreatorTypeIDAndCreatorTargetID_CreatorTypeID:{creatorTypeId}_CreatorTargetID:{creatorTargetId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CreatorTypeID:{creatorTypeId}_CreatorTargetID:{creatorTargetId}"), countId, () => ShopDAL.GetTotalNumberOfShopsByCreatorTypeIDAndCreatorTargetID(creatorTypeId, creatorTargetId));
	}

	public void Construct(ShopDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (_OriginalCreatorTypeID.HasValue || _OriginalCreatorTargetID.HasValue)
		{
			yield return new StateToken($"CreatorTypeID:{_OriginalCreatorTypeID ?? CreatorTypeID}_CreatorTargetID:{_OriginalCreatorTargetID ?? CreatorTargetID}");
		}
		yield return new StateToken($"CreatorTypeID:{CreatorTypeID}_CreatorTargetID:{CreatorTargetID}");
	}
}
