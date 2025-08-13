namespace Roblox.CachingV2.Core;

public class ReadThroughWithCreationOperationResult<TValue, TMetadata> : ReadThroughOperationResult<TValue, TMetadata> where TMetadata : BasicMetadata
{
	public bool WasCreated { get; }

	public bool WasRemoteInvalidationError { get; }

	public ReadThroughWithCreationOperationResult(TValue value, bool cacheHit, bool wasSet, TMetadata metadata, bool wasCreated)
		: base(value, cacheHit, wasSet, metadata)
	{
		WasCreated = wasCreated;
	}

	public ReadThroughWithCreationOperationResult(TValue value, bool cacheHit, bool wasSet, TMetadata metadata, bool wasCreated, bool wasCacheReadError, bool wasCacheWriteError, bool wasRemoteInvalidationError)
		: base(value, cacheHit, wasSet, metadata, wasCacheReadError, wasCacheWriteError)
	{
		WasCreated = wasCreated;
		WasRemoteInvalidationError = wasRemoteInvalidationError;
	}
}
