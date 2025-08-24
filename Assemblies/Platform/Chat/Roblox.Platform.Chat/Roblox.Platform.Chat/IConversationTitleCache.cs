namespace Roblox.Platform.Chat;

internal interface IConversationTitleCache
{
	void CacheConversationTitleForUnder13(long conversationId, string under13ConversationTitle);

	void ClearConversationTitleForUnder13(long conversationId);

	string GetConversationTitleForUnder13(long conversationId);
}
