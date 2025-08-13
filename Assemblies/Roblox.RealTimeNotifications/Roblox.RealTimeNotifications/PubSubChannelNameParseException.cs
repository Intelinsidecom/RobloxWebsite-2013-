using System;

namespace Roblox.RealTimeNotifications;

internal class PubSubChannelNameParseException : Exception
{
	public PubSubChannelNameParseException(string message)
		: base(message)
	{
	}
}
