using Newtonsoft.Json;

namespace Roblox.Platform.Notifications.Core.Events;

internal class NewNotification
{
	public NotificationSourceType Type { get; set; }

	public string Message { get; set; }

	public NewNotification(INotification message)
	{
		Type = message.SourceType;
		Message = JsonConvert.SerializeObject(message);
	}
}
