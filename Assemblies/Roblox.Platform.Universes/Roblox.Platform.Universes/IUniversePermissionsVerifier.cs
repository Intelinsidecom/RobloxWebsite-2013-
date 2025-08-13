using Roblox.Platform.Membership;

namespace Roblox.Platform.Universes;

/// <summary>
/// Handles authorization around <see cref="T:Roblox.Platform.Universes.IUniverse" />s
/// </summary>
public interface IUniversePermissionsVerifier
{
	/// <summary>
	/// Checks whether or not an <see cref="T:Roblox.Platform.Membership.IUser" /> can manage an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><c>true</c> if <paramref name="universe" /> can be managed by <paramref name="user" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Null <paramref name="user" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Null <paramref name="universe" />.</exception>
	bool CanUserManageUniverse(IUser user, IUniverse universe);

	/// <summary>
	/// Checks whether of not an <see cref="T:Roblox.Platform.Membership.IUser" /> can play an <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns><c>true</c> if <paramref name="universe" /> can be played by <paramref name="user" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Null <paramref name="user" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Null <paramref name="universe" />.</exception>
	bool CanUserPlayUniverse(IUser user, IUniverse universe);
}
