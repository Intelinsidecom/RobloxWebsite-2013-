using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Diagnostics;
using Roblox.Caching.Interfaces;
using Roblox.Caching.Properties;
using Roblox.Instrumentation;

namespace Roblox.Caching;

public class CacheManager
{
	public class CachePolicy
	{
		public string CachedStateQualifier;

		public TimeSpan Expiration;

		public CacheScopeFilter ScopeFilter;

		public DateTime UtcExpirationDate => DateTime.UtcNow.Add(Expiration);

		public CachePolicy()
		{
			Expiration = TimeSpan.MaxValue;
			ScopeFilter = CacheScopeFilter.Unqualified;
		}

		public CachePolicy(TimeSpan expiration)
		{
			Expiration = expiration;
			ScopeFilter = CacheScopeFilter.Unqualified;
		}

		public CachePolicy(CacheScopeFilter cacheScope, string cachedStateQualifier)
		{
			Expiration = TimeSpan.MaxValue;
			ScopeFilter = cacheScope;
			CachedStateQualifier = cachedStateQualifier;
		}
	}

	public enum CacheScopeFilter
	{
		Unqualified,
		Qualified
	}

	public delegate T GetCount<T>(ref CachePolicy policy) where T : struct;

	public delegate ICollection<T> GetIDCollection<T>(ref CachePolicy policy) where T : struct;

	public static readonly CachePerformanceCounters PerfCounters = new CachePerformanceCounters(StaticCounterRegistry.Instance);

	public static readonly CachePolicy UnqualifiedNonExpiringCachePolicy = new CachePolicy(CacheScopeFilter.Unqualified, null);

	public static TimeSpan RemoteCacheableExpiration => Settings.Default.RemoteCacheableExpiration;

	public static LocalCache LocalCache => CacheFactory.GetLocalCache();

	public static void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id)
	{
		CacheFactory.GetCacheForEntity(cacheInfo).AddEntityIDToLookupCache(cacheInfo, lookup, id);
	}

	public static void AddEntityToCache<T>(ICacheableObject<T> entity)
	{
		CacheFactory.GetCacheForEntity(entity.CacheInfo).AddEntityToCache(entity);
	}

	public static void AddNullEntityToCache<TIndex>(ICacheInfo cacheInfo, TIndex id)
	{
		CacheFactory.GetCacheForEntity(cacheInfo).AddNullEntityToCache(cacheInfo, string.Concat(id));
	}

	public static void AddNullEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup)
	{
		CacheFactory.GetCacheForEntity(cacheInfo).AddNullEntityIDToLookupCache(cacheInfo, lookup);
	}

	public static CachePolicy BuildQualifiedCachePolicy(string cachedStateQualifier)
	{
		return new CachePolicy(CacheScopeFilter.Qualified, cachedStateQualifier);
	}

	public static T GetCountFromCache<T>(ICacheInfo cacheInfo, string countId, GetCount<T> getter) where T : struct
	{
		return CacheFactory.GetCacheForEntity(cacheInfo).GetCountFromCache(cacheInfo, countId, getter);
	}

	public static TEntity TryGetEntityOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, out bool cacheHit) where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheFactory.GetCacheForEntity(cacheInfo).TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, entityId, out cacheHit);
	}

	public static IEnumerable<(TIndex Id, TEntity Result, bool CacheHit)> TryGetEntitiesOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, IReadOnlyCollection<TIndex> entityIds) where TEntity : class, ICacheableObject<TIndex>
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		if (entityIds == null)
		{
			throw new ArgumentNullException("entityIds");
		}
		return CacheFactory.GetCacheForEntity(cacheInfo).TryGetEntitiesOnlyFromCache<TIndex, TEntity>(cacheInfo, entityIds);
	}

	public static TEntity GetEntityFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter) where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheFactory.GetCacheForEntity(cacheInfo).GetEntityFromCache(cacheInfo, entityId, getter);
	}

	public static TEntity TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, out bool cacheHit) where TIndex : IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>
	{
		return CacheFactory.GetCacheForEntity(cacheInfo).TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, out cacheHit);
	}

	public static TEntity GetEntityFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, Func<TEntity> getter) where TIndex : IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>
	{
		return LocalCache.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, getter);
	}

	public static bool GetEntityIDFromLookupCache<T>(ICacheInfo cacheInfo, string lookUp, out T entityId)
	{
		return CacheFactory.GetCacheForEntity(cacheInfo).GetEntityIDFromLookupCache<T>(cacheInfo, lookUp, out entityId);
	}

	public static TimeSpan GetExpirationByTimeInterval(TimeSpan interval)
	{
		if (interval.TotalMinutes <= 60.0)
		{
			return TimeSpan.FromTicks(interval.Ticks / 60);
		}
		if (interval.TotalHours <= 24.0)
		{
			return TimeSpan.FromTicks(interval.Ticks / 24);
		}
		if (interval.TotalDays <= 7.0)
		{
			return TimeSpan.FromTicks(interval.Ticks / 7);
		}
		return TimeSpan.FromDays(1.0);
	}

	public static ICollection<T> GetIDCollectionFromCache<T>(ICacheInfo cacheInfo, string collectionId, GetIDCollection<T> getter) where T : struct
	{
		return CacheFactory.GetLocalCache().GetIDCollectionFromCache(cacheInfo, collectionId, getter);
	}

	public static ICollection<T> GetIDCollectionFromCache<T>(ICacheInfo cacheInfo, SortedDictionary<T, string> lookupToCacheKeyLookupMap, Func<ICollection<T>, ICollection<T>> getterByLookUps) where T : struct
	{
		RobloxCache cacheForEntity = CacheFactory.GetCacheForEntity(cacheInfo);
		List<T> list = new List<T>();
		List<T> list2 = new List<T>();
		foreach (KeyValuePair<T, string> item in lookupToCacheKeyLookupMap)
		{
			if (cacheForEntity.GetEntityIDFromLookupCache<T>(cacheInfo, item.Value, out var entityId))
			{
				list.Add(entityId);
				continue;
			}
			list2.Add(item.Key);
			list.Add(default(T));
		}
		ICollection<T> collection = getterByLookUps(list2);
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (num >= collection.Count)
			{
				break;
			}
			if (list[i].Equals(default(T)))
			{
				list[i] = collection.ElementAt(num);
				num++;
			}
		}
		return list.Where((T x) => !x.Equals(default(T))).ToList();
	}

	public static void ProcessEntityChange<T>(ICacheableObject<T> entity, StateChangeEventType stateChangeEventType)
	{
		CacheFactory.GetCacheForEntity(entity.CacheInfo).ProcessEntityChange(entity, stateChangeEventType);
	}

	public static DateTime Snap(DateTime time, TimeSpan span)
	{
		if (time == DateTime.MaxValue)
		{
			return time;
		}
		if (time == DateTime.MinValue)
		{
			return time;
		}
		long ticks = time.Ticks;
		return new DateTime(ticks - ticks % span.Ticks);
	}
}
