namespace Roblox.Platform.Authentication;

/// <summary>
/// An interface for a factory that generates <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />.
/// </summary>
public interface IUserCredentialsFactory
{
	/// <summary>
	/// Builds <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" /> for a given <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.
	/// </summary>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.</param>
	/// <param name="credentialsValue">The credential value. Ex. For <see cref="F:Roblox.Platform.Authentication.CredentialsType.Username" /> this would be the user's name.</param>
	/// <param name="password">The password.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///     <paramref name="credentialsValue" /> was null or whitespace.
	///     <paramref name="password" /> was null or empty.
	///     <paramref name="credentialsType" /> unsupported credential type was provided.
	/// </exception>
	IRobloxUserCredentials BuildUserCredentials(CredentialsType credentialsType, string credentialsValue, string password);
}
