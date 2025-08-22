// Minimal shim for missing external package Roblox.PermissionResolution.Client
// Provides only the types referenced by Roblox.Platform.AssetPermissions.
namespace Roblox.PermissionResolution.Client
{
    // Marker interface used only for DI typing in AssetPermissionsVerifier.
    // No members required for current usage.
    public interface IPermissionResolutionClient { }
}
