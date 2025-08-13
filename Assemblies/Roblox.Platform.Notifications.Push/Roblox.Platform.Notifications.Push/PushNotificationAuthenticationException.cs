using System;

namespace Roblox.Platform.Notifications.Push;

internal class PushNotificationAuthenticationException : Exception
{
	public PushNotificationAuthenticationException(string message)
		: base(message)
	{
	}
}
