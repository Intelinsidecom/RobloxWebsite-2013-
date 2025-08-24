using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Shirt : Asset, IShirt, IAsset, IAssetIdentifier
{
	internal Shirt(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.ShirtID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Shirt.");
		}
	}

	public IImage GetImage()
	{
		IAssetVersion currentVersion = this.GetCurrentVersion();
		if (currentVersion == null)
		{
			return null;
		}
		Roblox.IAsset imageAssetEntity = Roblox.Shirt.GetImageAsset(Roblox.AssetVersion.MustGet(currentVersion.Id));
		return base.DomainFactories.ImageFactory.Get(imageAssetEntity.CurrentVersion.AssetID);
	}
}
