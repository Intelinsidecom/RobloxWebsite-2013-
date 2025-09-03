using System;
using Roblox.PremiumFeatures;
namespace Roblox.Platform.PremiumFeatures
{
    public interface IAccountAddOnActivationTaskFactory

{
	DateTime CalculateBuildersClubUpgradeExpiration(AccountAddOn currentBuildersClubMembershipAddOn, int newPremiumFeatureId, bool isBaseExpiration = false);

	DateTime CalculateGracePeriodAwareExpiration(DateTime baseExpiration, bool isRenewal);
}


}
