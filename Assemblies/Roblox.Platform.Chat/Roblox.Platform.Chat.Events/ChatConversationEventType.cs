namespace Roblox.Platform.Chat.Events;

public enum ChatConversationEventType
{
	/// <summary>
	/// Used to indicate a new multi-user conversation has been created 
	/// </summary>
	NewConversationCreated = 1,
	/// <summary>
	/// Used to Indicate new user(s) have been added to a multi-user conversation
	/// </summary>
	UsersAddedToConversation,
	/// <summary>
	/// Used to Indicate that user(s) have been removed from a multi-user conversation
	/// </summary>
	UsersRemovedFromConversation,
	/// <summary>
	/// Used to indicate that conversation title has been changed
	/// </summary>
	ConversationTitleChanged
}
