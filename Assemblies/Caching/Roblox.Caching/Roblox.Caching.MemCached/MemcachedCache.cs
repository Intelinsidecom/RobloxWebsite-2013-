using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Diagnostics;
using Roblox.Caching.Interfaces;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching.MemCached;

public class MemcachedCache : RobloxCache
{
	private static MemcachedCache _Instance;

	private static readonly object _InstanceLock = new object();

	private readonly ISharedCacheClientProvider _CacheClientProvider;

	private readonly IEntityRampUpAuthority _EntityRampUpAuthority;

	private readonly IEntitySerializer _EntitySerializer;

	private readonly ISettings _Settings;

	private MemcachedCache(ICounterRegistry counterRegistry, ISettings settings, ILogger logger)
		: this(new SharedCacheClientProvider(logger), EntityRampUpAuthority.GetInstance(), new CachePerformanceCounters(counterRegistry, "Memcache"), new EntitySerializer(settings, logger, counterRegistry), settings)
	{
	}

	internal MemcachedCache(ISharedCacheClientProvider sharedCacheClientProvider, IEntityRampUpAuthority entityRampUpAuthority, IRobloxCacheListener cacheListener, IEntitySerializer entitySerializer, ISettings settings)
	{
		_CacheClientProvider = sharedCacheClientProvider ?? throw new ArgumentNullException("sharedCacheClientProvider");
		_EntityRampUpAuthority = entityRampUpAuthority ?? throw new ArgumentNullException("entityRampUpAuthority");
		if (cacheListener == null)
		{
			throw new ArgumentNullException("cacheListener");
		}
		AddRobloxCacheListener(cacheListener);
		_EntitySerializer = entitySerializer ?? throw new ArgumentNullException("entitySerializer");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	public static MemcachedCache GetInstance()
	{
		if (_Instance == null)
		{
			lock (_InstanceLock)
			{
				if (_Instance == null)
				{
					_Instance = new MemcachedCache(StaticCounterRegistry.Instance, Settings.Default, StaticLoggerRegistry.Instance);
				}
			}
		}
		return _Instance;
	}

	public override TEntity GetEntityFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter)
	{
		return RemoteGet(cacheInfo, entityId, getter);
	}

	public override void ProcessEntityChange<T>(ICacheableObject<T> entity, StateChangeEventType stateChangeEventType)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(entity.CacheInfo);
		string key = entity.GetKey();
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(entity.CacheInfo.EntityType))
		{
			cacheClientForEntity.Remove(key);
			return;
		}
		switch (stateChangeEventType)
		{
		case StateChangeEventType.Creation:
			AddToRemoteCache(cacheClientForEntity, key, entity);
			break;
		case StateChangeEventType.Modification:
			AddToRemoteCache(cacheClientForEntity, key, entity);
			break;
		case StateChangeEventType.Deletion:
			AddNullToRemoteCache(cacheClientForEntity, key);
			break;
		}
	}

	public override void AddEntityToCache<TIndex>(ICacheableObject<TIndex> entity)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(entity.CacheInfo);
		string key = entity.GetKey();
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(entity.CacheInfo.EntityType))
		{
			cacheClientForEntity.Remove(key);
		}
		else
		{
			AddToRemoteCache(cacheClientForEntity, key, entity);
		}
	}

	public override void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			cacheClientForEntity.Remove(key);
		}
		else
		{
			cacheClientForEntity.Set(key, id, _Settings.RemoteCacheableExpiration);
		}
	}

	private TEntity RemoteGet<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter) where TEntity : class, ICacheableObject<TIndex>
	{
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		bool flag = _EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType);
		if (!flag)
		{
			bool valueFound;
			TEntity fromRemoteCache = GetFromRemoteCache<TEntity>(cacheInfo, cacheClientForEntity, key, out valueFound);
			if (valueFound)
			{
				return fromRemoteCache;
			}
		}
		OnMiss(cacheInfo.EntityType);
		TEntity val = getter();
		if (flag)
		{
			cacheClientForEntity.Remove(key);
		}
		else
		{
			AddToRemoteCache(cacheClientForEntity, key, val);
		}
		return val;
	}

	private TEntity GetFromRemoteCache<TEntity>(ICacheInfo cacheInfo, ISharedCacheClient sharedCacheClient, string key, out bool valueFound) where TEntity : class, ICacheableObject
	{
		OnQuery(cacheInfo.EntityType);
		if (sharedCacheClient.QueryBytes(key, out var value))
		{
			valueFound = true;
			OnHit(cacheInfo.EntityType);
			if (value == null)
			{
				return null;
			}
			TEntity item = _EntitySerializer.TryDeserializeFromRemoteCache<TEntity>(sharedCacheClient, value, key).Entity;
			if (item != null)
			{
				return item;
			}
		}
		valueFound = false;
		return null;
	}

	private IEnumerable<(string Key, TEntity Entity, bool CacheHit)> GetFromRemoteCache<TEntity>(ICacheInfo cacheInfo, ISharedCacheClient sharedCacheClient, IReadOnlyCollection<string> keys) where TEntity : class, ICacheableObject
	{
		OnQuery(cacheInfo.EntityType, keys.Count);
		IEnumerable<(string, byte[], bool)> enumerable = sharedCacheClient.QueryBytes(keys.ToArray());
		int numberOfCacheHits = 0;
		foreach (var (text, array, flag) in enumerable)
		{
			if (flag)
			{
				numberOfCacheHits++;
			}
			if (array == null)
			{
				yield return (text, null, flag);
				continue;
			}
			(bool Success, TEntity Entity) tuple2 = _EntitySerializer.TryDeserializeFromRemoteCache<TEntity>(sharedCacheClient, array, text);
			bool item = tuple2.Success;
			TEntity item2 = tuple2.Entity;
			bool item3 = item && flag;
			yield return (text, item2, item3);
		}
		if (numberOfCacheHits > 0)
		{
			OnHit(cacheInfo.EntityType, numberOfCacheHits);
		}
	}

	private void AddToRemoteCache<TEntity>(ISharedCacheClient sharedCacheClient, string key, TEntity entity) where TEntity : ICacheableObject
	{
		if (entity != null)
		{
			byte[] array = _EntitySerializer.Serialize(entity);
			if (array != null)
			{
				sharedCacheClient.SetBytes(key, array, _Settings.RemoteCacheableExpiration);
			}
		}
		else
		{
			AddCheckedNullToCache(sharedCacheClient, key);
		}
	}

	private void AddCheckedNullToCache(ISharedCacheClient sharedCacheClient, string key)
	{
		sharedCacheClient.CheckAndSet(key, (byte[])null, _Settings.RemoteCacheableExpiration, 0uL);
	}

	private void AddNullToRemoteCache(ISharedCacheClient sharedCacheClient, string key)
	{
		sharedCacheClient.SetBytes(key, null, _Settings.RemoteCacheableExpiration);
	}

	public override void AddNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			cacheClientForEntity.Remove(key);
		}
		else
		{
			AddNullToRemoteCache(cacheClientForEntity, key);
		}
	}

	public override void AddCheckedNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		AddCheckedNullToCache(cacheClientForEntity, key);
	}

	public override void AddNullEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup)
	{
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			cacheClientForEntity.Remove(key);
		}
		else
		{
			AddNullToRemoteCache(cacheClientForEntity, key);
		}
	}

	public override TEntity TryGetEntityOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, out bool cacheHit)
	{
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			cacheHit = false;
			return null;
		}
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		return GetFromRemoteCache<TEntity>(cacheInfo, cacheClientForEntity, key, out cacheHit);
	}

	public override IEnumerable<(TIndex Id, TEntity Result, bool CacheHit)> TryGetEntitiesOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, IReadOnlyCollection<TIndex> entityIds)
	{
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			return ((IEnumerable<TIndex>)entityIds).Select((Func<TIndex, (TIndex, TEntity, bool)>)((TIndex id) => (id, null, false)));
		}
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		Dictionary<string, TIndex> keysToIds = entityIds.ToDictionary((TIndex id) => Cacheable.BuildEntityKey(cacheInfo, id), (TIndex id) => id);
		return from r in GetFromRemoteCache<TEntity>(cacheInfo, cacheClientForEntity, (IReadOnlyCollection<string>)(object)keysToIds.Keys.ToArray())
			select (keysToIds[r.Key], r.Entity, r.CacheHit);
	}

	public override TEntity GetEntityFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, Func<TEntity> getter)
	{
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			return null;
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, entityIdLookup);
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		OnQuery(cacheInfo.EntityType);
		TEntity val;
		if (!cacheClientForEntity.Query(key, out TIndex value))
		{
			OnMiss(cacheInfo.EntityType);
			val = getter();
			if (val == null)
			{
				return null;
			}
			AddEntityToCache(val);
		}
		else
		{
			OnHit(cacheInfo.EntityType);
			val = CacheFactory.GetCacheForEntity(cacheInfo).GetEntityFromCache(cacheInfo, value, getter);
		}
		foreach (string item in val.BuildEntityIDLookups())
		{
			if (item.Equals(entityIdLookup))
			{
				return val;
			}
		}
		AddNullEntityIDToLookupCache(cacheInfo, entityIdLookup);
		return null;
	}

	public override bool GetEntityIDFromLookupCache<T>(ICacheInfo cacheInfo, string lookUp, out T entityId)
	{
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			entityId = default(T);
			return false;
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookUp);
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		OnQuery(cacheInfo.EntityType);
		if (!cacheClientForEntity.Query(key, out entityId))
		{
			OnMiss(cacheInfo.EntityType);
			return false;
		}
		OnHit(cacheInfo.EntityType);
		return true;
	}

	public override TEntity TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, out bool cacheHit)
	{
		if (_EntityRampUpAuthority.IsEntityTypeInRampUp(cacheInfo.EntityType))
		{
			cacheHit = false;
			return null;
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, entityIdLookup);
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		TEntity result = null;
		OnQuery(cacheInfo.EntityType);
		if (!cacheClientForEntity.Query(key, out TIndex value))
		{
			OnMiss(cacheInfo.EntityType);
			cacheHit = false;
			return result;
		}
		OnHit(cacheInfo.EntityType);
		return CacheFactory.GetCacheForEntity(cacheInfo).TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, value, out cacheHit);
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope, StateToken stateToken)
	{
		throw new NotImplementedException();
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope)
	{
		throw new NotImplementedException();
	}

	public override T GetCountFromCache<T>(ICacheInfo cacheInfo, string countId, CacheManager.GetCount<T> getter)
	{
		throw new NotImplementedException();
	}
}
