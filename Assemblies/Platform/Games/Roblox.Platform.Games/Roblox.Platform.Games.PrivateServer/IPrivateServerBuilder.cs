namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerBuilder
{
	IPrivateServer CreatePrivateServer(long universeId, long ownerUserId, string serverName);

	IPrivateServerRenewal RenewExpiredPrivateServer(long privateServerId);

	IPrivateServer RollbackPrivateServerRenewal(IPrivateServerRenewal privateServerRenewal);

	void DeletePrivateServer(IPrivateServer privateServer);

	IPrivateServerSale CreatePrivateServerSaleEntry(IPrivateServer privateServer, long saleId);

	void DeletePrivateServerSale(IPrivateServerSale privateServerSale);
}
