using System.Diagnostics.CodeAnalysis;
using Roblox.FloodCheckers;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification.FloodCheckers;

/// <summary>
/// A flood checker for resending an already sent 2SV code
/// </summary>
[ExcludeFromCodeCoverage]
internal class TwoStepVerificationResendCodeFloodChecker : FloodChecker
{
	public TwoStepVerificationResendCodeFloodChecker(IUserIdentifier user)
		: base($"TwoStepVerificationResendCode_UserID:{user.Id}", Settings.Default.TwoStepVerificationResendCodeFloodCheckLimit, Settings.Default.TwoStepVerificationResendCodeFloodCheckExpiry)
	{
	}
}
