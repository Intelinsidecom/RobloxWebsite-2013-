using Roblox.Platform.Core;

namespace Roblox.Platform.Permissions.Core;

public class InvalidPermissionTypeException : PlatformException
{
	public InvalidPermissionTypeException()
		: base("Invalid Permission Type")
	{
	}

	public InvalidPermissionTypeException(string type)
		: base("Invalid Permission Type " + type)
	{
	}
}
