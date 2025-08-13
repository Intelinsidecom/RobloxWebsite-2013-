using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents an object to get information from the currently authenticated session.
/// </summary>
public interface IWebAuthenticationReader
{
	/// <summary>
	/// Provides the authenticated user for the current session
	/// </summary>
	/// <returns>The logged in <see cref="T:Roblox.Platform.Membership.IUser" /> or null if there is none.</returns>
	IUser GetAuthenticatedUser();

	/// <summary>
	/// Provides the authenticated user for the specified <see cref="T:System.Web.HttpContextBase" />.
	/// </summary>
	/// <param name="context"></param>
	/// <returns>The logged in <see cref="T:Roblox.Platform.Membership.IUser" /> or null if there is none.</returns>
	IUser GetAuthenticatedUser(HttpContextBase context);
}
