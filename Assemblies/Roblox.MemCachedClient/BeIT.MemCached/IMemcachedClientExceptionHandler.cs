using System;

namespace BeIT.MemCached;

internal interface IMemcachedClientExceptionHandler
{
	event Action<Exception> ExceptionOccurred;

	void HandleException(Exception ex);

	bool HandleVerboseException(Exception ex);
}
