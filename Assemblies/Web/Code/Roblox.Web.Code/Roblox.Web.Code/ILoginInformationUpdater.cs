using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

/// <summary>
/// Represents an object that perform login information updates.
/// </summary>
public interface ILoginInformationUpdater
{
	/// <summary>
	/// Updates the login information for the provided <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws if <paramref name="user" /> is null.</exception>
	void UpdateLoginInformation(IUser user);
}
