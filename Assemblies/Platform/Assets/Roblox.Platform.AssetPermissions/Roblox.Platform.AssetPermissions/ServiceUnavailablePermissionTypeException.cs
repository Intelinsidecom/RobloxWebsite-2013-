using Roblox.Platform.Core;

namespace Roblox.Platform.AssetPermissions;

public class ServiceUnavailablePermissionTypeException : PlatformException
{
	public ServiceUnavailablePermissionTypeException()
		: base("Permissions service unavailable")
	{
	}
}
