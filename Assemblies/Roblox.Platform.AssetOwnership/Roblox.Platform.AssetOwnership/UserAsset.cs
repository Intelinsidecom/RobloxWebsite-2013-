using System;
using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

public class UserAsset : IUserAsset
{
	public long Id { get; set; }

	public long AssetId { get; set; }

	public int AssetTypeId { get; set; }

	public DateTime Created { get; set; }

	public long UserId { get; set; }

	/// <summary>
	/// For reading userAssets from ov2!
	/// </summary>
	public UserAsset(long id, long assetId, int assetTypeId, DateTime created, long userId)
	{
		Id = id;
		AssetId = assetId;
		AssetTypeId = assetTypeId;
		Created = created;
		UserId = userId;
	}

	public UserAsset(UserAssetDTO dto)
	{
		Id = dto.Id;
		AssetId = dto.AssetId;
		AssetTypeId = dto.AssetTypeId;
		Created = dto.Created;
		UserId = dto.UserId;
	}
}
