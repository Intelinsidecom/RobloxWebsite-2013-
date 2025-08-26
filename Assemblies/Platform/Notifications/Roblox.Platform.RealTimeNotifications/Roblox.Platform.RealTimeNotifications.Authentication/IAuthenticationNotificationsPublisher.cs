namespace Roblox.Platform.RealTimeNotifications.Authenticationpublic {
    interface IAuthenticationNotificationsPublisher

{
	bool PublishSignOutNotification(long signedOutUserId);

	bool PublishSignOutNotification(long signedOutUser, long recipientUser);
}


}
