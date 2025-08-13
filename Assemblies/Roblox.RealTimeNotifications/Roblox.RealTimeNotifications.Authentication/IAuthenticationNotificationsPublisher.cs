namespace Roblox.RealTimeNotifications.Authentication;

public interface IAuthenticationNotificationsPublisher
{
	bool PublishSignOutNotification(long signedOutUserId);

	bool PublishSignOutNotification(long signedOutUser, long recipientUser);
}
