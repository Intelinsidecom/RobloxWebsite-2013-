using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommCaptchaAttemptUserIdFloodChecker : FloodChecker
{
	public InCommCaptchaAttemptUserIdFloodChecker(long userId)
		: base("GamecardRedemption", $"GamecardRedemptionCaptchaAttemptFloodChecker_UserID:{userId}", Settings.Default.InCommCaptchaAttemptUserIdFloodCheckLimit, Settings.Default.InCommCaptchaAttemptUserIdFloodCheckExpiry, Settings.Default.InCommCaptchaAttemptUserIdFloodCheckEnabled)
	{
	}
}
