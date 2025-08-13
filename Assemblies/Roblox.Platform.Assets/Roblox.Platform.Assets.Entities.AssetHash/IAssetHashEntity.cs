using System;
using Roblox.Entities;

namespace Roblox.Platform.Assets.Entities.AssetHash;

internal interface IAssetHashEntity : IEntity<long>
{
	int AssetTypeId { get; set; }

	string Hash { get; set; }

	bool IsApproved { get; set; }

	bool IsReviewed { get; set; }

	long CreatorId { get; set; }

	DateTime Updated { get; set; }

	void SetApproval(bool isApproved, bool isReviewed);
}
