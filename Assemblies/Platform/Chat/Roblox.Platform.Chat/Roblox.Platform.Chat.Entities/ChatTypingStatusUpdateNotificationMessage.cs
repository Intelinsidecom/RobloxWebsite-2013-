namespace Roblox.Platform.Chat.Entities;

internal class ChatTypingStatusUpdateNotificationMessage : ChatUpdateNotificationMessage
{
	public long UserId { get; set; }

	public bool IsTyping { get; set; }

	public ChatTypingStatusUpdateNotificationMessage(long conversationId, long userId, bool isTyping)
		: base(conversationId, ChatUpdateNotificationType.ParticipantTyping)
	{
		UserId = userId;
		IsTyping = isTyping;
	}
}
