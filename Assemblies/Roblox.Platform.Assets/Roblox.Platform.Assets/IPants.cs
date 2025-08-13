using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

public interface IPants : IAsset, IAssetIdentifier
{
	IImage GetImage();
}
