using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Permissions.Core;
using Api = Roblox.Platform.Permissions.Client;

namespace Roblox.Platform.AssetPermissions;

public static class AssetExtensions
{
    public static void AddPermissionGroup(this Roblox.Platform.Assets.IAsset asset, IActionType actionType, IPermissionGroup permissionGroup, Api.IPermissionsClient permissionsApiClient)
    {
        asset.VerifyIsNotNull();
        actionType.AddPermissionGroup(permissionGroup, permissionsApiClient, asset.Id);
    }

    public static IEnumerable<IPermissionGroup> GetPermissionGroups(this Roblox.Platform.Assets.IAsset asset, IActionType actionType, Api.IPermissionsClient permissionsApiClient)
    {
        asset.VerifyIsNotNull();
        return actionType.GetPermissionGroups(asset.Id, permissionsApiClient);
    }

    public static void RemovePermissionGroup(this Roblox.Platform.Assets.IAsset asset, IActionType actionType, IPermissionGroup permissionGroup, Api.IPermissionsClient permissionsApiClient)
    {
        asset.VerifyIsNotNull();
        actionType.RemovePermissionGroup(permissionGroup, permissionsApiClient, asset.Id);
    }
}
