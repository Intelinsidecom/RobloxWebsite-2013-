namespace Roblox.Platform.Notifications.Push;

public interface IUserPushDestinationCore
{
	long UserPushNotificationDestinationId { get; set; }

	PushApplicationType Application { get; set; }

	PushPlatformType Platform { get; set; }
}
