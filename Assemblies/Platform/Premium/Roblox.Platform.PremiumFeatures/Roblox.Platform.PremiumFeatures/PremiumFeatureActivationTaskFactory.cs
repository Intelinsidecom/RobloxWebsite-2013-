using System;
namespace Roblox.Platform.PremiumFeaturespublic {
    class PremiumFeatureActivationTaskFactory : IPremiumFeatureActivationTaskFactory

{
	public PremiumFeature RequestPremiumFeatureActivation(long accountId, int premiumFeatureId)
	{
		PremiumFeature premiumFeature = PremiumFeature.Get(premiumFeatureId);
		if (premiumFeature == null)
		{
			throw new ApplicationException($"Failed to load Premium Feature {premiumFeatureId}.");
		}
		PremiumFeatureActivationTask.CreateNew(accountId, premiumFeature);
		return premiumFeature;
	}
}


}
