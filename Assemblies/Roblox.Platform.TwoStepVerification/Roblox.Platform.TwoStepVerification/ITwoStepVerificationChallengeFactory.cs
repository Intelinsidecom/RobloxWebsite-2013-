using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Produces <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />s.
/// </summary>
internal interface ITwoStepVerificationChallengeFactory
{
	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /> for the given <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> and <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" />.
	/// </summary>
	/// <remarks>
	/// Revokes any existing challenge for the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> and <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /> pair.
	/// </remarks> 
	/// <param name="userIdentifier">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to generate the challeng for.</param>
	/// <param name="actionType">The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /> that the challenge is valid for.</param>
	/// <returns>The new <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformFloodedException">Thrown if <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeGenerationFloodChecker" /> is flooded.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="userIdentifier" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if an error occurred persisting a 2SV challenge.</exception>
	ITwoStepVerificationChallenge GenerateChallenge(IUserIdentifier userIdentifier, TwoStepVerificationActionType actionType);

	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /> for a given <paramref name="userIdentifier" /> and <paramref name="actionType" />
	/// </summary>
	/// <param name="userIdentifier">An <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /></param>
	/// <param name="actionType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /></param>
	/// <returns>A <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />, or null if not found or expired.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="userIdentifier" /> is null.</exception>
	ITwoStepVerificationChallenge GetByUserAndActionType(IUserIdentifier userIdentifier, TwoStepVerificationActionType actionType);
}
