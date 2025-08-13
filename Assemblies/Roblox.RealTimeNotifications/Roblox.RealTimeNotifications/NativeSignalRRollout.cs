using System;
using Roblox.RealTimeNotifications.Properties;

namespace Roblox.RealTimeNotifications;

public static class NativeSignalRRollout
{
	public static bool IsNativeSignalREnabledOnIOS(long? userId, Version appVersion)
	{
		if (!userId.HasValue)
		{
			return false;
		}
		Version.TryParse(Settings.Default.NativeSignalRMinimumSupportedIOSAppVersion, out var minimumSupportedVersion);
		if (appVersion != null && minimumSupportedVersion != null && appVersion < minimumSupportedVersion)
		{
			return false;
		}
		return userId.Value % 100 < Settings.Default.NativeSignalREnabledOnIOSRolloutPercentage;
	}
}
