namespace Roblox.Permissions.Client
{
    // Minimal stub to satisfy Roblox.Platform.Privacy until real Roblox.Permissions.Client is available
    public interface IPermissionsClient
    {
        void ApplyPermissionGroupToAction(string action, long permissionGroupId, long actorId, string actorType, long? contextId);
        void RemovePermissionGroupFromAction(string action, long permissionGroupId, long actorId, string actorType, long? contextId);
    }
}
