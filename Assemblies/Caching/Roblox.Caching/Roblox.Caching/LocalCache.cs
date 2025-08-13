using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Diagnostics;
using Roblox.Caching.Interfaces;
using Roblox.Caching.Properties;
using Roblox.Instrumentation;

namespace Roblox.Caching;

public abstract class LocalCache : RobloxCache, IRemoteCacheInvalidationSink
{
	private class ItemFetcher
	{
		private object _Value;

		public void Assign(object value)
		{
			_Value = value ?? _NullMarker;
		}

		public bool GetValue<T>(out T t)
		{
			if (_Value == null)
			{
				t = default(T);
				return false;
			}
			if (_Value is NullMarker)
			{
				t = default(T);
			}
			else
			{
				t = (T)_Value;
			}
			return true;
		}
	}

	[Serializable]
	private class NullMarker
	{
	}

	private static readonly NullMarker _NullMarker = new NullMarker();

	private const string _PerformanceCategory = "Roblox Cache Replication (CMN)";

	private const string _InstanceName = "LocalCache";

	private readonly ICounterRegistry _CounterRegistry;

	private readonly CachePerformanceCounters _CachePerformanceCounters;

	private readonly ConcurrentDictionary<string, ItemFetcher> _ItemFetchers = new ConcurrentDictionary<string, ItemFetcher>();

	private readonly bool _Replicate;

	public readonly IRateOfCountsPerSecondCounter InsertCount;

	public readonly IRateOfCountsPerSecondCounter LocalRemoveCount;

	public readonly IRateOfCountsPerSecondCounter RemoteRemoveCount;

	public readonly IRateOfCountsPerSecondCounter RequestCount;

	public string NodeId { get; } = Guid.NewGuid().ToString("N").Substring(8);


	public string Topic { get; }

	public string TopicNamespace => "Common-";

	public static TimeSpan GlobalSlidingExpiration => Settings.Default.CacheSlidingExpiration;

	protected LocalCache(ICounterRegistry counterRegistry, bool replicate)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_CachePerformanceCounters = new CachePerformanceCounters(counterRegistry, "LocalCache");
		RequestCount = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox Cache Replication (CMN)", "Request Count / sec");
		InsertCount = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox Cache Replication (CMN)", "Insert Count / sec");
		LocalRemoveCount = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox Cache Replication (CMN)", "Local Count / sec");
		RemoteRemoveCount = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox Cache Replication (CMN)", "Remote Count / sec");
		_Replicate = replicate;
		Topic = "RBX-" + TopicNamespace + NodeId;
		if (_Replicate)
		{
			EntityCacheInvalidator.AddListener(this);
		}
	}

	private static TEntity FillItemFetcher<TIndex, TEntity>(Func<TEntity> getter, ItemFetcher itemFetcher) where TEntity : ICacheableObject<TIndex>
	{
		if (itemFetcher.GetValue<TEntity>(out var t))
		{
			return t;
		}
		lock (itemFetcher)
		{
			if (itemFetcher.GetValue<TEntity>(out t))
			{
				return t;
			}
			t = getter();
			itemFetcher.Assign(t);
			return t;
		}
	}

	private T FillItemFetcher<T>(ICacheInfo cacheInfo, CacheManager.GetCount<T> getter, string key, ItemFetcher itemFetcher) where T : struct
	{
		if (itemFetcher.GetValue<T>(out var t))
		{
			return t;
		}
		lock (itemFetcher)
		{
			if (itemFetcher.GetValue<T>(out t))
			{
				return t;
			}
			CacheManager.CachePolicy policy = new CacheManager.CachePolicy();
			t = getter(ref policy);
			string text = ((policy.ScopeFilter != 0) ? Cacheable.BuildStateTokenKey(cacheInfo, policy.ScopeFilter, policy.CachedStateQualifier) : Cacheable.BuildStateTokenKey(cacheInfo, policy.ScopeFilter, null));
			AddStateTokenToCache(text);
			string[] dependency = new string[1] { text };
			itemFetcher.Assign(t);
			if (policy.Expiration < TimeSpan.MaxValue)
			{
				SetValue(key, t, dependency, policy.Expiration);
			}
			else
			{
				SetValue(key, t, dependency);
			}
			return t;
		}
	}

	private ICollection<T> FillItemFetcher<T>(ICacheInfo cacheInfo, CacheManager.GetIDCollection<T> getter, string key, ItemFetcher itemFetcher) where T : struct
	{
		if (itemFetcher.GetValue<ICollection<T>>(out var t))
		{
			return t;
		}
		lock (itemFetcher)
		{
			if (itemFetcher.GetValue<ICollection<T>>(out t))
			{
				return t;
			}
			CacheManager.CachePolicy policy = new CacheManager.CachePolicy();
			t = getter(ref policy);
			string text = ((policy.ScopeFilter != 0) ? Cacheable.BuildStateTokenKey(cacheInfo, policy.ScopeFilter, policy.CachedStateQualifier) : Cacheable.BuildStateTokenKey(cacheInfo, policy.ScopeFilter, null));
			AddStateTokenToCache(text);
			string[] dependency = new string[1] { text };
			itemFetcher.Assign(t);
			if (policy.Expiration < TimeSpan.MaxValue)
			{
				SetValue(key, t, dependency, policy.Expiration);
			}
			else
			{
				SetValue(key, t, dependency);
			}
			return t;
		}
	}

	private bool GetValue<T>(string key, out T result)
	{
		RequestCount.Increment();
		object obj = RawGetValue(key);
		if (obj == null)
		{
			result = default(T);
			return false;
		}
		if (obj is NullMarker)
		{
			result = default(T);
		}
		else
		{
			result = (T)obj;
		}
		return true;
	}

	private IEnumerable<(string Key, T Value, bool CacheHit)> GetValues<T>(IReadOnlyCollection<string> keys)
	{
		RequestCount.Increment();
		IEnumerable<(string, object)> enumerable = RawGetValues(keys);
		foreach (var (item, obj) in enumerable)
		{
			if (obj == null)
			{
				yield return (item, default(T), false);
			}
			else if (obj is NullMarker)
			{
				yield return (item, default(T), true);
			}
			else
			{
				yield return (item, (T)obj, true);
			}
		}
	}

	private void PerformItemFetchersCleanUp(bool createdCachedObject, string key)
	{
		if (createdCachedObject)
		{
			_ItemFetchers.TryRemove(key, out var _);
		}
	}

	private void Remove(ICacheInfo cacheInfo, string key)
	{
		RawRemove(key);
		LocalRemoveCount.Increment();
		if (_Replicate)
		{
			EntityCacheInvalidator.RemoveRemoteKey(this, cacheInfo.EntityType, key);
		}
	}

	private void SetValue(string key, object item)
	{
		if (item == null)
		{
			item = _NullMarker;
		}
		RawSetValue(key, item);
		InsertCount.Increment();
	}

	private void SetValue(string key, object item, string[] dependency)
	{
		if (item == null)
		{
			item = _NullMarker;
		}
		RawSetValue(key, item, dependency);
		InsertCount.Increment();
	}

	private void SetValue(string key, object item, string[] dependency, TimeSpan expiration)
	{
		if (item == null)
		{
			item = _NullMarker;
		}
		RawSetValue(key, item, dependency, expiration);
		InsertCount.Increment();
	}

	private void InvalidateRemoteCaches<T>(ICacheableObject<T> entity)
	{
		CacheInfo cacheInfo = entity.CacheInfo;
		CacheabilitySettings cacheability = cacheInfo.Cacheability;
		if (cacheability.EntityIsCacheable)
		{
			EntityCacheInvalidator.RemoveRemoteKey(key: entity.GetKey(), sink: this, entityType: cacheInfo.EntityType);
		}
		if (!cacheability.IDLookupsAreCacheable)
		{
			return;
		}
		foreach (string item in entity.BuildEntityIDLookups())
		{
			string key2 = Cacheable.BuildEntityIDLookupKey(cacheInfo, item);
			EntityCacheInvalidator.RemoveRemoteKey(this, cacheInfo.EntityType, key2);
		}
	}

	protected abstract void AddStateTokenToCache(string key);

	protected abstract object RawGetValue(string key);

	protected abstract IEnumerable<(string Key, object Value)> RawGetValues(IReadOnlyCollection<string> keys);

	protected abstract void RawAddCountToCache<T>(T count, CacheManager.CachePolicy policy, string countCacheKey, string[] dependencyKeys) where T : struct;

	protected abstract void RawRemove(string key);

	protected abstract void RawSetValue(string key, object item);

	protected abstract void RawSetValue(string key, object item, string[] dependencyKeys);

	protected abstract void RawSetValue(string key, object item, string[] dependencyKeys, TimeSpan expiration);

	public void AddEntityIDCollectionToCache<T>(CacheInfo cacheInfo, string collectionId, ICollection<T> collection, CacheManager.CacheScopeFilter collectionScope, string cachedStateQualifier) where T : struct
	{
		if (cacheInfo.Cacheability.CollectionsAreCacheable)
		{
			string text = ((collectionScope != 0) ? Cacheable.BuildStateTokenKey(cacheInfo, collectionScope, cachedStateQualifier) : Cacheable.BuildStateTokenKey(cacheInfo, collectionScope, null));
			AddStateTokenToCache(text);
			string[] dependency = new string[1] { text };
			string key = Cacheable.BuildEntityIDCollectionKey(cacheInfo, collectionId);
			SetValue(key, collection, dependency);
		}
	}

	public override void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id)
	{
		if (cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
			string[] dependencyKeys = new string[1] { Cacheable.BuildEntityKey(cacheInfo, id.ToString()) };
			RawSetValue(key, id, dependencyKeys);
			InsertCount.Increment();
		}
	}

	public override void AddEntityToCache<T>(ICacheableObject<T> entity)
	{
		if (entity.CacheInfo.Cacheability.EntityIsCacheable)
		{
			SetValue(entity.GetKey(), entity);
		}
	}

	public override void AddNullEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup)
	{
		if (cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
			RawSetValue(key, _NullMarker);
			InsertCount.Increment();
		}
	}

	public override void AddNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		if (cacheInfo.Cacheability.EntityIsCacheable)
		{
			string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
			RawSetValue(key, _NullMarker);
			InsertCount.Increment();
		}
	}

	public override void AddCheckedNullEntityToCache(ICacheInfo cacheInfo, string entityId)
	{
		if (cacheInfo.Cacheability.EntityIsCacheable)
		{
			string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
			if (RawGetValue(key) == null)
			{
				RawSetValue(key, _NullMarker);
				InsertCount.Increment();
			}
		}
	}

	public override T GetCountFromCache<T>(ICacheInfo cacheInfo, string countId, CacheManager.GetCount<T> getter)
	{
		if (!cacheInfo.Cacheability.CountsAreCacheable)
		{
			CacheManager.CachePolicy policy = new CacheManager.CachePolicy();
			return getter(ref policy);
		}
		string key = Cacheable.BuildCountKey(cacheInfo, countId);
		if (GetValue<T>(key, out var result))
		{
			return result;
		}
		bool createdCachedObject = false;
		try
		{
			ItemFetcher orAdd = _ItemFetchers.GetOrAdd(key, delegate
			{
				createdCachedObject = true;
				return new ItemFetcher();
			});
			return FillItemFetcher(cacheInfo, getter, key, orAdd);
		}
		finally
		{
			PerformItemFetchersCleanUp(createdCachedObject, key);
		}
	}

	public override TEntity TryGetEntityOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, out bool cacheHit)
	{
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			cacheHit = false;
			return null;
		}
		_CachePerformanceCounters.OnQuery(cacheInfo.EntityType);
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		if (GetValue<TEntity>(key, out var result))
		{
			cacheHit = true;
			_CachePerformanceCounters.OnHit(cacheInfo.EntityType);
			return result;
		}
		cacheHit = false;
		return null;
	}

	public override IEnumerable<(TIndex Id, TEntity Result, bool CacheHit)> TryGetEntitiesOnlyFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, IReadOnlyCollection<TIndex> entityIds)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		if (entityIds == null)
		{
			throw new ArgumentNullException("entityIds");
		}
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			return ((IEnumerable<TIndex>)entityIds).Select((Func<TIndex, (TIndex, TEntity, bool)>)((TIndex id) => (id, null, false)));
		}
		_CachePerformanceCounters.OnQuery(cacheInfo.EntityType, entityIds.Count);
		Dictionary<string, TIndex> dictionary = entityIds.ToDictionary((TIndex id) => Cacheable.BuildEntityKey(cacheInfo, id), (TIndex id) => id);
		IEnumerable<(string Key, TEntity Value, bool CacheHit)> values = GetValues<TEntity>(dictionary.Keys);
		(TIndex, TEntity, bool)[] array = new(TIndex, TEntity, bool)[entityIds.Count];
		int num = 0;
		int num2 = 0;
		foreach (var (key, item, flag) in values)
		{
			if (flag)
			{
				num2++;
			}
			array[num++] = (dictionary[key], item, flag);
		}
		if (num2 > 0)
		{
			_CachePerformanceCounters.OnHit(cacheInfo.EntityType, num2);
		}
		return array;
	}

	public override TEntity GetEntityFromCache<TIndex, TEntity>(ICacheInfo cacheInfo, TIndex entityId, Func<TEntity> getter)
	{
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			return getter();
		}
		_CachePerformanceCounters.OnQuery(cacheInfo.EntityType);
		string key = Cacheable.BuildEntityKey(cacheInfo, entityId);
		if (GetValue<TEntity>(key, out var result))
		{
			_CachePerformanceCounters.OnHit(cacheInfo.EntityType);
			return result;
		}
		bool createdCachedObject = false;
		try
		{
			ItemFetcher orAdd = _ItemFetchers.GetOrAdd(key, delegate
			{
				createdCachedObject = true;
				return new ItemFetcher();
			});
			return FillItemFetcher<TIndex, TEntity>(getter, orAdd);
		}
		finally
		{
			PerformItemFetchersCleanUp(createdCachedObject, key);
		}
	}

	public override TEntity TryGetEntityOnlyFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, out bool cacheHit)
	{
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			cacheHit = false;
			return null;
		}
		cacheHit = CacheManager.GetEntityIDFromLookupCache<TIndex>(cacheInfo, entityIdLookup, out var entityId);
		if (!cacheHit)
		{
			return null;
		}
		if (entityId.CompareTo(default(TIndex)) != 0)
		{
			return CacheManager.TryGetEntityOnlyFromCache<TIndex, TEntity>(cacheInfo, entityId, out cacheHit);
		}
		return null;
	}

	public override TEntity GetEntityFromCacheByIDLookup<TIndex, TEntity>(ICacheInfo cacheInfo, string entityIdLookup, Func<TEntity> getter)
	{
		if (!cacheInfo.Cacheability.EntityIsCacheable)
		{
			return getter();
		}
		if (!CacheManager.GetEntityIDFromLookupCache<TIndex>(cacheInfo, entityIdLookup, out var entityId))
		{
			return getter();
		}
		if (entityId.CompareTo(default(TIndex)) != 0)
		{
			return CacheManager.GetEntityFromCache(cacheInfo, entityId, getter);
		}
		return null;
	}

	public override bool GetEntityIDFromLookupCache<T>(ICacheInfo cacheInfo, string lookUp, out T entityId)
	{
		bool result = false;
		entityId = default(T);
		if (cacheInfo.Cacheability.IDLookupsAreCacheable)
		{
			RequestCount.Increment();
			string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookUp);
			object obj = RawGetValue(key);
			if (obj != null)
			{
				result = true;
				if (!(obj is NullMarker))
				{
					entityId = (T)obj;
				}
			}
		}
		return result;
	}

	public ICollection<T> GetIDCollectionFromCache<T>(ICacheInfo cacheInfo, string collectionId, CacheManager.GetIDCollection<T> getter) where T : struct
	{
		if (!cacheInfo.Cacheability.CollectionsAreCacheable)
		{
			CacheManager.CachePolicy policy = new CacheManager.CachePolicy();
			return getter(ref policy);
		}
		string key = Cacheable.BuildEntityIDCollectionKey(cacheInfo, collectionId);
		if (GetValue<ICollection<T>>(key, out var result))
		{
			return result;
		}
		bool createdCachedObject = false;
		try
		{
			ItemFetcher orAdd = _ItemFetchers.GetOrAdd(key, delegate
			{
				createdCachedObject = true;
				return new ItemFetcher();
			});
			return FillItemFetcher(cacheInfo, getter, key, orAdd);
		}
		finally
		{
			PerformItemFetchersCleanUp(createdCachedObject, key);
		}
	}

	public override void ProcessEntityChange<T>(ICacheableObject<T> entity, StateChangeEventType stateChangeEventType)
	{
		if (entity == null)
		{
			return;
		}
		switch (stateChangeEventType)
		{
		case StateChangeEventType.Creation:
			if (entity.CacheInfo.Cacheability.HasUnqualifiedCollections)
			{
				RemoveStateTokenFromCache(entity.CacheInfo, CacheManager.CacheScopeFilter.Unqualified);
			}
			RemoveStateTokensFromCache(entity);
			AddEntityToCache(entity);
			if (_Replicate && entity.CacheInfo.Cacheability.EntityIsCacheable && entity.CacheInfo.IsNullCacheable)
			{
				InvalidateRemoteCaches(entity);
			}
			break;
		case StateChangeEventType.Deletion:
			AddNullEntityToCache(entity.CacheInfo, entity.ID.ToString());
			if (_Replicate && entity.CacheInfo.Cacheability.EntityIsCacheable)
			{
				InvalidateRemoteCaches(entity);
			}
			RemoveStateTokensFromCache(entity);
			if (entity.CacheInfo.Cacheability.HasUnqualifiedCollections)
			{
				RemoveStateTokenFromCache(entity.CacheInfo, CacheManager.CacheScopeFilter.Unqualified);
			}
			break;
		case StateChangeEventType.Modification:
			if (entity.CacheInfo.Cacheability.HasUnqualifiedCollections)
			{
				RemoveStateTokenFromCache(entity.CacheInfo, CacheManager.CacheScopeFilter.Unqualified);
			}
			RemoveStateTokensFromCache(entity);
			if (_Replicate && entity.CacheInfo.Cacheability.EntityIsCacheable)
			{
				InvalidateRemoteCaches(entity);
			}
			AddEntityToCache(entity);
			break;
		}
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope)
	{
		CacheabilitySettings cacheability = cacheInfo.Cacheability;
		if (cacheability.CollectionsAreCacheable || cacheability.CountsAreCacheable)
		{
			string key = Cacheable.BuildStateTokenKey(cacheInfo, cacheScope, null);
			Remove(cacheInfo, key);
		}
	}

	public override void RemoveStateTokenFromCache(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter cacheScope, StateToken stateToken)
	{
		CacheabilitySettings cacheability = cacheInfo.Cacheability;
		if (cacheability.CollectionsAreCacheable || cacheability.CountsAreCacheable)
		{
			string key = Cacheable.BuildStateTokenKey(cacheInfo, cacheScope, stateToken.Value);
			Remove(cacheInfo, key);
		}
	}

	public void RemoveStateTokensFromCache<T>(ICacheableObject<T> entity)
	{
		CacheabilitySettings cacheability = entity.CacheInfo.Cacheability;
		if (!cacheability.CollectionsAreCacheable && !cacheability.CountsAreCacheable)
		{
			return;
		}
		foreach (StateToken item in entity.BuildStateTokenCollection())
		{
			RemoveStateTokenFromCache(entity.CacheInfo, CacheManager.CacheScopeFilter.Qualified, item);
		}
	}

	public void OnRemoteRemove(string key)
	{
		RawRemove(key);
		RemoteRemoveCount.Increment();
	}
}
