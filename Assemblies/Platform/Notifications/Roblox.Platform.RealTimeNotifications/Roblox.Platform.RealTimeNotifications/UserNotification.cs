namespace Roblox.RealTimeNotifications;

public class UserNotification
{
	public string NotificationNamespace { get; set; }

	public string NotificationDetail { get; set; }

	public long SequenceNumber { get; set; }

	public UserNotification(string notificationNamespace, string notificationDetail, long sequenceNumber)
	{
		NotificationNamespace = notificationNamespace;
		NotificationDetail = notificationDetail;
		SequenceNumber = sequenceNumber;
	}
}
