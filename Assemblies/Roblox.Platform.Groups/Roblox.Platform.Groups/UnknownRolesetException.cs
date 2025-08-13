using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class UnknownRolesetException : PlatformArgumentException
{
	public UnknownRolesetException()
		: base("Unknown group roleset.")
	{
	}
}
