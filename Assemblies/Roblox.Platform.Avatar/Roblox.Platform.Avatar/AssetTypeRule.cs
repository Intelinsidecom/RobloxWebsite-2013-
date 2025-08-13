namespace Roblox.Platform.Avatar;

public class AssetTypeRule
{
	public int AssetTypeId { get; }

	/// <summary>
	/// The number of this type of asset that can be worn at a time
	/// </summary>
	public int Limit { get; }

	internal AssetTypeRule(int assetTypeId, int limit)
	{
		AssetTypeId = assetTypeId;
		Limit = limit;
	}
}
