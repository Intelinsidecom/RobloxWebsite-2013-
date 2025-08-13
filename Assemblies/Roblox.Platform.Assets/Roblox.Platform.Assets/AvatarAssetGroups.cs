namespace Roblox.Platform.Assets;

public class AvatarAssetGroups
{
	/// <summary>
	/// For a given assetTypeID, does it belong to any AvatarAssetGroups?
	/// AvatarAssetGroups are non-overlapping groups of assetTypes.
	/// Not every assetTypeID belongs to an assetGroup.
	/// </summary>
	public static AvatarAssetGroupsEnum? GetAssetGroup(int? AssetTypeID)
	{
		if (!AssetTypeID.HasValue)
		{
			return null;
		}
		if (AccessoryAssetTypes.GetAccessoryAssetTypeIds.Contains(AssetTypeID.Value))
		{
			return AvatarAssetGroupsEnum.Accessories;
		}
		if (AvatarAnimationAssetTypes.GetAvatarAnimationAssetTypeIds.Contains(AssetTypeID.Value))
		{
			return AvatarAssetGroupsEnum.AvatarAnimations;
		}
		if (BodyPartAssetTypes.GetBodyPartAssetTypeIds.Contains(AssetTypeID.Value))
		{
			return AvatarAssetGroupsEnum.BodyParts;
		}
		if (ClothingAssetTypes.GetClothingAssetTypeIds.Contains(AssetTypeID.Value))
		{
			return AvatarAssetGroupsEnum.Clothing;
		}
		if (GearAssetTypes.GetGearAssetTypeIds.Contains(AssetTypeID.Value))
		{
			return AvatarAssetGroupsEnum.Gear;
		}
		return null;
	}
}
