using Roblox.Platform.Membership;

namespace Roblox.Platform.Notifications.Push;

internal class UserPushDestination : IUserPushDestination, IUserPushDestinationCore
{
	public IUser User { get; set; }

	public long UserPushNotificationDestinationId { get; set; }

	public string Name { get; set; }

	public string NotificationToken { get; set; }

	public PushApplicationType Application { get; set; }

	public PushPlatformType Platform { get; set; }

	public bool SupportsUpdateNotifications { get; set; }
}
