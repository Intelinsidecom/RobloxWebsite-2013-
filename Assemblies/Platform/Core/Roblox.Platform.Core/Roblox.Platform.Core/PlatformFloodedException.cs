using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Exception thrown when a platform request gets throttled, but may be available later.
/// </summary>
public class PlatformFloodedException : PlatformException
{
	public PlatformFloodedException()
	{
	}

	public PlatformFloodedException(string message)
		: base(message)
	{
	}

	public PlatformFloodedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
