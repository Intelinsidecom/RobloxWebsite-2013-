using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutPlayTogetherSupport
{
	public static bool IsPlayTogetherEnabledOnIOS(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsPlayTogetherEnabledOnIOSPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsPlayTogetherEnabledOnIOSTablet())
		{
			return true;
		}
		return false;
	}

	public static bool IsPlayTogetherEnabledOnAndroid(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsPlayTogetherEnabledOnAndroidPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsPlayTogetherEnabledOnAndroidTablet())
		{
			return true;
		}
		return false;
	}

	private static bool IsPlayTogetherEnabledOnIOSPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsPlayTogetherEnabledOnIOSPhoneForSoothsayers, Settings.Default.IsPlayTogetherEnabledOnIOSPhoneForBetatesters, Settings.Default.PlayTogetherEnabledOnIOSPhoneRolloutPercentage);
	}

	private static bool IsPlayTogetherEnabledOnIOSTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsPlayTogetherEnabledOnIOSTabletForSoothsayers, Settings.Default.IsPlayTogetherEnabledOnIOSTabletForBetatesters, Settings.Default.PlayTogetherEnabledOnIOSTabletRolloutPercentage);
	}

	private static bool IsPlayTogetherEnabledOnAndroidPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsPlayTogetherEnabledOnAndroidPhoneForSoothsayers, Settings.Default.IsPlayTogetherEnabledOnAndroidPhoneForBetatesters, Settings.Default.PlayTogetherEnabledOnAndroidPhoneRolloutPercentage);
	}

	private static bool IsPlayTogetherEnabledOnAndroidTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsPlayTogetherEnabledOnAndroidTabletForSoothsayers, Settings.Default.IsPlayTogetherEnabledOnAndroidTabletForBetatesters, Settings.Default.PlayTogetherEnabledOnAndroidTabletRolloutPercentage);
	}
}
