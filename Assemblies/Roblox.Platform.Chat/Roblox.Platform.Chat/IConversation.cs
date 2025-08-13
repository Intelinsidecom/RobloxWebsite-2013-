using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public interface IConversation
{
	long Id { get; set; }

	IUser InitiatorUser { get; set; }

	IParticipant Initiator { get; set; }

	IReadOnlyCollection<IUser> ParticipantUsers { get; set; }

	bool? HasUnreadMessages { get; set; }

	ConversationType ConversationType { get; set; }

	bool IsGroupChat { get; set; }

	IConversationTitle ConversationTitle { get; set; }

	UtcInstant LastUpdated { get; set; }

	long? UniverseId { get; set; }
}
