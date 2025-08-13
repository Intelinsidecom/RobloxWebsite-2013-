using Roblox.Platform.Core;

namespace Roblox.Platform.Membership;

public class UnknownVisitorException : PlatformException
{
	public UnknownVisitorException()
		: base("Unknown Visitor")
	{
	}
}
