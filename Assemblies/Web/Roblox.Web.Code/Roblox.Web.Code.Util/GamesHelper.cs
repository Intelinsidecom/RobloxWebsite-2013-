using System;
using Roblox.Platform.Devices;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.Util;

public class GamesHelper
{
	private static Version _IpadMinimumVersionForGamePlay => new Version(Settings.Default.IpadMinimumVersionForGamePlay, 0);

	private static Version _IpodMinimumVersionForGamePlay => new Version(Settings.Default.IpodMinimumVersionForGamePlay, 0);

	private static Version _IphoneMinimumVersionForGamePlay => new Version(Settings.Default.IphoneMinimumVersionForGamePlay, 0);

	public static bool CanDevicePlayGames(string userAgent, IClientDeviceIdentifier clientDeviceIdentifier)
	{
		if (clientDeviceIdentifier.IsRobloxIOSApp(userAgent) && Settings.Default.IOSMinimumVersionForGamePlayCheckEnabled)
		{
			clientDeviceIdentifier.GetDeviceVersionFromRobloxIOSApp(userAgent, out var deviceType, out var deviceVersion);
			if ((deviceType == IOSDeviceType.iPad && deviceVersion < _IpadMinimumVersionForGamePlay) || (deviceType == IOSDeviceType.iPod && deviceVersion < _IpodMinimumVersionForGamePlay) || (deviceType == IOSDeviceType.iPhone && deviceVersion < _IphoneMinimumVersionForGamePlay))
			{
				return false;
			}
		}
		return true;
	}
}
