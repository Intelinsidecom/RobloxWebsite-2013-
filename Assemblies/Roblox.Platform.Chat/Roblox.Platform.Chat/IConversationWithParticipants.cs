using Roblox.Time;

namespace Roblox.Platform.Chat;

public interface IConversationWithParticipants
{
	long Id { get; set; }

	string Title { get; set; }

	IParticipant Initiator { get; set; }

	IParticipant[] Participants { get; set; }

	ConversationType ConversationType { get; set; }

	UtcInstant LastUpdated { get; set; }
}
