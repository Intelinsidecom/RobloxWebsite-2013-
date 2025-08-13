using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Avatar;

internal class RecentItemList : IRobloxEntity<long, RecentItemListDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private RecentItemListDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(RecentItemList).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal byte RecentItemListTypeID
	{
		get
		{
			return _EntityDAL.RecentItemListTypeID;
		}
		set
		{
			_EntityDAL.RecentItemListTypeID = value;
		}
	}

	internal long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	internal byte[] RecentItemTypeIDs
	{
		get
		{
			return _EntityDAL.RecentItemTypeIDs;
		}
		set
		{
			_EntityDAL.RecentItemTypeIDs = value.ToArray();
		}
	}

	internal long[] TargetIDs
	{
		get
		{
			return _EntityDAL.TargetIDs;
		}
		set
		{
			_EntityDAL.TargetIDs = value.ToArray();
		}
	}

	internal DateTime[] Dates
	{
		get
		{
			return _EntityDAL.Dates;
		}
		set
		{
			_EntityDAL.Dates = value.ToArray();
		}
	}

	internal int Revision
	{
		get
		{
			return _EntityDAL.Revision;
		}
		set
		{
			_EntityDAL.Revision = value;
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

	/// <summary>
	/// Recent avatar items can be updated from nummerous threads
	/// The entity has 3 columns that need to be kept in sync:
	/// Dates, TypeIds, and TargetIds
	/// Because of this, we need to lock on the entity whenever:
	/// - we read from the DB
	/// - we write back to the DB
	/// - we copy data from the entity to another layer (like CachedMssqlEntity)
	/// - we copy data from CachedMssqlEntity back to the entity
	/// </summary>
	internal object ReadWriteLock { get; set; }

	public CacheInfo CacheInfo => EntityCacheInfo;

	public RecentItemList()
	{
		_EntityDAL = new RecentItemListDAL();
		ReadWriteLock = new object();
	}

	public RecentItemList(RecentItemListDAL entityDAL)
	{
		_EntityDAL = entityDAL;
		ReadWriteLock = new object();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal bool Save()
	{
		bool updatedEntity = false;
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			updatedEntity = _EntityDAL.UpdateByRevision();
		});
		return updatedEntity;
	}

	internal static RecentItemList Get(long id)
	{
		return EntityHelper.GetEntity<long, RecentItemListDAL, RecentItemList>(EntityCacheInfo, id, () => RecentItemListDAL.Get(id));
	}

	private static ICollection<RecentItemList> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, RecentItemListDAL, RecentItemList>(ids, EntityCacheInfo, RecentItemListDAL.MultiGet);
	}

	public static RecentItemList GetByUserIDAndRecentItemListTypeID(long userId, byte recentItemListTypeId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, RecentItemListDAL, RecentItemList>(EntityCacheInfo, GetLookupCacheKeysByUserIDRecentItemListTypeID(userId, recentItemListTypeId), () => RecentItemListDAL.GetRecentItemListByUserIDAndRecentItemListTypeID(userId, recentItemListTypeId), Get);
	}

	public static RecentItemList GetOrCreate(long userId, byte recentItemListTypeId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, RecentItemList>(EntityCacheInfo, GetLookupCacheKeysByUserIDRecentItemListTypeID(userId, recentItemListTypeId), () => DoGetOrCreate(userId, recentItemListTypeId), Get);
	}

	private static RecentItemList DoGetOrCreate(long userId, byte recentItemListTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, RecentItemListDAL, RecentItemList>(() => RecentItemListDAL.GetOrCreateRecentItemList(userId, recentItemListTypeId));
	}

	public void Construct(RecentItemListDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUserIDRecentItemListTypeID(UserID, RecentItemListTypeID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUserIDRecentItemListTypeID(long userId, byte recentItemListTypeId)
	{
		return $"UserID:{userId}_RecentItemListTypeID:{recentItemListTypeId}";
	}
}
