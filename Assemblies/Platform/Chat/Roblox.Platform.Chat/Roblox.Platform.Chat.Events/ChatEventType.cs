namespace Roblox.Platform.Chat.Events;

public enum ChatEventType
{
	/// <summary>
	/// Used to indicate that the conversation was abandoned by its last participant and needs to be deleted.
	/// </summary>
	ConversationReadyToBeDeleted = 1,
	/// <summary>
	/// Used to indicate that the conversation has some messages without corresponding data.
	/// </summary>
	ConversationWithMissingMessages,
	/// <summary>
	/// Used to indicate that the conversation is listed as the user's even though the user is not a participant.
	/// </summary>
	ConversationIncorrectlyListedForUser,
	/// <summary>
	///  Used to indicate that the consumer can start persisting the conversation
	///  </summary>
	ConversationReadyToBePersisted,
	/// <summary>
	/// When a conversation is marked as read for a particular user
	/// </summary>
	ConversationMarkedAsRead,
	/// <summary>
	/// Triggered when a cache miss happens for a participant's conversations
	/// </summary>
	ParticipantConversationCacheRestore
}
