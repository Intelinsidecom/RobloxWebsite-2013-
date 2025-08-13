using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Roles;
using Roblox.Website.Factories;

namespace Roblox.Website.Factories
{
    public class RolesDomainFactories
    {
        public IRoleSetReader RoleSetReader { get; private set; }
        
        public RolesDomainFactories()
        {
            RoleSetReader = new RoleSetReader();
        }
    }
    
    internal class StubRoleSetReader : IRoleSetReader
    {
        public IRoleSet GetRoleSetForUser(long userId)
        {
            // Return a stub implementation
            return new StubRoleSet();
        }
        
        public IEnumerable<IRole> GetRolesForUser(long userId)
        {
            // Return an empty collection as a stub
            return new List<IRole>();
        }
        
        public IRoleSet GetHighestRoleSetForAccountId(long accountId)
        {
            // Return a stub implementation
            return new StubRoleSet();
        }
    }
    
    internal class StubRoleSet : IRoleSet
    {
        public int Id => 0;
        public string Name => "StubRoleSet";
        public string Description => "Stub implementation of IRoleSet";
        public int Rank => 0;

        private readonly List<IRole> _roles = new List<IRole>();
        public IEnumerable<IRole> Roles => _roles;

        public bool HasPermission(string permission)
        {
            // Stub always denies permissions
            return false;
        }

        public bool IsInRole(int roleId)
        {
            // Stub always indicates role not present
            return false;
        }
    }
    
    internal class StubRole : IRole
    {
        public int Id => 0;
        public string Name => "StubRole";
        public int Rank => 0;
    }
}

namespace Roblox.Platform.Email
{
    internal class StubUserEmailFactory : IUserEmailFactory
    {
        public IUserEmail GetCurrentVerified(IUser user)
        {
            return new StubUserEmail();
        }
    }
    
    internal class StubUserEmail : IUserEmail
    {
        public long Id => 1;

        public long UserId => 1;

        public string Email => "stub@roblox.com";

        public bool IsVerified => true;

        public DateTime Created => DateTime.UtcNow;

        public DateTime Updated => DateTime.UtcNow;
    }
}
