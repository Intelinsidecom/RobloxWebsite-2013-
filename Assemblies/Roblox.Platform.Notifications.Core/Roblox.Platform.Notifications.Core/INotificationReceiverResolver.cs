using System.Collections.Generic;

namespace Roblox.Platform.Notifications.Core;

public interface INotificationReceiverResolver
{
	NotificationSourceType NotificationSourceType { get; }

	ICollection<IReceiver> GetReceiverForMessages(INotification message);
}
