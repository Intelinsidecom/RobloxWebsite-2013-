using System;
using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

public class UserAssetExpiration : IUserAssetExpiration
{
	public long Id { get; set; }

	public long UserAssetId { get; set; }

	public DateTime? Expiration { get; set; }

	public bool IsProcessed { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public UserAssetExpiration(UserAssetExpirationDTO dto)
	{
		Id = dto.Id;
		UserAssetId = dto.UserAssetId;
		Expiration = dto.Expiration;
		IsProcessed = dto.IsProcessed;
		Created = dto.Created;
		Updated = dto.Updated;
	}
}
