using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class Conversation : IConversation
{
	public long Id { get; set; }

	public IUser InitiatorUser { get; set; }

	public IParticipant Initiator { get; set; }

	public IReadOnlyCollection<IUser> ParticipantUsers { get; set; }

	public bool? HasUnreadMessages { get; set; }

	public bool IsGroupChat { get; set; }

	public ConversationType ConversationType { get; set; }

	public string TitleForViewer { get; set; }

	public IConversationTitle ConversationTitle { get; set; }

	public UtcInstant LastUpdated { get; set; }

	public long? UniverseId { get; set; }
}
