using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ClientStatusSetFloodChecker : FloodChecker
{
	public ClientStatusSetFloodChecker(string ipAddress)
		: base("ClientStatusFloodChecker_" + ipAddress, Settings.Default.ClientStatusSetFloodCheckerLimit, Settings.Default.ClientStatusSetFloodCheckerExpiry, enabled: true, "ClientStatus")
	{
	}
}
