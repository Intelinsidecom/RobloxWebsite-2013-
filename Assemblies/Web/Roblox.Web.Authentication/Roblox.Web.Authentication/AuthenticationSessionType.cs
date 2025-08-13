namespace Roblox.Web.Authentication;

/// <summary>
/// Types of <see cref="T:Roblox.Platform.Authentication.IAuthenticationSession" />s.
/// </summary>
public enum AuthenticationSessionType
{
	/// <summary>
	/// Default, type not defined
	/// </summary>
	Undefined,
	/// <summary>
	/// Session used by the website
	/// </summary>
	Website,
	/// <summary>
	/// Session used by the game client
	/// </summary>
	Game
}
