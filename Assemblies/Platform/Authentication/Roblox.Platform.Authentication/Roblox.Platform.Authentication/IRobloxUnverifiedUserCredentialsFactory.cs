namespace Roblox.Platform.Authentication;

/// <summary>
/// Represents a factory that builds <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" />
/// </summary>
public interface IRobloxUnverifiedUserCredentialsFactory
{
	/// <summary>
	/// Builds <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" /> for a given <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.
	/// </summary>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.</param>
	/// <param name="credentialsValue">The credential value. Ex. For <see cref="F:Roblox.Platform.Authentication.CredentialsType.Email" /> this would be the email.</param>
	/// <param name="password">The password.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///     <paramref name="credentialsValue" /> was null or whitespace.
	///     <paramref name="password" /> was null or empty.
	///     <paramref name="credentialsType" /> unsupported credential type was provided.
	/// </exception>
	IRobloxUnverifiedUserCredentials BuildUserCredentials(CredentialsType credentialsType, string credentialsValue, string password);
}
