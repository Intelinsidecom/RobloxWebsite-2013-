using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class PasswordResetUserIdFloodChecker : FloodChecker
{
	public PasswordResetUserIdFloodChecker(long userId)
		: base("PasswordResetUserIdFloodChecker_UserId:" + userId, Settings.Default.PasswordResetUserIdFloodCheckerLimit, Settings.Default.PasswordResetUserIdFloodCheckerExpiry)
	{
	}
}
