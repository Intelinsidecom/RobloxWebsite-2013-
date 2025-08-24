using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface IStreamNotificationEventPublisher
{
	void PublishNewStreamNotification(IReceiver receiver);

	void PublishStreamNotificationRevoked(IReceiver receiver, Guid entryId);

	void PublishStreamNotificationInteracted(IReceiver receiver, Guid entryId);

	void PublishNotificationsRead(IReceiver receiver);
}
