using System;

namespace Roblox.Platform.Assets;

internal class AccoutrementPackageItem : IAccoutrementPackageItem
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public int AssetTypeId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }
}
