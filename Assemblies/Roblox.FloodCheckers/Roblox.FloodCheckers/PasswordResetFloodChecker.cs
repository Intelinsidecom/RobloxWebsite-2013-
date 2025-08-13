using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class PasswordResetFloodChecker : FloodChecker
{
	public PasswordResetFloodChecker(string ipAddress)
		: base("PasswordResetFloodChecker_IPAddress:" + ipAddress, Settings.Default.PwdResetFloodCheckerLimit, Settings.Default.PwdResetFloodCheckerExpiry)
	{
	}
}
