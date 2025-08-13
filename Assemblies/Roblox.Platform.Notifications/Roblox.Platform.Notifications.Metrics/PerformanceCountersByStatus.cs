namespace Roblox.Platform.Notifications.Metrics;

/// <summary>
/// Lists PerformanceCounters that are segmented by ReceiverNotificationStatus
/// </summary>
internal enum PerformanceCountersByStatus
{
	/// <summary>
	/// Counts the number of times an update message was received but could not be processed.
	/// </summary>
	UpdateLookupErrorsByStatus
}
