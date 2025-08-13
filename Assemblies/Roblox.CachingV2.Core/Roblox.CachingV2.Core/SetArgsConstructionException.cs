using System;

namespace Roblox.CachingV2.Core;

public class SetArgsConstructionException : Exception
{
	public SetArgsConstructionException()
	{
	}

	public SetArgsConstructionException(string message)
		: base(message)
	{
	}

	public SetArgsConstructionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
