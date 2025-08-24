using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Stream.Properties;

namespace Roblox.Platform.Notifications.Stream;

public static class Extensions
{
	public static bool IsNotificationStreamEnabled(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (user.Id % 100 < Settings.Default.NotificationStreamRegularUserRolloutPercentage)
		{
			return true;
		}
		if (Settings.Default.IsNotificationStreamEnabledForBetaTesters && user.IsBetaTester())
		{
			return true;
		}
		if (Settings.Default.IsNotificationStreamEnabledForSoothSayers && user.IsSoothSayer())
		{
			return true;
		}
		return false;
	}

	public static bool IsNotificationStreamEnabledOnAndroid(this IUser user, Version appVersion = null)
	{
		if (user == null)
		{
			return false;
		}
		Version minimumVersion = ParseVersion(Settings.Default.MinimumSupportedVersionAndroid);
		if (appVersion != null && minimumVersion != null && appVersion < minimumVersion)
		{
			return false;
		}
		if (!Settings.Default.IsNotificationStreamEnabledOnAndroidForRegularUsers && (!Settings.Default.IsNotificationStreamEnabledOnAndroidForSoothsayers || !user.IsSoothSayer()))
		{
			if (Settings.Default.IsNotificationStreamEnabledOnAndroidForBetaTesters)
			{
				return user.IsBetaTester();
			}
			return false;
		}
		return true;
	}

	public static bool IsNotificationStreamEnabledOnIOS(this IUser user, Version appVersion = null)
	{
		if (user == null)
		{
			return false;
		}
		Version minimumVersion = ParseVersion(Settings.Default.MinimumSupportedVersionIOS);
		if (appVersion != null && minimumVersion != null && appVersion < minimumVersion)
		{
			return false;
		}
		if (!Settings.Default.IsNotificationStreamEnabledOnIOSForRegularUsers && (!Settings.Default.IsNotificationStreamEnabledOnIOSForSoothsayers || !user.IsSoothSayer()))
		{
			if (Settings.Default.IsNotificationStreamEnabledOnIOSForBetaTesters)
			{
				return user.IsBetaTester();
			}
			return false;
		}
		return true;
	}

	public static bool IsNotificationsStreamEnabledOnWindowsApp(this IUser user, Version appVersion = null)
	{
		if (user == null)
		{
			return false;
		}
		Version minimumVersion = ParseVersion(Settings.Default.MinimumSupportedVersionWindowsApp);
		if (appVersion != null && minimumVersion != null && appVersion < minimumVersion)
		{
			return false;
		}
		if (!Settings.Default.IsNotificationStreamEnabledOnWindowsAppForRegularUsers)
		{
			if (Settings.Default.IsNotificationStreamEnabledOnWindowsAppForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	private static Version ParseVersion(string versionString)
	{
		if (Version.TryParse(versionString, out var version))
		{
			return version;
		}
		return null;
	}
}
