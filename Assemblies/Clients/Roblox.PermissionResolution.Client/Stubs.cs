namespace Roblox.PermissionResolution.Client
{
    using System.Collections.Generic;

    public interface IPermissionResolutionClient
    {
        bool UserHasPermission(long userId, string resourceType, string resourceId, IList<System.ValueTuple<string, string>> attributes, string action);
    }
}
