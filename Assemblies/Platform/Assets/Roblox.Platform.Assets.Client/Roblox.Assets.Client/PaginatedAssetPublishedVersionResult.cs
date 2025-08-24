using System;
using System.Collections.Generic;

namespace Roblox.Assets.Client
{
	public class PaginatedAssetPublishedVersionResult
	{
		public List<AssetPublishedVersion> AssetPublishedVersion { get; set; }
		public string ExclusiveStartKey { get; set; }
	}
}
