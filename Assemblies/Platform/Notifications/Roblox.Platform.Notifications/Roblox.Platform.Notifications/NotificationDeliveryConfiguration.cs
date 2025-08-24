using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal class NotificationDeliveryConfiguration : INotificationDeliveryConfiguration
{
	public IReceiver Receiver { get; internal set; }

	public NotificationSourceType SourceType { get; internal set; }

	public ICollection<ReceiverDestinationType> ReceiverDestinationTypes { get; internal set; }

	public ICollection<long> DisallowedPushNotificationDestinationIds { get; internal set; }

	public NotificationDeliveryConfiguration()
	{
		DisallowedPushNotificationDestinationIds = new List<long>();
		ReceiverDestinationTypes = new List<ReceiverDestinationType>();
	}
}
