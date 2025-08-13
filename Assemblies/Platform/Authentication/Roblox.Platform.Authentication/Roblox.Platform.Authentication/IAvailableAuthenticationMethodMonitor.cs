using System.Collections.Generic;

namespace Roblox.Platform.Authentication;

/// <summary>
/// A helper interface that checks available authentication methods for user accounts.
/// </summary>
public interface IAvailableAuthenticationMethodMonitor
{
	/// <summary>
	/// Gets the number of available authentication methods a given account has.
	/// </summary>
	/// <param name="accountId">The account id to check.</param>
	/// <returns>The number of available <see cref="T:Roblox.Platform.Authentication.AuthenticationMethod" />s.</returns>
	int GetNumberOfAvailableAuthenticationMethods(long accountId);

	/// <summary>
	/// Gets an enumerable of available authentication methods a given account has.
	/// </summary>
	/// <param name="accountId">The account id to check.</param>
	/// <returns>The list of available <see cref="T:Roblox.Platform.Authentication.AuthenticationMethod" />s.</returns>
	IEnumerable<AuthenticationMethod> GetAvailableAuthenticationMethods(long accountId);
}
