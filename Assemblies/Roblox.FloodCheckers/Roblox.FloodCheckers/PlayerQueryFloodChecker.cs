using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class PlayerQueryFloodChecker : FloodChecker
{
	public PlayerQueryFloodChecker(long userId, string userIp)
		: base($"PlayerQueryFloodChecker_UserID:{userId}_UserIP:{userIp}", Settings.Default.PlayerQueryFloodCheckerLimit, Settings.Default.PlayerQueryFloodCheckerExpiry, Settings.Default.IsPlayerQueryFloodCheckerEnabled)
	{
	}
}
