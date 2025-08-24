using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Starts new, and looks up existing <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />s.
/// </summary>
public interface ITwoStepVerificationSessionFactory
{
	/// <summary>
	/// Starts a new <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" /> for the <paramref name="user" />.
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns>The newly created <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	ITwoStepVerificationSession CreateNew(IUser user);

	/// <summary>
	/// Looks up an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" /> by <paramref name="token" />
	/// </summary>
	/// <remarks>
	/// If an expired <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" /> is found for <paramref name="token" /> it will be deleted.
	/// </remarks>
	/// <param name="token">A unique identifier</param>
	/// <returns>An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />, or null if none found.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="token" /> is empty.</exception>
	ITwoStepVerificationSession GetByToken(Guid token);
}
