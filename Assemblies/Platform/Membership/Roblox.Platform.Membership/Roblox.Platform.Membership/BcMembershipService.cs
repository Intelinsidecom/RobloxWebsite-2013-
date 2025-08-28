using Roblox;

namespace Roblox.Platform.Membership;

public class BcMembershipService : IBcMembershipService
{
    // Temporary stub: decoupled from PremiumFeatureHelper to break circular dependency.
    // TODO: Wire real implementation from PremiumFeatures via composition.
    public bool IsAnyBuildersClubMember(long accountId) => false;
    public bool IsBuildersClubMember(long accountId) => false;
    public bool IsTurboBuildersClubMember(long accountId) => false;
    public bool IsOutrageousBuildersClubMember(long accountId) => false;
    public bool IsExBuildersClubMember(long accountId) => false;
    public string GetExBuildersClubMembership(long accountId) => string.Empty;
    public long GetCurrentOrFormerBuildersClubStipend(long accountId) => 0L;
}
