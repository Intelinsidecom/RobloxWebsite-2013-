using Roblox.Platform.Core;

namespace Roblox.Platform.Membership;

public class UnknownUserException : PlatformException
{
	public UnknownUserException()
		: base("Unknown User")
	{
	}

	public UnknownUserException(long id)
		: base("Unknown User " + id)
	{
	}
}
