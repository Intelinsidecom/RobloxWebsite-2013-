using System;

namespace Roblox.CachingV2.Core;

public class ErrorEventArgs : CacheEventArgs
{
	public Exception Error { get; }

	public ErrorEventArgs(Exception error)
	{
		Error = error ?? throw new ArgumentNullException("error");
	}
}
