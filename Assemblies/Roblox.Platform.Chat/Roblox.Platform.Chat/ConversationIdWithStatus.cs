using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal class ConversationIdWithStatus
{
	public long ConversationId { get; }

	public ConversationStatus Status { get; }

	public ConversationIdWithStatus(long conversationId, ConversationStatus conversationStatus)
	{
		ConversationId = conversationId;
		Status = conversationStatus;
	}
}
