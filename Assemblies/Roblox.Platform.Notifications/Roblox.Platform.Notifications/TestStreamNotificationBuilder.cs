using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.Notifications;

public class TestStreamNotificationBuilder : StreamNotificationBuilderBase<TestNotificationDetail>
{
	public override NotificationSourceType NotificationSourceType => NotificationSourceType.Test;

	protected override TestNotificationDetail BuildDetail(IStoredStreamNotification storedNotification)
	{
		return TestNotificationBuilder.BuildDetail();
	}

	protected override string BuildCategory(TestNotificationDetail detail)
	{
		return TestNotificationBuilder.BuildCategory();
	}
}
