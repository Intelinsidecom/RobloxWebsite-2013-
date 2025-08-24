using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// A record of an <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> being challenged by Two Step Verification
/// </summary>
internal interface ITwoStepVerificationChallenge
{
	/// <summary>
	/// A unique identifier for this challenge.
	/// </summary>
	Guid Id { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to challenge.
	/// </summary>
	IUserIdentifier UserIdentifier { get; }

	/// <summary>
	/// The code required to pass this challenge.
	/// </summary>
	string Passcode { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /> for this challenge.
	/// </summary>
	TwoStepVerificationActionType ActionType { get; }

	/// <summary>
	/// When the <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /> was generated.
	/// </summary>
	DateTime IssuedDate { get; }

	/// <summary>
	/// Revokes this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
	/// </summary>
	void Revoke();

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /> from this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /></returns>
	TwoStepVerificationChallengeDTO ToDTO();
}
