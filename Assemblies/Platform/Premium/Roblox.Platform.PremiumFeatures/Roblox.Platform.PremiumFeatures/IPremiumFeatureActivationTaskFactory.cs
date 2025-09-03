using Roblox.PremiumFeatures;
namespace Roblox.Platform.PremiumFeatures
{
    public interface IPremiumFeatureActivationTaskFactory

{
    PremiumFeature RequestPremiumFeatureActivation(long accountId, int premiumFeatureId);
}


}
