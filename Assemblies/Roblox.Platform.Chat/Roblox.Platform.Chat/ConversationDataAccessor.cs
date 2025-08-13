using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal class ConversationDataAccessor : IConversationDataAccessor
{
	internal class ConversationWithParticipants : IConversationWithParticipants
	{
		public long Id { get; set; }

		public string Title { get; set; }

		public IParticipant Initiator { get; set; }

		public IParticipant[] Participants { get; set; }

		public ConversationType ConversationType { get; set; }

		public UtcInstant LastUpdated { get; set; }
	}

	internal delegate void MissingParticipantDetectedHandler(long conversationId, long userId);

	private readonly IRedisClient _RedisClient;

	private readonly RedisParticipantConversationCache _RedisParticipantConversationCache;

	private readonly RedisConversationParticipantCache _RedisConversationParticipantCache;

	private readonly IConversationTitleCache _ConversationTitleCache;

	private readonly IConversationUniverseEntityFactory _ConversationUniverseEntityFactory;

	internal static event MissingParticipantDetectedHandler OnMissingParticipantDetected;

	public ConversationDataAccessor(IRedisClient redisClient, IInstantProvider instantProvider, ISettings settings, ILogger logger, IConversationUniverseEntityFactory conversationUniverseEntityFactory)
	{
		_RedisClient = redisClient;
		_RedisParticipantConversationCache = new RedisParticipantConversationCache(_RedisClient, instantProvider, settings, logger);
		_RedisConversationParticipantCache = new RedisConversationParticipantCache(_RedisClient);
		_ConversationTitleCache = new RedisConversationTitleCache(_RedisClient, logger);
		_ConversationUniverseEntityFactory = conversationUniverseEntityFactory;
	}

	public IConversationWithParticipants GetOneToOneConversation(IParticipant participant1, IParticipant participant2)
	{
		OneToOneConversation oneToOne = GetOneToOneConversationEntity(participant1, participant2);
		if (oneToOne != null)
		{
			return GetConversationWithParticipants(oneToOne.ConversationID);
		}
		return null;
	}

	public IConversationWithParticipants GetCloudEditConversation(long placeId)
	{
		CloudEditConversation cloudEditConversation = GetCloudEditConversationEntity(placeId);
		if (cloudEditConversation != null)
		{
			return GetConversationWithParticipants(cloudEditConversation.ConversationID);
		}
		return null;
	}

	public IConversationWithParticipants GetConversationWithParticipants(long conversationId, IReadOnlyCollection<ConversationType> conversationTypesToQuery = null)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return null;
		}
		return GetConversationWithParticipants(conversation, conversationTypesToQuery);
	}

	public ConversationType? GetConversationType(long conversationId)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return null;
		}
		return GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID);
	}

	public IConversation GetConversationWithoutParticipants(long conversationId)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return null;
		}
		return new Conversation
		{
			Id = conversation.ID,
			ConversationType = GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID),
			LastUpdated = new UtcInstant(conversation.Updated.ToUniversalTime())
		};
	}

	public long? GetCloudEditConversationPlaceId(long conversationId)
	{
		return CloudEditConversation.GetByConversationID(conversationId)?.PlaceID;
	}

	public IReadOnlyCollection<ConversationWithParticipantsAndStatus> GetConversationsForParticipant(IParticipant participant, int startIndex, int maxRows)
	{
		IReadOnlyCollection<ConversationIdWithStatus> sortedConversationIds = _RedisParticipantConversationCache.GetConversationIds(participant, startIndex, maxRows, GetParticipantsConversationsFromDatabase);
		return GetConversationsWithParticipantAndStatus(sortedConversationIds, participant);
	}

	public long GetParticipantUnreadConversationCount(IParticipant participant)
	{
		return _RedisParticipantConversationCache.GetConversationCount(participant, ConversationStatusFilter.Unread, GetParticipantsConversationsFromDatabase);
	}

	public long GetParticipantConversationCount(IParticipant participant)
	{
		return _RedisParticipantConversationCache.GetConversationCount(participant, ConversationStatusFilter.All, GetParticipantsConversationsFromDatabase);
	}

	public IConversationWithParticipants UpdateConversationForNewMessage(long conversationId, IParticipant messageSender)
	{
		IConversationWithParticipants conversation = GetConversationWithParticipants(conversationId);
		ConversationType conversationType = conversation.ConversationType;
		if (conversationType == ConversationType.OneToOneConversation || conversationType == ConversationType.MultiUserConversation)
		{
			_RedisParticipantConversationCache.UpdateParticipantConversationsForNewMessage(conversation, messageSender);
		}
		return conversation;
	}

	public IConversationWithParticipants CreateSocialConversation(IParticipant initiator, IReadOnlyCollection<IParticipant> participants, ConversationType conversationType)
	{
		byte conversationTypeId = ConvertConversationTypeToEntityId(conversationType);
		if (conversationType != ConversationType.MultiUserConversation && conversationType != ConversationType.OneToOneConversation)
		{
			throw new ConversationPersistenceException("Do not call create social conversation for creating other types of conversations");
		}
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.CreateNew(initiator.TypeId, initiator.TargetId, conversationTypeId, null);
		if (conversationType == ConversationType.OneToOneConversation)
		{
			try
			{
				CreateNewOneToOneConversation(initiator, participants.First(), conversation.ID);
			}
			catch (SqlException sqlException)
			{
				if (IsDuplicateKeyException(sqlException))
				{
					throw new OneToOneConversationDuplicateException();
				}
				throw;
			}
		}
		IParticipant[] uniqueParticipantArray = new HashSet<IParticipant>(participants, new ParticipantComparer()) { initiator }.ToArray();
		StoreConversationParticipantsInSqlAndCacheReverseLookup(conversation.ID, (IReadOnlyCollection<IParticipant>)(object)uniqueParticipantArray);
		return TranslateSqlEntityToConversationWithParticipants(conversation, (IReadOnlyCollection<IParticipant>)(object)uniqueParticipantArray);
	}

	public IConversationWithParticipants CreateCloudEditConversation(IParticipant initiator, IReadOnlyCollection<IParticipant> participants, long placeId)
	{
		byte conversationTypeId = ConvertConversationTypeToEntityId(ConversationType.CloudEditConversation);
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.CreateNew(initiator.TypeId, initiator.TargetId, conversationTypeId, null);
		try
		{
			CreateNewCloudEditConversation(conversation.ID, placeId);
		}
		catch (SqlException sqlException)
		{
			if (IsDuplicateKeyException(sqlException))
			{
				throw new CloudEditConversationDuplicateException();
			}
			throw;
		}
		IParticipant[] uniqueParticipantArray = new HashSet<IParticipant>(participants, new ParticipantComparer()) { initiator }.ToArray();
		StoreConversationParticipantsInRedis(conversation.ID, (IReadOnlyCollection<IParticipant>)(object)uniqueParticipantArray);
		return TranslateSqlEntityToConversationWithParticipants(conversation, (IReadOnlyCollection<IParticipant>)(object)uniqueParticipantArray);
	}

	public void AddParticipantsToConversation(long conversationId, IReadOnlyCollection<IParticipant> newParticipants)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation != null)
		{
			switch (GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID))
			{
			case ConversationType.OneToOneConversation:
			case ConversationType.MultiUserConversation:
				StoreConversationParticipantsInSqlAndCacheReverseLookup(conversationId, newParticipants);
				break;
			case ConversationType.CloudEditConversation:
				StoreConversationParticipantsInRedis(conversationId, newParticipants);
				break;
			default:
				throw new ConversationPersistenceException("Invalid conversation type");
			}
		}
	}

	public bool RemoveConversationParticipant(long conversationId, IParticipant participantToBeRemoved)
	{
		bool success = false;
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation != null)
		{
			switch (GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID))
			{
			case ConversationType.OneToOneConversation:
			case ConversationType.MultiUserConversation:
			{
				ConversationParticipant conversationParticipant = ConversationParticipant.GetByConversationIDParticipantTypeIDAndParticipantTargetID(conversationId, participantToBeRemoved.TypeId, participantToBeRemoved.TargetId);
				if (conversationParticipant != null)
				{
					conversationParticipant.Delete();
					success = true;
				}
				_RedisParticipantConversationCache.UpdateForRemovedConversationParticipants(conversationId, (IReadOnlyCollection<IParticipant>)(object)new IParticipant[1] { participantToBeRemoved });
				break;
			}
			case ConversationType.CloudEditConversation:
				RemoveConversationParticipantsFromRedis(conversationId, (IReadOnlyCollection<IParticipant>)(object)new IParticipant[1] { participantToBeRemoved });
				success = true;
				break;
			}
		}
		return success;
	}

	public IConversationWithParticipants RenameSocialConversation(long conversationId, string over13Title, string under13Title)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return null;
		}
		conversation.Title = (string.IsNullOrEmpty(over13Title) ? null : over13Title);
		conversation.Save();
		_ConversationTitleCache.CacheConversationTitleForUnder13(conversationId, string.IsNullOrEmpty(under13Title) ? null : under13Title);
		return GetConversationWithParticipants(conversation);
	}

	public bool UpdateConversationTimeStamp(long conversationId)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return false;
		}
		conversation.Save();
		return true;
	}

	public void SetConversationUniverse(long conversationId, long universeId, out DateTime? conversationUniverseChangedDateTime)
	{
		IConversationUniverseEntity conversationUniverse = _ConversationUniverseEntityFactory.GetByConversationId(conversationId);
		if (conversationUniverse != null)
		{
			conversationUniverse.UniverseId = universeId;
			conversationUniverse.Update();
		}
		else
		{
			_ConversationUniverseEntityFactory.Create(conversationId, universeId);
		}
		conversationUniverseChangedDateTime = _ConversationUniverseEntityFactory.GetByConversationId(conversationId)?.Updated;
	}

	public bool DoesContainParticipant(long conversationId, IParticipant participant)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return false;
		}
		switch (GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID))
		{
		case ConversationType.OneToOneConversation:
		case ConversationType.MultiUserConversation:
			return ConversationParticipant.GetByConversationIDParticipantTypeIDAndParticipantTargetID(conversationId, participant.TypeId, participant.TargetId) != null;
		case ConversationType.CloudEditConversation:
			return _RedisConversationParticipantCache.DoesContainParticipant(conversationId, participant);
		default:
			return false;
		}
	}

	public bool TryToMarkConversationAsReadForParticipant(long conversationId, IParticipant participant)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return false;
		}
		ConversationType conversationType = GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID);
		if (conversationType == ConversationType.MultiUserConversation || conversationType == ConversationType.OneToOneConversation)
		{
			return _RedisParticipantConversationCache.TryToMarkConversationAsReadForParticipant(conversationId, participant);
		}
		return true;
	}

	public long? ArchiveOneToOneConversation(IParticipant participant1, IParticipant participant2)
	{
		OneToOneConversation oneToOne = GetOneToOneConversationEntity(participant1, participant2);
		if (oneToOne == null)
		{
			return null;
		}
		ConversationParticipant conversationParticipant1 = ConversationParticipant.GetByConversationIDParticipantTypeIDAndParticipantTargetID(oneToOne.ConversationID, participant1.TypeId, participant1.TargetId);
		ConversationParticipant conversationParticipant2 = ConversationParticipant.GetByConversationIDParticipantTypeIDAndParticipantTargetID(oneToOne.ConversationID, participant2.TypeId, participant2.TargetId);
		conversationParticipant1?.Delete();
		conversationParticipant2?.Delete();
		_RedisParticipantConversationCache.UpdateForRemovedConversationParticipants(oneToOne.ConversationID, (IReadOnlyCollection<IParticipant>)(object)new IParticipant[2] { participant1, participant2 });
		return oneToOne.ConversationID;
	}

	public long? RestoreOneToOneConversation(IParticipant participant1, IParticipant participant2)
	{
		OneToOneConversation oneToOne = GetOneToOneConversationEntity(participant1, participant2);
		if (oneToOne == null)
		{
			return null;
		}
		IParticipant[] participants = new IParticipant[2] { participant1, participant2 };
		StoreConversationParticipantsInSqlAndCacheReverseLookup(oneToOne.ConversationID, (IReadOnlyCollection<IParticipant>)(object)participants);
		return oneToOne.ConversationID;
	}

	public bool RemoveConversationUniverse(long conversationId)
	{
		ConversationUniverse conversationUniverse = ConversationUniverse.GetByConversationId(conversationId);
		if (conversationUniverse == null)
		{
			return false;
		}
		conversationUniverse.Delete();
		return true;
	}

	public bool RemoveConversation(long conversationId)
	{
		Roblox.Platform.Chat.Entities.Conversation conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationId);
		if (conversation == null)
		{
			return false;
		}
		conversation.Delete();
		return true;
	}

	public int GetMaxParticipantsInConversation(ConversationType conversationType)
	{
		if (conversationType != ConversationType.CloudEditConversation)
		{
			return Settings.Default.MaxParticipantsInConversation;
		}
		return Settings.Default.MaxParticipantsInCloudEditConversations;
	}

	public IReadOnlyCollection<ConversationIdWithScore> GetCacheMissParticipantConversationsEligibleForScoreUpdate(IParticipant participant, ConversationsMissingInCache conversationsMissingInCache)
	{
		return _RedisParticipantConversationCache.GetCacheMissParticipantConversationsEligibleForScoreUpdate(participant, conversationsMissingInCache);
	}

	public void UpdateParticipantConversationScoreInCache(IParticipant participant, long conversationId, long score)
	{
		_RedisParticipantConversationCache.UpdateParticipantConversationScore(participant, conversationId, score);
	}

	public IReadOnlyCollection<IConversationWithParticipants> GetConversationsWithParticipantsForParticipant(IParticipant participant, int startIndex, int maxRows, out int conversationIdsQueried, IReadOnlyCollection<ConversationType> conversationTypesToQuery = null)
	{
		conversationIdsQueried = 0;
		IReadOnlyCollection<ConversationIdWithStatus> sortedConversationIds = _RedisParticipantConversationCache.GetConversationIds(participant, startIndex, maxRows, GetParticipantsConversationsFromDatabase);
		List<IConversationWithParticipants> conversationsWithParticipants = new List<IConversationWithParticipants>();
		if (sortedConversationIds == null || sortedConversationIds.Count < 1)
		{
			return conversationsWithParticipants;
		}
		conversationIdsQueried = sortedConversationIds.Count;
		conversationsWithParticipants.AddRange(from conversationWithStatus in sortedConversationIds
			let convWithParticipants = GetConversationWithParticipants(conversationWithStatus.ConversationId, conversationTypesToQuery)
			where convWithParticipants != null
			select convWithParticipants);
		return conversationsWithParticipants;
	}

	public long? GetConversationUniverseId(long conversationId)
	{
		return _ConversationUniverseEntityFactory.GetByConversationId(conversationId)?.UniverseId;
	}

	public void ResetConversationUniverse(long conversationId)
	{
		_ConversationUniverseEntityFactory.GetByConversationId(conversationId)?.Delete();
	}

	private ConversationType GetConversationTypeFromEntityTypeId(byte conversationTypeId)
	{
		if (conversationTypeId == Roblox.Platform.Chat.Entities.ConversationType.OneToOne.ID)
		{
			return ConversationType.OneToOneConversation;
		}
		if (conversationTypeId == Roblox.Platform.Chat.Entities.ConversationType.MultiUser.ID)
		{
			return ConversationType.MultiUserConversation;
		}
		if (conversationTypeId == Roblox.Platform.Chat.Entities.ConversationType.CloudEdit.ID)
		{
			return ConversationType.CloudEditConversation;
		}
		throw new ConversationPersistenceException("Invalid conversation type");
	}

	private byte ConvertConversationTypeToEntityId(ConversationType conversationType)
	{
		return conversationType switch
		{
			ConversationType.OneToOneConversation => Roblox.Platform.Chat.Entities.ConversationType.OneToOne.ID, 
			ConversationType.MultiUserConversation => Roblox.Platform.Chat.Entities.ConversationType.MultiUser.ID, 
			ConversationType.CloudEditConversation => Roblox.Platform.Chat.Entities.ConversationType.CloudEdit.ID, 
			_ => throw new ConversationPersistenceException("Invalid conversation type"), 
		};
	}

	private IConversationWithParticipants GetConversationWithParticipants(Roblox.Platform.Chat.Entities.Conversation conversation, IReadOnlyCollection<ConversationType> conversationTypesToQuery = null)
	{
		IReadOnlyCollection<IParticipant> participants = null;
		ConversationType conversationType = GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID);
		if (conversationTypesToQuery != null && !conversationTypesToQuery.Contains(conversationType))
		{
			return null;
		}
		int maxParticipantsInConversation = GetMaxParticipantsInConversation(conversationType);
		switch (conversationType)
		{
		case ConversationType.MultiUserConversation:
			participants = (from cp in ConversationParticipant.GetConversationParticipantsByConversationIDPaged(conversation.ID, 0L, maxParticipantsInConversation)
				where cp != null
				select cp).Select((Func<ConversationParticipant, IParticipant>)((ConversationParticipant x) => new Participant(x.ParticipantTypeID, x.ParticipantTargetID))).ToList();
			break;
		case ConversationType.OneToOneConversation:
		{
			OneToOneConversation oneToOneConversation = OneToOneConversation.GetByConversationID(conversation.ID);
			if (oneToOneConversation != null)
			{
				participants = new List<IParticipant>();
				if (ConversationParticipant.GetByConversationIDParticipantTypeIDAndParticipantTargetID(conversation.ID, oneToOneConversation.FirstParticipantTypeID, oneToOneConversation.FirstParticipantTargetID) != null)
				{
					Participant participant1 = new Participant(oneToOneConversation.FirstParticipantTypeID, oneToOneConversation.FirstParticipantTargetID);
					Participant participant2 = new Participant(oneToOneConversation.SecondParticipantTypeID, oneToOneConversation.SecondParticipantTargetID);
					participants = new List<IParticipant> { participant1, participant2 };
				}
			}
			break;
		}
		case ConversationType.CloudEditConversation:
			participants = ((IEnumerable<RedisConversationParticipant>)_RedisConversationParticipantCache.GetConversationParticipants(conversation.ID, 0, maxParticipantsInConversation)).Select((Func<RedisConversationParticipant, IParticipant>)((RedisConversationParticipant conversationParticipant) => new Participant(conversationParticipant.ParticipantTypeId, conversationParticipant.ParticipantTargetId))).ToList();
			break;
		}
		return TranslateSqlEntityToConversationWithParticipants(conversation, participants);
	}

	private IReadOnlyCollection<ConversationWithParticipantsAndStatus> GetConversationsWithParticipantAndStatus(IReadOnlyCollection<ConversationIdWithStatus> conversationIdsWithStatuses, IParticipant participantToValidate)
	{
		List<ConversationWithParticipantsAndStatus> conversationsWithParticipantsAndStatuses = new List<ConversationWithParticipantsAndStatus>();
		if (conversationIdsWithStatuses == null)
		{
			return conversationsWithParticipantsAndStatuses;
		}
		foreach (ConversationIdWithStatus conversationIdWithStatuses in conversationIdsWithStatuses)
		{
			IConversationWithParticipants conv = GetConversationWithParticipants(conversationIdWithStatuses.ConversationId);
			if (conv != null)
			{
				if (!conv.Participants.Any((IParticipant p) => ParticipantComparer.AreEqual(p, participantToValidate)))
				{
					ConversationDataAccessor.OnMissingParticipantDetected?.Invoke(conv.Id, participantToValidate.TargetId);
				}
				else
				{
					conversationsWithParticipantsAndStatuses.Add(new ConversationWithParticipantsAndStatus(conv, conversationIdWithStatuses.Status));
				}
			}
		}
		return conversationsWithParticipantsAndStatuses;
	}

	private IReadOnlyCollection<ConversationIdWithUpdatedDate> GetParticipantsConversationsFromDatabase(IParticipant participant)
	{
		return (from conversationParticipant in ConversationParticipant.GetConversationParticipantsByParticipantTypeIDAndParticipantTargetIDPaged(participant.TypeId, participant.TargetId, 0L, Settings.Default.MaxConversationParticipantsToFetch)
			where conversationParticipant != null
			let conversation = Roblox.Platform.Chat.Entities.Conversation.Get(conversationParticipant.ConversationID)
			where conversation != null
			select new ConversationIdWithUpdatedDate(conversationParticipant.ConversationID, UtcInstant.CoerceFrom(conversation.Updated))).ToList();
	}

	private OneToOneConversation GetOneToOneConversationEntity(IParticipant unsortedParticipant1, IParticipant unsortedParticipant2)
	{
		OneToOneConversationHelper oneToOneConversationHelper = new OneToOneConversationHelper(unsortedParticipant1, unsortedParticipant2);
		IParticipant orderedParticipant1 = oneToOneConversationHelper.Participant1;
		IParticipant orderedParticipant2 = oneToOneConversationHelper.Participant2;
		return OneToOneConversation.GetByByFirstAndSecondParticipants(orderedParticipant1.TypeId, orderedParticipant1.TargetId, orderedParticipant2.TypeId, orderedParticipant2.TargetId);
	}

	private CloudEditConversation GetCloudEditConversationEntity(long placeId)
	{
		return CloudEditConversation.GetByPlaceID(placeId);
	}

	private OneToOneConversation CreateNewOneToOneConversation(IParticipant unsortedParticipant1, IParticipant unsortedParticipant2, long conversationId)
	{
		OneToOneConversationHelper oneToOneConversationHelper = new OneToOneConversationHelper(unsortedParticipant1, unsortedParticipant2);
		IParticipant orderedParticipant1 = oneToOneConversationHelper.Participant1;
		IParticipant orderedParticipant2 = oneToOneConversationHelper.Participant2;
		return OneToOneConversation.CreateNew(conversationId, orderedParticipant1.TypeId, orderedParticipant1.TargetId, orderedParticipant2.TypeId, orderedParticipant2.TargetId);
	}

	private CloudEditConversation CreateNewCloudEditConversation(long conversationId, long placeId)
	{
		return CloudEditConversation.CreateNew(conversationId, placeId);
	}

	/// <summary>
	/// Stores the conversation participants in Sql server and stores the reverse lookup of participant-&gt; conversations in Redis
	/// </summary>
	/// <returns>The number of participant records stored successfully</returns>
	private void StoreConversationParticipantsInSqlAndCacheReverseLookup(long conversationId, IReadOnlyCollection<IParticipant> newParticipants)
	{
		int addedCount = 0;
		foreach (IParticipant participant in newParticipants)
		{
			try
			{
				ConversationParticipant.CreateNew(conversationId, participant.TypeId, participant.TargetId);
				addedCount++;
			}
			catch (SqlException sqlException)
			{
				if (!IsDuplicateKeyException(sqlException))
				{
					throw;
				}
			}
		}
		_RedisParticipantConversationCache.UpdateForNewConversationParticipants(conversationId, newParticipants);
	}

	private IConversationWithParticipants TranslateSqlEntityToConversationWithParticipants(Roblox.Platform.Chat.Entities.Conversation conversation, IReadOnlyCollection<IParticipant> participants)
	{
		return new ConversationWithParticipants
		{
			Id = conversation.ID,
			Title = conversation.Title,
			Initiator = new Participant(conversation.CreatorTypeID, conversation.CreatorTargetID),
			Participants = participants?.ToArray(),
			ConversationType = GetConversationTypeFromEntityTypeId(conversation.ConversationTypeID),
			LastUpdated = new UtcInstant(conversation.Updated.ToUniversalTime())
		};
	}

	private void StoreConversationParticipantsInRedis(long conversationId, IReadOnlyCollection<IParticipant> newParticipants)
	{
		_RedisConversationParticipantCache.AddConversationParticipants(conversationId, newParticipants);
	}

	private void RemoveConversationParticipantsFromRedis(long conversationId, IReadOnlyCollection<IParticipant> participantsToRemove)
	{
		_RedisConversationParticipantCache.RemoveConversationParticipants(conversationId, participantsToRemove);
	}

	private bool IsDuplicateKeyException(SqlException sqlException)
	{
		return sqlException.Message.StartsWith("Cannot insert duplicate key");
	}
}
