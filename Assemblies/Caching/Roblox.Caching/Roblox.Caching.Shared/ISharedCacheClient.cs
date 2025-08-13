using System;
using System.Collections.Generic;
using BeIT.MemCached;

namespace Roblox.Caching.Shared;

public interface ISharedCacheClient : IDisposable
{
	bool Query<TValue>(string key, out TValue value);

	bool Query<TValue>(string key, out TValue value, out ulong unique);

	bool Query(string key, out string value);

	bool Query(string key, out string value, out ulong unique);

	bool QueryBytes(string key, out byte[] value);

	bool QueryBytes(string key, out byte[] value, out ulong unique);

	IEnumerable<(string Key, byte[] Bytes, bool CacheHit)> QueryBytes(string[] keys);

	bool Append(string key, string appendedValue);

	bool Add(string key, string value, TimeSpan expiration);

	bool Delete(string key);

	bool Remove(string key);

	SharedCacheClient.CasResult CheckAndSet(string key, string value, TimeSpan policy, ulong uniqueFromQuery);

	SharedCacheClient.CasResult CheckAndSet<TValue>(string key, TValue value, TimeSpan policy, ulong uniqueFromQuery) where TValue : struct;

	SharedCacheClient.CasResult CheckAndSet(string key, byte[] value, TimeSpan policy, ulong uniqueFromQuery);

	bool Set(string key, string value, TimeSpan policy);

	bool Set<TValue>(string key, TValue value, TimeSpan expiration);

	bool SetBytes(string key, byte[] value, TimeSpan expiration);

	bool SetNull(string key, TimeSpan expiration);

	IEnumerable<Stat> GetStats();

	ulong?[] GetCounters(string[] keys);

	string[] MultiGetAsStrings(string[] keys);

	TValue[] MultiGet<TValue>(string[] keys);

	ulong? GetCounter(string key);

	void SetCounter(string key, ulong value, TimeSpan expiration);

	ulong? Increment(string key, ulong value);

	ulong? Decrement(string key, ulong value);
}
