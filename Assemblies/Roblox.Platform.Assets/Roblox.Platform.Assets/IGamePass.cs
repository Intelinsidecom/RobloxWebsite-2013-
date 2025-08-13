using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

public interface IGamePass : IAsset, IAssetIdentifier
{
	/// <summary>
	/// Gets the Id for the Place that this Game Pass is attached to.
	/// </summary>
	/// <returns>The Place Id</returns>
	long GetPlaceId();

	/// <summary>
	/// Gets the Image this Game Pass.
	/// </summary>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Assets.IImage" /></returns>
	IImage GetImage();
}
