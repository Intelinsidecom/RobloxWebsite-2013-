using System;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Interface;

namespace Roblox.Platform.Party.Events;

public class PartyPlayEventsTracker : IPartyPlayEventsTracker
{
	private readonly IUserPartyBuilder _UserPartyBuilder;

	private readonly ILogger _Logger;

	public PartyPlayEventsTracker(IUserPartyBuilder userPartyBuilder, ILogger logger)
	{
		_UserPartyBuilder = userPartyBuilder;
		_Logger = logger;
	}

	public void HandleUserGameDisconnected(IUser user, IPlace place, bool isTeleport)
	{
		try
		{
			if (user != null && !isTeleport)
			{
				_UserPartyBuilder.LeaveGame(user, place);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	public void HandlePartyGamePlayLaunchAttempt(IUser user, IPlatform platform, IPlace place, Guid gameId, DateTime gameSlotExpiration)
	{
		try
		{
			_UserPartyBuilder.JoinGame(user, platform, place, gameId, gameSlotExpiration);
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}

	public void HandlePlayTogetherGameLaunchAttempt(IPlatform platform, IUser user)
	{
		try
		{
			_UserPartyBuilder.LeaveCurrentParty(platform, user);
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}
}
