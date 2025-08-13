using System.Diagnostics.CodeAnalysis;

namespace Roblox.BriteVerify;

/// <summary>
/// Default implementation of <see cref="T:Roblox.BriteVerify.IBriteVerifyEmailRequest" />.
/// </summary>
[ExcludeFromCodeCoverage]
public class BriteVerifyEmailRequest : IBriteVerifyEmailRequest
{
	/// <summary>
	/// Email that needs to get checked.
	/// </summary>
	public string Email { get; }

	/// <summary>
	/// Specifies whether to allow/deny accept_all
	/// </summary>
	public bool AcceptAll { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="email"></param>
	/// <param name="allowAcceptAll">allow_all is BriteVerify's soft bounce for private servers</param>
	public BriteVerifyEmailRequest(string email, bool allowAcceptAll = true)
	{
		Email = email;
		AcceptAll = allowAcceptAll;
	}
}
