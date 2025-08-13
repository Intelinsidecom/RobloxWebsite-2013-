namespace Roblox.Platform.Notifications.Push;

internal static class InstrumentationUtilties
{
	public static string GetDestinationTypeString(PushApplicationType application, PushPlatformType platform)
	{
		return $"{application}_{platform}";
	}
}
