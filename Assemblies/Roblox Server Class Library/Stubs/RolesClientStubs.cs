using System;
using System.Collections.Generic;

namespace Roblox.Roles.Client
{
    public interface IRolesClient
    {
        void AddAccountRoleSet(long accountId, string roleSetName);
        void RemoveAccountRoleSet(long accountId, string roleSetName);
        DateTime GetAccountRoleSetLastModifiedDate();
        IEnumerable<AccountRoleSetResult> GetAllAccountRoleSets();
        IEnumerable<RoleSetResult> GetRoleSets();
    }

    public class RolesClient : IRolesClient
    {
        private readonly Func<string> _getApiKey;

        public RolesClient(Func<string> getApiKey)
        {
            _getApiKey = getApiKey;
        }

        public void AddAccountRoleSet(long accountId, string roleSetName) { }
        public void RemoveAccountRoleSet(long accountId, string roleSetName) { }
        public DateTime GetAccountRoleSetLastModifiedDate() => DateTime.UtcNow;
        public IEnumerable<AccountRoleSetResult> GetAllAccountRoleSets() => Array.Empty<AccountRoleSetResult>();
        public IEnumerable<RoleSetResult> GetRoleSets() => Array.Empty<RoleSetResult>();
    }

    public class AccountRoleSetResult
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string RoleSetName { get; set; }
        public DateTime Created { get; set; }
    }

    public class RoleSetResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }
}
