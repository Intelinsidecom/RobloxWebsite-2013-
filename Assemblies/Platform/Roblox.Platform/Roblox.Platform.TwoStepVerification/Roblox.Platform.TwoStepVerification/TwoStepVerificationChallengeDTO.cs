using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Data Transfer Object for an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
/// </summary>
public class TwoStepVerificationChallengeDTO
{
	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Id" />
	public Guid Id { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.UserIdentifier" />
	public IUserIdentifier UserIdentifier { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" />
	public string Passcode { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.ActionType" />
	public TwoStepVerificationActionType ActionType { get; set; }
}
