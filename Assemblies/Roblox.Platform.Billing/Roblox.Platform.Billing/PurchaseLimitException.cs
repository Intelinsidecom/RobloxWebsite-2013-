using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public class PurchaseLimitException : PlatformException
{
	public PurchaseLimitException(string friendlyMessage)
		: base(friendlyMessage)
	{
	}
}
