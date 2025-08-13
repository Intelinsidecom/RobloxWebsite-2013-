namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a Gigya response from a socialize.getSessionInfo REST API request.
/// </summary>
/// <remarks>
/// See: http://developers.gigya.com/display/GD/socialize.getSessionInfo+REST
/// </remarks>
public interface IGigyaSessionInfoResponse : IGigyaResponse
{
	/// <summary>
	/// The authentication information for the user's account with the provider. E.g. facebook access token used for executing API actions.
	/// </summary>
	string AuthToken { get; }

	/// <summary>
	/// The user's unique identifier on the provider's social network.
	/// </summary>
	string ProviderUid { get; }
}
