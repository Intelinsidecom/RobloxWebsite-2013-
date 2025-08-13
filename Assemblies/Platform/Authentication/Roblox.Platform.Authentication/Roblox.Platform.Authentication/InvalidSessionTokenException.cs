using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

public class InvalidSessionTokenException : PlatformException
{
	public InvalidSessionTokenException()
		: base("Invalid Session Token")
	{
	}
}
