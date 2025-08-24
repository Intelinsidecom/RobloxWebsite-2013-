using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Persists records of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />s.
/// </summary>
internal interface ITwoStepVerificationChallengePersister
{
	/// <summary>
	/// Gets a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode" /> for a given <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> and <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" />.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /></param>
	/// <param name="actionType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /></param>
	/// <returns>A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode" />, or null if not found.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	TwoStepVerificationCode GetByUserAndActionType(IUserIdentifier user, TwoStepVerificationActionType actionType);

	/// <summary>
	/// Persists the given <paramref name="cacheableChallenge" />
	/// </summary>
	/// <param name="cacheableChallenge">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode" /></param>
	/// <returns><c>True</c> if successful, <c>False</c> otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="cacheableChallenge" /> is null.</exception>
	bool Persist(TwoStepVerificationCode cacheableChallenge);

	/// <summary>
	/// Deletes a persisted <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /></param>
	/// <param name="actionType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	void Delete(IUserIdentifier user, TwoStepVerificationActionType actionType);
}
