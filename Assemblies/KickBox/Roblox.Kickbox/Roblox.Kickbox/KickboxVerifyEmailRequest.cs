using System.Diagnostics.CodeAnalysis;

namespace Roblox.Kickbox;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Kickbox.IKickboxVerifyEmailRequest" />.
/// </summary>
[ExcludeFromCodeCoverage]
public class KickboxVerifyEmailRequest : IKickboxVerifyEmailRequest
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
	/// <param name="allowAcceptAll">allow_all is Kickbox's soft bounce for private servers</param>
	public KickboxVerifyEmailRequest(string email, bool allowAcceptAll = true)
	{
		Email = email;
		AcceptAll = allowAcceptAll;
	}
}
