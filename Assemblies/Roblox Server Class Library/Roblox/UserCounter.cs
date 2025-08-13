using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class UserCounter : IRobloxEntity<long, UserCounterDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum DateThreshold
	{
		BeginningOfTheCurrentMinute,
		BeginningOfTheCurrentDay,
		BeginningOfTheCurrentWeek,
		BeginningOfTheCurrentMonth,
		BeginningOfTheCurrentYear
	}

	private UserCounterDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "UserCounter", isNullCacheable: true);

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

	public byte UserCounterTypeID
	{
		get
		{
			return _EntityDAL.UserCounterTypeID;
		}
		set
		{
			_EntityDAL.UserCounterTypeID = value;
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

	public UserCounter()
	{
		_EntityDAL = new UserCounterDAL();
	}

	public UserCounter(UserCounterDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Increment()
	{
		Increment(1L);
	}

	public void Increment(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Increment(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public void IncrementResetting(DateThreshold dateThresholdToReset)
	{
		IncrementResetting(1L, dateThresholdToReset);
	}

	public void IncrementResetting(long amount, DateThreshold dateThresholdToReset)
	{
		DateTime dateThresholdDateTime = default(DateTime);
		DateTime currentDate = DateTime.Now;
		DateTime currentWeek = currentDate.AddDays(-1 * Convert.ToInt16(currentDate.DayOfWeek));
		switch (dateThresholdToReset)
		{
		case DateThreshold.BeginningOfTheCurrentMinute:
			dateThresholdDateTime = DateTime.Parse(currentDate.Year + "-" + currentDate.Month + "-" + currentDate.Day + " " + currentDate.Hour + ":" + currentDate.Minute + ":00.001");
			break;
		case DateThreshold.BeginningOfTheCurrentDay:
			dateThresholdDateTime = DateTime.Parse(currentDate.Year + "-" + currentDate.Month + "-" + currentDate.Day + " 00:00:00.001");
			break;
		case DateThreshold.BeginningOfTheCurrentWeek:
			dateThresholdDateTime = DateTime.Parse(currentWeek.Year + "-" + currentWeek.Month + "-" + currentWeek.Day + " 00:00:00.001");
			break;
		case DateThreshold.BeginningOfTheCurrentMonth:
			dateThresholdDateTime = DateTime.Parse(currentDate.Year + "-" + currentDate.Month + "-01 00:00:00.001");
			break;
		case DateThreshold.BeginningOfTheCurrentYear:
			dateThresholdDateTime = DateTime.Parse(currentDate.Year + "-01-01 00:00:00.001");
			break;
		}
		IncrementResetting(amount, dateThresholdDateTime);
	}

	public void IncrementResetting(long amount, DateTime dateThreshold)
	{
		if (amount != 0L && !(dateThreshold == default(DateTime)))
		{
			_EntityDAL.IncrementResetting(amount, dateThreshold);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public void Decrement()
	{
		Decrement(1L);
	}

	public void Decrement(long amount)
	{
		if (amount != 0L)
		{
			_EntityDAL.Decrement(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	private static UserCounter DoGetOrCreate(long userId, byte userCounterTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, UserCounterDAL, UserCounter>(() => UserCounterDAL.GetOrCreate(userId, userCounterTypeId));
	}

	public static UserCounter GetOrCreate(long userId, byte userCounterTypeId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserCounter>(EntityCacheInfo, $"UserID:{userId}_UserCounterTypeID:{userCounterTypeId}", () => DoGetOrCreate(userId, userCounterTypeId), Get);
	}

	public static UserCounter GetOrCreate(long userId, byte userCounterTypeId, Action<UserCounter> onCreateHandler, out bool wasSynced)
	{
		wasSynced = false;
		if (onCreateHandler == null)
		{
			return GetOrCreate(userId, userCounterTypeId);
		}
		bool created = false;
		UserCounter entity = EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserCounter>(EntityCacheInfo, $"UserID:{userId}_UserCounterTypeID:{userCounterTypeId}", () => EntityHelper.DoGetOrCreate<long, UserCounterDAL, UserCounter>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<UserCounterDAL> orCreate = UserCounterDAL.GetOrCreate(userId, userCounterTypeId);
			created = orCreate.CreatedNewEntity;
			return orCreate;
		}), Get);
		if (created)
		{
			onCreateHandler(entity);
			wasSynced = true;
		}
		return entity;
	}

	public static UserCounter Get(long id)
	{
		return EntityHelper.GetEntity<long, UserCounterDAL, UserCounter>(EntityCacheInfo, id, () => UserCounterDAL.Get(id));
	}

	public void Construct(UserCounterDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"UserID:{UserID}_UserCounterTypeID:{UserCounterTypeID}";
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
