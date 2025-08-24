namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event arguments for CookieSizeEvent class
/// </summary>
public class CookieSizeEventArgs : WebEventArgs
{
	/// <summary>
	/// Gets or sets the cookie size threshold.
	/// </summary>
	/// <value>The cookie size threshold.</value>
	public int CookieSizeThreshold { get; set; }

	/// <summary>
	/// Gets or sets the actual size of the cookie.
	/// </summary>
	/// <value>The actual size of the cookie.</value>
	public int ActualCookieSize { get; set; }

	/// <summary>
	/// Gets or sets the raw cookies.
	/// </summary>
	/// <value>The raw cookies.</value>
	public string RawCookies { get; set; }
}
