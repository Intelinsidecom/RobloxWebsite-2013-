using System;
using System.Collections.Generic;
using Roblox.Caching.Interfaces;

namespace Roblox.Caching;

public abstract class RobloxCache : IRobloxCacheListener
{
	private readonly List<IRobloxCacheListener> _Listeners = new List<IRobloxCacheListener>();

	public abstract TEntity GetEntityFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter) where TEntity : class, ICacheableObject<TIndex>;

	public abstract TEntity GetEntityFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, Func<TEntity> getter) where TIndex : IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>;

	public abstract bool GetEntityIDFromLookupCache<TIndex>(ICacheInfo cacheInfo, string lookUp, out TIndex entityId);

	public abstract void ProcessEntityChange<TIndex>(ICacheableObject<TIndex> entity, StateChangeEventType stateChangeEventType);

	public abstract void AddEntityToCache<TIndex>(ICacheableObject<TIndex> entity);

	public abstract void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id);

	public abstract void AddNullEntityToCache(ICacheInfo cacheInfo, string entityId);

	public abstract void AddCheckedNullEntityToCache(ICacheInfo cacheInfo, string entityId);

	public abstract void AddNullEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup);

	public abstract TEntity TryGetEntityOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, out bool cacheHit) where TEntity : class, ICacheableObject<TIndex>;

	public abstract TEntity TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, out bool cacheHit) where TIndex : IComparable<TIndex> where TEntity : class, ICacheableObject<TIndex>;

	public abstract IEnumerable<(TIndex Id, TEntity Result, bool CacheHit)> TryGetEntitiesOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, IReadOnlyCollection<TIndex> entityIds) where TEntity : class, ICacheableObject<TIndex>;

	public abstract T GetCountFromCache<T>(ICacheInfo cacheInfo, string countId, CacheManager.GetCount<T> getter) where T : struct;

	public abstract void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope);

	public abstract void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope, StateToken stateToken);

	public void AddRobloxCacheListener(IRobloxCacheListener listener)
	{
		_Listeners.Add(listener);
	}

	public void RemoveRobloxCacheListener(IRobloxCacheListener listener)
	{
		_Listeners.Remove(listener);
	}

	public void OnQuery(string entityType)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnQuery(entityType);
		}
	}

	public void OnHit(string entityType)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnHit(entityType);
		}
	}

	public void OnMiss(string entityType)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnMiss(entityType);
		}
	}

	public void OnQuery(string entityType, int count)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnQuery(entityType, count);
		}
	}

	public void OnHit(string entityType, int count)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnHit(entityType, count);
		}
	}

	public void OnMiss(string entityType, int count)
	{
		foreach (IRobloxCacheListener listener in _Listeners)
		{
			listener.OnMiss(entityType, count);
		}
	}
}
