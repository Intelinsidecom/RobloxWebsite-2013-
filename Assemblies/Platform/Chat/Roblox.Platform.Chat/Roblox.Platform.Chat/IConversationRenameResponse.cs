namespace Roblox.Platform.Chat;

public interface IConversationRenameResponse
{
	IConversation Conversation { get; set; }

	ConversationRenameResult Result { get; set; }
}
