namespace Roblox.Platform.Assets;

/// <summary>
/// For reverting <see cref="T:Roblox.Platform.Assets.IAsset" /> versions.
/// </summary>
public interface IAssetReverter
{
	/// <summary>
	/// Resets the specified asset by reverting it to it's version number 1
	/// </summary>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	void Reset(IAsset asset);

	/// <summary>
	/// Reverts the specified <see cref="T:Roblox.Platform.Assets.IAsset" /> to the given <see cref="T:Roblox.Platform.Assets.IAssetVersion" />.
	/// </summary>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <param name="previousAssetVersion">The previous <see cref="T:Roblox.Platform.Assets.IAssetVersion" /> version, must be a version for the given IAsset.</param>
	/// <param name="isSavedVersionOnly">Indicates that the new version should only be saved but not published.</param>
	void Revert(IAsset asset, IAssetVersion previousAssetVersion, bool isSavedVersionOnly = false);

	/// <summary>
	/// Reverts the specified <see cref="T:Roblox.Platform.Assets.IAsset" />, to the given version number.
	/// </summary>
	/// <param name="asset">The <see cref="T:Roblox.Platform.Assets.IAsset" />.</param>
	/// <param name="versionNumber">The version number.</param>
	/// <param name="isSavedVersionOnly">Indicates that the new version should only be saved but not published.</param>
	void Revert(IAsset asset, int versionNumber, bool isSavedVersionOnly = false);

	/// <summary>
	/// Reverts an <see cref="T:Roblox.Platform.Assets.IAsset" /> to the given <see cref="T:Roblox.Platform.Assets.IAssetVersion" />. Which asset is reverted is derived from the <see cref="T:Roblox.Platform.Assets.IAssetVersion" />.
	/// </summary>
	/// <param name="previousAssetVersion">The previous <see cref="T:Roblox.Platform.Assets.IAssetVersion" />.</param>
	/// <param name="isSavedVersionOnly">Indicates that the new version should only be saved but not published.</param>
	void Revert(IAssetVersion previousAssetVersion, bool isSavedVersionOnly = false);
}
