using System;

namespace Roblox.CachingV2.Core;

public class ReadThroughOperationResult<TValue, TMetadata> : CacheReadOperationResult<TValue> where TMetadata : BasicMetadata
{
	public TMetadata Metadata { get; }

	public bool WasSet { get; }

	public bool WasCacheWriteError { get; }

	public ReadThroughOperationResult(TValue value, bool cacheHit, bool wasSet, TMetadata metadata)
		: base(value, cacheHit)
	{
		WasSet = wasSet;
		Metadata = metadata ?? throw new ArgumentNullException("metadata");
	}

	public ReadThroughOperationResult(TValue value, bool cacheHit, bool wasSet, TMetadata metadata, bool wasCacheReadError, bool wasCacheWriteError)
		: base(value, cacheHit, wasCacheReadError)
	{
		WasSet = wasSet;
		if (metadata == null && !wasCacheWriteError)
		{
			throw new ArgumentNullException("metadata");
		}
		Metadata = metadata;
		WasCacheWriteError = wasCacheWriteError;
	}
}
