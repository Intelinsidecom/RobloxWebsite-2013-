using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

public interface IShirt : IAsset, IAssetIdentifier
{
	IImage GetImage();
}
