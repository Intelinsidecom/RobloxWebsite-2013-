using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class UnknownGroupMembershipException : PlatformArgumentException
{
	public UnknownGroupMembershipException()
		: base("Unknown group membership.")
	{
	}
}
