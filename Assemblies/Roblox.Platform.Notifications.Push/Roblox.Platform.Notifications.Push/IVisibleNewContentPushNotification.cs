namespace Roblox.Platform.Notifications.Push;

public interface IVisibleNewContentPushNotification : ISilentNewContentPushNotification
{
	string Title { get; }

	string Body { get; }
}
