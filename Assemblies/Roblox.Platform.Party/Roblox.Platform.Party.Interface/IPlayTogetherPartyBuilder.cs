using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party.Interface;

public interface IPlayTogetherPartyBuilder
{
	IParty CreateParty(IUser partyCreator, IPlatform platform, long? conversationId, IReadOnlyCollection<IUser> pendingPartyMembers, IReadOnlyCollection<IUser> partyMembers);

	void JoinGame(IUser currentUser, IPlatform platform, IPlace joiningPlace, Guid gameId, DateTime gameSlotExpiry);

	bool JoinParty(IPlatform platform, Guid partyId, IUser joiningUser);

	IParty InviteUser(IPlatform platform, Guid partyId, IUser currentUser, IUser invitedUser);

	IParty LeaveCurrentParty(IPlatform platform, IUser leavingUser);

	void OnUserSignout(IUser signedoutUser, IPlatform platform);

	void RemoveAllPartyMembers(IPlatform platform, Guid partyId);
}
