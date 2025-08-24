using System;

namespace Roblox.RealTimeNotifications;

internal class SubscriptionProxyException : Exception
{
	public SubscriptionProxyException(string message)
		: base(message)
	{
	}
}
