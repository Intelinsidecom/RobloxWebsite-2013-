// Minimal shim for missing external package Roblox.Permissions.Client
// Provides only the types referenced by Roblox.Platform.AssetPermissions.
namespace Roblox.Permissions.Client
{
    // Marker interface used as a dependency type throughout the codebase.
    // No members are required for current usage within AssetPermissions.
    public interface IPermissionsClient { }
}
