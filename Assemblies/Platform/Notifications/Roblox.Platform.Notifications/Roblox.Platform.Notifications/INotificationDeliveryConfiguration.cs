using System.Collections.Generic;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal interface INotificationDeliveryConfiguration
{
	IReceiver Receiver { get; }

	NotificationSourceType SourceType { get; }

	ICollection<ReceiverDestinationType> ReceiverDestinationTypes { get; }

	ICollection<long> DisallowedPushNotificationDestinationIds { get; }
}
