using System;
using System.Collections.Generic;
using BeIT.MemCached;

namespace Roblox.Caching.Shared;

public abstract class DynamicSharedCacheClientBase : ISharedCacheClient, IDisposable
{
	protected abstract ISharedCacheClient Client { get; }

	public bool Add(string key, string value, TimeSpan expiration)
	{
		return Client.Add(key, value, expiration);
	}

	public bool Append(string key, string appendedValue)
	{
		return Client.Append(key, appendedValue);
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, string value, TimeSpan policy, ulong uniqueFromQuery)
	{
		return Client.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public SharedCacheClient.CasResult CheckAndSet<TValue>(string key, TValue value, TimeSpan policy, ulong uniqueFromQuery) where TValue : struct
	{
		return Client.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, byte[] value, TimeSpan policy, ulong uniqueFromQuery)
	{
		return Client.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public ulong? Decrement(string key, ulong value)
	{
		return Client.Decrement(key, value);
	}

	public bool Delete(string key)
	{
		return Client.Delete(key);
	}

	public void Dispose()
	{
		Client.Dispose();
	}

	public ulong? GetCounter(string key)
	{
		return Client.GetCounter(key);
	}

	public ulong?[] GetCounters(string[] keys)
	{
		return Client.GetCounters(keys);
	}

	public IEnumerable<Stat> GetStats()
	{
		return Client.GetStats();
	}

	public ulong? Increment(string key, ulong value)
	{
		return Client.Increment(key, value);
	}

	public TValue[] MultiGet<TValue>(string[] keys)
	{
		return Client.MultiGet<TValue>(keys);
	}

	public string[] MultiGetAsStrings(string[] keys)
	{
		return Client.MultiGetAsStrings(keys);
	}

	public bool Query<TValue>(string key, out TValue value)
	{
		return Client.Query(key, out value);
	}

	public bool Query<TValue>(string key, out TValue value, out ulong unique)
	{
		return Client.Query(key, out value, out unique);
	}

	public bool Query(string key, out string value)
	{
		return Client.Query(key, out value);
	}

	public bool Query(string key, out string value, out ulong unique)
	{
		return Client.Query(key, out value, out unique);
	}

	public bool QueryBytes(string key, out byte[] value)
	{
		return Client.QueryBytes(key, out value);
	}

	public bool QueryBytes(string key, out byte[] value, out ulong unique)
	{
		return Client.QueryBytes(key, out value, out unique);
	}

	public IEnumerable<(string Key, byte[] Bytes, bool CacheHit)> QueryBytes(string[] keys)
	{
		return Client.QueryBytes(keys);
	}

	public bool Remove(string key)
	{
		return Client.Remove(key);
	}

	public bool Set(string key, string value, TimeSpan policy)
	{
		return Client.Set(key, value, policy);
	}

	public bool Set<TValue>(string key, TValue value, TimeSpan expiration)
	{
		return Client.Set(key, value, expiration);
	}

	public bool SetBytes(string key, byte[] value, TimeSpan expiration)
	{
		return Client.SetBytes(key, value, expiration);
	}

	public void SetCounter(string key, ulong value, TimeSpan expiration)
	{
		Client.SetCounter(key, value, expiration);
	}

	public bool SetNull(string key, TimeSpan expiration)
	{
		return Client.SetNull(key, expiration);
	}
}
