using Roblox.TextFilter.Client;

namespace Roblox.Platform.Universes;

/// <summary>
/// Interface that represents a request submitting universe name and description to filtering service.
/// </summary>
public interface IUniverseTextFilterRequest
{
	/// <summary>
	/// Text author.
	/// </summary>
	IClientTextAuthor ClientTextAuthor { get; }

	/// <summary>
	/// Universe name.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Universe description.
	/// </summary>
	string Description { get; }

	/// <summary>
	/// Whether to allow partially moderated name or description.
	/// </summary>
	bool AllowPartiallyModerated { get; }
}
