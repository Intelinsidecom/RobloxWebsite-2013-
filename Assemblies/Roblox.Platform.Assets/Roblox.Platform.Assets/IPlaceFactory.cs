namespace Roblox.Platform.Assets;

public interface IPlaceFactory : IAssetFactoryBase<IPlace>
{
	/// <summary>
	/// Create a new published place version with base plate version.
	/// </summary>
	/// <param name="place">existing place</param>
	void OverridePlaceWithBaseTemplate(IAsset place);
}
