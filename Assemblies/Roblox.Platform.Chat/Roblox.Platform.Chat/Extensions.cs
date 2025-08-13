using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal static class Extensions
{
	internal static IReadOnlyCollection<IConversation> Translate(this IReadOnlyCollection<ConversationWithParticipantsAndStatus> conversations, IConversationTitleBuilder conversationTitleBuilder, IUser currentUser, IParticipantUtilities participantUtilities, Dictionary<long, long?> conversationUniverseIds)
	{
		if (conversations == null)
		{
			return null;
		}
		List<IConversation> translatedConversations = new List<IConversation>(conversations.Count);
		IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabled ? participantUtilities.BatchGetUsersForConversations(conversations.Select((ConversationWithParticipantsAndStatus c) => c.Conversation)) : null);
		foreach (ConversationWithParticipantsAndStatus sortedConversation in conversations)
		{
			conversationUniverseIds.TryGetValue(sortedConversation.Conversation.Id, out var universeId);
			translatedConversations.Add(sortedConversation.Conversation.Translate(conversationTitleBuilder, currentUser, participantUtilities, batchUsersResult, universeId, sortedConversation.Status == ConversationStatus.Unread));
		}
		return translatedConversations;
	}

	internal static IConversation Translate(this IConversationWithParticipants conversation, IConversationTitleBuilder conversationTitleBuilder, IUser currentUser, IParticipantUtilities participantUtilities, IReadOnlyDictionary<long, IUser> batchUsersResult, long? conversationUniverseId, bool? hasUnreadMessages = null)
	{
		ICollection<IUser> participantUsers;
		IUser initiatorUser;
		if (batchUsersResult != null)
		{
			IEnumerable<IParticipant> source = conversation.Participants.Where(participantUtilities.IsUser);
			IParticipant initiator = conversation.Initiator;
			participantUsers = source.Select((IParticipant p) => batchUsersResult[p.TargetId]).ToList();
			initiatorUser = batchUsersResult[initiator.TargetId];
		}
		else
		{
			participantUsers = conversation.Participants.Where(participantUtilities.IsUser).Select(participantUtilities.ToUser).ToList();
			initiatorUser = participantUtilities.ToUser(conversation.Initiator);
		}
		return conversation.Translate(conversationTitleBuilder, currentUser, initiatorUser, participantUsers, conversationUniverseId, hasUnreadMessages);
	}

	internal static IConversation Translate(this IConversationWithParticipants conversation, IConversationTitleBuilder conversationTitleBuilder, IUser currentUser, IUser initiator, ICollection<IUser> participants, long? conversationUniverseId, bool? hasUnreadMessages = null)
	{
		return new Conversation
		{
			Id = conversation.Id,
			ConversationTitle = conversationTitleBuilder.BuildConversationTitleForViewer(conversation, currentUser),
			InitiatorUser = initiator,
			Initiator = conversation.Initiator,
			ParticipantUsers = participants.ToList(),
			HasUnreadMessages = hasUnreadMessages,
			IsGroupChat = (conversation.ConversationType == ConversationType.MultiUserConversation),
			ConversationType = conversation.ConversationType,
			LastUpdated = conversation.LastUpdated,
			UniverseId = conversationUniverseId
		};
	}

	internal static IParticipant ToParticipant(this IUser user)
	{
		return new Participant(ParticipantType.User.GetParticipantTypeID(), user.Id);
	}

	internal static IUser ToUser(this IParticipant participant, IUserFactory userFactory)
	{
		if (!participant.IsUser())
		{
			return null;
		}
		long userId = participant.TargetId;
		return userFactory.GetUser(userId);
	}

	internal static bool IsUser(this IParticipant participant)
	{
		return participant.TypeId == Roblox.Platform.Chat.Entities.ParticipantType.GetOrCreate(ParticipantType.User.ToString()).ID;
	}

	internal static int GetParticipantTypeID(this ParticipantType participantType)
	{
		return Roblox.Platform.Chat.Entities.ParticipantType.GetOrCreate(participantType.ToString()).ID;
	}

	internal static bool IsUserSameAsMessageSource(this IUser viewingUser, IChatMessageSourceEntity chatMessageSourceEntity)
	{
		if (chatMessageSourceEntity == null || viewingUser == null || !(chatMessageSourceEntity is IChatMessageUserSourceEntity chatMessageUserSourceEntity))
		{
			return false;
		}
		return viewingUser.Id == chatMessageUserSourceEntity.SourceUserId;
	}
}
