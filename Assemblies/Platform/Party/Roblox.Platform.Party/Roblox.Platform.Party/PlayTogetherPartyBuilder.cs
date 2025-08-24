using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.Assets;
using Roblox.Platform.Chat;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Party.Interface;
using Roblox.Platform.Party.Properties;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public class PlayTogetherPartyBuilder : PartyBuilder, IPlayTogetherPartyBuilder
{
	private IRedisClient _RedisClient { get; }

	private IUniverseFactory _UniverseFactory { get; }

	private IRedisLeasedLockFactory _RedisLeasedLockFactory { get; }

	private ILogger _Logger { get; }

	public PlayTogetherPartyBuilder(IRedisClient redisClient, IConversationFactory conversationFactory, IUniverseFactory universeFactory, IPartyMetricsTracker partyMetricsTracker, ILogger logger, IPartyChangeEventsHandler partyChangeEventsHandler, IRedisLeasedLockFactory redisLeasedLockFactory, IUserFactory userFactory)
		: base(conversationFactory, universeFactory, partyMetricsTracker, logger, partyChangeEventsHandler, userFactory)
	{
		_RedisClient = redisClient;
		_UniverseFactory = universeFactory;
		_RedisLeasedLockFactory = redisLeasedLockFactory;
		_Logger = logger;
	}

	public new IParty CreateParty(IUser partyCreator, IPlatform platform, long? conversationId, IReadOnlyCollection<IUser> pendingPartyMembers, IReadOnlyCollection<IUser> partyMembers)
	{
		return base.CreateParty(partyCreator, platform, conversationId, pendingPartyMembers, partyMembers);
	}

	protected override bool CanDeletePartyWithNoMembers()
	{
		return false;
	}

	public bool JoinParty(IPlatform platform, Guid partyId, IUser joiningUser)
	{
		return JoinParty(platform, partyId, joiningUser, autoFollowPartyLeader: false);
	}

	public new IParty InviteUser(IPlatform platform, Guid partyId, IUser currentUser, IUser invitedUser)
	{
		return base.InviteUser(platform, partyId, currentUser, invitedUser);
	}

	public new IParty LeaveCurrentParty(IPlatform platform, IUser leavingUser)
	{
		return base.LeaveCurrentParty(platform, leavingUser);
	}

	public void RemoveAllPartyMembers(IPlatform platform, Guid partyId)
	{
		Roblox.Platform.Party.Entities.Party party = Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId);
		long[] memberUserIds = party.MemberUserIds;
		foreach (long memberUserId in memberUserIds)
		{
			RemoveUserFromParty(platform, partyId, UserFactory.GetUser(memberUserId), switchToPendingUser: true);
		}
		GetNotificationPublisher().NotifyPartyMembersAndPendingUsers(party, PartyUpdateNotificationType.PartyLeftGame);
	}

	protected override Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId)
	{
		return Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId);
	}

	public new void JoinGame(IUser currentUser, IPlatform platform, IPlace joiningPlace, Guid gameId, DateTime gameSlotExpiry)
	{
		base.JoinGame(currentUser, platform, joiningPlace, gameId, gameSlotExpiry);
	}

	protected override void AddGameDetailsToPartyEntity(Guid partyId, long placeId, Guid gameId, DateTime gameSlotExpiry)
	{
		Roblox.Platform.Party.Entities.Party.AddGameDetails(_RedisClient, partyId, placeId, gameId, gameSlotExpiry);
	}

	protected override void AddConfirmedPartyMemberToPartyEntity(Guid partyId, long userId)
	{
		Roblox.Platform.Party.Entities.Party.AddConfirmedPartyMember(_RedisClient, partyId, userId);
	}

	protected override void AddPendingPartyMemberToPartyEntity(Guid partyId, long userId)
	{
		Roblox.Platform.Party.Entities.Party.AddPendingPartyMember(_RedisClient, partyId, userId);
	}

	protected override bool PartyBelongsToTheSameWalledGarden(Roblox.Platform.Party.Entities.Party party, IPlatform platform)
	{
		return party.WalledGarden == WalledGarden.PlayTogether;
	}

	protected override bool CanRemoveGameDetailsFromPartyWithNoMembers()
	{
		return true;
	}

	public new void OnUserSignout(IUser signedoutUser, IPlatform platform)
	{
		base.OnUserSignout(signedoutUser, platform);
	}

	protected override void ValidateMinimumPartyMemberCountForCreateParty(IPlatform platform, int partyMemberCount)
	{
		if (partyMemberCount <= 0)
		{
			throw new PlatformArgumentException($"Cannot create a {WalledGarden.PlayTogether} walled garden party with {partyMemberCount} members");
		}
	}

	protected override bool CanRemoveMembersFromParty(Roblox.Platform.Party.Entities.Party party, IUser userBeingRemoved, IUser currentUser, IPlatform platform)
	{
		if (userBeingRemoved.Id != currentUser.Id)
		{
			throw new PartyAuthorizationException("Only users can also remove themselves from a party.");
		}
		return true;
	}

	protected override Roblox.Platform.Party.Entities.Party CreateNewPartyEntity(long? conversationId, long partyCreatorId, long[] confirmedMemberIdsHashSet, long[] pendingMemberIdsHashSet, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.Party.CreateNew(_RedisClient, WalledGarden.PlayTogether, conversationId, partyCreatorId, partyCreatorId, confirmedMemberIdsHashSet, pendingMemberIdsHashSet);
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetCurrentUserParty(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, WalledGarden.PlayTogether);
	}

	protected override bool DoesPartyInvitationExist(Guid partyId, long userId, IPlatform platform)
	{
		return PartyInvitation.DoesPartyInvitationExist(_RedisClient, WalledGarden.PlayTogether, partyId, userId);
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetUserPartyEntityByUserIdAndWalledGarden(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, WalledGarden.PlayTogether);
	}

	protected override bool RemoveUserPartyEntity(IUser leavingUser, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.Remove(_RedisClient, leavingUser.Id, WalledGarden.PlayTogether);
	}

	protected override void CreateNewPartyInvitation(Guid partyId, IUser user, long leaderUserId, IPlatform platform)
	{
		PartyInvitation.CreateNew(_RedisClient, WalledGarden.PlayTogether, partyId, user.Id, leaderUserId);
	}

	protected override void MovePartyMemberFromConfirmedToPendingInPartyEntity(Guid partyId, long userId)
	{
		Roblox.Platform.Party.Entities.Party.MovePartyMemberFromConfirmedToPending(_RedisClient, partyId, userId);
	}

	protected override bool RemovePartyMemberFromPartyEntity(Guid partyId, long userId)
	{
		return Roblox.Platform.Party.Entities.Party.RemovePartyMember(_RedisClient, partyId, userId);
	}

	protected override void ChangePartyLeaderInPartyEntity(Guid partyId, long newLeaderId)
	{
		Roblox.Platform.Party.Entities.Party.ChangePartyLeader(_RedisClient, partyId, newLeaderId);
	}

	protected override bool DeletePartyEntity(Guid partyId)
	{
		return Roblox.Platform.Party.Entities.Party.DeleteParty(_RedisClient, partyId);
	}

	protected override void RemoveMappingFromConversationMap(long conversationId, WalledGarden walledGarden)
	{
		ConversationPartyMap.RemoveMapping(_RedisClient, conversationId, WalledGarden.PlayTogether);
	}

	protected override void RemoveGameDetailsFromPartyEntity(Guid partyId)
	{
		Roblox.Platform.Party.Entities.Party.RemoveGameDetails(_RedisClient, partyId);
	}

	protected override bool RemovePartyInvitation(Guid partyId, long userId, WalledGarden walledGarden)
	{
		return PartyInvitation.Remove(_RedisClient, WalledGarden.PlayTogether, partyId, userId);
	}

	protected override int GetPartyMemberLimit(IPlatform platform = null)
	{
		return Settings.Default.PartyMemberLimit;
	}

	protected override Guid? GetPartyIdFromConversationMap(long conversationId, IPlatform platform)
	{
		return ConversationPartyMap.GetPartyId(_RedisClient, conversationId, WalledGarden.PlayTogether);
	}

	protected override void MapConversationToParty(long conversationId, Guid partyId, WalledGarden walledGarden)
	{
		ConversationPartyMap.MapConversationToParty(_RedisClient, conversationId, partyId, WalledGarden.PlayTogether);
	}

	protected override void CreateAndNotifyNewPartyInvitation(Roblox.Platform.Party.Entities.Party party, long pendingPartyMemberId, long partyCreatorId, IPlatform platform)
	{
		PartyInvitation.CreateNew(_RedisClient, WalledGarden.PlayTogether, party.Id, pendingPartyMemberId, partyCreatorId);
		GetNotificationPublisher().NotifyPartyMember(party, pendingPartyMemberId, PartyUpdateNotificationType.InvitedToParty);
	}

	protected override Roblox.Platform.Party.Entities.UserParty CreateUserParty(Guid partyId, long userId, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.CreateNew(_RedisClient, userId, WalledGarden.PlayTogether, partyId, platform.DeviceType, autoFollowPartyLeader: true);
	}

	protected override bool LeadershipCanBeClaimedAtAnyTime(IPlatform platform)
	{
		return true;
	}

	protected override bool AddGameDetailsToParty(IUser user, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiry)
	{
		try
		{
			Roblox.Platform.Party.Entities.UserParty currentUserparty = GetCurrentUserParty(user, platform);
			if (currentUserparty == null)
			{
				return false;
			}
			Guid partyId = currentUserparty.PartyId;
			Roblox.Platform.Party.Entities.Party party = GetPartyEntity(partyId);
			if (party == null)
			{
				return false;
			}
			if (party.GamePlaceId.HasValue && party.GameId.HasValue)
			{
				return false;
			}
			using IRedisLeasedLock redisLeasedLock = Roblox.Platform.Party.Entities.Party.GetPartyRedisLeasedLock(_RedisLeasedLockFactory, _Logger, party.Id);
			if (redisLeasedLock.TryAcquire())
			{
				party = GetPartyEntity(partyId);
				if (party.GamePlaceId.HasValue && party.GameId.HasValue)
				{
					return false;
				}
				TakeLeadershipOfParty(platform, partyId, user);
				AddGameDetailsToPartyEntity(party.Id, place.Id, gameId, gameSlotExpiry);
				return true;
			}
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
		return false;
	}
}
