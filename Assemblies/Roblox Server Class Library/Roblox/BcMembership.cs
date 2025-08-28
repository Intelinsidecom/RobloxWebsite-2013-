using System;

namespace Roblox
{
    /// <summary>
    /// Static access point for BC membership checks within the Server library.
    /// Default implementation is a null-safe stub. Applications should set
    /// BcMembership.Instance at composition time to a real implementation.
    /// </summary>
    public static class BcMembership
    {
        private sealed class NullBcMembershipService : IBcMembershipService
        {
            public bool IsAnyBuildersClubMember(long accountId) => false;
            public bool IsBuildersClubMember(long accountId) => false;
            public bool IsTurboBuildersClubMember(long accountId) => false;
            public bool IsOutrageousBuildersClubMember(long accountId) => false;
            public bool IsExBuildersClubMember(long accountId) => false;
            public string GetExBuildersClubMembership(long accountId) => string.Empty;
            public long GetCurrentOrFormerBuildersClubStipend(long accountId) => 0L;
        }

        private static IBcMembershipService _instance = new NullBcMembershipService();

        public static IBcMembershipService Instance
        {
            get => _instance;
            set => _instance = value ?? new NullBcMembershipService();
        }
    }
}
