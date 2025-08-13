namespace Roblox.Platform.Notifications.Push;

internal class PublishNotificationResult
{
	public PublishNotificationStatus Status { get; }

	public string Receipt { get; set; }

	public PublishNotificationResult(PublishNotificationStatus status)
	{
		Status = status;
	}
}
