using System;

namespace Roblox.RealTimeNotifications;

internal class PubSubSubcriptionException : Exception
{
	public PubSubSubcriptionException(string message)
		: base(message)
	{
	}
}
