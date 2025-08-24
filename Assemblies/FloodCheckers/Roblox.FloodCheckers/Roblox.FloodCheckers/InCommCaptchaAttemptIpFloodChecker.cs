using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class InCommCaptchaAttemptIpFloodChecker : FloodChecker
{
	public InCommCaptchaAttemptIpFloodChecker(string ipAddress)
		: base("GamecardRedemption", $"GamecardRedemptionCaptchaAttemptFloodChecker_IP:{ipAddress}", Settings.Default.InCommCaptchaAttemptIPFloodCheckLimit, Settings.Default.InCommCaptchaAttemptIPFloodCheckExpiry, Settings.Default.InCommCaptchaAttemptIPFloodCheckEnabled)
	{
	}
}
