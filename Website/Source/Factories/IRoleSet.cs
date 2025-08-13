using System.Collections.Generic;
using Roblox.Platform.Roles;

namespace Roblox.Platform.Roles
{
    public interface IRoleSet
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        int Rank { get; }
        IEnumerable<IRole> Roles { get; }
        bool HasPermission(string permission);
        bool IsInRole(int roleId);
    }
}
