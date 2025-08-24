namespace Roblox.Platform.Universes;

/// <summary>
/// Provides a common interface for updating an <see cref="T:Roblox.Platform.Universes.IUniverse" />
/// </summary>
public interface IUniverseWriter
{
	/// <summary>
	/// Updates the archive status of a universe
	/// </summary>
	/// <param name="universe">Universe to update</param>
	/// <param name="isArchived">Desired archive status</param>
	/// <exception cref="T:System.NullReferenceException"><paramref name="universe" /></exception>
	void UpdateIsArchived(IUniverse universe, bool isArchived);
}
