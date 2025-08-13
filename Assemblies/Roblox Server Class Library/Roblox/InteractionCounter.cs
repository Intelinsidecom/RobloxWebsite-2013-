using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class InteractionCounter : IRobloxEntity<long, InteractionCounterDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum ResetThreshold
	{
		BeginningOfTheCurrentMonth
	}

	private InteractionCounterDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "InteractionCounter", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte InteractionCounterTypeID
	{
		get
		{
			return _EntityDAL.InteractionCounterTypeID;
		}
		set
		{
			_EntityDAL.InteractionCounterTypeID = value;
		}
	}

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

	public long OtherUserID
	{
		get
		{
			return _EntityDAL.OtherUserID;
		}
		set
		{
			_EntityDAL.OtherUserID = value;
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

	public InteractionCounter(InteractionCounterDAL entityDal)
	{
		_EntityDAL = entityDal;
	}

	public InteractionCounter()
	{
		_EntityDAL = new InteractionCounterDAL();
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

	public void IncrementResetting(ResetThreshold dateThresholdToReset)
	{
		IncrementResetting(1L, dateThresholdToReset);
	}

	public void IncrementResetting(long amount, ResetThreshold dateThresholdToReset)
	{
		if (amount != 0L)
		{
			DateTime dateThresholdDateTime = default(DateTime);
			DateTime currentDate = DateTime.Now;
			if (dateThresholdToReset == ResetThreshold.BeginningOfTheCurrentMonth)
			{
				dateThresholdDateTime = DateTime.Parse($"{currentDate.Year}-{currentDate.Month}-01 00:00:00.001");
			}
			if (!(dateThresholdDateTime == default(DateTime)))
			{
				_EntityDAL.IncrementResetting(amount, dateThresholdDateTime);
				CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
			}
		}
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	private static InteractionCounter DoGetOrCreate(byte interactionCounterTypeId, long userId, long otherUserId)
	{
		return EntityHelper.DoGetOrCreate<long, InteractionCounterDAL, InteractionCounter>(() => InteractionCounterDAL.GetOrCreate(interactionCounterTypeId, userId, otherUserId));
	}

	public static InteractionCounter GetOrCreate(byte interactionCounterTypeId, long userId, long otherUserId)
	{
		return EntityHelper.GetOrCreateEntity<long, InteractionCounter>(EntityCacheInfo, $"InteractionCounterTypeID:{interactionCounterTypeId}_UserID:{userId}_OtherUserID:{otherUserId}", () => DoGetOrCreate(interactionCounterTypeId, userId, otherUserId));
	}

	public static InteractionCounter Get(long id)
	{
		return EntityHelper.GetEntity<long, InteractionCounterDAL, InteractionCounter>(EntityCacheInfo, id, () => InteractionCounterDAL.Get(id));
	}

	public static ICollection<InteractionCounter> GetUserInteractionCountersByTypePaged(long userId, byte interactionCounterTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserInteractionCountersByTypePaged_UserID:{userId}_InteractionCounterTypeID:{interactionCounterTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		CacheManager.CachePolicy cachePolicy = new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}_InteractionCounterTypeID:{interactionCounterTypeId}");
		return EntityHelper.GetEntityCollection(EntityCacheInfo, cachePolicy, collectionId, () => InteractionCounterDAL.GetUserInteractionCounterIDsByTypePaged(userId, interactionCounterTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(InteractionCounterDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"InteractionCounterTypeID:{InteractionCounterTypeID}_UserID:{UserID}_OtherUserID:{OtherUserID}";
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
