using System;

namespace Roblox.Platform.Groups
{
    // Legacy shim: Builders Club tiers are deprecated. These methods exist only to satisfy
    // older call sites in GroupManagement that differentiate limits by BC tier.
    // Modern premium checks should use AccountAddOnFactory.IsPremiumAccount(...) or IPremiumFeaturesUser.
    internal static class PremiumFeatureHelper
    {
        public static bool IsOutrageousBuildersClubMember(long accountId)
        {
            return false;
        }

        public static bool IsTurboBuildersClubMember(long accountId)
        {
            return false;
        }

        public static bool IsBuildersClubMember(long accountId)
        {
            return false;
        }

        public static bool IsAnyBuildersClubMember(long accountId)
        {
            return false;
        }
    }
}
