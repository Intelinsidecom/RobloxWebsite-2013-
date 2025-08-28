using System;

namespace Roblox.Platform.Membership;

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
