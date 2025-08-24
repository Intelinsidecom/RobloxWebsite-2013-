using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class InsufficientPermissionsException : PlatformException
{
	public InsufficientPermissionsException()
		: base("You do not have permission to do that.")
	{
	}
}
