using System;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.PremiumFeatures;

namespace Roblox.Platform.Membership.Extensions
{
    public static class UserPremiumExtensions
    {
        public static BuildersClubMembershipType GetBuildersClubMembershipType(this IUser user)
        {
            if (user == null)
            {
                return BuildersClubMembershipType.None;
            }

            AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(user.AccountId);
            if (accountAddOn == null || accountAddOn.Expiration <= DateTime.Now)
            {
                return BuildersClubMembershipType.None;
            }

            PremiumFeature premiumFeature = PremiumFeature.Get(accountAddOn.PremiumFeatureID);
            if (premiumFeature.IsOutrageousBuildersClub)
            {
                return BuildersClubMembershipType.OBC;
            }
            if (premiumFeature.IsTurboBuildersClub)
            {
                return BuildersClubMembershipType.TBC;
            }
            if (premiumFeature.IsBuildersClub)
            {
                return BuildersClubMembershipType.BC;
            }
            return BuildersClubMembershipType.None;
        }
    }
}
