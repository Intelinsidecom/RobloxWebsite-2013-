namespace Roblox.Platform.Notifications.Metrics;

/// <summary>
/// Represents the PerformanceCounters that are segmented by NotificationSourceType
/// </summary>
internal enum PerformanceCountersBySource
{
	/// <summary>
	/// Counts the number of attempts to deliver new notifications
	/// </summary>
	DeliverySuccessBySource,
	/// <summary>
	/// Counts the successful deliveries of new notifications
	/// </summary>
	DeliveryAttemptsBySource,
	/// <summary>
	/// Counts failed deliveries of new notifications
	/// </summary>
	DeliveryErrorsBySource,
	/// <summary>
	/// Counts average number of channels per receiver for a given notification
	/// </summary>
	ChannelsPerReceiverBySource,
	/// <summary>
	/// Counts average number of receivers per message for a given notification
	/// </summary>
	ReceiversPerMessageBySource,
	/// <summary>
	/// Counts the number of attempts to deliver notification updates
	/// </summary>
	UpdateAttemptsBySource,
	/// <summary>
	/// Counts the successful deliveries of notification updates
	/// </summary>
	UpdateSuccessBySource,
	/// <summary>
	/// Counts failed deliveries of notification updates
	/// </summary>
	UpdateErrorsBySource,
	/// <summary>
	/// Records average time to distribute a new notification
	/// </summary>
	DistributionTimeBySource,
	/// <summary>
	/// Records average time to distribute an update notification
	/// </summary>
	UpdateTimeBySource
}
