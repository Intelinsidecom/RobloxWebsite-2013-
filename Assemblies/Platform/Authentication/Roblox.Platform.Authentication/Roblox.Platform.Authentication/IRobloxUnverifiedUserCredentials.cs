using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Provides a common interface for credential types that may be unverified, such as emails.
/// </summary>
public interface IRobloxUnverifiedUserCredentials : IRobloxUserCredentials, IRobloxCredentials, ICredentials
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.IUser" /> with the unverified credentials. Ex. A user linked to an unverified email.
	/// </summary>
	/// <remarks>This allows getting a <see cref="T:Roblox.Platform.Membership.IUser" /> with an unverified credential instead of throwing an error.</remarks>
	/// <returns>A user with the unverified credentials, or null if no user is found.</returns>
	/// <exception cref="T:Roblox.Platform.Authentication.MultipleUsersPerCredentialException">
	///     Thrown if multiple users match the current credentials.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Authentication.TooManyUsersLinkedToCredentialsException">
	///     Thrown if too many users match the current credential value.
	/// </exception>
	IUser GetUserFromUnverifiedCredentials();
}
