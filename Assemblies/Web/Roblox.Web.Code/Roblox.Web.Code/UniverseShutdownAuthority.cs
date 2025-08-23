using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Games.Client;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Games;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

/// <summary>
/// Implements <see cref="T:Roblox.Web.Code.IUniverseShutdownAuthority" />.
/// </summary>
public class UniverseShutdownAuthority : IUniverseShutdownAuthority
{
	private readonly GameInstanceFactory _GameInstanceFactory;

	private readonly IAssetPermissionsVerifier _AssetPermissionsVerifier;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IMatchmakingContextFactory _MatchmakingContextFactory;

	private readonly IGamesAuthority _GamesAuthority;

	private readonly ILogger _Logger;

	public UniverseShutdownAuthority(GameInstanceFactory gameInstanceFactory, IAssetPermissionsVerifier assetPermissionsVerifier, IPlaceFactory placeFactory, IMatchmakingContextFactory matchmakingContextFactory, IGamesAuthority gamesAuthority, ILogger logger)
	{
		_GameInstanceFactory = gameInstanceFactory ?? throw new ArgumentNullException("gameInstanceFactory");
		_AssetPermissionsVerifier = assetPermissionsVerifier ?? throw new ArgumentNullException("assetPermissionsVerifier");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_MatchmakingContextFactory = matchmakingContextFactory ?? throw new ArgumentNullException("matchmakingContextFactory");
		_GamesAuthority = gamesAuthority ?? throw new ArgumentNullException("gamesAuthority");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.IUniverseShutdownAuthority.CloseAllGameInstances(System.Int64,Roblox.Platform.Membership.IUser)" />
	public bool CloseAllGameInstances(long universeId, IUser authenticatedUser)
	{
		HashSet<long> checkedPlaceIds = new HashSet<long>();
		int doneCount = 0;
		try
		{
			int[] cloudEditMatchmakingContext = new int[1] { _MatchmakingContextFactory.GetCloudEditMatchmakingContext().Id };
			IList<IGameInstanceIdentifier> gameInstanceIdentifiers;
			do
			{
				gameInstanceIdentifiers = _GameInstanceFactory.GetGameInstanceIdentifiersByUniverse(universeId, doneCount, 1000).ToList();
				foreach (IGameInstanceIdentifier gameInstanceIdentifier2 in gameInstanceIdentifiers)
				{
					if (!checkedPlaceIds.Contains(gameInstanceIdentifier2.PlaceId))
					{
						IPlace place = _PlaceFactory.Get(gameInstanceIdentifier2.PlaceId);
						if (!authenticatedUser.CanShutdownGameInstances(place, _AssetPermissionsVerifier))
						{
							ExceptionHandler.LogException($"Failure to shut down one of the places for a universe.  placeId={place.Id} universeId={universeId}");
							return false;
						}
						checkedPlaceIds.Add(gameInstanceIdentifier2.PlaceId);
					}
				}
				foreach (IGameInstanceIdentifier gameInstanceIdentifier in gameInstanceIdentifiers)
				{
					_GamesAuthority.Close(gameInstanceIdentifier.PlaceId, gameInstanceIdentifier.GameId, CloseGameReasonType.Developer, cloudEditMatchmakingContext);
				}
				doneCount += 1000;
			}
			while (gameInstanceIdentifiers.Count() == 1000);
		}
		catch (Exception e)
		{
			_Logger.Error($"Caught an exception trying to shut down all game instances for universe Id = {universeId}. \nThe exception was {e.Message} with the following stack trace : {e.StackTrace}");
			return false;
		}
		return true;
	}
}
