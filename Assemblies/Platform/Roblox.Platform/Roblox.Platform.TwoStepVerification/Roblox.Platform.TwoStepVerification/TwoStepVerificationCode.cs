using System;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// A cacheable version of an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />.
/// </summary>
/// <remarks>
/// DO NOT CHANGE THIS CLASS -- Modifying the properties or behavior of this class will cause cache misses during rollout and will impact 2SV users.
/// </remarks>
[Serializable]
internal class TwoStepVerificationCode
{
	/// <summary>
	/// The <see cref="P:Roblox.Platform.MembershipCore.IVisitorIdentifier.Id" /> for this challenge.
	/// </summary>
	/// <remarks>Corresponds to <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.UserIdentifier" /></remarks>
	public long UserId { get; set; }

	/// <summary>
	/// The code sent to second factor.
	/// </summary>
	/// <remarks>Corresponds to <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" /></remarks>
	public string Code { get; set; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode.TwoStepVerificationActionType" /> of this challenge.
	/// </summary>
	/// <remarks>Corresponds to <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.ActionType" /></remarks>
	public TwoStepVerificationActionType TwoStepVerificationActionType { get; set; }

	/// <summary>
	/// The <see cref="T:System.DateTime" /> when this challenge was created.
	/// </summary>
	public DateTime Created { get; set; }

	/// <summary>
	/// A unique identifier for this challenge.
	/// </summary>
	/// <remarks>Corresponds to <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Id" /></remarks>
	public Guid Nonce { get; set; }
}
