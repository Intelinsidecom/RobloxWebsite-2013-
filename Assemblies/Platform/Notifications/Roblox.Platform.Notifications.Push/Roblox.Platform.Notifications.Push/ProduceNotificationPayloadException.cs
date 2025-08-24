using System;

namespace Roblox.Platform.Notifications.Push;

internal class ProduceNotificationPayloadException : Exception
{
	public ProduceNotificationPayloadException(string message)
		: base(message)
	{
	}
}
