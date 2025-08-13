using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using Roblox.Caching.Properties;
using Roblox.Instrumentation;

namespace Roblox.Caching.DotNet;

internal class DotNetCoreCache : LocalCache
{
	private static readonly object _Token = new object();

	internal TimeSpan SlidingExpiration => Settings.Default.CacheSlidingExpiration;

	public DotNetCoreCache(ICounterRegistry counterRegistry, bool replicate)
		: base(counterRegistry, replicate)
	{
	}

	protected override void AddStateTokenToCache(string key)
	{
		if (MemoryCache.Default.Get(key) == null)
		{
			MemoryCache.Default.Add(key, _Token, CreateStandardExpirationPolicy());
		}
	}

	protected override void RawAddCountToCache<T>(T count, CacheManager.CachePolicy policy, string countCacheKey, string[] dependencyKeys)
	{
		if (policy.Expiration == TimeSpan.MaxValue)
		{
			CacheItemPolicy cacheItemPolicy = CreateStandardExpirationPolicy();
			cacheItemPolicy.ChangeMonitors.Add(MemoryCache.Default.CreateCacheEntryChangeMonitor(dependencyKeys));
			MemoryCache.Default.Add(countCacheKey, count, cacheItemPolicy);
		}
		else
		{
			CacheItemPolicy cacheItemPolicy2 = new CacheItemPolicy
			{
				AbsoluteExpiration = policy.UtcExpirationDate,
				SlidingExpiration = ObjectCache.NoSlidingExpiration
			};
			cacheItemPolicy2.ChangeMonitors.Add(MemoryCache.Default.CreateCacheEntryChangeMonitor(dependencyKeys));
			MemoryCache.Default.Add(countCacheKey, count, cacheItemPolicy2);
		}
	}

	protected override object RawGetValue(string key)
	{
		return MemoryCache.Default[key];
	}

	protected override IEnumerable<(string Key, object Value)> RawGetValues(IReadOnlyCollection<string> keys)
	{
		return keys.Select((string key) => (key, MemoryCache.Default[key])).ToArray();
	}

	protected override void RawRemove(string key)
	{
		MemoryCache.Default.Remove(key);
	}

	protected override void RawSetValue(string key, object item)
	{
		MemoryCache.Default.Set(key, item, CreateStandardExpirationPolicy());
	}

	protected override void RawSetValue(string key, object item, string[] dependencyKeys)
	{
		CacheItemPolicy cacheItemPolicy = CreateStandardExpirationPolicy();
		cacheItemPolicy.ChangeMonitors.Add(MemoryCache.Default.CreateCacheEntryChangeMonitor(dependencyKeys));
		MemoryCache.Default.Set(key, item, cacheItemPolicy);
	}

	protected override void RawSetValue(string key, object item, string[] dependencyKeys, TimeSpan expiration)
	{
		CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
		{
			AbsoluteExpiration = DateTime.SpecifyKind(DateTime.UtcNow.Add(expiration), DateTimeKind.Utc),
			SlidingExpiration = ObjectCache.NoSlidingExpiration
		};
		cacheItemPolicy.ChangeMonitors.Add(MemoryCache.Default.CreateCacheEntryChangeMonitor(dependencyKeys));
		MemoryCache.Default.Add(key, item, cacheItemPolicy);
	}

	private CacheItemPolicy CreateStandardExpirationPolicy()
	{
		return new CacheItemPolicy
		{
			AbsoluteExpiration = ObjectCache.InfiniteAbsoluteExpiration,
			SlidingExpiration = SlidingExpiration
		};
	}
}
