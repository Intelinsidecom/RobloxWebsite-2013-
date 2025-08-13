using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// An active 2SV session created after an <see cref="T:Roblox.Platform.Membership.IUser" /> passing an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
/// </summary>
public interface ITwoStepVerificationSession
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> that this session relates to.
	/// </summary>
	IUserIdentifier UserIdentifier { get; }

	/// <summary>
	/// A unique token that identifies this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />
	/// </summary>
	Guid Token { get; }

	/// <summary>
	/// Deletes this <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />
	/// </summary>
	void Delete();
}
