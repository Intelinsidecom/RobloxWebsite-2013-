using System;

namespace BeIT.MemCached;

internal class MemcachedClientExceptionHandler : IMemcachedClientExceptionHandler
{
	private readonly IMemCachedClientSettings _Settings;

	public event Action<Exception> ExceptionOccurred;

	public MemcachedClientExceptionHandler(IMemCachedClientSettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	public void HandleException(Exception ex)
	{
		if (this.ExceptionOccurred == null)
		{
			return;
		}
		try
		{
			this.ExceptionOccurred(ex);
		}
		catch
		{
		}
	}

	public bool HandleVerboseException(Exception ex)
	{
		bool logVerboseExceptions = _Settings.LogVerboseExceptions;
		if (logVerboseExceptions)
		{
			HandleException(ex);
		}
		return logVerboseExceptions;
	}
}
