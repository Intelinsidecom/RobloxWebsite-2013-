namespace Roblox.Platform.AssetOwnership;

public interface IUserAssetOption
{
	long Id { get; set; }

	long UserAssetId { get; set; }

	long ProductId { get; set; }

	long? SerialNumber { get; set; }

	long? PriceInRobux { get; set; }
}
