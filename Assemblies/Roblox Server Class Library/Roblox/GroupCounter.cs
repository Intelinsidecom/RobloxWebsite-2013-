using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupCounter : IRobloxEntity<long, GroupCounterDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GroupCounterDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "GroupCounter", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	public byte GroupCounterTypeID
	{
		get
		{
			return _EntityDAL.GroupCounterTypeID;
		}
		set
		{
			_EntityDAL.GroupCounterTypeID = value;
		}
	}

	public long Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GroupCounter()
	{
		_EntityDAL = new GroupCounterDAL();
	}

	public GroupCounter(GroupCounterDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Increment()
	{
		Increment(1L);
		if (new Random().Next(100) == 0)
		{
			RobloxThreadPool.QueueUserWorkItem(ReaggregateCounter);
		}
	}

	public void Increment(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Increment(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	private void ReaggregateCounter()
	{
		Value = UserGroup.GetTotalNumberOfUserGroupsByGroupID(GroupID);
		Save();
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

	public void TryDecrement()
	{
		TryDecrement(1L);
	}

	public void TryDecrement(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.TryDecrement(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	private static GroupCounter DoGetOrCreate(long groupId, byte groupCounterTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, GroupCounterDAL, GroupCounter>(() => GroupCounterDAL.GetOrCreate(groupId, groupCounterTypeId));
	}

	public static GroupCounter GetOrCreate(long groupId, byte groupCounterTypeId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, GroupCounter>(EntityCacheInfo, $"GroupID:{groupId}_GroupCounterTypeID:{groupCounterTypeId}", () => DoGetOrCreate(groupId, groupCounterTypeId), Get);
	}

	public static GroupCounter Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupCounterDAL, GroupCounter>(EntityCacheInfo, id, () => GroupCounterDAL.Get(id));
	}

	public void Construct(GroupCounterDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"GroupID:{GroupID}_GroupCounterTypeID:{GroupCounterTypeID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
