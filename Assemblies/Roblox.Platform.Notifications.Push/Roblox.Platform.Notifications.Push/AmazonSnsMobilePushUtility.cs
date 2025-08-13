using System;

namespace Roblox.Platform.Notifications.Push;

public static class AmazonSnsMobilePushUtility
{
	public static string BuildNotificationPublishReceipt(Guid messageId)
	{
		return $"AmazonSNSMobilePush:{messageId}";
	}
}
