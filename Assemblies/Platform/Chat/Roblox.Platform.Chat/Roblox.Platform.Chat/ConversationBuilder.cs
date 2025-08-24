using System;
using System.Collections.Generic;
using System.Linq;
using GraphemeSplitter;
using Roblox.EventLog;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Locking;
using Roblox.Platform.Assets;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Platform.TeamCreate;
using Roblox.Platform.Universes;
using Roblox.Redis;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

public class ConversationBuilder : IConversationBuilder, ISystemInitiatedConversationBuilder
{
	internal delegate void ConversationAbandonedHandler(long conversationId);

	internal delegate void NewConversationHandler(IUser creatorUser, IConversationWithParticipants conversation, IParticipantUtilities participantUtilities);

	internal delegate void UserRemovedFromConversationHandler(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> removedUsers, IParticipantUtilities participantUtilities);

	internal delegate void UserTypingStatusUpdateHandler(IUser typingUser, bool isTyping, long conversationId, ConversationType conversation, IReadOnlyCollection<IParticipant> otherParticipants);

	internal delegate void ConversationTitleChangeHandler(IUser currentUser, long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> participants);

	private readonly ILogger _Logger;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IConversationParticipantValidator _ConversationParticipantValidator;

	private readonly IAssetFactoryBase<IPlace> _PlaceFactory;

	private readonly IRedisLeasedLockFactory _RedisLeasedLockFactory;

	private readonly IContentValidator _ContentValidator;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly IGroupMembershipFactory _GroupMembershipFactory;

	private readonly string _FloodCheckerCategoryBase;

	private readonly IConversationTitleBuilder _ConversationTitleBuilder;

	private readonly ISettings _Settings;

	private readonly IChatFloodCheckerFactory _ChatFloodCheckerFactory;

	private readonly IUniqueConversationCache _UniqueConversationCache;

	internal event ConversationAbandonedHandler OnConversationAbandoned;

	internal event NewConversationHandler OnNewConversationCreated;

	public event UsersAddedToConversationHandler OnUsersAddedToConversation;

	internal event UserRemovedFromConversationHandler OnUsersRemovedFromConversation;

	internal event UserTypingStatusUpdateHandler OnUserTypingStatusUpdate;

	internal event ConversationTitleChangeHandler OnConversationTitleChanged;

	public event ConversationUniverseChangedHandler OnConversationUniverseChanged;

	public ConversationBuilder(IRedisClient redisClient, IUserFactory userFactory, IFriendshipFactory friendshipFactory, ILogger logger, IGroupMembershipFactory groupMembershipFactory, IAssetFactoryBase<IPlace> placeFactory, IRedisLeasedLockFactory redisLeasedLockFactory, ITeamCreatePermissionsVerifier teamCreatePermissionsVerifier, IUniverseFactory universeFactory, ITextFilterClientV2 textFilterClientV2)
		: this(redisClient, friendshipFactory, logger, groupMembershipFactory, placeFactory, redisLeasedLockFactory, teamCreatePermissionsVerifier, universeFactory, new ParticipantUtilities(userFactory), new ContentValidator(new ContentValidationRules(new ParticipantUtilities(userFactory)), textFilterClientV2, new ParticipantUtilities(userFactory)), ConversationDataAccessorFactory.GetConversationDataAccessor(redisClient, logger, universeFactory), new UniqueConversationCache(redisClient, logger, universeFactory, userFactory))
	{
	}

	private ConversationBuilder(IRedisClient redisClient, IFriendshipFactory friendshipFactory, ILogger logger, IGroupMembershipFactory groupMembershipFactory, IAssetFactoryBase<IPlace> placeFactory, IRedisLeasedLockFactory redisLeasedLockFactory, ITeamCreatePermissionsVerifier teamCreatePermissionsVerifier, IUniverseFactory universeFactory, IParticipantUtilities participantUtilities, IContentValidator contentValidator, IConversationDataAccessor conversationDataAccessor, IUniqueConversationCache uniqueConversationCache)
		: this(logger, groupMembershipFactory, placeFactory, redisLeasedLockFactory, contentValidator, participantUtilities, conversationDataAccessor, new ConversationParticipantValidator(friendshipFactory, conversationDataAccessor, teamCreatePermissionsVerifier, universeFactory), new ConversationTitleBuilder(redisClient, contentValidator, participantUtilities, logger), Settings.Default, new ChatFloodCheckerFactory(new FloodCheckerFactory(), logger, Settings.Default), uniqueConversationCache)
	{
	}

	internal ConversationBuilder(ILogger logger, IGroupMembershipFactory groupMembershipFactory, IAssetFactoryBase<IPlace> placeFactory, IRedisLeasedLockFactory rediseasedLockFactory, IContentValidator contentValidator, IParticipantUtilities participantUtilities, IConversationDataAccessor conversationDataAccessor, IConversationParticipantValidator conversationParticipantValidator, IConversationTitleBuilder conversationTitleBuilder, ISettings settings, IChatFloodCheckerFactory chatFloodCheckerFactory, IUniqueConversationCache uniqueConversationCache)
	{
		_Logger = logger;
		_ConversationDataAccessor = conversationDataAccessor;
		_ConversationParticipantValidator = conversationParticipantValidator;
		_GroupMembershipFactory = groupMembershipFactory;
		_PlaceFactory = placeFactory;
		_RedisLeasedLockFactory = rediseasedLockFactory;
		_ContentValidator = contentValidator;
		_ParticipantUtilities = participantUtilities;
		_FloodCheckerCategoryBase = GetType().FullName;
		_ConversationTitleBuilder = conversationTitleBuilder;
		_Settings = settings;
		_ChatFloodCheckerFactory = chatFloodCheckerFactory;
		_UniqueConversationCache = uniqueConversationCache;
	}

	public IGroupConversationActionResponse CreateGroupConversation(IUser initiator, IReadOnlyCollection<IUser> participantUsers, string rawTitle)
	{
		if (initiator == null)
		{
			throw new PlatformArgumentException("User cannot be null in call to create conversation");
		}
		if (!string.IsNullOrEmpty(rawTitle) && rawTitle.Length > Settings.Default.MaxConversationTitleLength)
		{
			throw new PlatformArgumentException("Title length is over the maximum limit");
		}
		ValidatedUsers validatedUsers = _ConversationParticipantValidator.GetValidatedParticipantsForSocialConversations(initiator, participantUsers, ConversationType.MultiUserConversation);
		IParticipant initiatorParticipant = _ParticipantUtilities.ToParticipant(initiator);
		IParticipant[] acceptedParticipants = validatedUsers.AcceptedUsers.Select(_ParticipantUtilities.ToParticipant).ToArray();
		if (acceptedParticipants.Length < _Settings.MinGroupConversationParticipantsCount || acceptedParticipants.Length > _Settings.MaxGroupConversationParticipantsCount)
		{
			throw new PlatformArgumentException($"Number of Participants needs to be within limit : {Settings.Default.MinGroupConversationParticipantsCount} - {Settings.Default.MaxGroupConversationParticipantsCount}");
		}
		if (ShouldCreateNewConversation(rawTitle, initiatorParticipant, acceptedParticipants, out var conversationEntity))
		{
			conversationEntity = _ConversationDataAccessor.CreateSocialConversation(initiatorParticipant, (IReadOnlyCollection<IParticipant>)(object)acceptedParticipants, ConversationType.MultiUserConversation);
			if (!string.IsNullOrEmpty(rawTitle))
			{
				IMessageContentValidationResult validationResult = _ContentValidator.Validate(initiatorParticipant, conversationEntity, ChatContentType.ConversationTitle, rawTitle);
				if (validationResult.IsAllowedToBeSent)
				{
					conversationEntity = _ConversationDataAccessor.RenameSocialConversation(conversationEntity.Id, validationResult.Over13Content, validationResult.Under13Content);
				}
			}
			FireNewConversationCreatedEvent(initiator, conversationEntity);
		}
		List<IUser> allUsers = new List<IUser> { initiator };
		allUsers.AddRange(validatedUsers.AcceptedUsers);
		long? conversationUniverseId = ((conversationEntity == null) ? null : _ConversationDataAccessor.GetConversationUniverseId(conversationEntity.Id));
		return new GroupConversationActionResponse
		{
			Conversation = conversationEntity.Translate(_ConversationTitleBuilder, initiator, initiator, allUsers, conversationUniverseId),
			RejectedUsers = validatedUsers.RejectedUsers
		};
	}

	public IConversation CreateOneToOneConversation(IUser firstUser, IUser secondUser)
	{
		return CreateOneToOneConversation(firstUser, secondUser, isSystemInitiated: false);
	}

	public IConversation CreateSystemInitiatedOneToOneConversation(IUser firstUser, IUser secondUser)
	{
		return CreateOneToOneConversation(firstUser, secondUser, isSystemInitiated: true);
	}

	public IConversation GetOrCreateCloudEditConversation(IUser currentUser, IPlace place)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("User cannot be null in call to get or create cloud edit conversation");
		}
		if (place == null)
		{
			throw new PlatformArgumentNullException("Place cannot be null in call to get or create cloud edit conversation");
		}
		_ConversationParticipantValidator.GetValidatedParticipantsForCloudEditConversations(place, currentUser, (IReadOnlyCollection<IUser>)(object)new IUser[1] { currentUser }, _GroupMembershipFactory);
		IConversation existingConversation = GetExistingCloudEditConversation(currentUser, place);
		if (existingConversation != null)
		{
			return existingConversation;
		}
		string key = GetCloudEditConversationCreationKey(place);
		using IRedisLeasedLock redisLeasedLock = _RedisLeasedLockFactory.CreateLeasedLock(key, TimeSpan.FromSeconds(2.0), delegate(Exception ex)
		{
			_Logger.Error(ex);
		});
		if (redisLeasedLock.TryAcquire())
		{
			existingConversation = GetExistingCloudEditConversation(currentUser, place);
			if (existingConversation != null)
			{
				return existingConversation;
			}
			try
			{
				IConversationWithParticipants conversationEntity = _ConversationDataAccessor.CreateCloudEditConversation(_ParticipantUtilities.ToParticipant(currentUser), new List<IParticipant>(0), place.Id);
				FireNewConversationCreatedEvent(currentUser, conversationEntity);
				long? conversationUniverseId = ((conversationEntity == null) ? null : _ConversationDataAccessor.GetConversationUniverseId(conversationEntity.Id));
				return conversationEntity.Translate(_ConversationTitleBuilder, currentUser, currentUser, new List<IUser>(), conversationUniverseId);
			}
			catch (CloudEditConversationDuplicateException)
			{
			}
		}
		existingConversation = GetExistingCloudEditConversation(currentUser, place);
		if (existingConversation == null)
		{
			throw new PlatformException("Unable to create the conversation. It already exists. Please retry");
		}
		return existingConversation;
	}

	public IGroupConversationActionResponse AddUsersToConversation(long conversationId, IUser currentUser, IUser[] newUsers, IPlatform platform)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("User cannot be null in call to add users to a conversation");
		}
		IParticipant currentUserAsParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		ValidatedUsers validatedUsers = null;
		if (conversationEntity.ConversationType == ConversationType.MultiUserConversation || conversationEntity.ConversationType == ConversationType.OneToOneConversation)
		{
			if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentUserAsParticipant))
			{
				throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation. Cannot add users to conversation.");
			}
			validatedUsers = _ConversationParticipantValidator.GetValidatedParticipantsForSocialConversations(currentUser, (IReadOnlyCollection<IUser>)(object)newUsers, conversationEntity.ConversationType);
		}
		else if (conversationEntity.ConversationType == ConversationType.CloudEditConversation)
		{
			long? placeId = _ConversationDataAccessor.GetCloudEditConversationPlaceId(conversationId);
			if (!placeId.HasValue)
			{
				throw new PlatformArgumentException("This conversation Id is corrupted");
			}
			IPlace place = _PlaceFactory.Get(placeId.Value);
			validatedUsers = _ConversationParticipantValidator.GetValidatedParticipantsForCloudEditConversations(place, currentUser, (IReadOnlyCollection<IUser>)(object)newUsers, _GroupMembershipFactory);
		}
		IParticipant[] newParticipants = validatedUsers.AcceptedUsers.Select(_ParticipantUtilities.ToParticipant).ToArray();
		HashSet<IParticipant> newParticipantsHash = new HashSet<IParticipant>(newParticipants, new ParticipantComparer());
		List<IUser> allParticipantUsers = new List<IUser>(validatedUsers.AcceptedUsers);
		List<IParticipant> allParticipants = new List<IParticipant>(newParticipants);
		List<IParticipant> existingParticipants = conversationEntity.Participants.ToList();
		foreach (IParticipant existingParticipant in existingParticipants)
		{
			if (!newParticipantsHash.Contains(existingParticipant))
			{
				allParticipants.Add(existingParticipant);
				allParticipantUsers.Add(_ParticipantUtilities.ToUser(existingParticipant));
			}
		}
		if (allParticipants.Count > _ConversationDataAccessor.GetMaxParticipantsInConversation(conversationEntity.ConversationType))
		{
			throw new ChatParticipantLimitExceededException("Too many participants in the conversation");
		}
		if (conversationEntity.ConversationType == ConversationType.OneToOneConversation && allParticipants.Count > 2)
		{
			conversationEntity = _ConversationDataAccessor.CreateSocialConversation(currentUserAsParticipant, (IReadOnlyCollection<IParticipant>)(object)allParticipants.ToArray(), ConversationType.MultiUserConversation);
			FireNewConversationCreatedEvent(currentUser, conversationEntity);
		}
		else
		{
			_ConversationDataAccessor.AddParticipantsToConversation(conversationId, (IReadOnlyCollection<IParticipant>)(object)newParticipants);
			FireUsersAddedToConversationEvent(currentUser, conversationEntity, (IReadOnlyCollection<IParticipant>)(object)newParticipants, existingParticipants, platform);
		}
		long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationId);
		return new GroupConversationActionResponse
		{
			Conversation = conversationEntity.Translate(_ConversationTitleBuilder, currentUser, _ParticipantUtilities.ToUser(conversationEntity.Initiator), allParticipantUsers, conversationUniverseId),
			RejectedUsers = validatedUsers.RejectedUsers
		};
	}

	public IConversation RemoveUserFromConversation(long conversationId, IUser currentUser, IUser userToBeRemoved)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("Current user cannot be null in call to remove users from conversation");
		}
		if (userToBeRemoved == null)
		{
			throw new PlatformArgumentNullException("Participant to be removed cannot be null");
		}
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		if (conversationEntity.ConversationType == ConversationType.OneToOneConversation)
		{
			throw new ChatPlatformAuthorizationException("You cannot remove participants from a 1-1 conversation");
		}
		IParticipant currentParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation. Cannot remove users from conversation.");
		}
		if (((conversationEntity.ConversationType != ConversationType.MultiUserConversation && conversationEntity.ConversationType != ConversationType.OneToOneConversation) || !ParticipantComparer.AreEqual(currentParticipant, conversationEntity.Initiator)) && currentUser.Id != userToBeRemoved.Id)
		{
			throw new ChatPlatformAuthorizationException($"The current user:{currentUser.Id} is not authorized to remove the participant from the conversation.");
		}
		IParticipant participantToBeRemoved = _ParticipantUtilities.ToParticipant(userToBeRemoved);
		_ConversationDataAccessor.RemoveConversationParticipant(conversationId, participantToBeRemoved);
		List<IParticipant> remainingParticipants = new List<IParticipant>(conversationEntity.Participants.Length - 1);
		IParticipant[] participants = conversationEntity.Participants;
		foreach (IParticipant participant in participants)
		{
			if (!ParticipantComparer.AreEqual(participant, participantToBeRemoved))
			{
				remainingParticipants.Add(participant);
			}
		}
		if (remainingParticipants.Count == 0 && conversationEntity.ConversationType == ConversationType.MultiUserConversation)
		{
			_ConversationDataAccessor.RemoveConversationUniverse(conversationId);
			_ConversationDataAccessor.RemoveConversation(conversationId);
			if (this.OnConversationAbandoned != null)
			{
				this.OnConversationAbandoned(conversationId);
			}
		}
		FireUsersRemovedFromConversationEvent(currentUser, conversationEntity, new List<IParticipant> { participantToBeRemoved });
		long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationId);
		IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabledV2 ? _ParticipantUtilities.BatchGetUsersForConversation(conversationEntity) : null);
		return conversationEntity.Translate(_ConversationTitleBuilder, currentUser, _ParticipantUtilities, batchUsersResult, conversationUniverseId);
	}

	public bool IsConversationTitleTooLong(string title)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(title))
		{
			return false;
		}
		if (!_Settings.IsGraphemeConversationTitleLengthCalculationEnabled)
		{
			return title.Length > _Settings.MaxConversationTitleLength;
		}
		try
		{
			return ((IEnumerable<StringSegment>)(object)StringSplitter.GetGraphemes(title)).Count() > _Settings.MaxConversationTitleLength;
		}
		catch
		{
			_Logger.Error("Exception occurred while using GraphemeSplitter");
		}
		return false;
	}

	public IConversationRenameResponse RenameGroupConversation(long conversationId, IUser currentUser, string newTitle)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "currentUser"));
		}
		if (IsConversationTitleTooLong(newTitle))
		{
			throw new PlatformArgumentException("New title length is over the maximum limit");
		}
		string leasedLockKey = GenerateLeasedLockKeyForConversation(conversationId);
		using IRedisLeasedLock redisLeasedLock = _RedisLeasedLockFactory.CreateLeasedLock(leasedLockKey, Settings.Default.ConversationPersistenceDeduplicationLockDuration);
		if (!redisLeasedLock.TryAcquire())
		{
			throw new Exception("Unable to lease Redis lock");
		}
		IParticipant currentUserAsParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		if (conversationEntity.ConversationType != ConversationType.MultiUserConversation)
		{
			throw new PlatformArgumentException("This is not a group conversation. ConversationId:" + conversationId);
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentUserAsParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation.");
		}
		IConversationWithParticipants newConversationEntity;
		if (string.IsNullOrWhiteSpace(newTitle))
		{
			newConversationEntity = _ConversationDataAccessor.RenameSocialConversation(conversationId, null, null);
		}
		else
		{
			IMessageContentValidationResult validationResult = _ContentValidator.Validate(currentUserAsParticipant, conversationEntity, ChatContentType.ConversationTitle, newTitle);
			if (!validationResult.IsAllowedToBeSent)
			{
				return new ConversationRenameResponse
				{
					Result = ConversationRenameResult.Moderated
				};
			}
			newConversationEntity = _ConversationDataAccessor.RenameSocialConversation(conversationId, validationResult.Over13Content, validationResult.Under13Content);
		}
		this.OnConversationTitleChanged?.Invoke(currentUser, conversationId, ConversationType.MultiUserConversation, (IReadOnlyCollection<IParticipant>)(object)newConversationEntity.Participants);
		long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationId);
		IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabledV2 ? _ParticipantUtilities.BatchGetUsersForConversation(conversationEntity) : null);
		return new ConversationRenameResponse
		{
			Conversation = newConversationEntity.Translate(_ConversationTitleBuilder, currentUser, _ParticipantUtilities, batchUsersResult, conversationUniverseId),
			Result = ConversationRenameResult.Success
		};
	}

	public void UpdateUserTypingStatus(IUser initiator, long conversationId, bool isTyping)
	{
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		IParticipant currentParticipant = _ParticipantUtilities.ToParticipant(initiator);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{initiator.Id} not part of the conversation.");
		}
		IFloodChecker updateUserTypingStatusFloodChecker = _ChatFloodCheckerFactory.GetFloodCheckerForUpdateUserTypingStatus(_FloodCheckerCategoryBase, initiator);
		if (updateUserTypingStatusFloodChecker.IsFlooded())
		{
			throw new ChatUpdateUserTypingStatusLimitExceeded($"User: {initiator.Id} cannot send any more typing status updates.");
		}
		List<Participant> otherParticipants = new List<Participant>();
		IParticipant[] participants = conversationEntity.Participants;
		for (int i = 0; i < participants.Length; i++)
		{
			Participant participant = (Participant)participants[i];
			if (!ParticipantComparer.AreEqual(participant, currentParticipant))
			{
				otherParticipants.Add(participant);
			}
		}
		try
		{
			this.OnUserTypingStatusUpdate?.Invoke(initiator, isTyping, conversationId, conversationEntity.ConversationType, otherParticipants);
			updateUserTypingStatusFloodChecker.UpdateCount();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public bool UpdateConversationTimestamp(IConversation conversation, Func<DateTime> nowProvider = null)
	{
		if (nowProvider == null)
		{
			nowProvider = () => DateTime.UtcNow;
		}
		string leasedLockKey = GenerateLeasedLockKeyForConversation(conversation.Id);
		if (nowProvider().Subtract(conversation.LastUpdated) > Settings.Default.ConversationPersistenceDeduplicationInterval)
		{
			using (IRedisLeasedLock redisLeasedLock = _RedisLeasedLockFactory.CreateLeasedLock(leasedLockKey, Settings.Default.ConversationPersistenceDeduplicationLockDuration))
			{
				if (!redisLeasedLock.TryAcquire())
				{
					throw new Exception("Unable to lease Redis lock while trying to update conversation time stamp");
				}
				return _ConversationDataAccessor.UpdateConversationTimeStamp(conversation.Id);
			}
		}
		return false;
	}

	public void SetConversationUniverse(IUser currentUser, long conversationId, IUniverse universe, IPlatform platform)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "currentUser"));
		}
		if (universe == null)
		{
			throw new PlatformArgumentException("Universe does not exist");
		}
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		IParticipant currentParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation. Cannot add universe to the conversation: {conversationId}.");
		}
		IFloodChecker setConversationUniverseFloodChecker = _ChatFloodCheckerFactory.GetFloodCheckerForSetConversationUniverse(_FloodCheckerCategoryBase, currentUser);
		if (setConversationUniverseFloodChecker.IsFlooded())
		{
			throw new SetConversationUniverseLimitExceeded($"User: {currentUser.Id} exceeded the limit to change conversation universe.");
		}
		_ConversationDataAccessor.SetConversationUniverse(conversationId, universe.Id, out var conversationUniverseChangedDateTime);
		try
		{
			setConversationUniverseFloodChecker.UpdateCount();
			this.OnConversationUniverseChanged?.Invoke(currentUser, conversationEntity, universe, platform, _ParticipantUtilities, conversationUniverseChangedDateTime);
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}

	public void ResetConversationUniverse(IUser currentUser, long conversationId, IPlatform platform)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "currentUser"));
		}
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversationEntity == null)
		{
			throw new PlatformArgumentException("Conversation does not exist. ConversationId:" + conversationId);
		}
		IParticipant currentParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation. Cannot reset universe to the conversation: {conversationId}.");
		}
		IFloodChecker setConversationUniverseFloodChecker = _ChatFloodCheckerFactory.GetFloodCheckerForSetConversationUniverse(_FloodCheckerCategoryBase, currentUser);
		if (setConversationUniverseFloodChecker.IsFlooded())
		{
			throw new SetConversationUniverseLimitExceeded($"User: {currentUser.Id} exceeded the limit to change conversation universe.");
		}
		_ConversationDataAccessor.ResetConversationUniverse(conversationId);
		try
		{
			setConversationUniverseFloodChecker.UpdateCount();
			this.OnConversationUniverseChanged?.Invoke(currentUser, conversationEntity, null, platform, _ParticipantUtilities, null);
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}

	private string GetOnetoOneConversationCreationKey(IParticipant participant1, IParticipant participant2)
	{
		return "CreateConversation_" + new OneToOneConversationHelper(participant1, participant2).GetKey();
	}

	private string GetCloudEditConversationCreationKey(IPlace place)
	{
		return "CloudEdit_CreateConversation_" + place.Id;
	}

	private IConversation GetExistingOneToOneConversation(IUser currentUser, IUser otherUser)
	{
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetOneToOneConversation(_ParticipantUtilities.ToParticipant(currentUser), _ParticipantUtilities.ToParticipant(otherUser));
		if (conversationEntity != null)
		{
			if (conversationEntity.ConversationType != ConversationType.OneToOneConversation)
			{
				throw new PlatformDataIntegrityException("Invalid conversation type for 1-1 conversation");
			}
			long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationEntity.Id);
			return conversationEntity.Translate(_ConversationTitleBuilder, currentUser, _ParticipantUtilities.ToUser(conversationEntity.Initiator), new List<IUser> { currentUser, otherUser }, conversationUniverseId);
		}
		return null;
	}

	private IConversation GetExistingCloudEditConversation(IUser currentUser, IPlace place)
	{
		IConversationWithParticipants conversationEntity = _ConversationDataAccessor.GetCloudEditConversation(place.Id);
		if (conversationEntity != null)
		{
			if (conversationEntity.ConversationType != ConversationType.CloudEditConversation)
			{
				throw new PlatformDataIntegrityException("Invalid conversation type for cloud edit conversation");
			}
			long? conversationUniverseId = _ConversationDataAccessor.GetConversationUniverseId(conversationEntity.Id);
			IReadOnlyDictionary<long, IUser> batchUsersResult = (Settings.Default.IsUserFactoryMultiGetEnabledV2 ? _ParticipantUtilities.BatchGetUsersForConversation(conversationEntity) : null);
			return conversationEntity.Translate(_ConversationTitleBuilder, currentUser, _ParticipantUtilities, batchUsersResult, conversationUniverseId);
		}
		return null;
	}

	private void FireNewConversationCreatedEvent(IUser creatorUser, IConversationWithParticipants conversation)
	{
		try
		{
			this.OnNewConversationCreated?.Invoke(creatorUser, conversation, _ParticipantUtilities);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	private void FireUsersAddedToConversationEvent(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> addedUsers, IReadOnlyCollection<IParticipant> existingUsers, IPlatform platform)
	{
		try
		{
			this.OnUsersAddedToConversation?.Invoke(currentUser, conversation, addedUsers, existingUsers, _ParticipantUtilities, platform);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	private void FireUsersRemovedFromConversationEvent(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> removedUsers)
	{
		try
		{
			this.OnUsersRemovedFromConversation?.Invoke(currentUser, conversation, removedUsers, _ParticipantUtilities);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	private string GenerateLeasedLockKeyForConversation(long conversationId)
	{
		return $"LeasedLock_ConversationId:{conversationId}";
	}

	private IConversation CreateOneToOneConversation(IUser firstUser, IUser secondUser, bool isSystemInitiated)
	{
		if (firstUser == null)
		{
			throw new PlatformArgumentNullException("User cannot be null in call to CreateOneToOneConversation");
		}
		ValidatedUsers validatedUsers = _ConversationParticipantValidator.GetValidatedParticipantsForSocialConversations(firstUser, (IReadOnlyCollection<IUser>)(object)new IUser[1] { secondUser }, ConversationType.OneToOneConversation);
		if (validatedUsers.RejectedUsers != null && validatedUsers.RejectedUsers.Any())
		{
			throw new ChatPlatformAuthorizationException("Unable to create one-to-one conversation, invited user failed validation: " + validatedUsers.RejectedUsers.First().Reason);
		}
		IConversation existingConversation = GetExistingOneToOneConversation(firstUser, secondUser);
		if (existingConversation != null)
		{
			return existingConversation;
		}
		IParticipant firstParticipant = _ParticipantUtilities.ToParticipant(firstUser);
		IParticipant secondParticipant = _ParticipantUtilities.ToParticipant(secondUser);
		string key = GetOnetoOneConversationCreationKey(firstParticipant, secondParticipant);
		using IRedisLeasedLock redisLeasedLock = _RedisLeasedLockFactory.CreateLeasedLock(key, TimeSpan.FromSeconds(2.0), delegate(Exception ex)
		{
			_Logger.Error(ex);
		});
		if (redisLeasedLock.TryAcquire())
		{
			existingConversation = GetExistingOneToOneConversation(firstUser, secondUser);
			if (existingConversation != null)
			{
				return existingConversation;
			}
			try
			{
				IConversationWithParticipants conversationEntity = _ConversationDataAccessor.CreateSocialConversation(_ParticipantUtilities.ToParticipant(firstUser), new List<IParticipant> { _ParticipantUtilities.ToParticipant(secondUser) }, ConversationType.OneToOneConversation);
				IUser creatorUser = (isSystemInitiated ? null : firstUser);
				FireNewConversationCreatedEvent(creatorUser, conversationEntity);
				long? conversationUniverseId = ((conversationEntity == null) ? null : _ConversationDataAccessor.GetConversationUniverseId(conversationEntity.Id));
				return conversationEntity.Translate(_ConversationTitleBuilder, firstUser, creatorUser, new IUser[2] { firstUser, secondUser }, conversationUniverseId);
			}
			catch (OneToOneConversationDuplicateException)
			{
			}
		}
		existingConversation = GetExistingOneToOneConversation(firstUser, secondUser);
		if (existingConversation == null)
		{
			throw new OneToOneConversationDuplicateException("Unable to create the conversation. It might already exist. Please retry");
		}
		return existingConversation;
	}

	private bool ShouldCreateNewConversation(string rawTitle, IParticipant initiatorParticipant, IParticipant[] newConversationParticipants, out IConversationWithParticipants existingConversation)
	{
		existingConversation = null;
		if (!_Settings.IsExistingChatGroupDeduplicationEnabled)
		{
			return true;
		}
		if (!string.IsNullOrEmpty(rawTitle))
		{
			return true;
		}
		if (!_UniqueConversationCache.ConversationExistsInCache(initiatorParticipant, newConversationParticipants, out var existingConversationId))
		{
			return true;
		}
		if (!existingConversationId.HasValue)
		{
			_Logger.Error("Conversation Id could not be found and unique conversation cache needs to return conversationAlreadyExists as false.");
			return true;
		}
		long existingConversationIdLong = existingConversationId.Value;
		if (existingConversationIdLong > 0)
		{
			existingConversation = _ConversationDataAccessor.GetConversationWithParticipants(existingConversationIdLong);
		}
		if (existingConversation == null)
		{
			if (Settings.Default.IsExistingChatGroupDeduplicationLoggingEnabled)
			{
				_Logger.Warning($"Conversation does not exists anymore and needs to be cleaned from the unique conversation cache. ConversationId : {existingConversationId}");
			}
			return true;
		}
		if (existingConversation.ConversationType != ConversationType.MultiUserConversation || !string.IsNullOrEmpty(existingConversation.Title) || existingConversation.Participants.Length != newConversationParticipants.Length + 1)
		{
			if (Settings.Default.IsExistingChatGroupDeduplicationLoggingEnabled)
			{
				_Logger.Warning("Wrong 'duplicate conversation' detected in redis : " + $"ExistingConversation [Id: {existingConversationId}, Title: {existingConversation.Title}, ConversationType: {existingConversation.ConversationType.ToString()}, NumOfParticipants: {existingConversation.Participants.Length}] " + $"NewConversationRequest [Title: {rawTitle}, NumOfParticipants: {newConversationParticipants.Length}]");
			}
			existingConversation = null;
			return true;
		}
		return false;
	}
}
