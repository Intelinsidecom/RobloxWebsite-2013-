using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Chat.Entities;

internal class ChatUpdateNotificationMessage : UserNotificationMessageBase
{
	public long ConversationId { get; set; }

	public long? ActorTargetId { get; set; }

	public string ActorType { get; set; }

	public override string Type { get; set; }

	public ChatUpdateNotificationMessage()
	{
	}

	public ChatUpdateNotificationMessage(long conversationId, ChatUpdateNotificationType type)
	{
		ConversationId = conversationId;
		Type = type.ToString();
	}

	public ChatUpdateNotificationMessage(long conversationId, long actorTargetId, string actorType, ChatUpdateNotificationType type)
		: this(conversationId, type)
	{
		ActorTargetId = actorTargetId;
		ActorType = actorType;
	}
}
