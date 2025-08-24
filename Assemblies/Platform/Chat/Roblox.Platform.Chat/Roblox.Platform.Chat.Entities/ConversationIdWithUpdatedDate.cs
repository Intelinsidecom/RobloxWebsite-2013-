using Roblox.Time;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationIdWithUpdatedDate
{
	public long ConversationId { get; }

	public UtcInstant Updated { get; }

	public ConversationIdWithUpdatedDate(long conversationId, UtcInstant updated)
	{
		ConversationId = conversationId;
		Updated = updated;
	}
}
