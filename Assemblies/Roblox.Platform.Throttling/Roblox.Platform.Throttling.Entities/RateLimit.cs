using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Throttling.Entities;

internal class RateLimit : IRobloxEntity<long, RateLimitDAL>, ICacheableObject<long>, ICacheableObject
{
	private RateLimitDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(RateLimit).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long NamespaceID
	{
		get
		{
			return _EntityDAL.NamespaceID;
		}
		set
		{
			_EntityDAL.NamespaceID = value;
		}
	}

	internal long ActionTypeID
	{
		get
		{
			return _EntityDAL.ActionTypeID;
		}
		set
		{
			_EntityDAL.ActionTypeID = value;
		}
	}

	internal long NumberOfRequests
	{
		get
		{
			return _EntityDAL.NumberOfRequests;
		}
		set
		{
			_EntityDAL.NumberOfRequests = value;
		}
	}

	internal long IntervalInTicks
	{
		get
		{
			return _EntityDAL.IntervalInTicks;
		}
		set
		{
			_EntityDAL.IntervalInTicks = value;
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

	public RateLimit()
	{
		_EntityDAL = new RateLimitDAL();
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
	}

	internal static RateLimit CreateNew(long namespaceId, long actionTypeId, int numberOfRequest, long intervalInTicks)
	{
		RateLimit rateLimit = new RateLimit();
		rateLimit.NamespaceID = namespaceId;
		rateLimit.ActionTypeID = actionTypeId;
		rateLimit.NumberOfRequests = numberOfRequest;
		rateLimit.IntervalInTicks = intervalInTicks;
		rateLimit.Save();
		return rateLimit;
	}

	internal static RateLimit Get(long id)
	{
		return EntityHelper.GetEntity<long, RateLimitDAL, RateLimit>(EntityCacheInfo, id, () => RateLimitDAL.Get(id));
	}

	internal static RateLimit GetByNamespaceIDActionTypeID(long namespaceID, long actionTypeID)
	{
		return EntityHelper.GetEntityByLookup<long, RateLimitDAL, RateLimit>(EntityCacheInfo, $"NamespaceID:{namespaceID}_ActionTypeID:{actionTypeID}", () => RateLimitDAL.GetRateLimitByNamespaceIDActionTypeID(namespaceID, actionTypeID));
	}

	internal static ICollection<RateLimit> GetRateLimitsPaged(long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetRateLimitsPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => RateLimitDAL.GetRateLimitIdsPaged(startRowIndex + 1, maximumRows), Get);
	}

	internal static long GetTotalNumberOfRateLimits()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalRateLimits", RateLimitDAL.GetTotalNumberOfRateLimits);
	}

	public void Construct(RateLimitDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"NamespaceID:{NamespaceID}_ActionTypeID:{ActionTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
