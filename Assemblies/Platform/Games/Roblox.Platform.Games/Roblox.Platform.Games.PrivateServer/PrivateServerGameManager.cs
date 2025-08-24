using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Games.Client;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerGameManager : IPrivateServerGameManager
{
	private readonly GameInstanceFactory _GameInstanceFactory;

	private readonly GamesAuthority _GamesAuthority;

	private readonly IUniverseFactory _UniverseFactory;

	public PrivateServerGameManager(GameInstanceFactory gameInstanceFactory, GamesAuthority gamesAuthority, IUniverseFactory universeFactory)
	{
		_GameInstanceFactory = gameInstanceFactory;
		_GamesAuthority = gamesAuthority;
		_UniverseFactory = universeFactory;
	}

	public void CloseRunningGameForPrivateServer(IPrivateServer privateServer, CloseGameReasonType closeGameReasonType)
	{
		if (privateServer == null)
		{
			return;
		}
		IUniverse universe = _UniverseFactory.GetUniverse(privateServer.UniverseId);
		if (universe != null && universe.RootPlaceId.HasValue)
		{
			List<Guid> gameCodeList = new List<Guid> { privateServer.AccessCode };
			IReadOnlyCollection<IGameInstance> gameInstances = _GameInstanceFactory.GetByPlaceAndGameCodes(universe.RootPlaceId.Value, gameCodeList);
			if (gameInstances.Any())
			{
				_GamesAuthority.Close(universe.RootPlaceId.Value, gameInstances.First().Id, closeGameReasonType);
			}
		}
	}
}
