namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Validates that a given <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /> is correct and all fields are valid.
/// </summary>
public interface ITwoStepVerificationCodeValidator
{
	/// <summary>
	/// Verifies that all fields of a given <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /> are valid.
	/// </summary>
	/// <param name="challengeDTO">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="challengeDTO" /> or <paramref name="challengeDTO.User.User" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="challengeDTO.Id.Id" /> is empty or if <paramref name="challengeDTO.Passcode.Passcode" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeInputFloodChecker" /> is flooded.</exception>
	/// <returns><c>True</c> if <paramref name="challengeDTO" /> is valid, <c>False</c> otherwise.</returns>
	bool IsCodeValid(TwoStepVerificationChallengeDTO challengeDTO);
}
