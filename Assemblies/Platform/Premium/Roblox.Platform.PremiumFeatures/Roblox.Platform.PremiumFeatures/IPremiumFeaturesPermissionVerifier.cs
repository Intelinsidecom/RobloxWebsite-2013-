using Roblox.Platform.Membership;

namespace Roblox.Platform.PremiumFeatures;

public interface IPremiumFeaturesPermissionVerifier
{
	bool IsFeaturedEnabledOnSettings(IUser user, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false);
}
