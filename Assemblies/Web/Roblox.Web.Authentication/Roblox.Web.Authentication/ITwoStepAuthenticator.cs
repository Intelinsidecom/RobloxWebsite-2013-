using System;
using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// Checks 2SV requirements for authentication and creates 2SV sessions
/// </summary>
public interface ITwoStepAuthenticator
{
	/// <summary>
	/// Checks if 2SV is required for <paramref name="user" /> to authenticate
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <returns><c>True</c> if required, <c>False</c> otherwise</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	bool IsTwoStepChallengeRequired(IUser user);

	/// <summary>
	/// Starts a 2SV session for <paramref name="user" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	void StartTwoStepSession(IUser user);

	/// <summary>
	/// Creates a secure blob out of a two step challenge id
	/// </summary>
	/// <param name="id">The challenge id to be converted to a secure blob</param>
	/// <returns>A secure blob string</returns>
	string CreateChallengeSecureBlob(Guid id);

	/// <summary>
	/// Decrypts a secure blob into the underlying two step challenge id
	/// </summary>
	/// <param name="ticket">The secure blob ticket</param>
	/// <returns>The underlying challenge</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	/// <exception cref="T:System.FormatException"></exception>
	/// <exception cref="T:Roblox.Platform.Security.SecureBlobs.SecureBlobExpiredException"></exception>
	Guid GetChallengeFromSecureBlobTicket(string ticket);
}
