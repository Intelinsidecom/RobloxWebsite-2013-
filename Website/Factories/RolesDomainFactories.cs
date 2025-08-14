using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Email.User;
using Roblox.Website.Factories;

namespace Roblox.Website.Factories
{
    public class RolesDomainFactories
    {
        public IRoleSetValidator RoleSetReader { get; private set; }
        
        public RolesDomainFactories()
        {
            RoleSetReader = new StubRoleSetValidator();
        }
    }
    
    // Note: These stubs are placeholders until we can properly reference the actual implementations
    // from the Roblox.Platform assemblies
    internal class StubRoleSetValidator : IRoleSetValidator
    {
        public bool IsProtectedUser(IUser user) => false;
        public bool IsSoothsayer(IUser user) => false;
        public bool IsBetaTester(IUser user) => false;
        public bool IsPrivilegedUser(IUser user) => false;
        public bool IsTrustedContributor(IUser user) => false;
        public bool IsContentCreator(IUser user) => false;
        public bool IsDeveloperRelations(IUser user) => false;
        public bool IsCommunityManager(IUser user) => false;
        public bool IsCustomerService(IUser user) => false;
        public bool IsCSAgentAdmin(IUser user) => false;
        public bool IsFastTrackMember(IUser user) => false;
        public bool IsFastTrackModerator(IUser user) => false;
        public bool IsFastTrackAdmin(IUser user) => false;
        public bool IsThumbnailAdmin(IUser user) => false;
        public bool IsMatchmakingAdmin(IUser user) => false;
        public bool IsRccReleaseTester(IUser user) => false;
        public bool IsRccReleaseTesterManager(IUser user) => false;
        public bool IsChinaLicenseUser(IUser user) => false;
        public bool IsChinaBetaUser(IUser user) => false;
        public bool IsInfluencer(IUser user) => false;
        public bool IsDataAdministrator(IUser user) => false;
        public bool IsAdOps(IUser user) => false;
        public bool IsCLBGameDeveloper(IUser user) => false;
        public bool IsInRole(IUser user, int roleSetId) => false;
        public bool IsInRole(IUser user, string roleName) => false;
        public ICollection<IRoleset> GetRoleSets(IUser user) => new List<IRoleset>();
        public IReadOnlyCollection<int> GetRoleSetIds(IUser user) => new List<int>();
        public IRoleset GetHighestRoleSet(IUser user) => new StubRoleSet();
        public IRoleset GetHighestRoleSetForAccountId(long accountId) => new StubRoleSet();
        public IRoleset GetRoleSetForUser(long userId) => new StubRoleSet();
        public IEnumerable<IRoleset> GetRolesForUser(long userId) => new List<IRoleset>();
    }
    

    internal class StubRoleSet : IRoleset
    {
        public int Id => 0;
        public string Name => "StubRoleSet";
        public int Rank => 0;
    }
}

namespace Roblox.Website.Factories
{
    internal class StubUserEmailFactory : IUserEmailFactory
    {
        public IAccountEmail GetCurrentVerified(IUser user)
        {
            return new StubUserEmail();
        }
        
        public IAccountEmail GetByEmail(string email)
        {
            return new StubUserEmail();
        }
        
        public ICollection<IAccountEmail> GetEmailsForUser(long userId)
        {
            return new List<IAccountEmail> { new StubUserEmail() };
        }
    }
    
    internal class StubUserEmail : IAccountEmail
    {
        public int Id => 1;
        public string Email => "stub@roblox.com";
        public bool IsBlacklisted => false;
        public bool IsVerified => true;
        public bool IsCurrent => true;
        public bool IsValid => true;
        public long AccountId => 1;
    }
}
