using System.Collections.Generic;

namespace Roblox.Platform.AssetPermissions;

public class PlaceAccessPermissions
{
	public PlaceVisitationPermissionType PlaceVisitationPermissionType { get; private set; }

	public IEnumerable<int> WhitelistedUserIds { get; private set; }

	internal PlaceAccessPermissions(PlaceVisitationPermissionType placeVisitationPermissionType)
	{
		PlaceVisitationPermissionType = placeVisitationPermissionType;
	}

	internal PlaceAccessPermissions(IEnumerable<int> whitelistedUserIds)
	{
		PlaceVisitationPermissionType = PlaceVisitationPermissionType.Whitelist;
		WhitelistedUserIds = whitelistedUserIds;
	}
}
