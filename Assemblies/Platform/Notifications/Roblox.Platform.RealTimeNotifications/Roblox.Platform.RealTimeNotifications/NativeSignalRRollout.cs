using System;
using Roblox.Platform.RealTimeNotifications.Properties;
namespace Roblox.Platform.RealTimeNotifications
{
    static class NativeSignalRRollout

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

}
