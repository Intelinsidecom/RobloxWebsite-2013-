using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Chat;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Party;

public abstract class PartyBuilder
{
	private readonly IConversationFactory _ConversationFactory;

	private readonly PartyUserNotificationPublisher _NotificationPublisher;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IPartyMetricsTracker _PartyMetricsTracker;

	private readonly IPartyChangeEventsHandler _PartyChangeEventsHandler;

	protected readonly IUserFactory UserFactory;

	protected PartyBuilder(IConversationFactory conversationFactory, IUniverseFactory universeFactory, IPartyMetricsTracker partyMetricsTracker, ILogger logger, IPartyChangeEventsHandler partyChangeEventsHandler, IUserFactory userFactory)
	{
		_ConversationFactory = conversationFactory;
		_UniverseFactory = universeFactory;
		_PartyMetricsTracker = partyMetricsTracker;
		_PartyChangeEventsHandler = partyChangeEventsHandler;
		UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_NotificationPublisher = new PartyUserNotificationPublisher(logger);
	}

	protected abstract void ChangePartyLeaderInPartyEntity(Guid partyId, long newLeaderId);

	protected abstract void ValidateMinimumPartyMemberCountForCreateParty(IPlatform platform, int partyMemberCount);

	protected abstract int GetPartyMemberLimit(IPlatform platform);

	protected abstract Guid? GetPartyIdFromConversationMap(long conversationId, IPlatform platform);

	protected abstract void MapConversationToParty(long conversationId, Guid partyId, WalledGarden walledGarden);

	protected abstract void CreateAndNotifyNewPartyInvitation(Roblox.Platform.Party.Entities.Party party, long pendingPartyMemberId, long partyCreatorId, IPlatform platform);

	protected abstract Roblox.Platform.Party.Entities.UserParty CreateUserParty(Guid partyId, long userId, IPlatform platform);

	protected abstract Roblox.Platform.Party.Entities.Party CreateNewPartyEntity(long? conversationId, long partyCreatorId, long[] confirmedMemberIdsHashSet, long[] pendingMemberIdsHashSet, IPlatform platform);

	protected abstract Roblox.Platform.Party.Entities.UserParty GetCurrentUserParty(IUser user, IPlatform platform);

	protected abstract Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId);

	protected abstract void AddGameDetailsToPartyEntity(Guid partyId, long placeId, Guid gameId, DateTime gameSlotExpiry);

	protected abstract bool DoesPartyInvitationExist(Guid partyId, long userId, IPlatform platform);

	protected abstract bool RemovePartyInvitation(Guid partyId, long userId, WalledGarden walledGarden);

	protected abstract void AddConfirmedPartyMemberToPartyEntity(Guid partyId, long userId);

	protected abstract bool CanRemoveMembersFromParty(Roblox.Platform.Party.Entities.Party party, IUser userBeingRemoved, IUser currentUser, IPlatform platform);

	protected abstract void AddPendingPartyMemberToPartyEntity(Guid partyId, long userId);

	protected abstract Roblox.Platform.Party.Entities.UserParty GetUserPartyEntityByUserIdAndWalledGarden(IUser user, IPlatform platform);

	protected abstract bool RemoveUserPartyEntity(IUser leavingUser, IPlatform platform);

	protected abstract void CreateNewPartyInvitation(Guid partyId, IUser user, long leaderUserId, IPlatform platform);

	protected abstract void MovePartyMemberFromConfirmedToPendingInPartyEntity(Guid partyId, long userId);

	protected abstract bool RemovePartyMemberFromPartyEntity(Guid partyId, long userId);

	protected abstract bool DeletePartyEntity(Guid partyId);

	protected abstract bool PartyBelongsToTheSameWalledGarden(Roblox.Platform.Party.Entities.Party party, IPlatform platform);

	protected abstract bool CanDeletePartyWithNoMembers();

	protected abstract bool AddGameDetailsToParty(IUser user, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiry);

	protected abstract void RemoveGameDetailsFromPartyEntity(Guid partyId);

	protected abstract bool LeadershipCanBeClaimedAtAnyTime(IPlatform platform);

	protected abstract void RemoveMappingFromConversationMap(long conversationId, WalledGarden walledGarden);

	protected abstract bool CanRemoveGameDetailsFromPartyWithNoMembers();

	/// <summary>
	/// If the user is signing out from the device type they joined their current party from, then remove them from it
	/// </summary>
	/// <param name="user"></param>
	/// <param name="platform"></param>
	protected void OnUserSignout(IUser user, IPlatform platform)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		Roblox.Platform.Party.Entities.UserParty currentParty = GetCurrentUserParty(user, platform);
		if (currentParty != null && currentParty.DeviceType == platform.DeviceType)
		{
			RemoveUserFromCurrentParty(user, null, platform);
		}
	}

	protected Roblox.Platform.Party.Entities.Party RemoveUserFromCurrentParty(IUser userToBeRemoved, Guid? newPartyId, IPlatform platform, bool switchToPendingUser = true)
	{
		Roblox.Platform.Party.Entities.UserParty currentPartyForUser = GetUserPartyEntityByUserIdAndWalledGarden(userToBeRemoved, platform);
		if (currentPartyForUser != null && currentPartyForUser.PartyId != newPartyId)
		{
			return RemoveUserFromParty(platform, currentPartyForUser.PartyId, userToBeRemoved, switchToPendingUser);
		}
		return null;
	}

	protected Roblox.Platform.Party.Entities.Party RemoveUserFromParty(IPlatform platform, Guid partyId, IUser leavingUser, bool switchToPendingUser)
	{
		Roblox.Platform.Party.Entities.UserParty userParty = GetUserPartyEntityByUserIdAndWalledGarden(leavingUser, platform);
		if (userParty != null && userParty.PartyId == partyId)
		{
			RemoveUserPartyEntity(leavingUser, platform);
		}
		bool shouldDeleteParty = false;
		Roblox.Platform.Party.Entities.Party party = GetPartyEntity(partyId);
		if (party == null)
		{
			return null;
		}
		if (GetPartyConversationType(party) == PartyConversationType.OneToOneConversation)
		{
			shouldDeleteParty = true;
		}
		if (switchToPendingUser)
		{
			MovePartyMemberFromConfirmedToPendingInPartyEntity(partyId, leavingUser.Id);
		}
		else
		{
			RemovePartyMemberFromPartyEntity(partyId, leavingUser.Id);
		}
		if (shouldDeleteParty || party.MemberUserIds.Length == 1)
		{
			if (CanDeletePartyWithNoMembers())
			{
				_PartyChangeEventsHandler.OnPartyReadyToBeDeleted(partyId);
			}
			if (CanRemoveGameDetailsFromPartyWithNoMembers())
			{
				RemoveGameDetailsFromPartyEntity(partyId);
			}
		}
		long leaderUserId = party.LeaderUserId;
		if (party.LeaderUserId == leavingUser.Id && party.MemberUserIds.Length > 1)
		{
			leaderUserId = party.MemberUserIds.First((long userId) => userId != leavingUser.Id);
			ChangePartyLeaderInPartyEntity(partyId, leaderUserId);
		}
		if (switchToPendingUser)
		{
			CreateNewPartyInvitation(partyId, leavingUser, leaderUserId, platform);
		}
		else
		{
			RemovePartyInvitation(partyId, leavingUser.Id, party.WalledGarden);
		}
		Roblox.Platform.Party.Entities.Party partyEntity = GetPartyEntity(partyId);
		_NotificationPublisher.NotifyPartyMembersAndPendingUsers(party, PartyUpdateNotificationType.PartyUserLeft, leavingUser.Id);
		_NotificationPublisher.NotifyPartyMember(party, leavingUser.Id, PartyUpdateNotificationType.ILeftParty);
		_PartyChangeEventsHandler.OnPartyMemberLeft(partyId, leavingUser);
		return partyEntity;
	}

	protected PartyUserNotificationPublisher GetNotificationPublisher()
	{
		return _NotificationPublisher;
	}

	protected IParty CreateParty(IUser partyCreator, IPlatform platform, long? conversationId, IReadOnlyCollection<IUser> pendingPartyMembers, IReadOnlyCollection<IUser> partyMembers)
	{
		if (partyCreator == null)
		{
			throw new PlatformArgumentNullException("Party creator cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (pendingPartyMembers == null || pendingPartyMembers.Any((IUser partyMember) => partyMember == null))
		{
			throw new PlatformArgumentException("Pending party members cannot be null");
		}
		if (partyMembers == null || partyMembers.Any((IUser partyMember) => partyMember == null))
		{
			throw new PlatformArgumentException("Party members cannot be null");
		}
		int totalCount = partyMembers.Count + pendingPartyMembers.Count;
		ValidateMinimumPartyMemberCountForCreateParty(platform, totalCount);
		int partyMemberLimit = GetPartyMemberLimit(platform);
		if (totalCount > partyMemberLimit)
		{
			throw new PartyFullException("Party member limit exceeded.");
		}
		if (conversationId.HasValue && conversationId.Value > 0)
		{
			if (!(_ConversationFactory.GetConversation(conversationId.Value) ?? throw new PlatformArgumentNullException("Conversation does not exist")).ParticipantUsers.Any((IUser participantUser) => participantUser.Id == partyCreator.Id))
			{
				throw new PartyAuthorizationException("Party creator is not part of the conversation!");
			}
			Guid? partyId = GetPartyIdFromConversationMap(conversationId.Value, platform);
			if (partyId.HasValue)
			{
				Roblox.Platform.Party.Entities.Party party = GetPartyEntity(partyId.Value);
				if (party != null)
				{
					if (party.MemberUserIds.Length != 0 || !CanDeletePartyWithNoMembers())
					{
						throw new PartyAuthorizationException("This conversation is already associated with a party");
					}
					_PartyChangeEventsHandler.OnPartyReadyToBeDeleted(party.Id);
				}
			}
		}
		List<IUser> confirmedMembers = new List<IUser>(partyMembers);
		HashSet<long> confirmedMemberIdsHashSet = new HashSet<long>(confirmedMembers.Select((IUser partyMember) => partyMember.Id));
		if (!confirmedMemberIdsHashSet.Contains(partyCreator.Id))
		{
			confirmedMembers.Add(partyCreator);
		}
		confirmedMemberIdsHashSet.Add(partyCreator.Id);
		foreach (IUser confirmedPartyMember in confirmedMembers)
		{
			RemoveUserFromCurrentParty(confirmedPartyMember, null, platform);
		}
		HashSet<long> pendingMemberIdsHashSet = new HashSet<long>(pendingPartyMembers.Select((IUser partyMember) => partyMember.Id));
		Roblox.Platform.Party.Entities.Party newParty = CreateNewPartyEntity(conversationId, partyCreator.Id, confirmedMemberIdsHashSet.ToArray(), pendingMemberIdsHashSet.ToArray(), platform);
		CreateUserParty(newParty.Id, newParty.CreatorUserId, platform);
		foreach (long pendingPartyMemberId in pendingMemberIdsHashSet)
		{
			CreateAndNotifyNewPartyInvitation(newParty, pendingPartyMemberId, partyCreator.Id, platform);
		}
		if (conversationId.HasValue && conversationId.Value > 0)
		{
			MapConversationToParty(conversationId.Value, newParty.Id, newParty.WalledGarden);
		}
		_PartyMetricsTracker.RecordPartyCreation(platform.DeviceType);
		_PartyMetricsTracker.RecordPartyUserJoined(platform.DeviceType, confirmedMembers.Count);
		_PartyChangeEventsHandler.OnPartyCreated(newParty.Id);
		return new Party
		{
			ConversationId = newParty.ConversationId,
			CreatorUser = partyCreator,
			LeaderUser = partyCreator,
			Id = newParty.Id,
			PendingUsers = pendingPartyMembers,
			MemberUsers = confirmedMembers,
			GameId = null,
			GamePlaceId = null,
			GameSlotExpiry = null
		};
	}

	protected void JoinGame(IUser currentUser, IPlatform platform, IPlace joiningPlace, Guid gameId, DateTime gameSlotExpiry)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("Current user cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		Roblox.Platform.Party.Entities.UserParty currentUserParty = GetCurrentUserParty(currentUser, platform);
		if (currentUserParty == null)
		{
			throw new PlatformArgumentException("The current user is not in any party.");
		}
		Roblox.Platform.Party.Entities.Party party = GetPartyEntity(currentUserParty.PartyId);
		if (party == null)
		{
			throw new PlatformArgumentException("The current user's party is no longer active");
		}
		if (joiningPlace == null)
		{
			throw new PlatformArgumentException("Place cannot be null in call to join party into a game");
		}
		if (party.GamePlaceId.HasValue && party.GamePlaceId.Value != joiningPlace.Id)
		{
			IUniverse placeUniverse = _UniverseFactory.GetPlaceUniverse(joiningPlace.Id);
			IUniverse currentPlaceUniverse = _UniverseFactory.GetPlaceUniverse(party.GamePlaceId.Value);
			if (placeUniverse.Id == currentPlaceUniverse.Id)
			{
				return;
			}
		}
		if (AddGameDetailsToParty(currentUser, platform, joiningPlace, gameId, gameSlotExpiry))
		{
			_PartyMetricsTracker.RecordPartyJoinedGame(platform.DeviceType, party.MemberUserIds.Length);
			_NotificationPublisher.NotifyPartyMembersAndPendingUsers(party, PartyUpdateNotificationType.PartyJoinedGame);
		}
	}

	protected bool JoinParty(IPlatform platform, Guid partyId, IUser joiningUser, bool autoFollowPartyLeader)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (joiningUser == null)
		{
			throw new PlatformArgumentNullException("acceptingUser cannot be null");
		}
		if (!DoesPartyInvitationExist(partyId, joiningUser.Id, platform))
		{
			throw new PartyAuthorizationException("Unauthorized party join call. User was never invited to the party");
		}
		RemoveUserFromCurrentParty(joiningUser, partyId, platform);
		AddConfirmedPartyMemberToPartyEntity(partyId, joiningUser.Id);
		Roblox.Platform.Party.Entities.UserParty userParty = CreateUserParty(partyId, joiningUser.Id, platform);
		bool num = RemovePartyInvitation(partyId, joiningUser.Id, platform.ToWalledGarden());
		Roblox.Platform.Party.Entities.Party updatedParty = GetPartyEntity(partyId);
		_NotificationPublisher.NotifyPartyMembersAndPendingUsers(updatedParty, PartyUpdateNotificationType.PartyUserJoined, joiningUser.Id);
		_NotificationPublisher.NotifyPartyMember(updatedParty, joiningUser.Id, PartyUpdateNotificationType.IJoinedParty);
		_PartyMetricsTracker.RecordPartyUserJoined(platform.DeviceType);
		_PartyChangeEventsHandler.OnPartyInvitationAccepted(partyId, joiningUser);
		if (num)
		{
			return userParty != null;
		}
		return false;
	}

	protected IParty InviteUser(IPlatform platform, Guid partyId, IUser currentUser, IUser invitedUser)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (currentUser == null || invitedUser == null)
		{
			throw new PlatformArgumentNullException("Current user and invited user cannot be null");
		}
		Roblox.Platform.Party.Entities.Party existingParty = GetPartyEntity(partyId);
		if (existingParty == null)
		{
			throw new PlatformArgumentException("Party does not exist");
		}
		if (!PartyBelongsToTheSameWalledGarden(existingParty, platform))
		{
			throw new PlatformArgumentException("Party belongs to a different walled garden");
		}
		if (!existingParty.MemberUserIds.Contains(currentUser.Id) && !existingParty.PendingUserIds.Contains(currentUser.Id))
		{
			throw new PartyAuthorizationException("Only users already invited to the party can invite users");
		}
		if (existingParty.MemberUserIds.Contains(invitedUser.Id))
		{
			throw new PlatformInvalidOperationException("The invited user is already a member of this party");
		}
		int num = existingParty.MemberUserIds.Length + existingParty.PendingUserIds.Length;
		int partyMemberLimit = GetPartyMemberLimit(platform);
		if (num == partyMemberLimit)
		{
			throw new PartyFullException("Party is full");
		}
		AddPendingPartyMemberToPartyEntity(partyId, invitedUser.Id);
		CreateAndNotifyNewPartyInvitation(existingParty, invitedUser.Id, currentUser.Id, platform);
		_PartyChangeEventsHandler.OnPartyInvitationSent(partyId, invitedUser);
		Party party = existingParty.Translate(_UniverseFactory, UserFactory);
		List<IUser> pendingUsers = new List<IUser>(party.PendingUsers) { invitedUser };
		party.PendingUsers = pendingUsers;
		return party;
	}

	protected void LeaveGameIfInSameUniverse(Roblox.Platform.Party.Entities.Party party, IUser currentUser, IPlace placeLeft)
	{
		if (party.LeaderUserId == currentUser.Id && party.GamePlaceId.HasValue)
		{
			IUniverse universeLeft = _UniverseFactory.GetPlaceUniverse(placeLeft.Id);
			IUniverse currentPartyUniverse = _UniverseFactory.GetPlaceUniverse(party.GamePlaceId.Value);
			if (universeLeft != null && currentPartyUniverse != null && universeLeft.Id == currentPartyUniverse.Id)
			{
				RemoveGameDetailsFromPartyEntity(party.Id);
				_NotificationPublisher.NotifyPartyMembersAndPendingUsers(party, PartyUpdateNotificationType.PartyLeftGame);
			}
		}
	}

	protected PartyConversationType GetPartyConversationType(Roblox.Platform.Party.Entities.Party party)
	{
		PartyConversationType partyConversationType = PartyConversationType.NoConversation;
		if (party.ConversationId.HasValue)
		{
			IConversation conversation = _ConversationFactory.GetConversation(party.ConversationId.Value);
			if (conversation == null)
			{
				return PartyConversationType.NoConversation;
			}
			partyConversationType = ((!conversation.IsGroupChat) ? PartyConversationType.OneToOneConversation : PartyConversationType.GroupConversation);
		}
		return partyConversationType;
	}

	protected IParty LeaveCurrentParty(IPlatform platform, IUser leavingUser)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (leavingUser == null)
		{
			throw new PlatformArgumentNullException("Leaving user cannot be null");
		}
		Roblox.Platform.Party.Entities.UserParty userParty = GetUserPartyEntityByUserIdAndWalledGarden(leavingUser, platform);
		if (userParty == null)
		{
			return null;
		}
		return RemoveUserFromParty(platform, userParty.PartyId, leavingUser, switchToPendingUser: true)?.Translate(_UniverseFactory, UserFactory);
	}

	/// <summary>
	/// The specified user takes leadership of the party.
	/// </summary>
	/// <param name="platform">The platform the user is on</param>
	/// <param name="partyId">The party the user wishes to be leader of. The user must be a member of that party</param>
	/// <param name="userToBeLeader">User who wishes to be leader</param>
	public void TakeLeadershipOfParty(IPlatform platform, Guid partyId, IUser userToBeLeader)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "platform"));
		}
		if (userToBeLeader == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "userToBeLeader"));
		}
		Roblox.Platform.Party.Entities.Party party = GetPartyEntity(partyId);
		if (party == null)
		{
			throw new PlatformArgumentException("Party does not exist");
		}
		if (!PartyBelongsToTheSameWalledGarden(party, platform))
		{
			throw new PlatformArgumentException("Party belongs to a different walled garden");
		}
		if (!party.MemberUserIds.Contains(userToBeLeader.Id))
		{
			throw new PartyAuthorizationException("Only users already in a party can claim the leadership");
		}
		if (party.LeaderUserId != userToBeLeader.Id)
		{
			if (!LeadershipCanBeClaimedAtAnyTime(platform))
			{
				throw new PartyAuthorizationException($"Leadership can not be taken at any time in parties within the '{party.WalledGarden}' walled garden");
			}
			ChangePartyLeaderInPartyEntity(partyId, userToBeLeader.Id);
		}
	}
}
