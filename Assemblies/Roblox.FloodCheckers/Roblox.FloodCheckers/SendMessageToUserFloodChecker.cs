using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class SendMessageToUserFloodChecker : FloodChecker
{
	public SendMessageToUserFloodChecker(string ipAddress, long targetUserId)
		: base($"SendMessageToUserFloodChecker_IPAddress:{ipAddress}_TargetUserID:{targetUserId}", Settings.Default.SendMessageToUserFloodCheckLimit, Settings.Default.SendMessageToUserFloodCheckExpiry)
	{
	}
}
