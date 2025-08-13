using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class ParticipantUtilities : IParticipantUtilities
{
	private readonly IUserFactory _UserFactory;

	public ParticipantUtilities(IUserFactory userFactory)
	{
		_UserFactory = userFactory;
	}

	public IParticipant ToParticipant(IUser user)
	{
		return user.ToParticipant();
	}

	public IUser ToUser(IParticipant participant)
	{
		return participant.ToUser(_UserFactory);
	}

	public bool IsUser(IParticipant participant)
	{
		return participant.IsUser();
	}

	public bool IsUserUnder13(IParticipant participant)
	{
		if (participant.IsUser())
		{
			return participant.ToUser(_UserFactory).IsUnder13();
		}
		return false;
	}

	public IReadOnlyDictionary<long, IUser> BatchGetUsersForConversation(IConversationWithParticipants conversation)
	{
		IEnumerable<IParticipant> participants = conversation.Participants.Append(conversation.Initiator);
		return BatchGetUsers(participants);
	}

	public IReadOnlyDictionary<long, IUser> BatchGetUsersForConversations(IEnumerable<IConversationWithParticipants> conversations)
	{
		IEnumerable<IParticipant> participantsFromAllConversations = conversations.SelectMany((IConversationWithParticipants c) => c.Participants.Append(c.Initiator));
		return BatchGetUsers(participantsFromAllConversations);
	}

	private IReadOnlyDictionary<long, IUser> BatchGetUsers(IEnumerable<IParticipant> participants)
	{
		long[] userIds = (from p in participants.Where(IsUser)
			select p.TargetId).ToArray();
		return _UserFactory.MultiGetUsers(userIds);
	}
}
