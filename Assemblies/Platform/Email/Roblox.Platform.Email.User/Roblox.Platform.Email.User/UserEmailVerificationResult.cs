using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// An object to contain the response from verifying a user's email.
/// </summary>
public class UserEmailVerificationResult
{
	/// <summary>
	/// The user whose email is verified.
	/// </summary>
	public IUser User { get; internal set; }
}
