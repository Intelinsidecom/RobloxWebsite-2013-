namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a Gigya response from a socialize.notifyLogin call.
/// </summary>
/// <remarks>
/// See: http://developers.gigya.com/display/GD/socialize.notifyLogin+REST
/// </remarks>
public interface IGigyaNotifyLoginResponse : IGigyaResponse, IGigyaValidatable
{
	/// <summary>
	/// Name of the Gigya cookie.
	/// </summary>
	string CookieName { get; }

	/// <summary>
	/// Value of the Gigya cookie.
	/// </summary>
	string CookieValue { get; }

	/// <summary>
	/// Domain for the Gigya cookie.
	/// </summary>
	string CookieDomain { get; }

	/// <summary>
	/// Path for the Gigya cookie.
	/// </summary>
	string CookiePath { get; }
}
