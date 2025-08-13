using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

public class UniqueConversationCache : IUniqueConversationCache
{
	private readonly IRedisClient _ChatConversationRedisClient;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly IUserFactory _UserFactory;

	public UniqueConversationCache(IRedisClient chatConversationRedisClient, ILogger logger, IUniverseFactory universeFactory, IUserFactory userFactory)
		: this(chatConversationRedisClient, ConversationDataAccessorFactory.GetConversationDataAccessor(chatConversationRedisClient, logger, universeFactory), logger, Settings.Default, userFactory, new ParticipantUtilities(userFactory))
	{
	}

	internal UniqueConversationCache(IRedisClient chatConversationRedisClient, IConversationDataAccessor conversationDataAccessor, ILogger logger, ISettings settings, IUserFactory userFactory, IParticipantUtilities participantUtilities)
	{
		_ChatConversationRedisClient = chatConversationRedisClient ?? throw new PlatformArgumentNullException("chatConversationRedisClient");
		_ConversationDataAccessor = conversationDataAccessor ?? throw new PlatformArgumentNullException("conversationDataAccessor");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_ParticipantUtilities = participantUtilities ?? throw new PlatformArgumentNullException("participantUtilities");
	}

	public bool ConversationExistsInCache(IParticipant initiatorParticipant, IParticipant[] participants, out long? existingConversationId)
	{
		existingConversationId = null;
		if (initiatorParticipant == null || participants == null || participants.Length == 0)
		{
			return false;
		}
		try
		{
			List<IParticipant> allparticipants = participants.Append(initiatorParticipant).ToList();
			string key = GetParticipantsHashKey(allparticipants);
			RedisValue existingConversationIdString = _ChatConversationRedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
			if (!existingConversationIdString.HasValue || !long.TryParse(existingConversationIdString, out var parsedConversationId))
			{
				return false;
			}
			if (parsedConversationId <= 0)
			{
				return false;
			}
			existingConversationId = parsedConversationId;
			return true;
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
			return false;
		}
	}

	public void UpdateCacheForNewConversationCreated(long conversationId)
	{
		if (conversationId <= 0 || !_Settings.IsExistingChatGroupDeduplicationEnabled)
		{
			return;
		}
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants != null && conversationWithParticipants.Participants.Length != 0 && conversationWithParticipants.ConversationType == ConversationType.MultiUserConversation && string.IsNullOrEmpty(conversationWithParticipants.Title))
		{
			string key = GetParticipantsHashKey(conversationWithParticipants.Participants.ToList());
			_ChatConversationRedisClient.Execute(key, (IDatabase db) => db.StringSet(key, conversationId.ToString()));
		}
	}

	public void UpdateCacheForConversationParticipantsAdded(long conversationId, IReadOnlyCollection<long> addedUserIds)
	{
		if (conversationId <= 0 || addedUserIds == null || addedUserIds.Count <= 0)
		{
			return;
		}
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants == null || conversationWithParticipants.Participants.Length == 0 || conversationWithParticipants.ConversationType != ConversationType.MultiUserConversation || !string.IsNullOrEmpty(conversationWithParticipants.Title))
		{
			return;
		}
		List<long> originalParticipantIds = (from participant in conversationWithParticipants.Participants
			select participant.TargetId into participantId
			where !addedUserIds.Contains(participantId)
			select participantId).ToList();
		if (originalParticipantIds.Count > 0)
		{
			List<IParticipant> originalParticipants = originalParticipantIds.Select((long id) => _ParticipantUtilities.ToParticipant(_UserFactory.GetUser(id))).ToList();
			string key = GetParticipantsHashKey(originalParticipants);
			_ChatConversationRedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
		}
	}

	public void UpdateCacheForConversationParticipantsRemoved(long conversationId, IReadOnlyCollection<long> removedUserIds)
	{
		if (conversationId <= 0 || removedUserIds == null || removedUserIds.Count <= 0)
		{
			return;
		}
		List<IParticipant> existingConversationParticipants = new List<IParticipant>();
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants != null && conversationWithParticipants.ConversationType == ConversationType.MultiUserConversation && string.IsNullOrEmpty(conversationWithParticipants.Title))
		{
			existingConversationParticipants = conversationWithParticipants.Participants.ToList();
		}
		List<long> originalParticipantIds = existingConversationParticipants.Select((IParticipant participant) => participant.TargetId).Union(removedUserIds).ToList();
		if (originalParticipantIds.Count <= 0)
		{
			return;
		}
		List<IParticipant> originalParticipants = originalParticipantIds.Select((long id) => _ParticipantUtilities.ToParticipant(_UserFactory.GetUser(id))).ToList();
		string key = GetParticipantsHashKey(originalParticipants);
		if (conversationWithParticipants == null)
		{
			RedisValue existingConversationIdString = _ChatConversationRedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
			if (!existingConversationIdString.HasValue || (long.TryParse(existingConversationIdString, out var parsedConversationId) && parsedConversationId != conversationId))
			{
				return;
			}
		}
		_ChatConversationRedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
	}

	public void UpdateCacheForConversationTitleChanged(long conversationId)
	{
		if (conversationId <= 0)
		{
			return;
		}
		IConversationWithParticipants conversationWithParticipants = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationWithParticipants?.Participants != null && conversationWithParticipants.Participants.Length != 0 && conversationWithParticipants.ConversationType == ConversationType.MultiUserConversation && !string.IsNullOrEmpty(conversationWithParticipants.Title))
		{
			string key = GetParticipantsHashKey(conversationWithParticipants.Participants.ToList());
			_ChatConversationRedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
		}
	}

	private string GetParticipantsHashKey(IReadOnlyCollection<IParticipant> participants)
	{
		SortedDictionary<long, int> sortedParticipantTargetAndTypeDictionary = new SortedDictionary<long, int>();
		foreach (IParticipant participant in participants)
		{
			if (participant != null && !sortedParticipantTargetAndTypeDictionary.ContainsKey(participant.TargetId))
			{
				sortedParticipantTargetAndTypeDictionary.Add(participant.TargetId, participant.TypeId);
			}
		}
		StringBuilder conversationKeyStringBuilder = new StringBuilder();
		string prefix = "";
		foreach (KeyValuePair<long, int> item in sortedParticipantTargetAndTypeDictionary)
		{
			conversationKeyStringBuilder.Append(prefix);
			conversationKeyStringBuilder.Append(item.Value);
			conversationKeyStringBuilder.Append(":");
			conversationKeyStringBuilder.Append(item.Key);
			prefix = ",";
		}
		StringBuilder hashedStringBuilder = new StringBuilder();
		using (SHA256 hash = SHA256.Create())
		{
			byte[] array = hash.ComputeHash(Encoding.UTF8.GetBytes(conversationKeyStringBuilder.ToString()));
			foreach (byte hashedByte in array)
			{
				hashedStringBuilder.Append(hashedByte.ToString("x2"));
			}
		}
		return $"UniqueConversations_HashedParticipantsList:{hashedStringBuilder}";
	}
}
