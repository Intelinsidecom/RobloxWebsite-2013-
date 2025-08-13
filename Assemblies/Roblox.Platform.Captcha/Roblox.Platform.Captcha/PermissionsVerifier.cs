using Roblox.Platform.Membership;

namespace Roblox.Platform.Captcha;

internal class PermissionsVerifier
{
	public static bool IsFeaturedEnabledOnSettings(IUser authenticatedUser, bool isGuestAllowed = false, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		if (turnOnForAllSetting)
		{
			return true;
		}
		bool result = authenticatedUser != null && ((soothsayerSetting && authenticatedUser.IsSoothSayer()) || (betaTesterSetting && authenticatedUser.IsBetaTester()) || rolloutPercentageSetting > authenticatedUser.Id % 100);
		if (authenticatedUser == null && isGuestAllowed)
		{
			return rolloutPercentageSetting == 100;
		}
		return result;
	}
}
