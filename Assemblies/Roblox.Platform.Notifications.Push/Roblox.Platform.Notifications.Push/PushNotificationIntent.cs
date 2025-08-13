namespace Roblox.Platform.Notifications.Push;

public enum PushNotificationIntent : byte
{
	/// <summary>
	/// New content which should be displayed either as a new notification, or, depending on client logic, 
	/// combined into an existing stack of notifications
	/// </summary>
	NewContent = 1,
	/// <summary>
	/// An update to a previously delivered notification, this could be a change in content or a request to remove it
	/// </summary>
	UpdateSingleNotification,
	/// <summary>
	/// An update that should be applied to any notifications present on the client belonging to the specified category
	/// </summary>
	UpdateCategoryOfNotifications
}
