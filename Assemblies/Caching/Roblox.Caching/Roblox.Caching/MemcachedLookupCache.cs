using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using BeIT.MemCached;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching;

internal class MemcachedLookupCache : ILookupCache
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly ISharedCacheClient _CacheClient;

	private readonly LookupCachePerformanceMonitor _PerformanceMonitor;

	public MemcachedLookupCache(ISettings settings, ILogger logger, ISharedCacheClient cacheClient, ICounterRegistry counterRegistry, string name)
		: this(settings, logger, cacheClient, new LookupCachePerformanceMonitor(counterRegistry, name))
	{
	}

	internal MemcachedLookupCache(ISettings settings, ILogger logger, ISharedCacheClient cacheClient, LookupCachePerformanceMonitor performanceMonitor)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CacheClient = cacheClient ?? throw new ArgumentNullException("cacheClient");
		_PerformanceMonitor = performanceMonitor ?? throw new ArgumentNullException("performanceMonitor");
	}

	public void AddEntityCountToLookupCache<TCount>(ICacheInfo cacheInfo, string countId, TCount count) where TCount : struct
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildCountKey(cacheInfo, countId);
		try
		{
			_CacheClient.Set(key, count, _Settings.RemoteCacheableExpiration);
			_PerformanceMonitor.SetCountPerSecond.Increment();
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.SetCountErrorPerSecond.Increment();
			LogError($"Exception during Memcached set: {arg}");
		}
	}

	public (bool, TCount) GetEntityCountFromLookupCache<TCount>(ICacheInfo cacheInfo, string countId) where TCount : struct
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildCountKey(cacheInfo, countId);
		try
		{
			TCount value;
			bool num = _CacheClient.Query(key, out value);
			_PerformanceMonitor.GetCountPerSecond.Increment();
			_PerformanceMonitor.EntityCountHitRate.IncrementBase();
			if (num)
			{
				_PerformanceMonitor.EntityCountHitRate.Increment();
				return (true, value);
			}
			return (false, default(TCount));
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.GetCountErrorPerSecond.Increment();
			LogError($"Exception during Memcached lookup retrieval: {arg}");
			return (false, default(TCount));
		}
	}

	public void RemoveEntityCountLookupCache(ICacheInfo cacheInfo, string countId)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildCountKey(cacheInfo, countId);
		try
		{
			_CacheClient.Delete(key);
			_PerformanceMonitor.SetCountPerSecond.Increment();
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.SetCountErrorPerSecond.Increment();
			LogError($"Error during Memcached count delete: {arg}");
		}
	}

	public void AddEntityIDToLookupCache(ICacheInfo cacheInfo, string lookup, object id)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
		try
		{
			_CacheClient.Set(key, id ?? MemcachedClient.Null, _Settings.RemoteCacheableExpiration);
			_PerformanceMonitor.SetLookupPerSecond.Increment();
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.SetLookupErrorPerSecond.Increment();
			LogError($"Error during Memcached set: {arg}");
		}
	}

	public (bool, T) GetEntityIDFromLookupCache<T>(ICacheInfo cacheInfo, string lookup)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
		try
		{
			T value;
			bool num = _CacheClient.Query(key, out value);
			_PerformanceMonitor.EntityLookupHitRate.IncrementBase();
			if (num)
			{
				_PerformanceMonitor.EntityLookupHitRate.Increment();
				return (true, value);
			}
			_PerformanceMonitor.GetLookupPerSecond.Increment();
			return (false, default(T));
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.GetLookupErrorPerSecond.Increment();
			LogError($"Error during Memcached lookup: {arg}");
			return (false, default(T));
		}
	}

	public void RemoveEntityIDLookupCache(ICacheInfo cacheInfo, string lookup)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		string key = Cacheable.BuildEntityIDLookupKey(cacheInfo, lookup);
		try
		{
			_CacheClient.Delete(key);
			_PerformanceMonitor.SetLookupPerSecond.Increment();
		}
		catch (Exception arg)
		{
			_PerformanceMonitor.SetLookupErrorPerSecond.Increment();
			LogError($"Error during Memcached delete: {arg}");
		}
	}

	private void LogError(string message)
	{
		_Logger.Error($"{message} at ${BuildCallStack()}");
	}

	private string BuildCallStack()
	{
		StackTrace stackTrace = new StackTrace();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (StackFrame item in stackTrace.GetFrames().Skip(1))
		{
			MethodBase method = item.GetMethod();
			stringBuilder.AppendLine($"{method.DeclaringType?.FullName}.{method.Name} at {item.GetFileName()} {item.GetFileLineNumber()}");
		}
		return stringBuilder.ToString();
	}
}
