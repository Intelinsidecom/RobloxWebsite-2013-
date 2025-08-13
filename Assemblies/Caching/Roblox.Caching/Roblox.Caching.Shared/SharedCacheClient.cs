using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeIT.MemCached;
using Roblox.Caching.Properties;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching.Shared;

public abstract class SharedCacheClient : ISharedCacheClient, IDisposable
{
	public enum CasResult
	{
		Stored,
		NotStored,
		Exists,
		NotFound
	}

	protected IMemcachedClient _Memcached;

	public Action<string, object> OnQuery;

	public Action<string, object> OnSet;

	public bool Query<TValue>(string key, out TValue value)
	{
		ulong unique;
		return Query(key, out value, out unique);
	}

	public bool Query<TValue>(string key, out TValue value, out ulong unique)
	{
		key = FormatKey(key);
		object obj = _Memcached.Gets(key, out unique);
		InvokeQueryEvent(key, obj);
		if (obj == null)
		{
			value = default(TValue);
			unique = 0uL;
			return false;
		}
		if (obj == MemcachedClient.Null)
		{
			value = default(TValue);
			unique = 0uL;
			return true;
		}
		Type conversionType = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);
		value = (TValue)Convert.ChangeType(obj, conversionType);
		return true;
	}

	private void InvokeQueryEvent(string key, object data)
	{
		OnQuery?.Invoke(key, data);
	}

	private void InvokeSetEvent(string key, object data)
	{
		OnSet?.Invoke(key, data);
	}

	public bool Query(string key, out string value)
	{
		ulong unique;
		return Query(key, out value, out unique);
	}

	public virtual bool Query(string key, out string value, out ulong unique)
	{
		if (QueryBytes(key, out var value2, out unique))
		{
			value = ((value2 != null) ? Encoding.UTF8.GetString(value2) : null);
			return true;
		}
		value = null;
		return false;
	}

	public bool QueryBytes(string key, out byte[] value)
	{
		ulong unique;
		return QueryBytes(key, out value, out unique);
	}

	public bool QueryBytes(string key, out byte[] value, out ulong unique)
	{
		key = FormatKey(key);
		object obj = _Memcached.Gets(key, out unique);
		InvokeQueryEvent(key, obj);
		if (obj == null)
		{
			unique = 0uL;
			value = null;
			return false;
		}
		if (obj == MemcachedClient.Null)
		{
			unique = 0uL;
			value = null;
			return true;
		}
		value = (byte[])obj;
		return true;
	}

	public IEnumerable<(string Key, byte[] Bytes, bool CacheHit)> QueryBytes(string[] keys)
	{
		if (keys == null || keys.Any(string.IsNullOrEmpty))
		{
			throw new ArgumentNullException("keys");
		}
		string[] keys2 = FormatKeyArray(keys);
		object[] array = _Memcached.Get(keys2);
		int i = 0;
		object[] array2 = array;
		foreach (object obj in array2)
		{
			byte[] item;
			bool item2;
			if (obj == null)
			{
				item = null;
				item2 = false;
			}
			else
			{
				item = ((obj == MemcachedClient.Null) ? null : ((byte[])obj));
				item2 = true;
			}
			yield return (keys[i++], item, item2);
		}
	}

	public bool Append(string key, string appendedValue)
	{
		key = FormatKey(key);
		return _Memcached.Append(key, appendedValue);
	}

	public bool Add(string key, string value, TimeSpan expiration)
	{
		key = FormatKey(key);
		return _Memcached.Add(key, value, expiration);
	}

	public bool Delete(string key)
	{
		key = FormatKey(key);
		return _Memcached.Delete(key);
	}

	public bool Remove(string key)
	{
		key = FormatKey(key);
		return _Memcached.Delete(key);
	}

	public virtual CasResult CheckAndSet(string key, string value, TimeSpan policy, ulong uniqueFromQuery)
	{
		key = FormatKey(key);
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		if (uniqueFromQuery == 0L)
		{
			if (_Memcached.Add(key, bytes, policy))
			{
				return CasResult.Stored;
			}
			return CasResult.Exists;
		}
		return (CasResult)_Memcached.CheckAndSet(key, bytes, policy, uniqueFromQuery);
	}

	public CasResult CheckAndSet<TValue>(string key, TValue value, TimeSpan policy, ulong uniqueFromQuery) where TValue : struct
	{
		key = FormatKey(key);
		if (uniqueFromQuery == 0L)
		{
			if (_Memcached.Add(key, value, policy))
			{
				return CasResult.Stored;
			}
			return CasResult.Exists;
		}
		return (CasResult)_Memcached.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public CasResult CheckAndSet(string key, byte[] value, TimeSpan policy, ulong uniqueFromQuery)
	{
		key = FormatKey(key);
		object value2 = value ?? MemcachedClient.Null;
		if (uniqueFromQuery == 0L)
		{
			if (_Memcached.Add(key, value2, policy))
			{
				return CasResult.Stored;
			}
			return CasResult.Exists;
		}
		return (CasResult)_Memcached.CheckAndSet(key, value2, policy, uniqueFromQuery);
	}

	public bool Set(string key, string value, TimeSpan policy)
	{
		return SetBytes(key, Encoding.UTF8.GetBytes(value), policy);
	}

	public bool Set<TValue>(string key, TValue value, TimeSpan expiration)
	{
		key = FormatKey(key);
		bool result = _Memcached.Set(key, value, expiration);
		InvokeSetEvent(key, value);
		return result;
	}

	public bool SetBytes(string key, byte[] value, TimeSpan expiration)
	{
		key = FormatKey(key);
		object obj = value ?? MemcachedClient.Null;
		bool result = _Memcached.Set(key, obj, expiration);
		InvokeSetEvent(key, obj);
		return result;
	}

	public bool SetNull(string key, TimeSpan expiration)
	{
		return SetBytes(key, null, expiration);
	}

	public IEnumerable<Stat> GetStats()
	{
		return _Memcached.Stats();
	}

	public void Dispose()
	{
		_Memcached?.Dispose();
	}

	private static string[] FormatKeyArray(IEnumerable<string> keys)
	{
		return keys.Select(FormatKey).ToArray();
	}

	public ulong?[] GetCounters(string[] keys)
	{
		if (keys == null || keys.Length == 0)
		{
			return null;
		}
		keys = FormatKeyArray(keys);
		return _Memcached.GetCounter(keys);
	}

	public string[] MultiGetAsStrings(string[] keys)
	{
		if (keys == null || keys.Length == 0)
		{
			return null;
		}
		keys = FormatKeyArray(keys);
		return (from v in _Memcached.Get(keys)
			select (!(v is byte[] bytes)) ? null : Encoding.UTF8.GetString(bytes)).ToArray();
	}

	public TValue[] MultiGet<TValue>(string[] keys)
	{
		if (keys == null || keys.Length == 0)
		{
			return null;
		}
		keys = FormatKeyArray(keys);
		ulong[] uniques;
		return (from data in _Memcached.Gets(keys, out uniques)
			select (data != null && data != MemcachedClient.Null) ? ((TValue)data) : default(TValue)).ToArray();
	}

	public ulong? GetCounter(string key)
	{
		key = FormatKey(key);
		return _Memcached.GetCounter(key);
	}

	public void SetCounter(string key, ulong value, TimeSpan expiration)
	{
		key = FormatKey(key);
		_Memcached.SetCounter(key, value, expiration);
	}

	public ulong? Increment(string key, ulong value)
	{
		key = FormatKey(key);
		return _Memcached.Increment(key, value);
	}

	public ulong? Decrement(string key, ulong value)
	{
		key = FormatKey(key);
		return _Memcached.Decrement(key, value);
	}

	protected void CreateMemcachedClient(string[] addresses, string clientNameSuffix, ILogger logger, IMemCachedClientSettings settings = null)
	{
		string name = Settings.Default.SharedCacheKeyPrefix + clientNameSuffix;
		settings = settings ?? new MemCachedClientSettings(Settings.Default, logger);
		_Memcached = new MemcachedClient(name, addresses, logger.Error, StaticCounterRegistry.Instance, settings);
	}

	private static string FormatKey(string key)
	{
		return Settings.Default.SharedCacheKeyPrefix + key;
	}

	protected static string[] GetCacheAddressesFromSetting(string addresses)
	{
		return addresses.Split(',', ';');
	}
}
