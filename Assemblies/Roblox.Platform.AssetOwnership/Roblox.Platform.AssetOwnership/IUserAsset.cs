using System;

namespace Roblox.Platform.AssetOwnership;

public interface IUserAsset
{
	long Id { get; set; }

	long AssetId { get; set; }

	int AssetTypeId { get; set; }

	DateTime Created { get; set; }

	long UserId { get; set; }
}
