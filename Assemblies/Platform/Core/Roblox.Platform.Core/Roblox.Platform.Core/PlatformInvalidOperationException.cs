using System;

namespace Roblox.Platform.Core;

public class PlatformInvalidOperationException : PlatformException
{
	public PlatformInvalidOperationException()
	{
	}

	public PlatformInvalidOperationException(string message)
		: base(message)
	{
	}

	public PlatformInvalidOperationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
