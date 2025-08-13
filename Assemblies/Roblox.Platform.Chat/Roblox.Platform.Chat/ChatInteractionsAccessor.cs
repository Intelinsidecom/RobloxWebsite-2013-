using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Redis;

namespace Roblox.Platform.Chat;

internal class ChatInteractionsAccessor : IChatInteractionsAccessor
{
	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly RedisChatInteractionsCache _RedisChatInteractionsCache;

	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IUserFactory _UserFactory;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly ILogger _Logger;

	public ChatInteractionsAccessor(IConversationDataAccessor conversationDataAccessor, IRedisClient redisClient, IParticipantUtilities participantUtilities, IFriendshipFactory friendshipFactory, IUserFactory userFactory, ILogger logger)
	{
		_ConversationDataAccessor = conversationDataAccessor ?? throw new ArgumentNullException("conversationDataAccessor");
		_ParticipantUtilities = participantUtilities ?? throw new ArgumentNullException("participantUtilities");
		_FriendshipFactory = friendshipFactory ?? throw new ArgumentNullException("friendshipFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		if (redisClient == null)
		{
			throw new ArgumentNullException("redisClient");
		}
		_RedisChatInteractionsCache = new RedisChatInteractionsCache(redisClient, logger);
	}

	public IReadOnlyCollection<IParticipant> GetUniqueChatParticipants(IParticipant participant, int startIndex, int maxRows)
	{
		return _RedisChatInteractionsCache.GetUniqueChatParticipants(participant, startIndex, maxRows, FetchUniqueChatInteractionsFromConversations);
	}

	public long GetUniqueChatParticipantsCount(IParticipant participant)
	{
		return _RedisChatInteractionsCache.GetUniqueChatParticipantsCount(participant);
	}

	public IReadOnlyCollection<ChatInteraction> FetchUniqueChatInteractionsFromConversations(IParticipant participant)
	{
		IReadOnlyCollection<IParticipant> friendsForUserParticipant = GetFriendsForUserParticipant(participant);
		return GetChatInteractionsForParticipantFromConversations(participant, (IParticipant conversationParticipant) => !friendsForUserParticipant.Contains(conversationParticipant));
	}

	public void UpdateChatInteractionsCacheForUsers(KeyValuePair<IParticipant, List<ChatInteraction>>[] usersWithChatInteractions)
	{
		if (usersWithChatInteractions == null || usersWithChatInteractions.Length == 0)
		{
			return;
		}
		for (int i = 0; i < usersWithChatInteractions.Length; i++)
		{
			KeyValuePair<IParticipant, List<ChatInteraction>> chatInteractionPerUser = usersWithChatInteractions[i];
			IParticipant participantToUpdateCacheFor = chatInteractionPerUser.Key;
			if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipant(participantToUpdateCacheFor))
			{
				_RedisChatInteractionsCache.CacheChatInteractionsForUser(chatInteractionPerUser.Key, chatInteractionPerUser.Value);
			}
			else
			{
				_RedisChatInteractionsCache.PopulateChatInteractionsOnCacheMiss(participantToUpdateCacheFor, FetchUniqueChatInteractionsFromConversations(participantToUpdateCacheFor));
			}
		}
	}

	public void CacheChatInteractionForUser(IParticipant participant, ChatInteraction chatInteraction)
	{
		if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipant(participant))
		{
			_RedisChatInteractionsCache.CacheChatInteractionForUser(participant, chatInteraction);
		}
		else
		{
			_RedisChatInteractionsCache.PopulateChatInteractionsOnCacheMiss(participant, FetchUniqueChatInteractionsFromConversations(participant));
		}
	}

	public void CacheChatInteractionsForUser(IParticipant participant, IReadOnlyCollection<ChatInteraction> chatInteractionsForParticipant)
	{
		if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipant(participant))
		{
			_RedisChatInteractionsCache.CacheChatInteractionsForUser(participant, chatInteractionsForParticipant);
		}
		else
		{
			_RedisChatInteractionsCache.PopulateChatInteractionsOnCacheMiss(participant, FetchUniqueChatInteractionsFromConversations(participant));
		}
	}

	public void RemoveCachedChatInteractionsForUser(IParticipant participant, HashSet<IParticipant> participantInteractionsToRemove)
	{
		if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipant(participant))
		{
			_RedisChatInteractionsCache.RemoveCachedChatInteractionsForUser(participant, participantInteractionsToRemove);
		}
	}

	public void RemoveCachedChatInteractionForUser(IParticipant participant, IParticipant participantInteractionToRemove)
	{
		if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipant(participant))
		{
			_RedisChatInteractionsCache.RemoveCachedChatInteractionForUser(participant, participantInteractionToRemove);
		}
	}

	public bool AreChatInteractionsAlreadyCachedForParticipants(IParticipant firstParticipant, IParticipant secondParticipant)
	{
		if (_RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipants(firstParticipant, secondParticipant).HasValue)
		{
			return _RedisChatInteractionsCache.DoesChatInteractionsCacheExistForParticipants(secondParticipant, firstParticipant).HasValue;
		}
		return false;
	}

	public IReadOnlyCollection<IParticipant> GetFriendsForUserParticipant(IParticipant participant)
	{
		try
		{
			if (participant == null)
			{
				return null;
			}
			IUser user = _ParticipantUtilities.ToUser(participant);
			if (user == null)
			{
				return null;
			}
			IReadOnlyCollection<IFriend> allFriends = _FriendshipFactory.GetAllFriends(user);
			HashSet<IParticipant> friends = new HashSet<IParticipant>(new ParticipantComparer());
			if (allFriends == null)
			{
				return friends;
			}
			foreach (IFriend friend in allFriends)
			{
				if (friend != null)
				{
					IUser userObj = _UserFactory.GetUser(friend.UserId);
					if (userObj != null)
					{
						friends.Add(_ParticipantUtilities.ToParticipant(userObj));
					}
				}
			}
			return friends;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return null;
		}
	}

	public IReadOnlyCollection<ChatInteraction> GetChatInteractionsForParticipantFromConversations(IParticipant participant, ShouldParticipantBeIncludedInChatInteractions filterParticipantsCondition = null, ShouldQueryMoreParticipantConversationsForChatInteractions queryConversationsExitCondition = null)
	{
		return GetChatInteractionsForParticipantFromConversations(participant, Settings.Default.QueryConversationsWithParticipantsForUserBatchSize, Settings.Default.MaximumGroupConversationsToQueryForCachingChatInteractions, Settings.Default.QueryParticipantConversationsCacheLimitForChatInteractionsCache, filterParticipantsCondition, queryConversationsExitCondition);
	}

	internal IReadOnlyCollection<ChatInteraction> GetChatInteractionsForParticipantFromConversations(IParticipant participant, int queryConversationsWithParticipantsBatchSize, int maxGroupConversationsToQuery, int maxConversationsToQuery, ShouldParticipantBeIncludedInChatInteractions filterParticipantsCondition = null, ShouldQueryMoreParticipantConversationsForChatInteractions queryConversationsExitCondition = null)
	{
		HashSet<ChatInteraction> chatInteractionsForParticipant = new HashSet<ChatInteraction>(new ChatInteractionComparer());
		int start = 0;
		int groupConversationsQueried = 0;
		int conversationIdsQueried = 0;
		do
		{
			IReadOnlyCollection<IConversationWithParticipants> participantConversations = _ConversationDataAccessor.GetConversationsWithParticipantsForParticipant(participant, start, queryConversationsWithParticipantsBatchSize, out conversationIdsQueried, new HashSet<ConversationType> { ConversationType.MultiUserConversation });
			if (participantConversations == null || conversationIdsQueried == 0)
			{
				break;
			}
			foreach (IConversationWithParticipants conversation in participantConversations)
			{
				if (conversation?.Participants == null)
				{
					continue;
				}
				IParticipant[] participants = conversation.Participants;
				foreach (IParticipant convParticipant in participants)
				{
					if (convParticipant != null && IsParticipantUser(convParticipant) && !ParticipantComparer.AreEqual(participant, convParticipant) && (filterParticipantsCondition == null || filterParticipantsCondition(convParticipant)))
					{
						chatInteractionsForParticipant.Add(new ChatInteraction(convParticipant, conversation.LastUpdated));
						if (queryConversationsExitCondition != null && queryConversationsExitCondition(chatInteractionsForParticipant))
						{
							return chatInteractionsForParticipant;
						}
					}
				}
				groupConversationsQueried++;
			}
			start += conversationIdsQueried;
		}
		while (groupConversationsQueried < maxGroupConversationsToQuery && start <= maxConversationsToQuery && conversationIdsQueried >= queryConversationsWithParticipantsBatchSize);
		return chatInteractionsForParticipant;
	}

	internal virtual bool IsParticipantUser(IParticipant participant)
	{
		return participant.IsUser();
	}
}
