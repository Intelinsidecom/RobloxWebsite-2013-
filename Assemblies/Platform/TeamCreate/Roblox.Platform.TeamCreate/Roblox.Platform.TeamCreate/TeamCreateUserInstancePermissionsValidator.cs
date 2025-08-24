using System;
using Roblox.EventLog;
using Roblox.Games.Client;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Games;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;
using Roblox.Platform.TeamCreate.Properties;

namespace Roblox.Platform.TeamCreate;

/// <inheritdoc cref="T:Roblox.Platform.TeamCreate.ITeamCreateUserInstancePermissionsValidator" />
public class TeamCreateUserInstancePermissionsValidator : ITeamCreateUserInstancePermissionsValidator
{
	private readonly ILogger _Logger;

	private readonly IGamesAuthority _GamesAuthority;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IGameInstanceFactory _GameInstanceFactory;

	private readonly IPresenceReader _PresenceReader;

	private readonly IMatchmakingContextFactory _MatchmakingContextFactory;

	private readonly IAssetPermissionsVerifier _AssetPermissionsVerifier;

	private readonly int _CloudEditMatchmakingContextId;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TeamCreate.TeamCreateUserInstancePermissionsValidator" /> class.
	/// </summary>
	/// <param name="logger">The logger.</param>
	/// <param name="gamesAuthority">The games authority.</param>
	/// <param name="gameInstanceFactory">The game instance factory.</param>
	/// <param name="presenceReader">The presence reader.</param>
	/// <param name="matchmakingContextFactory">The matchmaking context factory.</param>
	/// <param name="assetPermissionsVerifier">The asset permissions verifier.</param>
	/// <param name="placeFactory">The place factory.</param>
	/// <exception cref="T:System.ArgumentNullException">On any argument is null.</exception>
	public TeamCreateUserInstancePermissionsValidator(ILogger logger, IGamesAuthority gamesAuthority, IGameInstanceFactory gameInstanceFactory, IPresenceReader presenceReader, IMatchmakingContextFactory matchmakingContextFactory, IAssetPermissionsVerifier assetPermissionsVerifier, IPlaceFactory placeFactory)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_GamesAuthority = gamesAuthority ?? throw new ArgumentNullException("gamesAuthority");
		_GameInstanceFactory = gameInstanceFactory ?? throw new ArgumentNullException("gameInstanceFactory");
		_PresenceReader = presenceReader ?? throw new ArgumentNullException("presenceReader");
		_MatchmakingContextFactory = matchmakingContextFactory ?? throw new ArgumentNullException("matchmakingContextFactory");
		_AssetPermissionsVerifier = assetPermissionsVerifier ?? throw new ArgumentNullException("assetPermissionsVerifier");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("logger");
		_CloudEditMatchmakingContextId = _MatchmakingContextFactory.GetCloudEditMatchmakingContext().Id;
	}

	/// <inheritdoc />
	public void ValidateTeamCreateUserInstances(IUser user)
	{
		if (!Settings.Default.IsTeamCreateKickUserOnPermissionLossEnabled)
		{
			return;
		}
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		foreach (IPresence presence in _PresenceReader.GetAllActivePresences(user))
		{
			Roblox.Platform.Presence.LocationType? locationType = presence.LocationType;
			Roblox.Platform.Presence.LocationType locationType2 = Roblox.Platform.Presence.LocationType.CloudEdit;
			if (locationType.GetValueOrDefault() != locationType2 || !locationType.HasValue || presence == null || !presence.PlaceId.HasValue || !presence.GameId.HasValue)
			{
				continue;
			}
			long placeId = presence.PlaceId.Value;
			Guid gameGuid = presence.GameId.Value;
			if (_GameInstanceFactory.GetGameInstance(placeId, gameGuid)?.MatchmakingContextId != _CloudEditMatchmakingContextId)
			{
				continue;
			}
			IPlace place = _PlaceFactory.Get(placeId);
			if (place != null && !_AssetPermissionsVerifier.CanManage(user, place))
			{
				try
				{
					_GamesAuthority.Evict(placeId, gameGuid, user.Id);
				}
				catch (Exception ex)
				{
					_Logger.Error($"KickUser failed - PlaceId: {placeId}, GameGUID: {gameGuid} " + ex);
				}
			}
		}
	}
}
