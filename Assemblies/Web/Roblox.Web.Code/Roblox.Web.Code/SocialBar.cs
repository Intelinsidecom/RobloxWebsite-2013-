using Roblox.Platform.Membership;
using Roblox.Web.Devices;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

public static class SocialBar
{
	public static bool IsSocialBarEnabled(IUser user, string userAgent, IClientDeviceIdentifier clientDeviceIdentifier, bool isGameDetailsPage = false)
	{
		bool isGigyaShareBarEnabled = Settings.Default.IsGigyaShareBarEnabled;
		bool isFacebookLikeEnabled = !Settings.Default.FacebookLikeOff;
		bool isEnabledInApp = IsEnabledInApp(clientDeviceIdentifier, userAgent, isGameDetailsPage);
		bool isEnabledForAge = IsEnabledForAge(clientDeviceIdentifier, userAgent, user);
		bool isTwitterEnabled = Settings.Default.TwitterButtonOnItemPageEnabled;
		if (isGigyaShareBarEnabled && !isFacebookLikeEnabled && isEnabledForAge && isEnabledInApp)
		{
			return !isTwitterEnabled;
		}
		return false;
	}

	private static bool IsEnabledInApp(IClientDeviceIdentifier deviceIdentifier, string userAgent, bool isGameDetailsPage)
	{
		if (!deviceIdentifier.IsRobloxApp(userAgent) || deviceIdentifier.IsRobloxWindowsApp(userAgent))
		{
			return true;
		}
		if (deviceIdentifier.IsRobloxIOSApp(userAgent) && Settings.Default.IsSocialShareForIosEnabled)
		{
			return true;
		}
		if (isGameDetailsPage && deviceIdentifier.IsRobloxAndroidApp(userAgent))
		{
			return Settings.Default.IsGameDetailsShareBarForAndroidEnabled;
		}
		return false;
	}

	private static bool IsEnabledForAge(IClientDeviceIdentifier deviceIdentifier, string userAgent, IUser user)
	{
		if (user == null)
		{
			return !Settings.Default.IsGigyaJsHiddenForGuests;
		}
		if (user.AgeBracket == Roblox.Platform.Membership.AgeBracket.Age13OrOver)
		{
			return true;
		}
		if (Settings.Default.IsSocialShareForU13Enabled)
		{
			return deviceIdentifier.IsRobloxApp(userAgent);
		}
		return false;
	}
}
