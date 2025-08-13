using System.Diagnostics.CodeAnalysis;
using Roblox.FloodCheckers;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationCodeInputFloodChecker : FloodChecker
{
	public TwoStepVerificationCodeInputFloodChecker(IUserIdentifier user, TwoStepVerificationActionType actionType)
		: base($"TwoStepVerificationCodeInput_UserID:{user.Id}_ActionTypeID:{(byte)actionType}", Settings.Default.TwoStepVerificationCodeInputFloodCheckLimit, Settings.Default.TwoStepVerificationCodeInputFloodCheckExpiry)
	{
	}
}
