using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutPartyDisableSupport
{
	public static bool IsPartyDisabled(this IUser user, IPlatform platform)
	{
		if (platform.PlatformType == PlatformType.XboxOne)
		{
			return false;
		}
		if (user == null)
		{
			return true;
		}
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsPartyDisabledForSoothsayers, Settings.Default.IsPartyDisabledForBetatesters, Settings.Default.PartyDisabledRolloutPercentage);
	}
}
