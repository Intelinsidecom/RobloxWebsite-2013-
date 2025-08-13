using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public abstract class StreamNotificationBuilderBase<TDetail> : IStreamNotificationBuilder, INotificationBuilder
{
	public abstract NotificationSourceType NotificationSourceType { get; }

	public IStreamNotification BuildNotification(IStoredStreamNotification storedNotification)
	{
		TDetail detail = BuildDetail(storedNotification);
		return new StreamNotification
		{
			SourceType = NotificationSourceType,
			EventTargetId = storedNotification.EventTargetId,
			EventDate = storedNotification.EventDate,
			Category = BuildCategory(detail),
			Detail = detail
		};
	}

	protected abstract string BuildCategory(TDetail detail);

	protected abstract TDetail BuildDetail(IStoredStreamNotification storedNotification);
}
