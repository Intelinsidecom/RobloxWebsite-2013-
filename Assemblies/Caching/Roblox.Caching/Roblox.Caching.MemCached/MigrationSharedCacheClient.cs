using System;
using System.Collections.Generic;
using BeIT.MemCached;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.Common.NetStandard;
using Roblox.EventLog;

namespace Roblox.Caching.MemCached;

internal class MigrationSharedCacheClient : ISharedCacheClient, IDisposable
{
	private readonly ISharedCacheClient _ReadAndWriteCache;

	private readonly ISharedCacheClient _WriteCache;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly bool _ReadAndDiscardInBackgroundFromWriteCache;

	private readonly bool _OnlyDeleteFromWriteCache;

	public MigrationSharedCacheClient(ISharedCacheClient readAndWriteCache, ISharedCacheClient writeCache, bool onlyDeleteFromWriteCache, bool readAndDiscardInBackgroundFromWriteCache, ISettings settings, ILogger logger)
	{
		_ReadAndWriteCache = readAndWriteCache ?? throw new ArgumentNullException("readAndWriteCache");
		_WriteCache = writeCache ?? throw new ArgumentNullException("writeCache");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ReadAndDiscardInBackgroundFromWriteCache = readAndDiscardInBackgroundFromWriteCache;
		_OnlyDeleteFromWriteCache = onlyDeleteFromWriteCache;
	}

	public bool Delete(string key)
	{
		return PerformWriteOperation((ISharedCacheClient c) => c.Delete(key));
	}

	public bool Remove(string key)
	{
		return PerformWriteOperation((ISharedCacheClient c) => c.Remove(key));
	}

	public bool Add(string key, string value, TimeSpan expiration)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Add(key, value, expiration), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Add(key, value, expiration));
	}

	public bool Append(string key, string appendedValue)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Append(key, appendedValue), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Append(key, appendedValue));
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, string value, TimeSpan policy, ulong uniqueFromQuery)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery), delegate(ISharedCacheClient c)
			{
				c.Delete(key);
				return SharedCacheClient.CasResult.NotFound;
			});
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery));
	}

	public SharedCacheClient.CasResult CheckAndSet<TValue>(string key, TValue value, TimeSpan policy, ulong uniqueFromQuery) where TValue : struct
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery), delegate(ISharedCacheClient c)
			{
				c.Delete(key);
				return SharedCacheClient.CasResult.NotFound;
			});
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery));
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, byte[] value, TimeSpan policy, ulong uniqueFromQuery)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery), delegate(ISharedCacheClient c)
			{
				c.Delete(key);
				return SharedCacheClient.CasResult.NotFound;
			});
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.CheckAndSet(key, value, policy, uniqueFromQuery));
	}

	public ulong? Increment(string key, ulong value)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Increment(key, value), delegate(ISharedCacheClient c)
			{
				c.Delete(key);
				return null;
			});
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Increment(key, value));
	}

	public ulong? Decrement(string key, ulong value)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Decrement(key, value), delegate(ISharedCacheClient c)
			{
				c.Delete(key);
				return null;
			});
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Decrement(key, value));
	}

	public bool Set(string key, string value, TimeSpan policy)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Set(key, value, policy), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Set(key, value, policy));
	}

	public bool Set<TValue>(string key, TValue value, TimeSpan expiration)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.Set(key, value, expiration), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.Set(key, value, expiration));
	}

	public bool SetBytes(string key, byte[] value, TimeSpan expiration)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.SetBytes(key, value, expiration), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.SetBytes(key, value, expiration));
	}

	public void SetCounter(string key, ulong value, TimeSpan expiration)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			PerformWriteOperation(delegate(ISharedCacheClient c)
			{
				c.SetCounter(key, value, expiration);
			}, delegate(ISharedCacheClient c)
			{
				c.Delete(key);
			});
		}
		else
		{
			PerformWriteOperation(delegate(ISharedCacheClient c)
			{
				c.SetCounter(key, value, expiration);
			});
		}
	}

	public bool SetNull(string key, TimeSpan expiration)
	{
		if (_OnlyDeleteFromWriteCache)
		{
			return PerformWriteOperation((ISharedCacheClient c) => c.SetNull(key, expiration), (ISharedCacheClient c) => c.Delete(key));
		}
		return PerformWriteOperation((ISharedCacheClient c) => c.SetNull(key, expiration));
	}

	public IEnumerable<Stat> GetStats()
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.GetStats());
		}
		return _ReadAndWriteCache.GetStats();
	}

	public string[] MultiGetAsStrings(string[] keys)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.MultiGetAsStrings(keys));
		}
		return _ReadAndWriteCache.MultiGetAsStrings(keys);
	}

	public TValue[] MultiGet<TValue>(string[] keys)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.MultiGet<TValue>(keys));
		}
		return _ReadAndWriteCache.MultiGet<TValue>(keys);
	}

	public bool Query<TValue>(string key, out TValue value)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.Query(key, out TValue _));
		}
		return _ReadAndWriteCache.Query(key, out value);
	}

	public bool Query<TValue>(string key, out TValue value, out ulong unique)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.Query(key, out TValue _, out ulong _));
		}
		return _ReadAndWriteCache.Query(key, out value, out unique);
	}

	public bool Query(string key, out string value)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.Query(key, out var _));
		}
		return _ReadAndWriteCache.Query(key, out value);
	}

	public bool Query(string key, out string value, out ulong unique)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.Query(key, out var _, out var _));
		}
		return _ReadAndWriteCache.Query(key, out value, out unique);
	}

	public bool QueryBytes(string key, out byte[] value)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.QueryBytes(key, out var _));
		}
		return _ReadAndWriteCache.QueryBytes(key, out value);
	}

	public bool QueryBytes(string key, out byte[] value, out ulong unique)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.QueryBytes(key, out var _, out var _));
		}
		return _ReadAndWriteCache.QueryBytes(key, out value, out unique);
	}

	public IEnumerable<(string Key, byte[] Bytes, bool CacheHit)> QueryBytes(string[] keys)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.QueryBytes(keys));
		}
		return _ReadAndWriteCache.QueryBytes(keys);
	}

	public ulong? GetCounter(string key)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.GetCounter(key));
		}
		return _ReadAndWriteCache.GetCounter(key);
	}

	public ulong?[] GetCounters(string[] keys)
	{
		if (_ReadAndDiscardInBackgroundFromWriteCache)
		{
			PerformReadOperationInBackground((ISharedCacheClient c) => c.GetCounters(keys));
		}
		return _ReadAndWriteCache.GetCounters(keys);
	}

	public void Dispose()
	{
		_ReadAndWriteCache.Dispose();
		_WriteCache.Dispose();
	}

	private T PerformWriteOperation<T>(Func<ISharedCacheClient, T> executorForReadOrBoth, Func<ISharedCacheClient, T> executorForWrite = null) where T : struct
	{
		try
		{
			if (executorForWrite == null)
			{
				executorForReadOrBoth(_WriteCache);
			}
			else
			{
				executorForWrite(_WriteCache);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return executorForReadOrBoth(_ReadAndWriteCache);
	}

	private T? PerformWriteOperation<T>(Func<ISharedCacheClient, T?> executorForReadOrBoth, Func<ISharedCacheClient, T?> executorForWrite = null) where T : struct
	{
		try
		{
			if (executorForWrite == null)
			{
				executorForReadOrBoth(_WriteCache);
			}
			else
			{
				executorForWrite(_WriteCache);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return executorForReadOrBoth(_ReadAndWriteCache);
	}

	private void PerformWriteOperation(Action<ISharedCacheClient> executorForReadOrBoth, Action<ISharedCacheClient> executorForWrite = null)
	{
		try
		{
			if (executorForWrite == null)
			{
				executorForReadOrBoth(_WriteCache);
			}
			else
			{
				executorForWrite(_WriteCache);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		executorForReadOrBoth(_ReadAndWriteCache);
	}

	private void PerformReadOperationInBackground<T>(Func<ISharedCacheClient, T> executor)
	{
		if (_Settings.IsReadingFromWriteCacheForMigrationInBackground)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				executor(_WriteCache);
			});
			return;
		}
		try
		{
			executor(_WriteCache);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}
}
