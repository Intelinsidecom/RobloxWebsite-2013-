namespace Roblox.Platform.PremiumFeatures
{
    interface IPremiumFeatureActivationTaskFactory

{
	PremiumFeature RequestPremiumFeatureActivation(long accountId, int premiumFeatureId);
}


}
