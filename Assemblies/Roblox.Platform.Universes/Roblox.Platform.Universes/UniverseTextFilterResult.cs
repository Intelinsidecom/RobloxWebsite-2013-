namespace Roblox.Platform.Universes;

/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniverseTextFilterResult" />
internal class UniverseTextFilterResult : IUniverseTextFilterResult
{
	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterResult.Name" />
	public string Name { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterResult.Description" />
	public string Description { get; internal set; }
}
