using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Website.Factories
{
    internal class StubUserFactory : Roblox.Platform.Membership.IUserFactory
    {
        public IUser GetUser(long id, bool shouldReturnForgottenUser = false) => new StubUser(id, $"User{id}");
        public IUser MustGetUser(long id, bool shouldReturnForgottenUser = false) => GetUser(id, shouldReturnForgottenUser);
        public IUser GetUserByName(string name, bool shouldReturnForgottenUser = false) => new StubUser(1, name ?? "User");
        public IUser GetUserByAccountId(long accountId, bool shouldReturnForgottenUser = false) => new StubUser(accountId, $"User{accountId}");
        public IUser GetUserByAnyName(string name, bool shouldReturnForgottenUser = false) => new StubUser(1, name ?? "User");
        public ICollection<IUser> GetUsers(ICollection<long> ids, bool shouldReturnForgottenUser = false)
        {
            var list = new List<IUser>();
            if (ids != null)
            {
                foreach (var id in ids)
                {
                    list.Add(new StubUser(id, $"User{id}"));
                }
            }
            return list;
        }
        public IReadOnlyDictionary<long, IUser> MultiGetUsers(ICollection<long> ids, bool shouldReturnForgottenUsers = false)
        {
            var dict = new Dictionary<long, IUser>();
            if (ids != null)
            {
                foreach (var id in ids)
                {
                    dict[id] = new StubUser(id, $"User{id}");
                }
            }
            return dict;
        }
        public IReadOnlyDictionary<string, IUser> MultiGetUsersByNames(ISet<string> names, bool includePreviousUsernames, bool shouldReturnForgottenUsers)
        {
            var dict = new Dictionary<string, IUser>(StringComparer.OrdinalIgnoreCase);
            if (names != null)
            {
                foreach (var name in names)
                {
                    dict[name] = new StubUser(1, name);
                }
            }
            return dict;
        }
        public IUser CreateNewUser(string username, string password) => new StubUser(2, username ?? "NewUser");
        public long GetRobloxSystemUserId() => 1;
        public IUser GetRobloxSystemUser() => new StubUser(1, "Roblox");
        public IUser GetCurrentUser() => new StubUser(1, "CurrentUser");
    }

    internal class StubUser : IUser
    {
        public StubUser(long id, string name)
        {
            Id = id;
            Name = name;
            AccountId = id;
            Created = DateTime.UtcNow.AddYears(-1);
            AccountStatus = AccountStatus.Ok;
        }

        public string Name { get; }
        public string Description { get; } = string.Empty;
        public long AccountId { get; }
        public DateTime Created { get; }
        public AccountStatus AccountStatus { get; }
        public AgeBracket AgeBracket { get; } = AgeBracket.Age13OrOver;
        public bool UseSuperSafeConversationMode { get; } = false;
        public bool UseSuperSafePrivacyMode { get; } = false;
        public DateTime? Birthdate { get; } = null;
        public GenderType GenderType { get; } = GenderType.Unknown;
        public bool IsBCMember(MembershipLevels.BCMembershipLevel? bcMembershipLevel = null) => false;
        public bool IsBuildersClubMember() => false;
        public bool IsTurboBuildersClubMember() => false;
        public bool IsOutrageousBuildersClubMember() => false;
        public bool IsAnyBuildersClubMember() => false;

        // IVisitorIdentifier/IUserIdentifier
        public long Id { get; }
    }

    internal class StubRoleset : IRoleset
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Member";
        public int Rank { get; set; } = 0;
    }

    internal class StubRoleSetValidator : IRoleSetValidator
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
        public ICollection<IRoleset> GetRoleSets(IUser user) => new List<IRoleset> { new StubRoleset() };
        public System.Collections.Generic.IReadOnlyCollection<int> GetRoleSetIds(IUser user) => new List<int> { 0 };
        public IRoleset GetHighestRoleSet(IUser user) => new StubRoleset();
        public IRoleset GetHighestRoleSetForAccountId(long accountId) => new StubRoleset();
    }
}
