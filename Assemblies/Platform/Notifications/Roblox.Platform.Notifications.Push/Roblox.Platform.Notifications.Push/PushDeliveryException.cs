using Roblox.Platform.Core;

namespace Roblox.Platform.Notifications.Push;

internal class PushDeliveryException : PlatformException
{
	public PushDeliveryException(string message)
		: base(message)
	{
	}
}
