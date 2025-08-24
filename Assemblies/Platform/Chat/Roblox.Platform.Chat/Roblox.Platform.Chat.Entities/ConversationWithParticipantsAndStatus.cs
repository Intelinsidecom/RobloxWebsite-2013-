namespace Roblox.Platform.Chat.Entities;

internal class ConversationWithParticipantsAndStatus
{
	private readonly IConversationWithParticipants _Conversation;

	private readonly ConversationStatus _Status;

	public IConversationWithParticipants Conversation => _Conversation;

	public ConversationStatus Status => _Status;

	public ConversationWithParticipantsAndStatus(IConversationWithParticipants conversation, ConversationStatus conversationStatus)
	{
		_Conversation = conversation;
		_Status = conversationStatus;
	}
}
