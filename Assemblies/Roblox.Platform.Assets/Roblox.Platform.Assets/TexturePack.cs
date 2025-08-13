using System;
using Roblox.Platform.AssetsCore;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

/// <summary>
/// Represents a custom material asset.
/// </summary>
internal class TexturePack : Asset, ITexturePack, IAsset, IAssetIdentifier
{
	/// <summary>
	/// Constructor of <see cref="T:Roblox.Platform.Assets.TexturePack" />.
	/// </summary>
	/// <param name="domainFactories"></param>
	/// <param name="asset"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any argument is null.</exception>
	internal TexturePack(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset == null)
		{
			throw new PlatformArgumentNullException("asset");
		}
		if (asset.TypeId != Roblox.AssetType.TexturePackID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType TexturePack.");
		}
	}
}
