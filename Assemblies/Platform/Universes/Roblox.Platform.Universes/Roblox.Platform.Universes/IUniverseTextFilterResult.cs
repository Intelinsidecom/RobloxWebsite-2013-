namespace Roblox.Platform.Universes;

/// <summary>
/// The result of filtering text for a Universe, safe to go to DB.
/// </summary>
public interface IUniverseTextFilterResult
{
	/// <summary>
	/// Filtered universe name.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Filtered universe description.
	/// </summary>
	string Description { get; }
}
