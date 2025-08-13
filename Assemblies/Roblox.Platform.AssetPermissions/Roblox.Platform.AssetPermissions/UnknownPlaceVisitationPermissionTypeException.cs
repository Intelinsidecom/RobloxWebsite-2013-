using Roblox.Platform.Core;

namespace Roblox.Platform.AssetPermissions;

public class UnknownPlaceVisitationPermissionTypeException : PlatformException
{
	public UnknownPlaceVisitationPermissionTypeException()
		: base("Unknown PlaceVisitationPermisionType")
	{
	}
}
