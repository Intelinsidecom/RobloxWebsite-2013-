using System;

namespace Roblox.Platform.Assets;

public interface IAccoutrementPackageItem
{
	long Id { get; }

	long AssetId { get; set; }

	int AssetTypeId { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
