namespace Roblox.AuthenticationV2;

/// <summary>
/// AuthenticationV2 flow occurrences to track
/// </summary>
public enum Instance
{
	/// <summary>
	/// The flow was successful
	/// </summary>
	Success,
	/// <summary>
	/// The flow failed
	/// </summary>
	Failure,
	/// <summary>
	/// The flow would have been processed, but is disabled
	/// </summary>
	DisabledIntent,
	/// <summary>
	/// The flow was not provided a valid <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" />
	/// </summary>
	NullCookie,
	/// <summary>
	/// The user provided in the <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /> does not exist
	/// </summary>
	NullUser,
	/// <summary>
	/// The session provided in the <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /> does not exist
	/// </summary>
	NullSession,
	/// <summary>
	/// The session token provided in the <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /> is malformed
	/// </summary>
	BadToken,
	/// <summary>
	/// The session provided in the <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /> is missing an expiration
	/// </summary>
	SessionWithoutExpiration,
	/// <summary>
	/// The session provided in the <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /> has an invalid IPAddress
	/// </summary>
	BadIpAddress
}
