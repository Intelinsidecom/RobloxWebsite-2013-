using Roblox.EventLog;

namespace Roblox.RealTimeNotifications.Authentication;

public class AuthenticationNotificationsPublisher : IAuthenticationNotificationsPublisher
{
	private readonly UserNotificationPublisher<AuthenticationNotificationMessage> _UserNotificationPublisher;

	public AuthenticationNotificationsPublisher(ILogger logger)
	{
		_UserNotificationPublisher = new UserNotificationPublisher<AuthenticationNotificationMessage>(logger, "AuthenticationNotifications");
	}

	public bool PublishSignOutNotification(long signedOutUserId)
	{
		return PublishSignOutNotification(signedOutUserId, signedOutUserId);
	}

	public bool PublishSignOutNotification(long signedOutUserId, long recipientUserId)
	{
		AuthenticationNotificationMessage message = new AuthenticationNotificationMessage(signedOutUserId, AuthenticationEventType.SignOut.ToString());
		return _UserNotificationPublisher.Publish(recipientUserId, message).IsSuccess();
	}
}
