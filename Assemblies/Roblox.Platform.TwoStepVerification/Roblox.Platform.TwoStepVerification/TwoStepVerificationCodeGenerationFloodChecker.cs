using System.Diagnostics.CodeAnalysis;
using Roblox.FloodCheckers;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationCodeGenerationFloodChecker : FloodChecker
{
	public TwoStepVerificationCodeGenerationFloodChecker(IUserIdentifier user, TwoStepVerificationActionType actionType)
		: base($"TwoStepVerificationCodeGeneration_UserID:{user.Id}_ActionType:{(byte)actionType}", Settings.Default.TwoStepVerificationCodeGenerationFloodCheckLimit, Settings.Default.TwoStepVerificationCodeGenerationFloodCheckExpiry)
	{
	}
}
