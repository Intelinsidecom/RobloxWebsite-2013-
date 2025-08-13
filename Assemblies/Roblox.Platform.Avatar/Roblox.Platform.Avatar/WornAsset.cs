namespace Roblox.Platform.Avatar;

/// <summary>
/// This is how platform.avatar communicates the currently worn assets of a user to everyone else.
/// </summary>
public class WornAsset : IWornAsset
{
	public long AssetId { get; set; }

	public bool IsEquippedGear { get; set; }

	public bool IsGear { get; set; }

	public bool IsAnimation { get; set; }

	public int AssetTypeId { get; set; }

	public WornAsset(int assetTypeId, long assetId, bool isEquippedGear, bool isGear, bool isAnimation)
	{
		AssetId = assetId;
		IsEquippedGear = isEquippedGear;
		IsGear = isGear;
		IsEquippedGear = isEquippedGear;
		IsAnimation = isAnimation;
		AssetTypeId = assetTypeId;
	}

	public WornAsset()
	{
	}
}
