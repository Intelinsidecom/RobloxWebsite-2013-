using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Push;

public class LegacyStoredPushNotificationFormat
{
	public const string PushExpiryMessageType = "PushExpiryMessage";

	public const string PushCategoryRevokeMessageType = "PushCategoryExpiryMessage";

	public DateTime Created { get; set; }

	public string Type { get; set; }

	public string Detail { get; set; }

	public static string GetLegacyNotificationType(PushNotificationIntent intent, NotificationSourceType? notificationSourceType)
	{
		switch (intent)
		{
		case PushNotificationIntent.UpdateSingleNotification:
			return "PushExpiryMessage";
		case PushNotificationIntent.UpdateCategoryOfNotifications:
			return "PushCategoryExpiryMessage";
		default:
			if (notificationSourceType.HasValue)
			{
				return notificationSourceType.ToString();
			}
			return "Unknown";
		}
	}

	public static PushNotificationIntent GetIntentFromLegacyNotificationType(string notificationType)
	{
		if (!(notificationType == "PushExpiryMessage"))
		{
			if (notificationType == "PushCategoryExpiryMessage")
			{
				return PushNotificationIntent.UpdateCategoryOfNotifications;
			}
			return PushNotificationIntent.NewContent;
		}
		return PushNotificationIntent.UpdateSingleNotification;
	}
}
