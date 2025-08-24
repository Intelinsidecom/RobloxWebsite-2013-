namespace Roblox.Platform.Notifications.Push;

public class VisibleNewContentPushNotification : SilentNewContentPushNotification, IVisibleNewContentPushNotification, ISilentNewContentPushNotification
{
	public string Title { get; set; }

	public string Body { get; set; }
}
