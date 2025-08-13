namespace Roblox.Platform.Chat;

public enum ChatUpdateNotificationType
{
	NewMessage,
	NewMessageBySelf,
	NewConversation,
	AddedToConversation,
	ParticipantAdded,
	ParticipantLeft,
	RemovedFromConversation,
	ConversationRemoved,
	ParticipantTyping,
	ConversationTitleChanged,
	ConversationUniverseChanged,
	MessageMarkedAsRead
}
