namespace Roblox.Platform.Notifications.Core.Events;

internal class NotificationEvent
{
	public NotificationEventType Type { get; set; }

	public string Message { get; set; }

	public NotificationEvent(NotificationEventType type, string message)
	{
		Type = type;
		Message = message;
	}
}
