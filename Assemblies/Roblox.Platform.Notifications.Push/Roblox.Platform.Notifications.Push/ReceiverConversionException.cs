using Roblox.Platform.Core;

namespace Roblox.Platform.Notifications.Push;

internal class ReceiverConversionException : PlatformException
{
	public ReceiverConversionException(string message)
		: base(message)
	{
	}
}
