using System;

namespace Roblox.Platform.AssetOwnership;

public interface IUserAssetExpiration
{
	long Id { get; set; }

	long UserAssetId { get; set; }

	DateTime? Expiration { get; set; }

	bool IsProcessed { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }
}
