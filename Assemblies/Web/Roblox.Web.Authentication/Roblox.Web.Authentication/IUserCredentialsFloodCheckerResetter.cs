using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents an object to reset credentials floodcheckers.
/// </summary>
public interface IUserCredentialsFloodCheckerResetter
{
	/// <summary>
	/// Resets all the credentials floodcheckers for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// <remarks>
	/// Resets the username, email, and phone number credentials floodchecker. See <see cref="T:Roblox.Web.Authentication.Floodcheckers.UserCredentialsFloodChecker" />
	/// </remarks>
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="user" /> is null.
	/// </exception>
	void ResetCredentialsFloodChecker(IUser user);
}
