using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public class InvalidProductException : PlatformException
{
	public InvalidProductException(string friendlyMessage)
		: base(friendlyMessage)
	{
	}
}
