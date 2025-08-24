namespace Roblox.Platform.Chat.Entities;

internal class ConversationIdWithScore
{
	public long ConversationId { get; }

	public long Score { get; }

	public ConversationIdWithScore(long conversationId, long score)
	{
		ConversationId = conversationId;
		Score = score;
	}
}
