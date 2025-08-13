namespace Roblox.Platform.Chat;

internal class ConversationRenameResponse : IConversationRenameResponse
{
	public IConversation Conversation { get; set; }

	public ConversationRenameResult Result { get; set; }
}
