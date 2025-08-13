using Roblox.Platform.Groups;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Universes;

/// <summary>
/// Provides limits on the number of public universes.
/// </summary>
public interface IUniversePrivacyLimits
{
	/// <summary>
	/// Returns the maximum allowed number of public universes for a user.
	/// </summary>
	/// <param name="user">User whose limit to return.</param>
	/// <returns>The maximum allowed number of public universes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if <paramref name="user" /> is null.
	/// </exception>
	int GetMaxPublicUniverses(IUser user);

	/// <summary>
	/// Returns the maximum allowed number of public universes for a group.
	/// </summary>
	/// <param name="group">Group whose limit to return.</param>
	/// <returns>The maximum allowed number of public universes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// Thrown if <paramref name="group" /> is null.
	/// </exception>
	int GetMaxPublicUniverses(IGroup group);
}
