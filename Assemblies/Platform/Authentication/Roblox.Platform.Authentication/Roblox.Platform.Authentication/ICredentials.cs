using System;

namespace Roblox.Platform.Authentication;

public interface ICredentials
{
	/// <summary>
	/// Authenticates the <see cref="T:Roblox.Platform.Authentication.ICredentials" /> and returns the resulting <see cref="T:Roblox.Platform.Authentication.IAuthenticationSession" />. If the
	/// authentication was successful the <see cref="E:Roblox.Platform.Authentication.AuthenticationEvents.Authenticated" /> event will be raised.
	/// </summary>
	/// <param name="timeToLive">How long the <see cref="T:Roblox.Platform.Authentication.IAuthenticationSession" /> should live.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Authentication.IAuthenticationSession" /> if the authentication was successful. Otherwise null.</returns>
	IAuthenticationSession Authenticate(TimeSpan timeToLive);
}
