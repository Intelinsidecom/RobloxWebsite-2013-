using System;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetCategoryAuthority" />
public class AssetCategoryAuthority : IAssetCategoryAuthority
{
	/// <inheritdocs />
	public ulong GetCategories(IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Roblox.Asset.Get(asset.Id).AssetCategories;
	}
}
