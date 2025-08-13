using System;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// Represents a record in ov2 of type "Asset".  for asset ownership.
/// </summary>
public class UserAssetModel
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public long UserId { get; set; }

	public DateTime Created { get; set; }

	public UserAssetModel(long id, long assetId, DateTime created, long userId)
	{
		Id = id;
		AssetId = assetId;
		Created = created;
		UserId = userId;
	}
}
