using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Redis;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

public class ConversationFactory : IConversationFactory
{
	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IConversationTitleBuilder _ConversationTitleBuilder;

	public ConversationFactory(IRedisClient redisClient, IUserFactory userFactory, ITextFilterClientV2 textFilterClientV2, ILogger logger, IUniverseFactory universeFactory)
		: this(redisClient, textFilterClientV2, logger, new ParticipantUtilities(userFactory), universeFactory)
	{
	}

	internal ConversationFactory(IRedisClient redisClient, ITextFilterClientV2 textFilterClientV2, ILogger logger, IParticipantUtilities participantUtilities, IUniverseFactory universeFactory)
		: this(ConversationDataAccessorFactory.GetConversationDataAccessor(redisClient, logger, universeFactory), new ConversationTitleBuilder(redisClient, new ContentValidator(new ContentValidationRules(participantUtilities), textFilterClientV2, participantUtilities), participantUtilities, logger), participantUtilities)
	{
	}

	internal ConversationFactory(IConversationDataAccessor conversationDataAccessor, IConversationTitleBuilder conversationTitleBuilder, IParticipantUtilities participantUtilities)
	{
		_ParticipantUtilities = participantUtilities;
		_ConversationDataAccessor = conversationDataAccessor;
		_ConversationTitleBuilder = conversationTitleBuilder;
	}

	public IReadOnlyCollection<IConversation> GetConversations(IUser user, int startIndex, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		IReadOnlyCollection<ConversationWithParticipantsAndStatus> conversations = _ConversationDataAccessor.GetConversationsForParticipant(_ParticipantUtilities.ToParticipant(user), startIndex, maxRows);
		Dictionary<long, long?> conversationUniverseIds = GetConversationUniverseIds(GetConversationIds(conversations));
		return conversations.Translate(_ConversationTitleBuilder, user, _ParticipantUtilities, conversationUniverseIds);
	}

	public IReadOnlyCollection<IConversation> GetConversations(IUser user, long[] conversationIds)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (conversationIds == null || conversationIds.Length == 0 || conversationIds.Any((long id) => id <= 0))
		{
			throw new PlatformArgumentException();
		}
		List<IConversationWithParticipants> conversationEntities = new List<IConversationWithParticipants>();
		foreach (long conversationId in conversationIds)
		{
			IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
			if (conversationEntity != null)
			{
				conversationEntities.Add(conversationEntity);
			}
		}
		IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabledV2 ? _ParticipantUtilities.BatchGetUsersForConversations(conversationEntities) : null);
		List<IConversation> conversations = new List<IConversation>(conversationIds.Length);
		foreach (IConversationWithParticipants conversationEntity2 in conversationEntities)
		{
			IParticipant userParticipant = _ParticipantUtilities.ToParticipant(user);
			if (!conversationEntity2.Participants.Any((IParticipant existingParticipant) => ParticipantComparer.AreEqual(existingParticipant, userParticipant)))
			{
				throw new ChatPlatformAuthorizationException("User trying to fetch a conversation that he/she is not a part of");
			}
			long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationEntity2.Id);
			conversations.Add(conversationEntity2.Translate(_ConversationTitleBuilder, user, _ParticipantUtilities, batchUsersResult, conversationUniverseId));
		}
		return conversations;
	}

	public long GetUnreadConversationCount(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		return _ConversationDataAccessor.GetParticipantUnreadConversationCount(_ParticipantUtilities.ToParticipant(user));
	}

	public IConversation GetConversation(long conversationId)
	{
		if (conversationId <= 0)
		{
			throw new PlatformArgumentException("Conversation id needs to be positive");
		}
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			return null;
		}
		IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabledV2 ? _ParticipantUtilities.BatchGetUsersForConversation(conversationEntity) : null);
		long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationId);
		return conversationEntity.Translate(_ConversationTitleBuilder, null, _ParticipantUtilities, batchUsersResult, conversationUniverseId);
	}

	public IConversation GetConversationWithoutParticipants(long conversationId)
	{
		if (conversationId <= 0)
		{
			throw new PlatformArgumentException("Conversation id needs to be positive");
		}
		return _ConversationDataAccessor.GetConversationWithoutParticipants(conversationId);
	}

	public IReadOnlyCollection<IUser> GetConversationParticipantUsers(long conversationId, IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (conversationId <= 0)
		{
			throw new PlatformArgumentException("Conversation id needs to be positive");
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, _ParticipantUtilities.ToParticipant(user)))
		{
			throw new ChatPlatformAuthorizationException("User trying to fetch conversation participants needs to be part of the conversation");
		}
		return GetConversation(conversationId)?.ParticipantUsers ?? new List<IUser>();
	}

	public bool DoesConversationContainsUser(IUser user, long conversationId)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (conversationId <= 0)
		{
			throw new PlatformArgumentException("Conversation id needs to be positive");
		}
		return _ConversationDataAccessor.DoesContainParticipant(conversationId, _ParticipantUtilities.ToParticipant(user));
	}

	private IEnumerable<long> GetConversationIds(IEnumerable<ConversationWithParticipantsAndStatus> conversations)
	{
		return conversations.Select((ConversationWithParticipantsAndStatus conversation) => conversation?.Conversation?.Id).Where(delegate(long? conversationId)
		{
			long? num2 = conversationId;
			return num2.HasValue;
		}).Select(delegate(long? conversationId)
		{
			long? num = conversationId;
			return num.Value;
		})
			.ToList();
	}

	private Dictionary<long, long?> GetConversationUniverseIds(IEnumerable<long> conversationIds)
	{
		Dictionary<long, long?> universeIdMap = new Dictionary<long, long?>();
		foreach (long conversationId in conversationIds)
		{
			if (!universeIdMap.ContainsKey(conversationId))
			{
				long? universeId = _ConversationDataAccessor.GetConversationUniverseId(conversationId);
				universeIdMap.Add(conversationId, universeId);
			}
		}
		return universeIdMap;
	}
}
