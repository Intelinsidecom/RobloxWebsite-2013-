using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class TeeShirt : Asset, ITeeShirt, IAsset, IAssetIdentifier
{
	internal TeeShirt(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.TeeShirtID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType TeeShirt.");
		}
	}

	public IImage GetImage()
	{
		IAssetVersion currentVersion = this.GetCurrentVersion();
		if (currentVersion == null)
		{
			return null;
		}
		Roblox.IAsset imageAssetEntity = Roblox.TeeShirt.GetImageAsset(Roblox.AssetVersion.MustGet(currentVersion.Id));
		return base.DomainFactories.ImageFactory.Get(imageAssetEntity.CurrentVersion.AssetID);
	}
}
