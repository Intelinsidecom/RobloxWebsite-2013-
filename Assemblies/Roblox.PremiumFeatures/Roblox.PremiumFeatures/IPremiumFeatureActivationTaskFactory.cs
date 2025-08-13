namespace Roblox.PremiumFeatures;

public interface IPremiumFeatureActivationTaskFactory
{
	PremiumFeature RequestPremiumFeatureActivation(long accountId, int premiumFeatureId);
}
