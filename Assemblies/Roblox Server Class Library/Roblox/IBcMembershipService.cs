using System;

namespace Roblox
{
    /// <summary>
    /// Neutral BC membership service interface that the Server library can call without
    /// taking a dependency on Premium or Membership. An app may supply a concrete
    /// implementation at composition time.
    /// </summary>
    public interface IBcMembershipService
    {
        bool IsAnyBuildersClubMember(long accountId);
        bool IsBuildersClubMember(long accountId);
        bool IsTurboBuildersClubMember(long accountId);
        bool IsOutrageousBuildersClubMember(long accountId);
        bool IsExBuildersClubMember(long accountId);
        string GetExBuildersClubMembership(long accountId);
        long GetCurrentOrFormerBuildersClubStipend(long accountId);
    }
}
