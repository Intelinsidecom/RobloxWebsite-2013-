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
using Roblox.Platform.Party.Interface;
using Roblox.Platform.Party.Properties;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Party;

public class UserPartyBuilder : PartyBuilder, IUserPartyBuilder
{
	private readonly IRedisClient _RedisClient;

	private readonly List<WalledGarden> _AllWalledGardens;

	private readonly IUniverseFactory _UniverseFactory;

	public UserPartyBuilder(IRedisClient redisClient, IConversationFactory conversationFactory, IUniverseFactory universeFactory, IPartyMetricsTracker partyMetricsTracker, ILogger logger, IPartyChangeEventsHandler partyChangeEventsHandler, IUserFactory userFactory)
		: base(conversationFactory, universeFactory, partyMetricsTracker, logger, partyChangeEventsHandler, userFactory)
	{
		_RedisClient = redisClient;
		_UniverseFactory = universeFactory;
		_AllWalledGardens = Enum.GetValues(typeof(WalledGarden)).OfType<WalledGarden>().ToList();
	}

	public new IParty CreateParty(IUser partyCreator, IPlatform platform, long? conversationId, IReadOnlyCollection<IUser> pendingPartyMembers, IReadOnlyCollection<IUser> partyMembers)
	{
		return base.CreateParty(partyCreator, platform, conversationId, pendingPartyMembers, partyMembers);
	}

	protected override bool CanDeletePartyWithNoMembers()
	{
		return true;
	}

	protected override bool PartyBelongsToTheSameWalledGarden(Roblox.Platform.Party.Entities.Party party, IPlatform platform)
	{
		return platform.ToWalledGarden() == party.WalledGarden;
	}

	protected override bool CanRemoveGameDetailsFromPartyWithNoMembers()
	{
		return false;
	}

	public new void OnUserSignout(IUser signedoutUser, IPlatform platform)
	{
		base.OnUserSignout(signedoutUser, platform);
	}

	public void DeleteParty(Guid partyId)
	{
		Roblox.Platform.Party.Entities.Party party = GetPartyEntity(partyId);
		if (party != null && (GetPartyConversationType(party) == PartyConversationType.OneToOneConversation || party.MemberUserIds.Length == 0))
		{
			DeleteParty(party);
		}
	}

	private void DeleteParty(Roblox.Platform.Party.Entities.Party party)
	{
		DeletePartyEntity(party.Id);
		long[] pendingUserIds = party.PendingUserIds;
		foreach (long userId in pendingUserIds)
		{
			RemovePartyInvitation(party.Id, userId, party.WalledGarden);
			GetNotificationPublisher().NotifyPartyMember(party, userId, PartyUpdateNotificationType.PartyDeleted);
		}
		pendingUserIds = party.MemberUserIds;
		foreach (long userId2 in pendingUserIds)
		{
			RemovePartyInvitation(party.Id, userId2, party.WalledGarden);
			GetNotificationPublisher().NotifyPartyMember(party, userId2, PartyUpdateNotificationType.PartyDeleted);
		}
		if (party.ConversationId.HasValue)
		{
			RemoveMappingFromConversationMap(party.ConversationId.Value, party.WalledGarden);
		}
	}

	public bool UpdateUserDevice(IUser user, IPlatform platform)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		WalledGarden walledGarden = platform.ToWalledGarden();
		Roblox.Platform.Party.Entities.UserParty userParty = GetUserPartyEntityByUserIdAndWalledGarden(user, platform);
		if (userParty == null)
		{
			throw new PartyAuthorizationException("The user is not in a party.");
		}
		Roblox.Platform.Party.Entities.UserParty.UpdateUserPartyDeviceType(_RedisClient, user.Id, walledGarden, platform.DeviceType);
		Roblox.Platform.Party.Entities.Party party = Roblox.Platform.Party.Entities.Party.Get(_RedisClient, userParty.PartyId);
		GetNotificationPublisher().NotifyPartyMember(party, user.Id, PartyUpdateNotificationType.PartyUserDeviceUpdated);
		return true;
	}

	public new void TakeLeadershipOfParty(IPlatform platform, Guid partyId, IUser userToBeLeader)
	{
		base.TakeLeadershipOfParty(platform, partyId, userToBeLeader);
	}

	public new bool JoinParty(IPlatform platform, Guid partyId, IUser joiningUser, bool autoFollowPartyLeader)
	{
		return base.JoinParty(platform, partyId, joiningUser, autoFollowPartyLeader);
	}

	public void LeaveGame(IUser user, IPlace placeLeft)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "user"));
		}
		if (placeLeft == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "placeLeft"));
		}
		foreach (WalledGarden walledGarden in _AllWalledGardens)
		{
			Roblox.Platform.Party.Entities.UserParty currentUserParty = Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, walledGarden);
			if (currentUserParty != null)
			{
				Roblox.Platform.Party.Entities.Party party = Roblox.Platform.Party.Entities.Party.Get(_RedisClient, currentUserParty.PartyId);
				if (party != null)
				{
					LeaveGameIfInSameUniverse(party, user, placeLeft);
				}
			}
		}
	}

	public new void JoinGame(IUser currentUser, IPlatform platform, IPlace joiningPlace, Guid gameId, DateTime gameSlotExpiry)
	{
		base.JoinGame(currentUser, platform, joiningPlace, gameId, gameSlotExpiry);
	}

	public IParty LeaveParty(IPlatform platform, Guid partyId, IUser leavingUser)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (leavingUser == null)
		{
			throw new PlatformArgumentNullException("Leaving user cannot be null");
		}
		Roblox.Platform.Party.Entities.UserParty userParty = GetCurrentUserParty(leavingUser, platform);
		if (userParty == null || userParty.PartyId != partyId)
		{
			throw new PartyAuthorizationException("Leaving user is not part of the party");
		}
		return RemoveUserFromParty(platform, partyId, leavingUser, switchToPendingUser: true).Translate(_UniverseFactory, UserFactory);
	}

	public IParty RemoveFromParty(IPlatform platform, Guid partyId, IUser currentUser, IUser userBeingRemoved)
	{
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		if (currentUser == null || userBeingRemoved == null)
		{
			throw new PlatformArgumentNullException("Current user and user being removed should be non-null values");
		}
		Roblox.Platform.Party.Entities.Party obj = Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId) ?? throw new PlatformArgumentException("Party does not exist");
		if (obj.LeaderUserId != currentUser.Id && userBeingRemoved.Id != currentUser.Id)
		{
			throw new PartyAuthorizationException("Only party leader can remove users from a party. Users can also remove themselves from a party.");
		}
		bool isConfirmedMember = obj.MemberUserIds.Any((long userId) => userId == userBeingRemoved.Id);
		bool isPendingMember = obj.PendingUserIds.Any((long userId) => userId == userBeingRemoved.Id);
		if (!isConfirmedMember && !isPendingMember)
		{
			throw new PartyAuthorizationException("User is not part of the party");
		}
		return RemoveUserFromParty(platform, partyId, userBeingRemoved, switchToPendingUser: false).Translate(_UniverseFactory, UserFactory);
	}

	public new IParty InviteUser(IPlatform platform, Guid partyId, IUser currentUser, IUser invitedUser)
	{
		return base.InviteUser(platform, partyId, currentUser, invitedUser);
	}

	public new IParty LeaveCurrentParty(IPlatform platform, IUser leavingUser)
	{
		return base.LeaveCurrentParty(platform, leavingUser);
	}

	protected override void MapConversationToParty(long conversationId, Guid partyId, WalledGarden walledGarden)
	{
		ConversationPartyMap.MapConversationToParty(_RedisClient, conversationId, partyId, walledGarden);
	}

	protected override Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId)
	{
		return Roblox.Platform.Party.Entities.Party.Get(_RedisClient, partyId);
	}

	protected override void ValidateMinimumPartyMemberCountForCreateParty(IPlatform platform, int partyMemberCount)
	{
		bool isValidCount = true;
		WalledGarden walledGarden = platform.ToWalledGarden();
		switch (walledGarden)
		{
		case WalledGarden.Xbox:
			isValidCount = partyMemberCount >= 0;
			break;
		case WalledGarden.General:
			isValidCount = partyMemberCount >= 1;
			break;
		}
		if (!isValidCount)
		{
			throw new PlatformArgumentException($"Cannot create a {walledGarden} walled garden party with {partyMemberCount} members");
		}
	}

	protected override Guid? GetPartyIdFromConversationMap(long conversationId, IPlatform platform)
	{
		return ConversationPartyMap.GetPartyId(_RedisClient, conversationId, platform.ToWalledGarden());
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetUserPartyEntityByUserIdAndWalledGarden(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, platform.ToWalledGarden());
	}

	protected override bool RemoveUserPartyEntity(IUser leavingUser, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.Remove(_RedisClient, leavingUser.Id, platform.ToWalledGarden());
	}

	protected override void CreateNewPartyInvitation(Guid partyId, IUser user, long leaderUserId, IPlatform platform)
	{
		PartyInvitation.CreateNew(_RedisClient, platform.ToWalledGarden(), partyId, user.Id, leaderUserId);
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
		ConversationPartyMap.RemoveMapping(_RedisClient, conversationId, walledGarden);
	}

	protected override void RemoveGameDetailsFromPartyEntity(Guid partyId)
	{
		Roblox.Platform.Party.Entities.Party.RemoveGameDetails(_RedisClient, partyId);
	}

	protected override void CreateAndNotifyNewPartyInvitation(Roblox.Platform.Party.Entities.Party party, long pendingPartyMemberId, long partyCreatorId, IPlatform platform)
	{
		WalledGarden walledGarden = platform.ToWalledGarden();
		PartyInvitation.CreateNew(_RedisClient, walledGarden, party.Id, pendingPartyMemberId, partyCreatorId);
		GetNotificationPublisher().NotifyPartyMember(party, pendingPartyMemberId, PartyUpdateNotificationType.InvitedToParty);
	}

	protected override Roblox.Platform.Party.Entities.UserParty CreateUserParty(Guid partyId, long userId, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.CreateNew(_RedisClient, userId, platform.ToWalledGarden(), partyId, platform.DeviceType, autoFollowPartyLeader: true);
	}

	protected override Roblox.Platform.Party.Entities.Party CreateNewPartyEntity(long? conversationId, long partyCreatorId, long[] confirmedMemberIdsHashSet, long[] pendingMemberIdsHashSet, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.Party.CreateNew(_RedisClient, platform.ToWalledGarden(), conversationId, partyCreatorId, partyCreatorId, confirmedMemberIdsHashSet, pendingMemberIdsHashSet);
	}

	protected override Roblox.Platform.Party.Entities.UserParty GetCurrentUserParty(IUser user, IPlatform platform)
	{
		return Roblox.Platform.Party.Entities.UserParty.GetUserPartyByUserIdAndWalledGarden(_RedisClient, user.Id, platform.ToWalledGarden());
	}

	protected override void AddGameDetailsToPartyEntity(Guid partyId, long placeId, Guid gameId, DateTime gameSlotExpiry)
	{
		Roblox.Platform.Party.Entities.Party.AddGameDetails(_RedisClient, partyId, placeId, gameId, gameSlotExpiry);
	}

	protected override bool DoesPartyInvitationExist(Guid partyId, long userId, IPlatform platform)
	{
		return PartyInvitation.DoesPartyInvitationExist(_RedisClient, platform.ToWalledGarden(), partyId, userId);
	}

	protected override bool RemovePartyInvitation(Guid partyId, long userId, WalledGarden walledGarden)
	{
		return PartyInvitation.Remove(_RedisClient, walledGarden, partyId, userId);
	}

	protected override void AddConfirmedPartyMemberToPartyEntity(Guid partyId, long userId)
	{
		Roblox.Platform.Party.Entities.Party.AddConfirmedPartyMember(_RedisClient, partyId, userId);
	}

	protected override void AddPendingPartyMemberToPartyEntity(Guid partyId, long userId)
	{
		Roblox.Platform.Party.Entities.Party.AddPendingPartyMember(_RedisClient, partyId, userId);
	}

	protected override bool CanRemoveMembersFromParty(Roblox.Platform.Party.Entities.Party party, IUser userBeingRemoved, IUser currentUser, IPlatform platform)
	{
		if (party.LeaderUserId != currentUser.Id && userBeingRemoved.Id != currentUser.Id)
		{
			throw new PartyAuthorizationException("Only party leader can remove users from a party. Users can also remove themselves from a party.");
		}
		return true;
	}

	protected override int GetPartyMemberLimit(IPlatform platform)
	{
		if (platform.ToWalledGarden() != WalledGarden.Xbox)
		{
			return Settings.Default.PartyMemberLimit;
		}
		return Settings.Default.XboxPartyMemberLimit;
	}

	protected override bool LeadershipCanBeClaimedAtAnyTime(IPlatform platform)
	{
		return platform.ToWalledGarden() switch
		{
			WalledGarden.General => false, 
			WalledGarden.Xbox => Settings.Default.AllowLeadershipToBeClaimedAtAnyTimeForXboxWalledGarden, 
			_ => false, 
		};
	}

	protected override bool AddGameDetailsToParty(IUser user, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiry)
	{
		Roblox.Platform.Party.Entities.UserParty currentUserParty = GetCurrentUserParty(user, platform);
		if (currentUserParty == null)
		{
			return false;
		}
		Roblox.Platform.Party.Entities.Party party = GetPartyEntity(currentUserParty.PartyId);
		if (party == null)
		{
			return false;
		}
		if (party.LeaderUserId != user.Id)
		{
			throw new PartyAuthorizationException("Only party leader can move an entire party into a game");
		}
		AddGameDetailsToPartyEntity(party.Id, place.Id, gameId, gameSlotExpiry);
		return true;
	}
}
