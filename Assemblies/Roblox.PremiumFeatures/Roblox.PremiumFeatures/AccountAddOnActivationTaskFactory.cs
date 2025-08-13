using System;

namespace Roblox.PremiumFeatures;

public class AccountAddOnActivationTaskFactory : IAccountAddOnActivationTaskFactory
{
	public DateTime CalculateBuildersClubUpgradeExpiration(AccountAddOn currentBuildersClubMembershipAddOn, int newPremiumFeatureId, bool isBaseExpiration = false)
	{
		return AccountAddOnActivationTask.CalculateBuildersClubUpgradeExpiration(currentBuildersClubMembershipAddOn, newPremiumFeatureId, isBaseExpiration);
	}

	public DateTime CalculateGracePeriodAwareExpiration(DateTime baseExpiration, bool isRenewal)
	{
		return AccountAddOnActivationTask.CalculateGracePeriodAwareExpiration(baseExpiration, isRenewal);
	}
}
