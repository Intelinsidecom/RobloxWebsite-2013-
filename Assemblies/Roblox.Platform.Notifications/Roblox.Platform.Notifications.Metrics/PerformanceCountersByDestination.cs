namespace Roblox.Platform.Notifications.Metrics;

/// <summary>
/// Lists the performance counters that are segmented by ReceiverDestinationType
/// </summary>
internal enum PerformanceCountersByDestination
{
	/// <summary>
	/// Counts the number of attempts to deliver new notifications
	/// </summary>
	DeliveryAttemptsByDestination,
	/// <summary>
	/// Counts the successful deliveries of new notifications
	/// </summary>
	DeliverySuccessByDestination,
	/// <summary>
	/// Counts failed deliveries of new notifications
	/// </summary>
	DeliveryErrorsByDestination,
	/// <summary>
	/// Counts the number of attempts to deliver notification updates
	/// </summary>
	UpdateAttemptsByDestination,
	/// <summary>
	/// Counts the successful deliveries of notification updates
	/// </summary>
	UpdateSuccessByDestination,
	/// <summary>
	/// Counts failed deliveries of notification updates
	/// </summary>
	UpdateErrorsByDestination
}
