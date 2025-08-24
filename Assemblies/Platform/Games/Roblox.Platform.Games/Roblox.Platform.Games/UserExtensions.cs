using System.Collections.Generic;
using Roblox.Platform.AssetPermissions;
using Roblox.Platform.Assets;
using Roblox.Platform.Games.PrivateServer;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Games;

public static class UserExtensions
{
	public static bool CanPlay(this IUser user, IPlace place, IAssetPermissionsVerifier assetPermissionsVerifier)
	{
		return PlacePlayPermissionsProvider.CanPlay(user, place, assetPermissionsVerifier);
	}

	public static IReadOnlyCollection<IPrivateServer> GetPrivateServersOwned(this IUser user, IPrivateServerFactory privateServerFactory, int startIndex, int maxRows)
	{
		return privateServerFactory.GetPrivateServersByOwnerUserID(user.Id, startIndex, maxRows);
	}

	public static long GetTotalNumberOfPrivateServersOwned(this IUser user, IPrivateServerFactory privateServerFactory)
	{
		return privateServerFactory.GetTotalNumberOfPrivateServersByOwnerUserID(user.Id);
	}

	public static IReadOnlyCollection<IPrivateServer> GetPrivateServersOwnedByUniverseId(this IUser user, IPrivateServerFactory privateServerFactory, long universeId, int startIndex, int maxRows)
	{
		return privateServerFactory.GetPrivateServersByOwnerUserIDAndUniverseID(user.Id, universeId, startIndex, maxRows);
	}

	public static long GetTotalNumberOfPrivateServersOwnedByUniverseId(this IUser user, IPrivateServerFactory privateServerFactory, long universeId)
	{
		return privateServerFactory.GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID(user.Id, universeId);
	}

	public static IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessTo(this IUser user, IPrivateServerFactory privateServerFactory, int startIndex, int maxRows)
	{
		return privateServerFactory.GetPrivateServersUserHasAccessTo(user.Id, startIndex, maxRows);
	}

	public static long GetTotalNumberOfPrivateServersUserHasAccessTo(this IUser user, IPrivateServerFactory privateServerFactory)
	{
		return privateServerFactory.GetTotalNumberOfPrivateServersUserHasAccessTo(user.Id);
	}

	public static IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessToByUniverseID(this IUser user, IPrivateServerFactory privateServerFactory, long universeId, int startIndex, int maxRows)
	{
		return privateServerFactory.GetPrivateServersUserHasAccessToByUniverseID(user.Id, universeId, startIndex, maxRows);
	}

	public static long GetTotalNumberOfPrivateServersUserHasAccessToByUniverseID(this IUser user, IPrivateServerFactory privateServerFactory, long universeId)
	{
		return privateServerFactory.GetTotalNumberOfPrivateServersUserHasAccessToByUniverseID(user.Id, universeId);
	}

	public static bool CanShutdownGameInstances(this IUser user, IPlace place, IAssetPermissionsVerifier assetPermissionsVerifier)
	{
		place.VerifyIsNotNull();
		if (user == null)
		{
			return false;
		}
		if (user.IsModerator())
		{
			return true;
		}
		return assetPermissionsVerifier.CanManage(user, place);
	}
}
