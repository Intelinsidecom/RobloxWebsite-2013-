using System;

namespace Roblox.Platform.Moderation;

public class BadMessageException : Exception
{
	public BadMessageException(string message)
		: base(message)
	{
	}

	public BadMessageException(string message, Exception e)
		: base(message, e)
	{
	}
}
