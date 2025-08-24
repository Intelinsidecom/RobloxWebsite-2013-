namespace Roblox.RealTimeNotifications;

/// <summary>
/// Performance monitor for <see cref="T:Roblox.RealTimeNotifications.UserNotificationPublisher`1" />
/// </summary>
public interface IUserNotificationPublisherPerformanceMonitor
{
	/// <summary>
	/// Increment counters for result of user notification publish.
	/// </summary>
	/// <param name="result"></param>
	/// <param name="recipients"></param>
	void LogUserNotificationPublishResult(UserNotificationPublishResult result, long recipients);
}
