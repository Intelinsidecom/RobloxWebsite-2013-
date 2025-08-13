using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutConversationUniverseSupport
{
	public static bool IsConversationUniverseEnabledOnWeb(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationUniverseEnabledOnWebForSoothsayers, Settings.Default.IsConversationUniverseEnabledOnWebForBetatesters, Settings.Default.ConversationUniverseEnabledOnWebRolloutPercentage);
	}

	public static bool IsConversationUniverseEnabledOnIOS(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsConversationUniverseEnabledOnIOSPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsConversationUniverseEnabledOnIOSTablet())
		{
			return true;
		}
		return false;
	}

	public static bool IsConversationUniverseEnabledOnAndroid(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsConversationUniverseEnabledOnAndroidPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsConversationUniverseEnabledOnAndroidTablet())
		{
			return true;
		}
		return false;
	}

	private static bool IsConversationUniverseEnabledOnIOSPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationUniverseEnabledOnIOSPhoneForSoothsayers, Settings.Default.IsConversationUniverseEnabledOnIOSPhoneForBetatesters, Settings.Default.ConversationUniverseEnabledOnIOSPhoneRolloutPercentage);
	}

	private static bool IsConversationUniverseEnabledOnIOSTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationUniverseEnabledOnIOSTabletForSoothsayers, Settings.Default.IsConversationUniverseEnabledOnIOSTabletForBetatesters, Settings.Default.ConversationUniverseEnabledOnIOSTabletRolloutPercentage);
	}

	private static bool IsConversationUniverseEnabledOnAndroidPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationUniverseEnabledOnAndroidPhoneForSoothsayers, Settings.Default.IsConversationUniverseEnabledOnAndroidPhoneForBetatesters, Settings.Default.ConversationUniverseEnabledOnAndroidPhoneRolloutPercentage);
	}

	private static bool IsConversationUniverseEnabledOnAndroidTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationUniverseEnabledOnAndroidTabletForSoothsayers, Settings.Default.IsConversationUniverseEnabledOnAndroidTabletForBetatesters, Settings.Default.ConversationUniverseEnabledOnAndroidTabletRolloutPercentage);
	}
}
