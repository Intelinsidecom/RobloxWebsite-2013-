using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class InsufficientRankException : PlatformException
{
	public InsufficientRankException()
		: base("Target user is equal or greater rank than you.")
	{
	}
}
