using System;

namespace Roblox.PremiumFeatures;

public interface IAccountAddOnActivationTaskFactory
{
	DateTime CalculateBuildersClubUpgradeExpiration(AccountAddOn currentBuildersClubMembershipAddOn, int newPremiumFeatureId, bool isBaseExpiration = false);

	DateTime CalculateGracePeriodAwareExpiration(DateTime baseExpiration, bool isRenewal);
}
