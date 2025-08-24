using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Shared;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Implementations;
using Roblox.Instrumentation;

namespace Roblox.FloodCheckers;

public class FloodChecker : IFloodChecker, IBasicFloodChecker
{
	private const int _DefaultLimit = 10;

	private static readonly ISharedCacheClient _CacheClient = SharedCacheWebClient.GetSingleton();

	private static readonly TimeSpan _DefaultExpiry = TimeSpan.FromHours(1.0);

	private static readonly FloodCheckerMonitor _TotalMonitor = new FloodCheckerMonitor(StaticCounterRegistry.Instance, "_Total");

	private static readonly ConcurrentDictionary<string, FloodCheckerMonitor> _InstanceMonitors = new ConcurrentDictionary<string, FloodCheckerMonitor>();

	private readonly string _CacheKey;

	private readonly int _Limit;

	private readonly TimeSpan _Expiry;

	private readonly bool _Enabled;

	private readonly string _Category;

	private readonly FloodCheckerMonitor _InstanceMonitor;

	/// <summary>
	/// Constructs a new Floodchecker
	/// </summary>
	/// <param name="keyName">The key for the individual action you wish to flood check, which may be much more specific than the category</param>
	/// <param name="limit">The threshold before a checker becomes flooded</param>
	/// <param name="expiry">The lifespan of the floodchecker before the count is reset</param>
	/// <param name="enabled">Whether or not the floodchecker is enabled. If false it will never report itself as flooded</param>
	/// <param name="category">A category for the floodchecker. If none specified the type name of the class will be used. This will be used for plotting floodchecker metrics and should be broad</param>
	protected FloodChecker(string keyName, int limit, TimeSpan expiry, bool enabled = true, string category = null)
	{
		_Category = category;
		_CacheKey = keyName;
		_Enabled = enabled;
		_Limit = limit;
		_Expiry = expiry;
		string instanceName = _Category ?? GetType().Name;
		_InstanceMonitor = _InstanceMonitors.GetOrAdd(instanceName, new FloodCheckerMonitor(StaticCounterRegistry.Instance, instanceName));
	}

	/// <summary>
	/// Constructs a new Floodchecker
	/// </summary>
	/// <param name="category">A category for the floodchecker. This will be used for plotting floodchecker metrics and should be broad</param>
	/// <param name="keyName">The key for the individual action you wish to flood check, which may be much more specific than the category</param>
	/// <param name="limit">The threshold before a checker becomes flooded</param>
	/// <param name="expiry">The lifespan of the floodchecker before the count is reset</param>
	/// <param name="enabled">Whether or not the floodchecker is enabled. If false it will never report itself as flooded</param>
	public FloodChecker(string category, string keyName, int? limit = null, TimeSpan? expiry = null, bool? enabled = null)
		: this(keyName, limit ?? 10, expiry ?? _DefaultExpiry, enabled ?? true, category)
	{
	}

	public int GetCount()
	{
		_TotalMonitor.GetCountOperationsPerSecond.Increment();
		_InstanceMonitor.GetCountOperationsPerSecond.Increment();
		if (_Enabled)
		{
			return GetCountFromTimeStamps();
		}
		return 0;
	}

	public int GetCountOverLimit()
	{
		_TotalMonitor.GetCountOverLimitOperationsPerSecond.Increment();
		_InstanceMonitor.GetCountOverLimitOperationsPerSecond.Increment();
		if (_Enabled)
		{
			int rawCount = GetCountFromTimeStamps() - _Limit;
			if (rawCount <= 0)
			{
				return 0;
			}
			return rawCount;
		}
		return 0;
	}

	public IFloodCheckerStatus Check()
	{
		_TotalMonitor.CheckOperationsPerSecond.Increment();
		_InstanceMonitor.CheckOperationsPerSecond.Increment();
		bool isFlooded = false;
		int count = 0;
		if (_Enabled)
		{
			count = GetCountFromTimeStamps();
			isFlooded = count >= _Limit;
		}
		try
		{
			if (isFlooded)
			{
				GlobalFloodCheckerEventLogger.RecordFloodCheckerIsFloodedStatic(_Category ?? GetType().FullName);
			}
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
		return new FloodCheckerStatus(isFlooded, _Limit, count, _Category ?? _CacheKey);
	}

	public bool IsFlooded()
	{
		_TotalMonitor.IsFloodedOperationsPerSecond.Increment();
		_InstanceMonitor.IsFloodedOperationsPerSecond.Increment();
		return Check().IsFlooded;
	}

	public virtual void UpdateCount()
	{
		_TotalMonitor.UpdateCountOperationsPerSecond.Increment();
		_InstanceMonitor.UpdateCountOperationsPerSecond.Increment();
		if (!_Enabled)
		{
			return;
		}
		for (int writeAttempts = 0; writeAttempts < 10; writeAttempts++)
		{
			ulong unique;
			List<string> values = GetTimeStamps(out unique);
			values.Add(DateTime.Now.ToString());
			string newValue = string.Join(";", values);
			_TotalMonitor.MemcachedOperationsPerSecond.Increment();
			_InstanceMonitor.MemcachedOperationsPerSecond.Increment();
			SharedCacheClient.CasResult result = _CacheClient.CheckAndSet(_CacheKey, newValue, _Expiry, unique);
			if (result == SharedCacheClient.CasResult.Stored || result == SharedCacheClient.CasResult.Exists)
			{
				return;
			}
		}
		ExceptionHandler.LogException("Could not write to shared cache after 10 tries");
	}

	/// <summary>
	/// Removes particular key from the Cache Client
	/// </summary>
	public void Reset()
	{
		_TotalMonitor.ResetOperationsPerSecond.Increment();
		_InstanceMonitor.ResetOperationsPerSecond.Increment();
		if (_Enabled)
		{
			_TotalMonitor.MemcachedOperationsPerSecond.Increment();
			_InstanceMonitor.MemcachedOperationsPerSecond.Increment();
			_CacheClient.Remove(_CacheKey);
		}
	}

	/// <summary>
	/// The amount of time in seconds until the caller can send a request that will not be flood checked. Null if the caller is not flood checked.
	/// </summary>
	/// <remarks>
	/// This is an internal-protected method because there isn't currently a justification for all flood checkers exposing this functionality.
	/// </remarks>
	/// <returns>The amount of seconds until the caller can send</returns>
	protected virtual int? RetryAfterInternal()
	{
		DateTime? nextUnfloodedTime = GetNextAvailableTime();
		if (!nextUnfloodedTime.HasValue)
		{
			return null;
		}
		return Convert.ToInt32(Math.Max(0.0, nextUnfloodedTime.Value.Subtract(DateTime.Now).TotalSeconds));
	}

	/// <summary>
	/// Returns the next time at which the caller can make a call that will not be flood checked.
	/// </summary>
	/// <returns>A <see cref="T:System.DateTime" /> representing the next un-flooded time, or null if the flood checker isn't enabled.</returns>
	private DateTime? GetNextAvailableTime()
	{
		if (_Enabled)
		{
			if (!IsFlooded())
			{
				return DateTime.Now;
			}
			ulong unique;
			List<string> timeStamps = GetTimeStamps(out unique);
			if (!timeStamps.Any())
			{
				return DateTime.Now;
			}
			return Convert.ToDateTime(timeStamps.First()) + _Expiry;
		}
		return null;
	}

	private List<string> GetTimeStamps(out ulong unique)
	{
		_TotalMonitor.MemcachedOperationsPerSecond.Increment();
		_InstanceMonitor.MemcachedOperationsPerSecond.Increment();
		_CacheClient.Query(_CacheKey, out var timeStampsDelimited, out unique);
		List<string> obj = ((!string.IsNullOrEmpty(timeStampsDelimited)) ? timeStampsDelimited.Split(';').ToList() : new List<string>());
		DateTime minTime = DateTime.Now - _Expiry;
		obj.RemoveAll((string x) => Convert.ToDateTime(x) <= minTime);
		return obj;
	}

	private int GetCountFromTimeStamps()
	{
		ulong unique;
		return GetTimeStamps(out unique).Count;
	}
}
