using Roblox.Platform.Membership;

namespace Roblox.Platform.PremiumFeatures;

public class PremiumFeaturesPermissionVerifier : IPremiumFeaturesPermissionVerifier
{
	public bool IsFeaturedEnabledOnSettings(IUser user, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		if (user == null)
		{
			return false;
		}
		if (turnOnForAllSetting)
		{
			return true;
		}
		if ((!soothsayerSetting || !user.IsSoothSayer()) && (!betaTesterSetting || !user.IsBetaTester()))
		{
			return rolloutPercentageSetting > user.Id % 100;
		}
		return true;
	}
}
