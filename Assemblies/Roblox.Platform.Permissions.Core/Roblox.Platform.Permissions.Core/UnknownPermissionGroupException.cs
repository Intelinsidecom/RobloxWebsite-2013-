using Roblox.Platform.Core;

namespace Roblox.Platform.Permissions.Core;

public class UnknownPermissionGroupException : PlatformException
{
	public UnknownPermissionGroupException()
		: base("Unknown PermissionGroup")
	{
	}

	public UnknownPermissionGroupException(long id)
		: base("Unknown PermissionGroup " + id)
	{
	}
}
