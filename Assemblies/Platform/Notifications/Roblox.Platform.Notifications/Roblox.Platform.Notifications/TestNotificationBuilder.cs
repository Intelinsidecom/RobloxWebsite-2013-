using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

internal static class TestNotificationBuilder
{
	public static TestNotificationDetail BuildDetail()
	{
		return new TestNotificationDetail
		{
			Message = "New test message!"
		};
	}

	public static string BuildCategory()
	{
		return NotificationSourceType.Test.ToString();
	}
}
