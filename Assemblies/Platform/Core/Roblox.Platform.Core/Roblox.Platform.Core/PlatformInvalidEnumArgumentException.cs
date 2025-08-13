using System;

namespace Roblox.Platform.Core;

public class PlatformInvalidEnumArgumentException : PlatformArgumentException
{
	public PlatformInvalidEnumArgumentException()
	{
	}

	public PlatformInvalidEnumArgumentException(string message)
		: base(message)
	{
	}

	public PlatformInvalidEnumArgumentException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
