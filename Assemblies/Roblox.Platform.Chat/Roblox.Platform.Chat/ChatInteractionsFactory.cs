using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class ChatInteractionsFactory : IChatInteractionsFactory
{
	private readonly IChatInteractionsAccessor _ChatInteractionsAccessor;

	private readonly IParticipantUtilities _ParticipantUtilities;

	internal ChatInteractionsFactory(IChatInteractionsAccessor chatInteractionsAccessor, IParticipantUtilities participantUtilities)
	{
		_ChatInteractionsAccessor = chatInteractionsAccessor ?? throw new ArgumentNullException("chatInteractionsAccessor");
		_ParticipantUtilities = participantUtilities ?? throw new ArgumentNullException("participantUtilities");
	}

	public IReadOnlyCollection<long> GetUniqueChatParticipantIdsForUser(IUser user, int startIndex, int maxRows)
	{
		return (from participant in _ChatInteractionsAccessor.GetUniqueChatParticipants(_ParticipantUtilities.ToParticipant(user), startIndex, maxRows)
			where participant != null
			select participant.TargetId).ToList();
	}

	public long GetUniqueChatParticipantsCountForUser(IUser user)
	{
		return _ChatInteractionsAccessor.GetUniqueChatParticipantsCount(_ParticipantUtilities.ToParticipant(user));
	}
}
