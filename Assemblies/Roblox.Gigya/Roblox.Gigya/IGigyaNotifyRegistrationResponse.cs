namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a Gigya response from a socialize.notifyRegistration call.
/// </summary>
/// <remarks>
/// See: http://developers.gigya.com/display/GD/socialize.notifyRegistration+REST
/// </remarks>
public interface IGigyaNotifyRegistrationResponse : IGigyaResponse
{
	/// <summary>
	/// The Gigya UID.
	/// </summary>
	string UID { get; }
}
