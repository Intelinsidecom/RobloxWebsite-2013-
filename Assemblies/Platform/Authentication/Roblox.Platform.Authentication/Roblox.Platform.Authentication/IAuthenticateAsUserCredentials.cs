using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Credentials for authenticating as a given <see cref="T:Roblox.Platform.Membership.IUser" />.
/// </summary>
public interface IAuthenticateAsUserCredentials : ICredentials
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Membership.IUser" /> to authenticate as.
	/// </summary>
	IUser User { get; }
}
