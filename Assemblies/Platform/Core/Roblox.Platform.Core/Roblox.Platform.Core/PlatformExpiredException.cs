using System;

namespace Roblox.Platform.Core;

/// <summary>
/// An exception thrown when something is expired at the platform level.
/// </summary>
public class PlatformExpiredException : PlatformException
{
	public PlatformExpiredException()
	{
	}

	public PlatformExpiredException(string message)
		: base(message)
	{
	}

	public PlatformExpiredException(string message, Exception exception)
		: base(message, exception)
	{
	}
}
