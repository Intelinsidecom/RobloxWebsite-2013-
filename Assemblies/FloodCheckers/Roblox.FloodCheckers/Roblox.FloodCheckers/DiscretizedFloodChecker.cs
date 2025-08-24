using System;
using Roblox.Caching.Shared;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers;

/// <summary>
/// Tracks counts in fixed time buckets instead of a sliding window.  Use when a high number of counts is expected.
/// </summary>
public class DiscretizedFloodChecker : IFloodChecker, IBasicFloodChecker
{
	private static readonly ISharedCacheClient _CacheClient = SharedCacheWebClient.GetSingleton();

	private static readonly TimeSpan _DefaultExpiry = TimeSpan.FromMinutes(1.0);

	private const int _DefaultLimit = 100;

	private readonly string _CacheKey;

	private readonly int _Limit;

	private readonly TimeSpan _Expiry;

	private readonly bool _Enabled;

	public DiscretizedFloodChecker(string keyName, int limit, TimeSpan expiry, bool enabled = true)
	{
		_CacheKey = keyName;
		_Limit = limit;
		_Expiry = expiry;
		_Enabled = enabled;
	}

	public DiscretizedFloodChecker(string keyName, int? limit = null, TimeSpan? expiry = null, bool? enabled = null)
	{
		_CacheKey = keyName;
		_Limit = limit ?? 100;
		_Expiry = expiry ?? _DefaultExpiry;
		_Enabled = enabled ?? true;
	}

	public IFloodCheckerStatus Check()
	{
		bool isFlooded = false;
		int count = 0;
		if (_Enabled)
		{
			count = GetCount();
			isFlooded = count >= _Limit;
		}
		return new FloodCheckerStatus(isFlooded, _Limit, count, _CacheKey);
	}

	public int GetCount()
	{
		if (_Enabled)
		{
			ulong? counter = _CacheClient.GetCounter(_CacheKey);
			if (!counter.HasValue)
			{
				return 0;
			}
			return (int)counter.Value;
		}
		return 0;
	}

	public int GetCountOverLimit()
	{
		if (_Enabled)
		{
			int count = GetCount();
			if (count <= _Limit)
			{
				return 0;
			}
			return count - _Limit;
		}
		return 0;
	}

	public bool IsFlooded()
	{
		return Check().IsFlooded;
	}

	public void UpdateCount()
	{
		if (_Enabled && !_CacheClient.Increment(_CacheKey, 1uL).HasValue)
		{
			_CacheClient.SetCounter(_CacheKey, 1uL, _Expiry);
		}
	}

	public void Reset()
	{
		if (_Enabled)
		{
			_CacheClient.SetCounter(_CacheKey, 0uL, _Expiry);
		}
	}
}
