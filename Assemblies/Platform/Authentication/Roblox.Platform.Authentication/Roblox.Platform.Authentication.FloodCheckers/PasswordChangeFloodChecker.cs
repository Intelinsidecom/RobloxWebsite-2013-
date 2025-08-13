using Roblox.FloodCheckers;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Authentication.FloodCheckers;

public class PasswordChangeFloodChecker : FloodChecker
{
	public PasswordChangeFloodChecker(IUserIdentifier user)
		: base($"PasswordChangeFloodChecker_UserId:{user.Id}", Settings.Default.PasswordChangeFloodCheckerLimit, Settings.Default.PasswordChangeFloodCheckerExpiry)
	{
	}
}
