namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event Arguments for authentication session validation failures.
/// </summary>
public class SessionValidationFailureEventArgs : WebEventArgs
{
	/// <summary>
	/// The reason a user's cookie failed to validate as an authentication session.
	/// </summary>
	public byte CookieValidationStatus { get; set; }
}
