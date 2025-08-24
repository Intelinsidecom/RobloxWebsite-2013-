namespace Roblox.Platform.Assets;

/// <summary>
/// Interface for the factory for <see cref="T:Roblox.Platform.Assets.AssetOption" />.
/// </summary>
public interface IAssetOptionFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Assets.IAssetOption" /> of the specified id.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.IAssetOption" /> of the specified id.  Null if no asset option is found.</returns>
	IAssetOption Get(long id);

	/// <summary>
	/// Gets or creates the <see cref="T:Roblox.Platform.Assets.IAssetOption" /> of specified asset id.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.IAssetOption" /> of the specified asset id.</returns>
	IAssetOption GetOrCreate(long assetId);

	/// <summary>
	/// Make <see cref="T:Roblox.Platform.Assets.IAssetOption" /> from <see cref="T:Roblox.AssetOption" />
	/// </summary>
	/// <param name="assetOption"><see cref="T:Roblox.AssetOption" />, which is in SCL.</param>
	IAssetOption GetAssetOption(Roblox.AssetOption assetOption);

	/// <summary>
	/// Save <see cref="T:Roblox.Platform.Assets.IAssetOption" /> into backend storage.
	/// </summary>
	/// <param name="assetOption"><see cref="T:Roblox.AssetOption" />, which is in SCL.</param>
	void Save(IAssetOption assetOption);
}
