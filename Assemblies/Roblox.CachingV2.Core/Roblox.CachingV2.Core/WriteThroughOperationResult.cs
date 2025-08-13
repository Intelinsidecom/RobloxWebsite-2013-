using System;

namespace Roblox.CachingV2.Core;

public class WriteThroughOperationResult<TMetadata> where TMetadata : BasicMetadata
{
	public SetResult<TMetadata> SetResult { get; }

	public bool WasCacheWriteError { get; }

	public bool WasRemoteInvalidationError { get; }

	public WriteThroughOperationResult(SetResult<TMetadata> setResult)
	{
		SetResult = setResult ?? throw new ArgumentNullException("setResult");
	}

	public WriteThroughOperationResult(SetResult<TMetadata> setResult, bool wasCacheWriteError, bool wasRemoteInvalidationError)
	{
		if (setResult == null && !wasCacheWriteError)
		{
			throw new ArgumentNullException("setResult");
		}
		SetResult = setResult;
		WasCacheWriteError = wasCacheWriteError;
		WasRemoteInvalidationError = wasRemoteInvalidationError;
	}
}
