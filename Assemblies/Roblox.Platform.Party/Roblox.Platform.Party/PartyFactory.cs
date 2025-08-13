using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Party;

public abstract class PartyFactory
{
	private readonly IUniverseFactory _UniverseFactory;

	private readonly IUserFactory _UserFactory;

	protected PartyFactory(IUniverseFactory universeFactory, IUserFactory userFactory)
	{
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	protected abstract Guid[] GetPartyInvitations(IUser user, int startRow, int maxRows, IPlatform platform);

	protected IReadOnlyCollection<IParty> GetPendingPartiesForUser(IUser currentUser, IPlatform platform, int startRow, int maxRows)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		Guid[] partyIds = GetPartyInvitations(currentUser, startRow, maxRows, platform);
		return GetPartiesFromPartyIds((IReadOnlyCollection<Guid>)(object)partyIds);
	}

	protected IReadOnlyCollection<IParty> GetFilteredPartiesForUser(IUser currentUser, Guid[] partyIds)
	{
		IReadOnlyCollection<IParty> partiesFromPartyIds = GetPartiesFromPartyIds((IReadOnlyCollection<Guid>)(object)partyIds);
		List<IParty> filteredParties = new List<IParty>(partiesFromPartyIds.Count);
		foreach (IParty party in partiesFromPartyIds)
		{
			if (party.PendingUsers.Any((IUser user) => user.Id == currentUser.Id) || party.MemberUsers.Any((IUser user) => user.Id == currentUser.Id))
			{
				filteredParties.Add(party);
			}
		}
		return filteredParties;
	}

	protected abstract Guid?[] GetPartyIdsFromConversationMap(long[] conversationIds, IPlatform platform);

	protected IReadOnlyCollection<IParty> GetPartiesForConversationIds(IUser currentUser, long[] conversationIds, IPlatform platform)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser cannot be null");
		}
		Guid[] partyIds = (from partyId in GetPartyIdsFromConversationMap(conversationIds, platform)
			where partyId.HasValue
			select partyId.Value).ToArray();
		return GetFilteredPartiesForUser(currentUser, partyIds);
	}

	protected abstract Roblox.Platform.Party.Entities.UserParty GetUserPartyByUserId(IUser user, IPlatform platform);

	protected IUserParty GetCurrentPartyForUser(IUser currentUser, IPlatform platform)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("acceptingUser cannot be null");
		}
		if (platform == null)
		{
			throw new PlatformArgumentNullException("Platform cannot be null");
		}
		Roblox.Platform.Party.Entities.UserParty userParty = GetUserPartyByUserId(currentUser, platform);
		if (userParty == null)
		{
			return null;
		}
		Roblox.Platform.Party.Entities.Party partyEntity = GetPartyEntity(userParty.PartyId);
		if (partyEntity == null)
		{
			return null;
		}
		Party party = partyEntity.Translate(_UniverseFactory, _UserFactory);
		return new UserParty
		{
			Party = party,
			AutoFollowPartyLeader = userParty.AutoFollowPartyLeader,
			IsPartyLeader = (partyEntity.LeaderUserId == currentUser.Id),
			DeviceType = userParty.DeviceType
		};
	}

	protected IParty GetPartyById(Guid partyId)
	{
		return GetPartyEntity(partyId)?.Translate(_UniverseFactory, _UserFactory);
	}

	protected abstract DateTime? GetPartyInvitationDate(Guid partyId, WalledGarden walledGarden, IUser user);

	protected DateTime? GetPartyInvitationDate(IUser currentUser, IParty party)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser cannot be null");
		}
		if (party == null)
		{
			throw new PlatformArgumentNullException("party cannot be null");
		}
		return GetPartyInvitationDate(party.Id, party.WalledGarden, currentUser);
	}

	protected DateTime? GetPartyJoinDate(IUser currentUser, IParty party)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser cannot be null");
		}
		if (party == null)
		{
			throw new PlatformArgumentNullException("party cannot be null");
		}
		return GetPartyMemberJoinTimeFromPartyEntity(party.Id, currentUser.Id);
	}

	protected abstract DateTime? GetPartyMemberJoinTimeFromPartyEntity(Guid partyId, long userId);

	protected abstract Roblox.Platform.Party.Entities.Party GetPartyEntity(Guid partyId);

	private IReadOnlyCollection<IParty> GetPartiesFromPartyIds(IReadOnlyCollection<Guid> partyIds)
	{
		List<IParty> parties = new List<IParty>(partyIds.Count);
		foreach (Guid partyId in partyIds)
		{
			Roblox.Platform.Party.Entities.Party partyEntity = GetPartyEntity(partyId);
			if (partyEntity != null)
			{
				parties.Add(partyEntity.Translate(_UniverseFactory, _UserFactory));
			}
		}
		return parties;
	}
}
