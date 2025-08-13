using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutMessageTypesSupport
{
	public static bool IsGameLinkChatMessageEnabled(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsGameLinkChatMessageEnabledForSoothsayers, Settings.Default.IsGameLinkChatMessageEnabledForBetatesters, Settings.Default.GameLinkChatMessageEnabledRolloutPercentage);
	}
}
