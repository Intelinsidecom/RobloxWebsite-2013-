using System;

namespace Roblox.Platform.Notifications.Core.Events;

public class CategoryUpdate
{
	public IReceiver Receiver { get; set; }

	public NotificationSourceType Type { get; set; }

	public string Category { get; set; }

	public ReceiverNotificationStatus Status { get; set; }

	public DateTime EventDate { get; set; }
}
