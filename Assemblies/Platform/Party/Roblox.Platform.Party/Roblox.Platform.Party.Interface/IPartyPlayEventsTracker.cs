using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party.Interface;

public interface IPartyPlayEventsTracker
{
	void HandleUserGameDisconnected(IUser user, IPlace place, bool isTeleport);

	void HandlePartyGamePlayLaunchAttempt(IUser user, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiration);

	void HandlePlayTogetherGameLaunchAttempt(IPlatform platform, IUser user);
}
