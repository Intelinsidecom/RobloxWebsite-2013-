using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Sends 2SV codes to an <see cref="T:Roblox.Platform.Membership.IUser" />'s configured second factor.
/// </summary>
public interface ITwoStepVerificationCodeSender
{
	/// <summary>
	/// Generates a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /> and sends <see cref="P:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO.Passcode" /> to the given <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="actionType">The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /></param>
	/// <param name="ipAddress">The IpAddress of the original request</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the <paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeGenerationFloodChecker" /> is flooded.</exception>
	/// <exception cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationUnverifiedMediaTypeException">Thrown if <paramref name="user" /> has not verified their chosen <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if there was an unexpected failure to send <see cref="P:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO.Passcode" />.</exception>
	/// <returns>The generated <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /></returns>
	TwoStepVerificationChallengeDTO GenerateChallengeAndSendCode(IUser user, TwoStepVerificationActionType actionType, string ipAddress);

	/// <summary>
	/// Resends a <see cref="P:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO.Passcode" /> to the <see cref="T:Roblox.Platform.Membership.IUser" /> it was generated for.
	/// </summary>
	/// <param name="challengeDto">The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /></param>
	/// <param name="ipAddress">The IpAddress of the original request</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the <paramref name="challengeDto" /> or <paramref name="challengeDto.UserIdentifier.UserIdentifier" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="challengeDto.Id.Id" /> is empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if <pramref name="challenge.Id" /> was not issued for <paramref name="challengeDto.UserIdentifier.UserIdentifier" />.</exception>
	/// <exception cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationUnverifiedMediaTypeException">Thrown if <paramref name="challengeDto.UserIdentifier.UserIdentifier" /> has not verified their chosen <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if there was an unexpected failure to send <see cref="P:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO.Passcode" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Flood check limit reached retrying code.</exception>
	void ResendCodeForChallenge(TwoStepVerificationChallengeDTO challengeDto, string ipAddress);
}
