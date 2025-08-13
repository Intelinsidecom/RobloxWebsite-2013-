using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Entities;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Party;

internal static class Extensions
{
	internal static Party Translate(this Roblox.Platform.Party.Entities.Party party, IUniverseFactory universeFactory, IUserFactory userFactory)
	{
		if (party == null)
		{
			return null;
		}
		List<IUser> partyMembers = new List<IUser>(party.MemberUserIds.Length);
		long[] memberUserIds = party.MemberUserIds;
		foreach (long memberUserId in memberUserIds)
		{
			partyMembers.Add(userFactory.GetUser(memberUserId));
		}
		List<IUser> pendingUsers = new List<IUser>(party.PendingUserIds.Length);
		memberUserIds = party.PendingUserIds;
		foreach (long pendingUserId in memberUserIds)
		{
			pendingUsers.Add(userFactory.GetUser(pendingUserId));
		}
		string gameName = string.Empty;
		if (party.GamePlaceId.HasValue)
		{
			IUniverse universe = universeFactory.GetPlaceUniverse(party.GamePlaceId.Value);
			if (universe != null)
			{
				gameName = universe.Name;
			}
		}
		return new Party
		{
			ConversationId = party.ConversationId,
			CreatorUser = userFactory.GetUser(party.CreatorUserId),
			LeaderUser = userFactory.GetUser(party.LeaderUserId),
			GameId = party.GameId,
			GamePlaceId = party.GamePlaceId,
			GameSlotExpiry = party.GameSlotExpiry,
			GameName = gameName,
			Id = party.Id,
			MemberUsers = partyMembers,
			PendingUsers = pendingUsers,
			WalledGarden = party.WalledGarden
		};
	}

	internal static WalledGarden ToWalledGarden(this IPlatform platform)
	{
		if (platform.PlatformType == PlatformType.XboxOne)
		{
			return WalledGarden.Xbox;
		}
		return WalledGarden.General;
	}
}
