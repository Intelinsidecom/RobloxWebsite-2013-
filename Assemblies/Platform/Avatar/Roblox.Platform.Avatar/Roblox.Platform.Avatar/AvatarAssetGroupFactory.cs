using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.Avatar;

internal class AvatarAssetGroupFactory : IAvatarAssetGroupFactory
{
	public AvatarAssetGroupsEnum? GetAssetGroup(Roblox.Platform.Assets.AssetType? assetType)
	{
		if (!assetType.HasValue)
		{
			return null;
		}
		return AvatarAssetGroups.GetAssetGroup(assetType.Value.ToId());
	}

	public ICollection<Roblox.Platform.Assets.AssetType> GetAssetTypes(AvatarAssetGroupsEnum avatarAssetGroupsEnum)
	{
		return avatarAssetGroupsEnum switch
		{
			AvatarAssetGroupsEnum.Accessories => AccessoryAssetTypes.GetAccessoryAssetTypes, 
			AvatarAssetGroupsEnum.AvatarAnimations => AvatarAnimationAssetTypes.GetAvatarAnimationAssetTypes, 
			AvatarAssetGroupsEnum.BodyParts => BodyPartAssetTypes.GetBodyPartAssetTypes, 
			AvatarAssetGroupsEnum.Clothing => ClothingAssetTypes.GetClothingAssetTypes, 
			AvatarAssetGroupsEnum.Gear => GearAssetTypes.GetGearAssetTypes, 
			_ => null, 
		};
	}
}
