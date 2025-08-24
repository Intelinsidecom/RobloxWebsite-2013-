using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class NotAGroupMemberException : PlatformException
{
	public NotAGroupMemberException()
		: base("Must be a group member.")
	{
	}
}
