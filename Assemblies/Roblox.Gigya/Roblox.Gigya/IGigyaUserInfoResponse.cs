namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a Gigya response from a socialize.getUserInfo REST API request.
/// </summary>
/// <remarks>
/// See: http://developers.gigya.com/display/GD/socialize.getUserInfo+REST
/// </remarks>
public interface IGigyaUserInfoResponse : IGigyaResponse
{
	/// <summary>
	/// The <see cref="T:Roblox.Gigya.IGigyaUser" /> fetched by this request.
	/// </summary>
	IGigyaUser User { get; }
}
