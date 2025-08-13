namespace Roblox.BriteVerify;

/// <summary>
/// Basic interface for making a request to the BriteVerify Email Verification endpoint.
/// </summary>
public interface IBriteVerifyEmailRequest
{
	/// <summary>
	/// Email that needs to get checked.
	/// </summary>
	string Email { get; }

	/// <summary>
	/// Specifies whether to allow/deny accept_all
	/// </summary>
	bool AcceptAll { get; }
}
