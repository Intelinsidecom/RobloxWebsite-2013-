using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseAccessChanger
{
	/// <summary>
	/// Activates an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="universe" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="universe" /> does not have a root place.</exception>
	/// <exception cref="T:Roblox.Platform.Moderation.ModeratedOperationException">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> is moderated, or the group it belongs to is locked (if owned by a group.)</exception>
	/// <exception cref="!:CreatorHasTooManyActiveUniversesException">The creator of the <see cref="T:Roblox.Platform.Universes.IUniverse" /> is at it's max activation limit.</exception>
	void ActivateUniverse(IUniverse universe);

	/// <summary>
	/// Deactivates a <see cref="T:Roblox.Platform.Universes.IUniverse" />.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="universe" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="universe" /> does not have a root place.</exception>
	void DeactivateUniverse(IUniverse universe);
}
