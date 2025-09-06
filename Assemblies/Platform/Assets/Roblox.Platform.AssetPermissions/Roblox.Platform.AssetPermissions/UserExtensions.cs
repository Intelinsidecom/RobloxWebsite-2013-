using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Permissions.Core;
using Api = Roblox.Platform.Permissions.Client;

namespace Roblox.Platform.AssetPermissions;

public static class UserExtensions
{
    public static void AddPermissionGroup(this IUserIdentifier user, Roblox.Platform.Assets.IAsset asset, IActionType actionType, Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroups, Api.IPermissionsClient permissionsApiClient)
    {
        user.VerifyIsNotNull();
        asset.VerifyIsNotNull();
        user.VerifyIsCreator(asset);
        asset.AddPermissionGroup(actionType, permissionGroups, permissionsApiClient);
    }

    public static void RemovePermissionGroup(this IUserIdentifier user, Roblox.Platform.Assets.IAsset asset, IActionType actionType, Roblox.Platform.Permissions.Core.IPermissionGroup permissionGroups, Api.IPermissionsClient permissionsApiClient)
    {
        user.VerifyIsNotNull();
        asset.VerifyIsNotNull();
        user.VerifyIsCreator(asset);
        asset.RemovePermissionGroup(actionType, permissionGroups, permissionsApiClient);
    }
}
