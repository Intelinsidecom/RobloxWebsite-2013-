using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core.Properties;

namespace Roblox.Platform.Notifications.Core;

public static class Extensions
{
	public static IReceiver ToReceiver(this IUser user)
	{
		return Accessors.ReceiverAccessor.GetByReceiverTypeAndTarget(ReceiverType.User, user.Id);
	}

	public static IReadOnlyCollection<string> GetBlacklistedNotificationSourceTypesForAndroid(this IUser user)
	{
		return user.GetBlacklistedNotificationSourceTypes(MobilePlatforms.Android);
	}

	public static IReadOnlyCollection<string> GetBlacklistedNotificationSourceTypesForIOS(this IUser user)
	{
		return user.GetBlacklistedNotificationSourceTypes(MobilePlatforms.IOS);
	}

	private static IReadOnlyCollection<string> GetBlacklistedNotificationSourceTypes(this IUser user, MobilePlatforms platform)
	{
		if (user == null || user.IsSoothSayer())
		{
			return new List<string>();
		}
		try
		{
			string blacklistString = "";
			switch (platform)
			{
			case MobilePlatforms.Android:
				blacklistString = (user.IsBetaTester() ? Settings.Default.NotificationSettingsSourceTypeBlacklistedForAndroidBetaTesters : Settings.Default.NotificationSettingsSourceTypeBlacklistedForAndroidRegularUsers);
				break;
			case MobilePlatforms.IOS:
				blacklistString = (user.IsBetaTester() ? Settings.Default.NotificationSettingsSourceTypeBlacklistedForIOSBetaTesters : Settings.Default.NotificationSettingsSourceTypeBlacklistedForIOSRegularUsers);
				break;
			}
			return blacklistString.Split(',').ToList();
		}
		catch (Exception)
		{
			return new List<string>();
		}
	}
}
