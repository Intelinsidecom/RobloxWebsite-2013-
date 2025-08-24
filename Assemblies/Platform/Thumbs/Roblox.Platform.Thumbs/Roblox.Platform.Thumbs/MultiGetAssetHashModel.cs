namespace Roblox.Thumbs;

/// <summary>
/// Contains information about an asset used to fetch it's thumbnail from the Thumbnail Service
/// </summary>
public class MultiGetAssetHashModel
{
	/// <summary>
	/// The asset
	/// </summary>
	public IAsset Asset;

	/// <summary>
	/// If the asset hash id has been swapped out (because it's a badge or game pass) this will be the changed id
	/// </summary>
	public long ToFetchAssetHashId;

	/// <summary>
	/// The universe identifier associated with this asset, if any.
	/// </summary>
	public long? UniverseId;

	/// <summary>
	/// If the fetch worked then the <see cref="T:Roblox.Thumbs.ThumbResult" /> will be here
	/// </summary>
	public ThumbResult Result;
}
