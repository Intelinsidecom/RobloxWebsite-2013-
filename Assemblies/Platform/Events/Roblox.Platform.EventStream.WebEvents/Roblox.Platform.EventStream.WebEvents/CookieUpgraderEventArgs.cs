namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event arguments for tracking Cookie Conversion.
/// </summary>
public class CookieUpgraderEventArgs : WebEventArgs
{
	/// <summary>
	/// Gets or sets the context.
	/// </summary>
	/// <value>
	/// The context.
	/// </value>
	public CookieUpgraderContextTypes Ctx { get; set; }

	/// <summary>
	/// Gets or sets the name of the cookie.
	/// </summary>
	/// <value>
	/// The name of the cookie.
	/// </value>
	public string CookieName { get; set; }

	/// <summary>
	/// Gets or sets the cookie value.
	/// </summary>
	/// <value>
	/// The cookie value.
	/// </value>
	public string CookieValue { get; set; }

	/// <summary>
	/// Gets or sets the name of the new cookie.
	/// </summary>
	/// <value>
	/// The name of the new cookie.
	/// </value>
	public string NewCookieName { get; set; }
}
