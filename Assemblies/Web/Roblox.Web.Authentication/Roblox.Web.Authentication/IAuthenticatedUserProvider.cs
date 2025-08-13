using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// Provides the Authenticated IUser for use in a web application
/// </summary>
public interface IAuthenticatedUserProvider
{
	/// <summary>
	/// The authenticated user
	/// </summary>
	IUser AuthenticatedUser { get; }
}
