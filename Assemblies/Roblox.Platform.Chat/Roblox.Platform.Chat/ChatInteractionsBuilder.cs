using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class ChatInteractionsBuilder : IChatInteractionsBuilder
{
	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IChatInteractionsAccessor _ChatInteractionsAccessor;

	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly ILogger _Logger;

	internal ChatInteractionsBuilder(IConversationDataAccessor conversationDataAccessor, IChatInteractionsAccessor chatInteractionsAccessor, IParticipantUtilities participantUtilities, IFriendshipFactory friendshipFactory, ILogger logger)
	{
		_ConversationDataAccessor = conversationDataAccessor;
		_ChatInteractionsAccessor = chatInteractionsAccessor;
		_ParticipantUtilities = participantUtilities;
		_FriendshipFactory = friendshipFactory;
		_Logger = logger;
	}

	public void UpdateCacheForNewConversationCreated(long conversationId)
	{
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (ConversationType.MultiUserConversation != conversationWithParticipants?.ConversationType)
		{
			return;
		}
		IParticipant[] participants = conversationWithParticipants.Participants;
		UtcInstant lastUpdated = conversationWithParticipants.LastUpdated;
		Dictionary<IParticipant, List<ChatInteraction>> usersWithNonFriendChatInteractions = new Dictionary<IParticipant, List<ChatInteraction>>();
		for (int i = 0; i < participants.Length - 1; i++)
		{
			IReadOnlyCollection<IParticipant> friends = _ChatInteractionsAccessor.GetFriendsForUserParticipant(participants[i]);
			if (friends == null)
			{
				continue;
			}
			for (int j = i + 1; j < participants.Length; j++)
			{
				if (participants[j] != null && IsParticipantUser(participants[j]) && !friends.Contains(participants[j]))
				{
					UpdateChatInteractionsDictionary(usersWithNonFriendChatInteractions, participants[i], participants[j], lastUpdated);
					UpdateChatInteractionsDictionary(usersWithNonFriendChatInteractions, participants[j], participants[i], lastUpdated);
				}
			}
		}
		_ChatInteractionsAccessor.UpdateChatInteractionsCacheForUsers(usersWithNonFriendChatInteractions.ToArray());
	}

	public void UpdateCacheForNewUsersAddedToConversation(long conversationId, IReadOnlyCollection<IUser> usersAddedToConversation)
	{
		List<IParticipant> newParticipants = (from user in usersAddedToConversation?.Where((IUser user) => user != null)
			select user.ToParticipant()).ToList();
		if (newParticipants == null || newParticipants.Count < 1)
		{
			return;
		}
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants == null)
		{
			return;
		}
		foreach (IParticipant newParticipant in newParticipants)
		{
			UpdateChatInteractionsForNewParticipantInConversation(newParticipant, conversationWithParticipants, newParticipants);
		}
	}

	internal void UpdateChatInteractionsForNewParticipantInConversation(IParticipant newParticipant, IConversationWithParticipants conversationWithParticipants, IReadOnlyCollection<IParticipant> newParticipantsInConversation)
	{
		IParticipant[] participants = conversationWithParticipants.Participants;
		IReadOnlyCollection<IParticipant> newParticipantFriends = _ChatInteractionsAccessor.GetFriendsForUserParticipant(newParticipant);
		if (newParticipantFriends == null || !participants.Any((IParticipant participant) => ParticipantComparer.AreEqual(participant, newParticipant)))
		{
			return;
		}
		UtcInstant lastUpdated = conversationWithParticipants.LastUpdated;
		List<ChatInteraction> chatInteractionsToCacheForNewParticipant = new List<ChatInteraction>();
		IParticipant[] array = participants;
		foreach (IParticipant participant2 in array)
		{
			if (!ParticipantComparer.AreEqual(participant2, newParticipant) && IsParticipantUser(participant2) && !newParticipantFriends.Contains(participant2))
			{
				chatInteractionsToCacheForNewParticipant.Add(new ChatInteraction(participant2, lastUpdated));
				if (!newParticipantsInConversation.Contains(participant2))
				{
					_ChatInteractionsAccessor.CacheChatInteractionForUser(participant2, new ChatInteraction(newParticipant, lastUpdated));
				}
			}
		}
		_ChatInteractionsAccessor.CacheChatInteractionsForUser(newParticipant, chatInteractionsToCacheForNewParticipant);
	}

	public void UpdateCacheForUsersRemovedFromConversation(long conversationId, IReadOnlyCollection<IUser> usersRemovedFromConversation)
	{
		List<IParticipant> participantsRemoved = (from user in usersRemovedFromConversation?.Where((IUser user) => user != null)
			select user.ToParticipant()).ToList();
		if (participantsRemoved == null || participantsRemoved.Count < 1)
		{
			return;
		}
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants == null || conversationWithParticipants.Participants.Length == 0)
		{
			return;
		}
		IParticipant[] participants = conversationWithParticipants.Participants;
		foreach (IParticipant participantRemoved in participantsRemoved)
		{
			UpdateChatInteractionsForParticipantRemovedFromConversation(participantRemoved, (IReadOnlyCollection<IParticipant>)(object)participants, participantsRemoved);
		}
	}

	internal void UpdateChatInteractionsForParticipantRemovedFromConversation(IParticipant participantRemoved, IReadOnlyCollection<IParticipant> conversationParticipants, IReadOnlyCollection<IParticipant> allParticipantsRemovedFromConversation)
	{
		IReadOnlyCollection<IParticipant> removedParticipantsFriends = _ChatInteractionsAccessor.GetFriendsForUserParticipant(participantRemoved);
		if (removedParticipantsFriends == null || IsRemovedParticipantInConversation(conversationParticipants, participantRemoved, removedParticipantsFriends, out var remainingNonFriendParticipants) || remainingNonFriendParticipants == null || remainingNonFriendParticipants.Count == 0)
		{
			return;
		}
		int otherParticipantsInConvCount = conversationParticipants.Count - 1;
		IReadOnlyCollection<ChatInteraction> removedParticipantsInteractionsInOtherConversations = _ChatInteractionsAccessor.GetChatInteractionsForParticipantFromConversations(participantRemoved, (IParticipant convParticipant) => remainingNonFriendParticipants.Contains(convParticipant), (IReadOnlyCollection<ChatInteraction> chatInteractionsResult) => chatInteractionsResult.Count >= otherParticipantsInConvCount);
		if (removedParticipantsInteractionsInOtherConversations != null && removedParticipantsInteractionsInOtherConversations.Count > 0)
		{
			_ChatInteractionsAccessor.CacheChatInteractionsForUser(participantRemoved, removedParticipantsInteractionsInOtherConversations);
			foreach (ChatInteraction chatInteraction in removedParticipantsInteractionsInOtherConversations)
			{
				if (chatInteraction?.ChatParticipant != null)
				{
					if (!allParticipantsRemovedFromConversation.Contains(chatInteraction.ChatParticipant))
					{
						_ChatInteractionsAccessor.CacheChatInteractionForUser(chatInteraction.ChatParticipant, new ChatInteraction(participantRemoved, chatInteraction.LastInteracted));
					}
					remainingNonFriendParticipants.Remove(chatInteraction.ChatParticipant);
				}
			}
		}
		HashSet<IParticipant> hashSet = remainingNonFriendParticipants;
		if (hashSet == null || hashSet.Count <= 0)
		{
			return;
		}
		_ChatInteractionsAccessor.RemoveCachedChatInteractionsForUser(participantRemoved, remainingNonFriendParticipants);
		foreach (IParticipant userNotInConversationWithAnymore in remainingNonFriendParticipants)
		{
			_ChatInteractionsAccessor.RemoveCachedChatInteractionForUser(userNotInConversationWithAnymore, participantRemoved);
		}
	}

	public void RestoreCacheForFrienshipFormedEvent(IUser firstUser, IUser secondUser)
	{
		if (firstUser != null && secondUser != null && _FriendshipFactory.AreFriends(firstUser.Id, secondUser.Id))
		{
			IParticipant firstParticipant = _ParticipantUtilities.ToParticipant(firstUser);
			IParticipant secondParticipant = _ParticipantUtilities.ToParticipant(secondUser);
			if (firstParticipant != null && secondParticipant != null)
			{
				_ChatInteractionsAccessor.RemoveCachedChatInteractionForUser(firstParticipant, secondParticipant);
				_ChatInteractionsAccessor.RemoveCachedChatInteractionForUser(secondParticipant, firstParticipant);
			}
		}
	}

	public void RestoreCacheForFrienshipRevokedEvent(IUser firstUser, IUser secondUser)
	{
		if (firstUser == null || secondUser == null || _FriendshipFactory.AreFriends(firstUser.Id, secondUser.Id))
		{
			return;
		}
		IParticipant firstParticipant = _ParticipantUtilities.ToParticipant(firstUser);
		IParticipant secondParticipant = _ParticipantUtilities.ToParticipant(secondUser);
		if (firstParticipant == null || secondParticipant == null)
		{
			return;
		}
		if (Settings.Default.IsAvoidDuplicateChatInteractionsCacheUpdateEnabled && _ChatInteractionsAccessor.AreChatInteractionsAlreadyCachedForParticipants(firstParticipant, secondParticipant))
		{
			_Logger.Warning($"Chat Interactions cache entries already exists for participants: {firstParticipant.TargetId} & {secondParticipant.TargetId}");
			return;
		}
		ChatInteraction secondParticipantsInteraction = _ChatInteractionsAccessor.GetChatInteractionsForParticipantFromConversations(firstParticipant, (IParticipant convParticipant) => ParticipantComparer.AreEqual(secondParticipant, convParticipant), (IReadOnlyCollection<ChatInteraction> chatInteractionsResult) => true).FirstOrDefault();
		if (secondParticipantsInteraction != null)
		{
			_ChatInteractionsAccessor.CacheChatInteractionForUser(firstParticipant, secondParticipantsInteraction);
			_ChatInteractionsAccessor.CacheChatInteractionForUser(secondParticipant, new ChatInteraction(firstParticipant, secondParticipantsInteraction.LastInteracted));
		}
	}

	private bool IsRemovedParticipantInConversation(IReadOnlyCollection<IParticipant> participants, IParticipant removedParticipant, IReadOnlyCollection<IParticipant> removedParticipantsFriends, out HashSet<IParticipant> remainingNonFriendParticipants)
	{
		bool participantPresentInConversation = false;
		remainingNonFriendParticipants = new HashSet<IParticipant>(new ParticipantComparer());
		foreach (IParticipant participant in participants)
		{
			if (ParticipantComparer.AreEqual(participant, removedParticipant))
			{
				participantPresentInConversation = true;
			}
			else if (IsParticipantUser(participant) && !removedParticipantsFriends.Contains(participant))
			{
				remainingNonFriendParticipants.Add(participant);
			}
		}
		return participantPresentInConversation;
	}

	private static void UpdateChatInteractionsDictionary(IDictionary<IParticipant, List<ChatInteraction>> chatInteractionsDictionary, IParticipant participantKey, IParticipant chatInteractionParticipant, UtcInstant chatInteractionScore)
	{
		if (!chatInteractionsDictionary.TryGetValue(participantKey, out var chatInteractionsForUser))
		{
			chatInteractionsForUser = (chatInteractionsDictionary[participantKey] = new List<ChatInteraction>());
		}
		chatInteractionsForUser.Add(new ChatInteraction(chatInteractionParticipant, chatInteractionScore));
	}

	internal virtual bool IsParticipantUser(IParticipant participant)
	{
		return participant.IsUser();
	}
}
