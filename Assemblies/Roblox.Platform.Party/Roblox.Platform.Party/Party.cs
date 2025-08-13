using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party;

internal class Party : IParty
{
	public Guid Id { get; internal set; }

	public long? ConversationId { get; internal set; }

	public IUser CreatorUser { get; internal set; }

	public IUser LeaderUser { get; internal set; }

	public IReadOnlyCollection<IUser> PendingUsers { get; internal set; }

	public IReadOnlyCollection<IUser> MemberUsers { get; internal set; }

	public Guid? GameId { get; internal set; }

	public long? GamePlaceId { get; internal set; }

	public string GameName { get; internal set; }

	public DateTime? GameSlotExpiry { get; internal set; }

	public WalledGarden WalledGarden { get; internal set; }
}
