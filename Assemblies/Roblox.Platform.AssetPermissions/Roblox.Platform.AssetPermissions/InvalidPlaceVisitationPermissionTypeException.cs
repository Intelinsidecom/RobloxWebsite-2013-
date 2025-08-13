using Roblox.Platform.Core;

namespace Roblox.Platform.AssetPermissions;

public class InvalidPlaceVisitationPermissionTypeException : PlatformException
{
	public InvalidPlaceVisitationPermissionTypeException()
		: base("Invalid PlaceVisitationPermisionType")
	{
	}

	public InvalidPlaceVisitationPermissionTypeException(PlaceVisitationPermissionType accessType)
		: base("Invalid PlaceVisitationPermisionType: " + accessType)
	{
	}
}
