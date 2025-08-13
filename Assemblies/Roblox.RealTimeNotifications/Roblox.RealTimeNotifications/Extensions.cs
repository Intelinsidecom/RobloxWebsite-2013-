namespace Roblox.RealTimeNotifications;

public static class Extensions
{
	public static bool IsSuccess(this UserNotificationPublishResult userNotificationPublishResult)
	{
		return userNotificationPublishResult == UserNotificationPublishResult.UserReceivedNotification;
	}

	public static bool IsErroredOut(this UserNotificationPublishResult userNotificationPublishResult)
	{
		return UserNotificationPublishResult.ErrorPublishingNotification == userNotificationPublishResult;
	}
}
