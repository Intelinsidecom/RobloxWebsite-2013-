using System.Collections.Generic;
using Roblox.Platform.Roles;

namespace Roblox.Website.Factories
{
    public interface IRoleSetReader
    {
        IRoleSet GetRoleSetForUser(long userId);
        IEnumerable<IRole> GetRolesForUser(long userId);
        IRoleSet GetHighestRoleSetForAccountId(long accountId);
    }
}
