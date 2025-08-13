namespace Roblox.Platform.Universes;

/// <summary>
/// Manages the public or private status of an <see cref="T:Roblox.Platform.Universes.IUniverse" />.
/// </summary>
public interface IUniversePublicizer
{
	/// <summary>
	/// Sets the <see cref="T:Roblox.Platform.Universes.IUniverse" /> to public.
	/// </summary>
	/// <param name="universe">The universe to be made public.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when the <paramref name="universe" /> is null</exception>
	/// <exception cref="T:System.ArgumentException">Thrown when the the root place of the IUniverse can not be found.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="universe" />'s creator type is group, but creator target id is invalid group id.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown when the universes service is unable to perform the operation.</exception>
	/// <exception cref="T:Roblox.Platform.Universes.PublicUniverseLimitReachedException">Thrown when the public universe limit is already reached by the creator of the universe.</exception>
	void SetUniverseToPublic(IUniverse universe);

	/// <summary>
	/// Sets the <see cref="T:Roblox.Platform.Universes.IUniverse" /> to private.
	/// </summary>
	/// <param name="universe">The universe to be made private.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when the <paramref name="universe" /> is null</exception>
	/// <exception cref="T:System.ArgumentException">Thrown when the the root place of the IUniverse can not be found.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="universe" />'s creator type is group, but creator target id is invalid group id.</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown when the universes service is unable to perform the operation.</exception>
	void SetUniverseToPrivate(IUniverse universe);
}
