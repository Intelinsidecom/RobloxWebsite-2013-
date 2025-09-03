using Roblox.Platform.TextFilter;
using Roblox.Platform.TextFilter.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// An public interface for the <see cref="T:Roblox.Platform.Assets.AssetNameAndDescription" /> change to an asset
/// </summary>
public interface IAssetNameAndDescription : INameAndDescription
{
	/// <summary>
	/// Deprecated. Use ClientTextAuthor.
	/// The <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" /> who is attempting to make the change.
	/// </summary>
	ITextAuthor TextAuthor { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TextFilter.Client.IClientTextAuthor" /> who is attempting to make the change.
	/// </summary>
	IClientTextAuthor ClientTextAuthor { get; }
}
