using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Pants : Asset, IPants, IAsset, IAssetIdentifier
{
	internal Pants(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.PantsID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Pants.");
		}
	}

	public IImage GetImage()
	{
		IAssetVersion currentVersion = this.GetCurrentVersion();
		if (currentVersion == null)
		{
			return null;
		}
		Roblox.IAsset imageAssetEntity = Roblox.Pants.GetImageAsset(Roblox.AssetVersion.MustGet(currentVersion.Id));
		return base.DomainFactories.ImageFactory.Get(imageAssetEntity.CurrentVersion.AssetID);
	}
}
