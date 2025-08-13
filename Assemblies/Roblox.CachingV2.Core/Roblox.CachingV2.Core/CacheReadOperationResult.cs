using System;

namespace Roblox.CachingV2.Core;

public class CacheReadOperationResult<TValue>
{
	public TValue Value { get; }

	public bool CacheHit { get; }

	public bool WasCacheReadError { get; }

	public CacheReadOperationResult(TValue value, bool cacheHit)
		: this(value, cacheHit, wasCacheReadError: false)
	{
	}

	public CacheReadOperationResult(TValue value, bool cacheHit, bool wasCacheReadError)
	{
		Value = value;
		if (cacheHit && wasCacheReadError)
		{
			throw new ArgumentException(string.Format("{0} and {1} cannot both be true.", "cacheHit", "wasCacheReadError"));
		}
		CacheHit = cacheHit;
		WasCacheReadError = wasCacheReadError;
	}
}
