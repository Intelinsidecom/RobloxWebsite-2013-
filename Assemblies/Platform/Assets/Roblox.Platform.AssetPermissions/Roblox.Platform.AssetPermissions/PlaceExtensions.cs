using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Permissions.Core;
using Api = Roblox.Platform.Permissions.Client;

namespace Roblox.Platform.AssetPermissions;

public static class PlaceExtensions
{
    private static PlaceVisitationPermissionType Translate(this Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroup)
    {
        if (permissionGroup == null)
        {
            return PlaceVisitationPermissionType.Everyone;
        }
        if (permissionGroup.Name == PlaceVisitationPermissionType.Creator.ToString())
        {
            return PlaceVisitationPermissionType.Creator;
        }
        if (permissionGroup.Name == PlaceVisitationPermissionType.Friends.ToString())
        {
            return PlaceVisitationPermissionType.Friends;
        }
        if (permissionGroup.Name.Contains(PlaceVisitationPermissionType.Whitelist.ToString()))
        {
            return PlaceVisitationPermissionType.Whitelist;
        }
        throw new UnknownPlaceVisitationPermissionTypeException();
    }

    public static IEnumerable<Roblox.Platform.Permissions.Core.IPermissionGroup> GetPlaceVisitationPermissionGroups(this IPlace place, Api.IPermissionsClient permissionsApiClient)
    {
        place.VerifyIsNotNull();
        return ActionTypeFactory.GetActionType("VisitPlace").GetPermissionGroups(place.Id, permissionsApiClient);
    }
}
