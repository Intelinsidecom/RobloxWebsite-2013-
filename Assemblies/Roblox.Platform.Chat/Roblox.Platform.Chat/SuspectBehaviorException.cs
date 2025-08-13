using System;

namespace Roblox.Platform.Chat;

public class SuspectBehaviorException : Exception
{
	public SuspectBehaviorException(string message)
		: base(message)
	{
	}
}
