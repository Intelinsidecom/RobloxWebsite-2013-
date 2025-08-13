using Roblox.Platform.Games.Entities;

namespace Roblox.Platform.Games.PrivateServer;

internal interface IPrivateServerSaleManager
{
	bool CancelRecurringSaleForPrivateServer(IPrivateServer privateServer);

	Roblox.Platform.Games.Entities.PrivateServerSale GetActivePrivateServerSale(IPrivateServer privateServer, out Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale);

	Roblox.Platform.Games.Entities.PrivateServerSale GetNewestPrivateServerSale(IPrivateServer privateServer);
}
