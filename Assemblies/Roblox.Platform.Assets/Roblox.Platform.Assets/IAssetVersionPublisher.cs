namespace Roblox.Platform.Assets;

/// <summary>
/// For publishing an asset version.
/// </summary>
public interface IAssetVersionPublisher
{
	/// <summary>
	/// Checks whether an asset of the provided type can be published.
	/// </summary>
	/// <param name="assetTypeId">Asset type ID.</param>
	/// <returns>True if supported, false otherwise.</returns>
	/// <exception cref="T:System.ApplicationException">Asset type ID cannot be translated to an <see cref="T:Roblox.Platform.Assets.AssetType" /></exception>
	bool IsAssetTypeSupported(int assetTypeId);

	/// <summary>
	/// Checks whether an asset of the provided type can be published.
	/// </summary>
	/// <param name="assetType">Asset type.</param>
	/// <returns>True if supported, false otherwise.</returns>
	bool IsAssetTypeSupported(AssetType assetType);

	/// <summary>
	/// Publishes an asset version. Supported asset types: <see cref="F:Roblox.Platform.Assets.AssetType.Place" />
	/// </summary>
	/// <param name="assetVersion">The asset version to be published.</param>
	/// <param name="actorType">Type of the entity (user, group, etc.) publishing the asset version.</param>
	/// <param name="actorTargetId">ID of the publishing entity.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersion" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="actorTargetId" /> is null or empty.</exception>
	/// <exception cref="T:System.ApplicationException">Asset type ID cannot be translated to an <see cref="T:Roblox.Platform.Assets.AssetType" /></exception>
	/// <exception cref="T:System.NotSupportedException">Asset type not supported.</exception>
	void PublishAssetVersion(IAssetVersion assetVersion, CreatorType actorType, string actorTargetId);
}
