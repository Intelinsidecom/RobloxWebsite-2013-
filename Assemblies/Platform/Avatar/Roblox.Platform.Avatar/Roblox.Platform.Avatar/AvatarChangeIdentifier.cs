using Roblox.Platform.Assets;

namespace Roblox.Platform.Avatar;

internal class AvatarChangeIdentifier : IAvatarChangeIdentifier
{
	/// <summary>
	/// For a given accoutrement add/removal, determine how it should be logged.
	/// </summary>
	public AvatarChangeTypeEnum GetChangeType(int? assetTypeId, bool wearing)
	{
		if (!assetTypeId.HasValue)
		{
			return AvatarChangeTypeEnum.Unknown;
		}
		if (assetTypeId.Value == AssetType.PackageID)
		{
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemovePackage;
			}
			return AvatarChangeTypeEnum.WearPackage;
		}
		if (assetTypeId.Value == AssetType.GearID)
		{
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemoveGear;
			}
			return AvatarChangeTypeEnum.WearGear;
		}
		switch (AvatarAssetGroups.GetAssetGroup(assetTypeId))
		{
		case AvatarAssetGroupsEnum.Accessories:
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemoveAccessory;
			}
			return AvatarChangeTypeEnum.WearAccessory;
		case AvatarAssetGroupsEnum.AvatarAnimations:
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemoveAvatarAnimation;
			}
			return AvatarChangeTypeEnum.WearAvatarAnimation;
		case AvatarAssetGroupsEnum.BodyParts:
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemoveBodyPart;
			}
			return AvatarChangeTypeEnum.WearBodyPart;
		case AvatarAssetGroupsEnum.Clothing:
			if (!wearing)
			{
				return AvatarChangeTypeEnum.RemoveClothing;
			}
			return AvatarChangeTypeEnum.WearClothing;
		default:
			return AvatarChangeTypeEnum.Unknown;
		}
	}

	public AvatarAssetGroupsEnum? GetAssetGroup(int assetTypeId)
	{
		return AvatarAssetGroups.GetAssetGroup(assetTypeId);
	}
}
