using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Social.Events;

internal class UserNotificationMessage : UserNotificationMessageBase
{
	public override string Type { get; set; }

	public long MessageId { get; }

	public UserNotificationMessage(MessageEventType type, long messageId)
	{
		Type = type.ToString();
		MessageId = messageId;
	}
}
