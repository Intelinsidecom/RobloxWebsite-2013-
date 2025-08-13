using System;

namespace Roblox.Platform.Games;

public class DuplicateAccessCodeException : Exception
{
	public DuplicateAccessCodeException(string message)
		: base(message)
	{
	}
}
