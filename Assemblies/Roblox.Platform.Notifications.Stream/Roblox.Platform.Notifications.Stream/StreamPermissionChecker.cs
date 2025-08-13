using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Stream.Properties;

namespace Roblox.Platform.Notifications.Stream;

public class StreamPermissionChecker : IStreamPermissionChecker
{
	public bool IsNotificationStreamEnabled(IUser user)
	{
		return user.IsNotificationStreamEnabled();
	}

	public bool IsNotificationStreamEnabledOnAndroid(IUser user)
	{
		return user.IsNotificationStreamEnabledOnAndroid();
	}

	public bool IsNotificationStreamEnabledOnIOS(IUser user)
	{
		return user.IsNotificationStreamEnabledOnIOS();
	}

	public bool IsNotificationStreamPopulationEnabled(IUser user)
	{
		if (user != null && user.Id % 100 < Settings.Default.NotificationStreamPopulationRolloutPercentage)
		{
			return true;
		}
		return user.IsNotificationStreamEnabled();
	}
}
