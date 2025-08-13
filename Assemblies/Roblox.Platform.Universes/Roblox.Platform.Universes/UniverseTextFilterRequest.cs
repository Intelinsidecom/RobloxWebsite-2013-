using Roblox.TextFilter.Client;

namespace Roblox.Platform.Universes;

/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniverseTextFilterRequest" />
internal class UniverseTextFilterRequest : IUniverseTextFilterRequest
{
	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterRequest.ClientTextAuthor" />
	public IClientTextAuthor ClientTextAuthor { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterRequest.Name" />
	public string Name { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterRequest.Description" />
	public string Description { get; internal set; }

	/// <inheritdoc cref="P:Roblox.Platform.Universes.IUniverseTextFilterRequest.AllowPartiallyModerated" />
	public bool AllowPartiallyModerated { get; internal set; }
}
