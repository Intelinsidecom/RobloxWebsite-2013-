using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Provides a common interface for sign in with TwoStepVerification.
/// </summary>
public interface ITwoStepVerificationCredentials : ICredentials
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /> that is being fulfilled.
	/// </summary>
	TwoStepVerificationChallengeDTO Challenge { get; }
}
