using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public class BasicDictionaryRawCache : IRawCache
{
	private class ExpirationAwareEntry
	{
		public byte[] Value { get; }

		public DateTime? Expiration { get; }

		public ExpirationAwareEntry(byte[] value, DateTime? expiration)
		{
			Value = value;
			Expiration = expiration;
		}
	}

	private readonly IDictionary<string, ExpirationAwareEntry> _Dictionary;

	private readonly ISerializer _Serializer;

	private readonly Func<DateTime> _GetCurrentTimeFunc;

	public BasicDictionaryRawCache(ISerializer serializer, Func<DateTime> getCurrentTimeFunc)
	{
		_Serializer = serializer ?? throw new ArgumentNullException("serializer");
		_GetCurrentTimeFunc = getCurrentTimeFunc ?? throw new ArgumentNullException("getCurrentTimeFunc");
		_Dictionary = new ConcurrentDictionary<string, ExpirationAwareEntry>();
	}

	public CacheGetResult<TValue> Get<TValue>(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		if (!_Dictionary.TryGetValue(key, out var value))
		{
			return CacheGetResult<TValue>.NotFound(key);
		}
		DateTime dateTime = _GetCurrentTimeFunc().ToUniversalTime();
		if (value.Expiration.HasValue && dateTime > value.Expiration.Value)
		{
			Remove(key);
			return CacheGetResult<TValue>.NotFound(key);
		}
		TValue entry = _Serializer.Deserialize<TValue>(value.Value);
		return new CacheGetResult<TValue>(key, entry);
	}

	public Task<CacheGetResult<TValue>> GetAsync<TValue>(string key, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(key, "key");
		return Task.FromResult(Get<TValue>(key));
	}

	public IEnumerable<CacheGetResult<TValue>> MultiGet<TValue>(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		return OrderResults(keys, keys.Select(Get<TValue>));
	}

	public Task<IEnumerable<CacheGetResult<TValue>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
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

	public async Task MultiSetAsync<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries, CancellationToken cancellationToken)
	{
		if (entries == null || entries.Any((RawSetEntry<TValue> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		foreach (RawSetEntry<TValue> entry in entries)
		{
			await SetAsync(entry, cancellationToken);
		}
	}

	public void Remove(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		_Dictionary.Remove(key);
	}

	public Task RemoveAsync(string key, CancellationToken cancellationToken)
	{
		Remove(key);
		return Task.FromResult(result: true);
	}

	public void Set<TValue>(RawSetEntry<TValue> entry)
	{
		NullChecker.ThrowIfNull(entry, "entry");
		ExpirationAwareEntry value = new ExpirationAwareEntry(_Serializer.Serialize(entry.Value), entry.Expiration?.ToUniversalTime());
		_Dictionary[entry.Key] = value;
	}

	public Task SetAsync<TValue>(RawSetEntry<TValue> entry, CancellationToken cancellationToken)
	{
		Set(entry);
		return Task.FromResult(result: true);
	}

	public void MultiRemove(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			Remove(key);
		}
	}

	public async Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			await RemoveAsync(key, cancellationToken);
		}
	}

	private static IEnumerable<CacheGetResult<TValue>> OrderResults<TValue>(IReadOnlyCollection<string> keys, IEnumerable<CacheGetResult<TValue>> unorderedResults)
	{
		Dictionary<string, CacheGetResult<TValue>> dictionary = unorderedResults.ToDictionary((CacheGetResult<TValue> r) => r.Key, (CacheGetResult<TValue> r) => r);
		CacheGetResult<TValue>[] array = new CacheGetResult<TValue>[keys.Count];
		int num = 0;
		foreach (string key in keys)
		{
			array[num++] = dictionary[key];
		}
		return array;
	}
}
