using System;

namespace Roblox.Assets.Client
{
	public class AssetPublishedVersion
	{
		public string AssetId { get; set; }
		public long AssetVersionNumber { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
