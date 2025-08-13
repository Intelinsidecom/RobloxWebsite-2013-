using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class SendMessageFloodCheckerByIp : FloodChecker
{
	public SendMessageFloodCheckerByIp(string ipAddress)
		: base($"SendMessageFloodCheckerByIp_IPAdress:{ipAddress}", Settings.Default.SendMessageFloodCheckerLimitByIp, Settings.Default.SendMessageFloodCheckerExpiryByIp)
	{
	}
}
