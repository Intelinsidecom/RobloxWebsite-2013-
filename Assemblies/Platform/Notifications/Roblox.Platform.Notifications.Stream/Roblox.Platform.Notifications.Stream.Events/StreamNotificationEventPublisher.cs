using System;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Notifications.Stream.Events;

public class StreamNotificationEventPublisher : UserNotificationPublisher<UserNotificationMessageBase>, IStreamNotificationEventPublisher
{
	public StreamNotificationEventPublisher(ILogger logger)
		: base(logger, "NotificationStream")
	{
	}

	public void PublishNewStreamNotification(IReceiver receiver)
	{
		if (receiver.ReceiverType == ReceiverType.User)
		{
			Publish((int)receiver.ReceiverTargetId, new NewNotificationMessage());
		}
	}

	public void PublishStreamNotificationRevoked(IReceiver receiver, Guid entryId)
	{
		if (receiver.ReceiverType == ReceiverType.User)
		{
			Publish((int)receiver.ReceiverTargetId, new NotificationRevokedMessage(entryId));
		}
	}

	public void PublishNotificationsRead(IReceiver receiver)
	{
		if (receiver.ReceiverType == ReceiverType.User)
		{
			Publish((int)receiver.ReceiverTargetId, new NotificationsReadMessage());
		}
	}

	public void PublishStreamNotificationInteracted(IReceiver receiver, Guid entryId)
	{
		if (receiver.ReceiverType == ReceiverType.User)
		{
			Publish((int)receiver.ReceiverTargetId, new NotificationMarkedInteractedMessage(entryId));
		}
	}
}
