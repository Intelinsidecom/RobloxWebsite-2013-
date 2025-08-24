namespace Roblox.Kickbox;

/// <summary>
/// Basic interface for making a request to the Kickbox Email Verification endpoint.
/// </summary>
public interface IKickboxVerifyEmailRequest
{
	/// <summary>
	/// Email that needs to get checked.
	/// </summary>
	string Email { get; }

	bool AcceptAll { get; }
}
