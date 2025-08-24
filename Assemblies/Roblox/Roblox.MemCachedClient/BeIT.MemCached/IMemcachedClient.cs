using System;
using System.Collections.Generic;

namespace BeIT.MemCached;

public interface IMemcachedClient : IDisposable
{
	bool Set<T>(string key, T value, TimeSpan expiry);

	bool Add<T>(string key, T value, TimeSpan expiry);

	bool Replace<T>(string key, T value, TimeSpan expiry);

	bool Append<T>(string key, T value);

	bool Prepend<T>(string key, T value);

	MemcachedClient.CasResult CheckAndSet<T>(string key, T value, TimeSpan expiry, ulong unique);

	object Get(string key);

	object Gets(string key, out ulong unique);

	object[] Get(string[] keys);

	object[] Gets(string[] keys, out ulong[] uniques);

	bool Delete(string key);

	bool Delete(string key, TimeSpan delay);

	bool SetCounter(string key, ulong value, TimeSpan expiry);

	ulong? GetCounter(string key);

	ulong?[] GetCounter(string[] keys);

	ulong? Increment(string key, ulong value);

	ulong? Decrement(string key, ulong value);

	IEnumerable<Stat> Stats();
}
