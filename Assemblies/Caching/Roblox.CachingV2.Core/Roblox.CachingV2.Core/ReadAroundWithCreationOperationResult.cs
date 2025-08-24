namespace Roblox.CachingV2.Core;

public class ReadAroundWithCreationOperationResult<TValue> : CacheReadOperationResult<TValue>
{
	public bool WasCreated { get; }

	public bool WasCacheWriteError { get; }

	public bool WasRemoteInvalidationError { get; }

	public ReadAroundWithCreationOperationResult(TValue value, bool cacheHit, bool wasCreated)
		: base(value, cacheHit)
	{
		WasCreated = wasCreated;
		WasCacheWriteError = false;
	}

	public ReadAroundWithCreationOperationResult(TValue value, bool cacheHit, bool wasCreated, bool wasCacheReadError, bool wasCacheWriteError, bool wasRemoteInvalidationError)
		: base(value, cacheHit, wasCacheReadError)
	{
		WasCreated = wasCreated;
		WasCacheWriteError = wasCacheWriteError;
		WasRemoteInvalidationError = wasRemoteInvalidationError;
	}
}
