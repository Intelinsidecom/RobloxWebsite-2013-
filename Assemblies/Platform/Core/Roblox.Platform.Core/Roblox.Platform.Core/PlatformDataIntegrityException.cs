using System;

namespace Roblox.Platform.Core;

public class PlatformDataIntegrityException : PlatformException
{
	public PlatformDataIntegrityException()
	{
	}

	public PlatformDataIntegrityException(string message)
		: base(message)
	{
	}

	public PlatformDataIntegrityException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
