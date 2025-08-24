using System;

namespace Roblox.Assets.Client
{
	public class CreateAssetDependencyRequest
	{
		public string DependsAssetId { get; set; }
		public AssetType DependsAssetType { get; set; }
		public long DependsAssetVersionNumber { get; set; }
		public string SupportsAssetId { get; set; }
		public AssetType SupportsAssetType { get; set; }
		public long SupportsAssetVersionNumber { get; set; }
	}
}
