using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party;

public interface IParty
{
	Guid Id { get; }

	long? ConversationId { get; }

	IUser CreatorUser { get; }

	IUser LeaderUser { get; }

	IReadOnlyCollection<IUser> PendingUsers { get; }

	IReadOnlyCollection<IUser> MemberUsers { get; }

	Guid? GameId { get; }

	long? GamePlaceId { get; }

	string GameName { get; }

	DateTime? GameSlotExpiry { get; }

	WalledGarden WalledGarden { get; }
}
