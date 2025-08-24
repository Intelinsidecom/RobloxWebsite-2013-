using Roblox.Ownership.Client;

namespace Roblox.Platform.AssetOwnership;

internal class UserAssetOption : IUserAssetOption
{
	public long Id { get; set; }

	public long UserAssetId { get; set; }

	public long ProductId { get; set; }

	public long? SerialNumber { get; set; }

	public long? PriceInRobux { get; set; }

	public UserAssetOption(UserAssetOptionDTO dto)
	{
		Id = dto.Id;
		UserAssetId = dto.UserAssetId;
		ProductId = dto.ProductId;
		SerialNumber = dto.SerialNumber;
		PriceInRobux = dto.PriceInRobux;
	}
}
