using Roblox.Platform.Membership;

namespace Roblox.Platform.Notifications.Push;

public interface IUserPushDestination : IUserPushDestinationCore
{
	IUser User { get; set; }

	string Name { get; set; }

	string NotificationToken { get; set; }

	bool SupportsUpdateNotifications { get; set; }
}
