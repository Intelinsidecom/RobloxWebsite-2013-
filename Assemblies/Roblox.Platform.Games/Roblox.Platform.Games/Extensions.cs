using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.PrivateServer;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Games;

public static class Extensions
{
	public static void VerifyIsNotNull(this IPrivateServer privateServer, long? id = null)
	{
		if (privateServer != null)
		{
			return;
		}
		if (id.HasValue)
		{
			throw new UnknownPrivateServerException(id.Value);
		}
		throw new UnknownPrivateServerException();
	}

	public static string GenerateLinkCode(this IPrivateServer privateServer, IUser authenticatedUser)
	{
		return PrivateServerLinkFactory.GenerateLinkCode(privateServer.Id, authenticatedUser);
	}

	public static void RemoveLinkCode(this IPrivateServer privateServer, IUser authenticatedUser)
	{
		PrivateServerLinkFactory.RemoveLinkCode(privateServer.Id, authenticatedUser);
	}

	internal static IPrivateServer Translate(this Roblox.Platform.Games.Entities.PrivateServer entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new Roblox.Platform.Games.PrivateServer.PrivateServer(entity.ID, entity.UniverseID, entity.Name, entity.OwnerUserID, entity.PrivateServerStatusTypeID, entity.AccessCode, entity.ExpirationDate, entity.Created, entity.Updated, entity.LinkCode);
	}

	internal static IPrivateServerSale Translate(this Roblox.Platform.Games.Entities.PrivateServerSale entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new Roblox.Platform.Games.PrivateServer.PrivateServerSale
		{
			Id = entity.ID,
			PrivateServerId = entity.PrivateServerID,
			SaleId = entity.SaleID
		};
	}
}
