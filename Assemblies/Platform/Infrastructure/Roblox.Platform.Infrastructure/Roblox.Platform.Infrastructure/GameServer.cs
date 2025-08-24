namespace Roblox.Platform.Infrastructure;

internal class GameServer : IGameServer
{
	public string IpAddress { get; }

	public GameServer(string ipAddress)
	{
		IpAddress = ipAddress;
	}
}
