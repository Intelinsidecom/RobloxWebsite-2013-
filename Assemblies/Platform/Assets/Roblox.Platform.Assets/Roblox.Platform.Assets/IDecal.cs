using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

public interface IDecal : IAsset, IAssetIdentifier
{
	IImage GetImage();
}
