using Roblox.Platform.Membership;

namespace Roblox.Platform.Notifications.Stream;

public interface IStreamPermissionChecker
{
	bool IsNotificationStreamEnabled(IUser user);

	bool IsNotificationStreamEnabledOnAndroid(IUser user);

	bool IsNotificationStreamEnabledOnIOS(IUser user);

	bool IsNotificationStreamPopulationEnabled(IUser user);
}
