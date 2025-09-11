using System;
using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    // Placeholder for membership-related DI factories. Expand as needed.
    public class MembershipDomainFactories
    {
        public MembershipDomainFactories(object logger, RolesDomainFactories rolesDomainFactories, EmailDomainFactories emailDomainFactories)
        {
            Logger = logger;
            RolesDomainFactories = rolesDomainFactories;
            EmailDomainFactories = emailDomainFactories;
            UserFactory = new StubUserFactory();
            RoleSetValidator = new StubRoleSetValidator();
        }

        public object Logger { get; }
        public RolesDomainFactories RolesDomainFactories { get; }
        public EmailDomainFactories EmailDomainFactories { get; }

        public IUserFactory UserFactory { get; }
        public IRoleSetValidator RoleSetValidator { get; }

        private class StubUserFactory : IUserFactory
        {
            public IUser GetUser(long id, bool shouldReturnForgottenUser = false) => new StubUser { Id = (int)id, Name = $"User{id}" };
            public IUser MustGetUser(long id, bool shouldReturnForgottenUser = false) => GetUser(id, shouldReturnForgottenUser);
            public IUser GetUserByName(string name, bool shouldReturnForgottenUser = false) => new StubUser { Id = 1, Name = name ?? "Guest" };
            public IUser GetUserByAccountId(long accountId, bool shouldReturnForgottenUser = false) => new StubUser { Id = (int)accountId, Name = $"Acct{accountId}" };
            public IUser GetUserByAnyName(string name, bool shouldReturnForgottenUser = false) => GetUserByName(name, shouldReturnForgottenUser);
            public System.Collections.Generic.ICollection<IUser> GetUsers(System.Collections.Generic.ICollection<long> ids, bool shouldReturnForgottenUser = false) => new System.Collections.Generic.List<IUser>();
            public System.Collections.Generic.IReadOnlyDictionary<long, IUser> MultiGetUsers(System.Collections.Generic.ICollection<long> ids, bool shouldReturnForgottenUsers = false) => new System.Collections.Generic.Dictionary<long, IUser>();
            public System.Collections.Generic.IReadOnlyDictionary<string, IUser> MultiGetUsersByNames(System.Collections.Generic.ISet<string> names, bool includePreviousUsernames, bool shouldReturnForgottenUsers) => new System.Collections.Generic.Dictionary<string, IUser>(System.StringComparer.OrdinalIgnoreCase);
            public IUser CreateNewUser(string username, string password) => new StubUser { Id = 2, Name = username ?? "NewUser" };
            public long GetRobloxSystemUserId() => 1;
            public IUser GetRobloxSystemUser() => new StubUser { Id = 1, Name = "ROBLOX" };
            public IUser GetCurrentUser() => new StubUser { Id = 1, Name = "Admin" };
        }

        private class StubUser : IUser
        {
            public string Name { get; set; } = "Guest";
            public string Description { get; } = string.Empty;
            public long AccountId { get; } = 1;
            public DateTime Created { get; } = DateTime.UtcNow.AddYears(-10);
            public Roblox.Platform.Membership.AccountStatus AccountStatus { get; } = Roblox.Platform.Membership.AccountStatus.Ok;
            public Roblox.Platform.Membership.AgeBracket AgeBracket { get; } = Roblox.Platform.Membership.AgeBracket.Age13OrOver;
            public bool UseSuperSafeConversationMode { get; } = false;
            public bool UseSuperSafePrivacyMode { get; } = false;
            public DateTime? Birthdate { get; } = DateTime.UtcNow.AddYears(-20);
            public Roblox.Platform.Membership.GenderType GenderType { get; } = Roblox.Platform.Membership.GenderType.Unknown;
            public bool IsBCMember(Roblox.Platform.Membership.MembershipLevels.BCMembershipLevel? bcMembershipLevel = null) => false;
            public bool IsBuildersClubMember() => false;
            public bool IsTurboBuildersClubMember() => false;
            public bool IsOutrageousBuildersClubMember() => false;
            public bool IsAnyBuildersClubMember() => false;

            // MembershipCore visitor interfaces minimal implementation
            public long Id { get; set; } = 1;
            public long GetUserId() => Id;
            public long GetVisitorId() => Id;
        }

        private class StubRoleSetValidator : IRoleSetValidator
        {
            public bool IsProtectedUser(IUser user) => false;
            public bool IsSoothsayer(IUser user) => false;
            public bool IsBetaTester(IUser user) => false;
            public bool IsPrivilegedUser(IUser user) => true;
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
            public System.Collections.Generic.ICollection<IRoleset> GetRoleSets(IUser user) => new System.Collections.Generic.List<IRoleset>();
            public System.Collections.Generic.IReadOnlyCollection<int> GetRoleSetIds(IUser user) => new System.Collections.Generic.List<int>();
            public IRoleset GetHighestRoleSet(IUser user) => null;
            public IRoleset GetHighestRoleSetForAccountId(long accountId) => null;
        }
    }
}
