using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class UnknownClanInvitationException : PlatformArgumentException
{
	public UnknownClanInvitationException()
		: base("Unknown clan invitation.")
	{
	}
}
