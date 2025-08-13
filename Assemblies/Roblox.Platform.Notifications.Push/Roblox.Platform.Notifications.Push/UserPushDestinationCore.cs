namespace Roblox.Platform.Notifications.Push;

internal class UserPushDestinationCore : IUserPushDestinationCore
{
	public long UserPushNotificationDestinationId { get; set; }

	public PushApplicationType Application { get; set; }

	public PushPlatformType Platform { get; set; }
}
