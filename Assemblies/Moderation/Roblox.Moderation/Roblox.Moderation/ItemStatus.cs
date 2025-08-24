using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class ItemStatus : IRobloxEntity<long, ItemStatusDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ItemStatusDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ItemStatus).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte ItemTypeID
	{
		get
		{
			return _EntityDAL.ItemTypeID;
		}
		set
		{
			_EntityDAL.ItemTypeID = value;
		}
	}

	public long ItemTargetID
	{
		get
		{
			return _EntityDAL.ItemTargetID;
		}
		set
		{
			_EntityDAL.ItemTargetID = value;
		}
	}

	public byte StatusTypeID
	{
		get
		{
			return _EntityDAL.StatusTypeID;
		}
		set
		{
			_EntityDAL.StatusTypeID = value;
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

	public ItemStatus()
	{
		_EntityDAL = new ItemStatusDAL();
	}

	public ItemStatus(ItemStatusDAL itemStatusDAL)
	{
		_EntityDAL = itemStatusDAL;
	}

	public void Delete()
	{
		if (Settings.Default.IsRemoteCacheForItemStatusEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	public void Save()
	{
		if (Settings.Default.IsRemoteCacheForItemStatusEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
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
		else
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
	}

	public static ItemStatus CreateNew(byte itemTypeId, long itemTargetId, byte statusTypeId)
	{
		ItemStatus itemStatus = new ItemStatus();
		itemStatus.ItemTypeID = itemTypeId;
		itemStatus.ItemTargetID = itemTargetId;
		itemStatus.StatusTypeID = statusTypeId;
		itemStatus.Save();
		return itemStatus;
	}

	public static ItemStatus Get(long id)
	{
		return EntityHelper.GetEntity<long, ItemStatusDAL, ItemStatus>(EntityCacheInfo, id, () => ItemStatusDAL.Get(id));
	}

	public static ItemStatus GetByItemTypeIDAndItemTargetID(byte itemTypeId, long itemTargetId)
	{
		if (Settings.Default.IsRemoteCacheForItemStatusEnabled)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, ItemStatusDAL, ItemStatus>(EntityCacheInfo, GetLookupCacheKeysByItemTypeIDItemTargetID(itemTypeId, itemTargetId), () => ItemStatusDAL.GetByItemTypeIdAndItemTargetId(itemTypeId, itemTargetId), Get);
		}
		return EntityHelper.GetEntityByLookup<long, ItemStatusDAL, ItemStatus>(EntityCacheInfo, GetLookupCacheKeysByItemTypeIDItemTargetID(itemTypeId, itemTargetId), () => ItemStatusDAL.GetByItemTypeIdAndItemTargetId(itemTypeId, itemTargetId));
	}

	public void Construct(ItemStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByItemTypeIDItemTargetID(ItemTypeID, ItemTargetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByItemTypeIDItemTargetID(byte itemTypeId, long itemTargetId)
	{
		return $"GetByItemTypeID:{itemTypeId}AndItemTargetID:{itemTargetId}";
	}
}
