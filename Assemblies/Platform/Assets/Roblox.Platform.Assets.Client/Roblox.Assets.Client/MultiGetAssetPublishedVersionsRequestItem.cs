using System;

namespace Roblox.Assets.Client
{
	public class MultiGetAssetPublishedVersionsRequestItem
	{
		public string AssetId { get; set; }
		public AssetType AssetType { get; set; }
		public int AssetVersionNumber { get; set; }
	}
}
