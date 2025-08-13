using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Roblox.CachingV2.Core;

namespace Roblox.CachingV2.MemoryCache;

public class MemoryCacheWrapper : IMemoryCache, IRawCache
{
	private class NullMarker
	{
		public static NullMarker Instance { get; } = new NullMarker();

	}

	private readonly MemoryCacheConfiguration _Config;

	private readonly System.Runtime.Caching.MemoryCache _MemoryCache;

	public static MemoryCacheWrapper Default { get; } = new MemoryCacheWrapper(System.Runtime.Caching.MemoryCache.Default);


	public long CacheMemoryLimit => _MemoryCache.CacheMemoryLimit;

	public DefaultCacheCapabilities DefaultCacheCapabilities => _MemoryCache.DefaultCacheCapabilities;

	public string Name => _MemoryCache.Name;

	public long PhysicalMemoryLimit => _MemoryCache.PhysicalMemoryLimit;

	public TimeSpan PollingInterval => _MemoryCache.PollingInterval;

	public MemoryCacheWrapper(string name, MemoryCacheConfiguration config = null)
		: this(new System.Runtime.Caching.MemoryCache(name, TranslateConfig(config ?? new MemoryCacheConfiguration())))
	{
		_Config = config ?? new MemoryCacheConfiguration();
	}

	private MemoryCacheWrapper(System.Runtime.Caching.MemoryCache memoryCache)
	{
		_MemoryCache = memoryCache;
	}

	public void Set<TValue>(RawSetEntry<TValue> entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		object value = ((entry.Value == null) ? NullMarker.Instance : ((object)entry.Value));
		CacheItemPolicy cacheItemPolicyForEntry = GetCacheItemPolicyForEntry(entry);
		try
		{
			_MemoryCache.Set(entry.Key, value, cacheItemPolicyForEntry);
		}
		catch (Exception innerException)
		{
			throw new IOException("Error adding item to cache.", innerException);
		}
	}

	public Task SetAsync<TValue>(RawSetEntry<TValue> entry, CancellationToken cancellationToken)
	{
		Set(entry);
		return Task.FromResult(result: true);
	}

	public void Remove(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		try
		{
			_MemoryCache.Remove(key);
		}
		catch (Exception innerException)
		{
			throw new IOException("Error removing entry from cache.", innerException);
		}
	}

	public Task RemoveAsync(string key, CancellationToken cancellationToken)
	{
		Remove(key);
		return Task.FromResult(result: true);
	}

	public CacheGetResult<TValue> Get<TValue>(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		object obj;
		try
		{
			obj = _MemoryCache.Get(key);
		}
		catch (Exception innerException)
		{
			throw new IOException("Error getting value from cache.", innerException);
		}
		if (obj == null)
		{
			return CacheGetResult<TValue>.NotFound(key);
		}
		TValue entry;
		try
		{
			entry = ((obj == NullMarker.Instance) ? default(TValue) : ((TValue)obj));
		}
		catch (Exception innerException2)
		{
			throw new SerializationException($"Failed to deserialize value {obj} to type {typeof(TValue).Name}.", innerException2);
		}
		return new CacheGetResult<TValue>(key, entry);
	}

	public Task<CacheGetResult<TValue>> GetAsync<TValue>(string key, CancellationToken cancellationToken)
	{
		return Task.FromResult(Get<TValue>(key));
	}

	public IEnumerable<CacheGetResult<TValue>> MultiGet<TValue>(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		IDictionary<string, object> values = _MemoryCache.GetValues(keys);
		if (values == null)
		{
			return keys.Select(CacheGetResult<TValue>.NotFound);
		}
		CacheGetResult<TValue>[] array = new CacheGetResult<TValue>[keys.Count];
		int num = 0;
		foreach (string key in keys)
		{
			if (values.TryGetValue(key, out var value))
			{
				TValue entry;
				try
				{
					entry = ((value == NullMarker.Instance) ? default(TValue) : ((TValue)value));
				}
				catch (Exception innerException)
				{
					throw new SerializationException($"Failed to deserialize {value} to {typeof(TValue).Name}.", innerException);
				}
				array[num++] = new CacheGetResult<TValue>(key, entry);
			}
			else
			{
				array[num++] = CacheGetResult<TValue>.NotFound(key);
			}
		}
		return array;
	}

	public Task<IEnumerable<CacheGetResult<TValue>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		return Task.FromResult(MultiGet<TValue>(keys));
	}

	public void MultiSet<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries)
	{
		if (entries == null || entries.Any((RawSetEntry<TValue> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		foreach (RawSetEntry<TValue> entry in entries)
		{
			Set(entry);
		}
	}

	public Task MultiSetAsync<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries, CancellationToken cancellationToken)
	{
		if (entries == null || entries.Any((RawSetEntry<TValue> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		foreach (RawSetEntry<TValue> entry in entries)
		{
			Set(entry);
		}
		return Task.FromResult(result: true);
	}

	public void MultiRemove(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string e) => e == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			Remove(key);
		}
	}

	public Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string e) => e == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			Remove(key);
		}
		return Task.FromResult(result: true);
	}

	private CacheItemPolicy GetCacheItemPolicyForEntry<TValue>(RawSetEntry<TValue> entry)
	{
		CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
		if (entry.Expiration.HasValue)
		{
			cacheItemPolicy.AbsoluteExpiration = entry.Expiration.Value;
		}
		else
		{
			cacheItemPolicy.SlidingExpiration = _Config.DefaultSlidingExpiration;
		}
		return cacheItemPolicy;
	}

	private static NameValueCollection TranslateConfig(MemoryCacheConfiguration config)
	{
		return new NameValueCollection
		{
			{
				"cacheMemoryLimitMegabytes",
				config.CacheMemoryLimit.ToString()
			},
			{
				"physicalMemoryLimitPercentage",
				config.PhysicalMemoryLimit.ToString()
			},
			{
				"pollingInterval",
				config.PollingInterval.ToString("hh\\:mm\\:ss")
			}
		};
	}
}
