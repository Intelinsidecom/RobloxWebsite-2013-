using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Represents the credentials for an <see cref="T:Roblox.Platform.Membership.IUser" />.
/// </summary>
public interface IRobloxUserCredentials : IRobloxCredentials, ICredentials
{
	/// <summary>
	/// Gets the credentials <see cref="P:Roblox.Platform.Authentication.IRobloxUserCredentials.CredentialsType" />.
	/// </summary>
	CredentialsType CredentialsType { get; }

	/// <summary>
	/// Gets the credentials value.
	/// </summary>
	string CredentialValue { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.IUser" /> associated with the current credentials.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.IUser" />.</returns>
	/// <exception cref="T:Roblox.Platform.Authentication.MultipleUsersPerCredentialException">
	///     Multiple user matches for current credential.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Authentication.UnverifiedCredentialsException">
	///     Provided credentials are unverified.
	///     Ex. For email credentials the email is not verified for the user. 
	/// </exception>
	IUser GetUser();
}
