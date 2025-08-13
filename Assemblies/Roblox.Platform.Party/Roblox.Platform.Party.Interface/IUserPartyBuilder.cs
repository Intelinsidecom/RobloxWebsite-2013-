using System;
using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party.Interface;

public interface IUserPartyBuilder
{
	IParty CreateParty(IUser partyCreator, IPlatform platform, long? conversationId, IReadOnlyCollection<IUser> pendingPartyMembers, IReadOnlyCollection<IUser> partyMembers);

	bool JoinParty(IPlatform platform, Guid partyId, IUser joiningUser, bool autoFollowPartyLeader);

	void LeaveGame(IUser user, IPlace placeLeft);

	IParty LeaveParty(IPlatform platform, Guid partyId, IUser leavingUser);

	IParty RemoveFromParty(IPlatform platform, Guid partyId, IUser currentUser, IUser userBeingRemoved);

	IParty InviteUser(IPlatform platform, Guid partyId, IUser currentUser, IUser invitedUser);

	bool UpdateUserDevice(IUser user, IPlatform platform);

	void TakeLeadershipOfParty(IPlatform platform, Guid partyId, IUser userToBeLeader);

	void JoinGame(IUser partyLeader, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiry);

	void OnUserSignout(IUser signedoutUser, IPlatform platform);

	void DeleteParty(Guid partyId);

	IParty LeaveCurrentParty(IPlatform platform, IUser leavingUser);
}
