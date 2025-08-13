using Roblox.Platform.Authentication;
using Roblox.Web.Authentication.Enums;

namespace Roblox.Web.Authentication.Verification;

/// <summary>
/// Represents a class that verifies credentials.
/// </summary>
public interface ICredentialsVerifier
{
	/// <summary>
	/// Checks if a verification message can be sent for the provided credentials.
	/// </summary>
	/// <remarks>A verification message can only be sent if the credentials are tied to exactly one user.</remarks>
	/// <param name="credentials">The <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="credentials" /> is null.</exception>
	/// <exception cref="T:Roblox.Web.Authentication.FloodedException">Thrown if operation is flooded.</exception>
	/// <returns>True if a verification message can be sent, or false otherwise.</returns>
	bool CanSendCredentialsVerificationMessage(IRobloxUnverifiedUserCredentials credentials);

	/// <summary>
	/// Sends a verification message to the user with the provided credential value if it is unverified.
	/// </summary>
	/// <param name="credentials">The <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="credentials" /> is null.
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	///     Thrown if <paramref name="credentials.CredentialsValue.CredentialsValue" /> is null or whitespace, or <paramref name="credentials.CredentialsType.CredentialsType" /> is not supported.
	/// </exception>
	/// <returns>A <see cref="T:Roblox.Web.Authentication.Enums.SendVerificationMessageStatus" />.</returns>
	SendVerificationMessageStatus SendCredentialsVerificationMessage(IRobloxUnverifiedUserCredentials credentials);
}
