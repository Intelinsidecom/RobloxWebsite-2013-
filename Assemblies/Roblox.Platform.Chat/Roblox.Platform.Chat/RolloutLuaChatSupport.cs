using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutLuaChatSupport
{
	public static bool IsLuaChatEnabledOnIos(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsLuaChatEnabledOnIosPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsLuaChatEnabledOnIosTablet())
		{
			return true;
		}
		return false;
	}

	public static bool IsLuaChatEnabledOnAndroid(this IUser user, DeviceType deviceType)
	{
		if (user == null)
		{
			return false;
		}
		if (deviceType == DeviceType.Phone && user.IsLuaChatEnabledOnAndroidPhone())
		{
			return true;
		}
		if (deviceType == DeviceType.Tablet && user.IsLuaChatEnabledOnAndroidTablet())
		{
			return true;
		}
		return false;
	}

	private static bool IsLuaChatEnabledOnIosPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsLuaChatEnabledOnIOSPhoneForSoothsayers, Settings.Default.IsLuaChatEnabledOnIOSPhoneForBetaTesters, Settings.Default.LuaChatOnIOSPhoneRolloutPercentage);
	}

	private static bool IsLuaChatEnabledOnIosTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsLuaChatEnabledOnIOSTabletForSoothsayers, Settings.Default.IsLuaChatEnabledOnIOSTabletForBetaTesters, Settings.Default.LuaChatOnIOSTabletRolloutPercentage);
	}

	private static bool IsLuaChatEnabledOnAndroidPhone(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsLuaChatEnabledOnAndroidPhoneForSoothsayers, Settings.Default.IsLuaChatEnabledOnAndroidPhoneForBetaTesters, Settings.Default.LuaChatOnAndroidPhoneInclusiveStartRolloutPercentage, Settings.Default.LuaChatOnAndroidPhoneExclusiveEndRolloutPercentage);
	}

	private static bool IsLuaChatEnabledOnAndroidTablet(this IUser user)
	{
		return RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsLuaChatEnabledOnAndroidTabletForSoothsayers, Settings.Default.IsLuaChatEnabledOnAndroidTabletForBetaTesters, Settings.Default.LuaChatOnAndroidTabletInclusiveStartRolloutPercentage, Settings.Default.LuaChatOnAndroidTabletExclusiveEndRolloutPercentage);
	}
}
