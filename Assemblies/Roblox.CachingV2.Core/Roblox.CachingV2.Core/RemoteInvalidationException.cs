using System;

namespace Roblox.CachingV2.Core;

public class RemoteInvalidationException : Exception
{
	public RemoteInvalidationException()
	{
	}

	public RemoteInvalidationException(string message)
		: base(message)
	{
	}

	public RemoteInvalidationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
