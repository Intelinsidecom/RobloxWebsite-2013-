namespace Roblox.RealTimeNotifications.Authentication;

public class AuthenticationNotificationMessage : UserNotificationMessageBase
{
	public long UserId { get; }

	public override string Type { get; set; }

	public AuthenticationNotificationMessage(long userId, string type)
	{
		UserId = userId;
		Type = type;
	}
}
