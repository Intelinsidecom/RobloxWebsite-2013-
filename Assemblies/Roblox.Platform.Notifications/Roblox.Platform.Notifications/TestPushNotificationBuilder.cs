using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

public class TestPushNotificationBuilder : PushNotificationContentBuilderBase<TestNotification, TestNotificationDetail>
{
	public override NotificationSourceType NotificationSourceType => NotificationSourceType.Test;

	protected override string BuildCategory(TestNotificationDetail detail)
	{
		return TestNotificationBuilder.BuildCategory();
	}

	protected override TestNotificationDetail BuildDetail(TestNotification notification)
	{
		return TestNotificationBuilder.BuildDetail();
	}

	protected override string BuildBody(TestNotificationDetail detail)
	{
		return TestNotificationBuilder.BuildDetail().Message;
	}

	protected override string BuildLocalizedBody(IUser user, TestNotificationDetail detail)
	{
		return TestNotificationBuilder.BuildDetail().Message;
	}
}
