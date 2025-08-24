using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class RobuxBalance : IRobloxEntity<long, RobuxBalanceDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private RobuxBalanceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "RobuxBalance", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
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

	public RobuxBalance()
	{
		_EntityDAL = new RobuxBalanceDAL();
	}

	public RobuxBalance(RobuxBalanceDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Credit(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Credit(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public bool TryDebit(long amount)
	{
		bool num = _EntityDAL.TryDebit(amount);
		if (num)
		{
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
		return num;
	}

	private static RobuxBalance DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<long, RobuxBalanceDAL, RobuxBalance>(() => RobuxBalanceDAL.GetOrCreate(userId));
	}

	public static RobuxBalance GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, RobuxBalance>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId), Get);
	}

	public static RobuxBalance Get(long id)
	{
		return EntityHelper.GetEntity<long, RobuxBalanceDAL, RobuxBalance>(EntityCacheInfo, id, () => RobuxBalanceDAL.Get(id));
	}

	public void Construct(RobuxBalanceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"UserID:{UserID}";
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
