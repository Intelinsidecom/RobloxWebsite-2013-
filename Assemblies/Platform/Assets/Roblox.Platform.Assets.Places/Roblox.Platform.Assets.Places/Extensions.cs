using Roblox.Platform.Assets.Places.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets.Places;

public static class Extensions
{
	public static bool IsSocialSlotTypesEnabled(this IUser user)
	{
		user.VerifyIsNotNull();
		if (Settings.Default.IsSocialSlotTypesEnabledForSoothsayers && user.IsSoothSayer())
		{
			return true;
		}
		if (Settings.Default.IsSocialSlotTypesEnabledForBetaTesters && user.IsBetaTester())
		{
			return true;
		}
		if (user.Id % 100 < Settings.Default.SocialSlotTypesRolloutPercentage)
		{
			return true;
		}
		return false;
	}
}
