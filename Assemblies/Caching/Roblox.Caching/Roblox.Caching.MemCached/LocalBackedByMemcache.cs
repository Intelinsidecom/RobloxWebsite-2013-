using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.DotNet;
using Roblox.Caching.Interfaces;
using Roblox.Instrumentation;

namespace Roblox.Caching.MemCached;

internal class LocalBackedByMemcache : RobloxCache
{
	private readonly LocalCache _LocalCache;

	private readonly MemcachedCache _MemcachedCache;

	public LocalBackedByMemcache()
	{
		_LocalCache = new DotNetCoreCache(StaticCounterRegistry.Instance, replicate: true);
		_MemcachedCache = MemcachedCache.GetInstance();
	}

	public override TEntity GetEntityFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter)
	{
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			return getter();
		}
		return _LocalCache.GetEntityFromCache(cacheInfo, entityId, delegate
		{
			TEntity entityFromCache = _MemcachedCache.GetEntityFromCache(cacheInfo, entityId, getter);
			if (entityFromCache == null)
			{
				_LocalCache.AddCheckedNullEntityToCache(cacheInfo, entityId.ToString());
			}
			else
			{
				_LocalCache.AddEntityToCache(entityFromCache);
			}
			return entityFromCache;
		});
	}

	public override void ProcessEntityChange<TIndex>(ICacheableObject<TIndex> entity, StateChangeEventType stateChangeEventType)
	{
		_MemcachedCache.ProcessEntityChange(entity, stateChangeEventType);
		_LocalCache.ProcessEntityChange(entity, stateChangeEventType);
	}

	public override void AddEntityToCache<TIndex>(ICacheableObject<TIndex> entity)
	{
		if (entity.CacheInfo.Cacheability.EntityIsCacheable)
		{
			_MemcachedCache.AddEntityToCache(entity);
			_LocalCache.AddEntityToCache(entity);
		}
	}

	public override void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id)
	{
		if (cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			_LocalCache.AddEntityIDToLookupCache(cacheInfo, lookup, id);
		}
	}

	public override void AddNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		if (cacheInfo.Cacheability.EntityIsCacheable)
		{
			_MemcachedCache.AddNullEntityToCache(cacheInfo, entityId);
			_LocalCache.AddNullEntityToCache(cacheInfo, entityId);
		}
	}

	public override void AddCheckedNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		if (cacheInfo.Cacheability.EntityIsCacheable)
		{
			_MemcachedCache.AddCheckedNullEntityToCache(cacheInfo, entityId);
			_LocalCache.AddCheckedNullEntityToCache(cacheInfo, entityId);
		}
	}

	public override void AddNullEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup)
	{
		if (cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			_LocalCache.AddNullEntityIDToLookupCache(cacheInfo, lookup);
		}
	}

	public override TEntity TryGetEntityOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, out bool cacheHit)
	{
		TEntity result = _LocalCache.TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, entityId, out cacheHit);
		if (cacheHit)
		{
			return result;
		}
		result = _MemcachedCache.TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, entityId, out cacheHit);
		if (cacheHit)
		{
			if (result == null)
			{
				_LocalCache.AddNullEntityToCache(cacheInfo, entityId.ToString());
			}
			else
			{
				_LocalCache.AddEntityToCache(result);
			}
		}
		return result;
	}

	public override IEnumerable<(TIndex Id, TEntity Result, bool CacheHit)> TryGetEntitiesOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, IReadOnlyCollection<TIndex> entityIds)
	{
		(TIndex, TEntity, bool)[] array = _LocalCache.TryGetEntitiesOnlyFromCache<TIndex, TEntity>(cacheInfo, entityIds).ToArray();
		(TIndex, TEntity, bool)[] source = array.Where(((TIndex Id, TEntity Result, bool CacheHit) lr) => !lr.CacheHit).ToArray();
		if (source.Any())
		{
			TIndex[] entityIds2 = source.Select(((TIndex Id, TEntity Result, bool CacheHit) lcmr) => lcmr.Id).ToArray();
			Dictionary<TIndex, (TIndex Id, TEntity Result, bool CacheHit)> memcachedResults = _MemcachedCache.TryGetEntitiesOnlyFromCache<TIndex, TEntity>(cacheInfo, (IReadOnlyCollection<TIndex>)(object)entityIds2).ToDictionary(((TIndex Id, TEntity Result, bool CacheHit) r) => r.Id, ((TIndex Id, TEntity Result, bool CacheHit) r) => r);
			foreach (KeyValuePair<TIndex, (TIndex, TEntity, bool)> item in memcachedResults.Where((KeyValuePair<TIndex, (TIndex Id, TEntity Result, bool CacheHit)> r) => r.Value.CacheHit))
			{
				if (item.Value.Item2 == null)
				{
					_LocalCache.AddNullEntityToCache(cacheInfo, item.Value.Item1.ToString());
				}
				else
				{
					_LocalCache.AddEntityToCache(item.Value.Item2);
				}
			}
			array = array.Select(((TIndex Id, TEntity Result, bool CacheHit) r) => (!r.CacheHit) ? memcachedResults[r.Id] : r).ToArray();
		}
		return array;
	}

	public override T GetCountFromCache<T>(ICacheInfo cacheInfo, string countId, CacheManager.GetCount<T> getter)
	{
		if (!cacheInfo.Cacheability.CountsAreCacheable)
		{
			CacheManager.CachePolicy policy = new CacheManager.CachePolicy();
			return getter(ref policy);
		}
		return _LocalCache.GetCountFromCache(cacheInfo, countId, getter);
	}

	public override TEntity GetEntityFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, Func<TEntity> getter)
	{
		if (!cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			return getter();
		}
		return _LocalCache.GetEntityFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, getter);
	}

	public override bool GetEntityIDFromLookupCache<T>(ICacheInfo cacheInfo, string lookUp, out T entityId)
	{
		if (!cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			entityId = default(T);
			return false;
		}
		return _LocalCache.GetEntityIDFromLookupCache<T>(cacheInfo, lookUp, out entityId);
	}

	public override TEntity TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, out bool cacheHit)
	{
		return _LocalCache.TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(cacheInfo, entityIdLookup, out cacheHit);
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope, StateToken stateToken)
	{
		CacheabilitySettings cacheability = cacheInfo.Cacheability;
		if (cacheability.CollectionsAreCacheable || cacheability.CountsAreCacheable)
		{
			_LocalCache.RemoveStateTokenFromCache(cacheInfo, cacheScope, stateToken);
		}
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope)
	{
		CacheabilitySettings cacheability = cacheInfo.Cacheability;
		if (cacheability.CollectionsAreCacheable || cacheability.CountsAreCacheable)
		{
			_LocalCache.RemoveStateTokenFromCache(cacheInfo, cacheScope);
		}
	}
}
