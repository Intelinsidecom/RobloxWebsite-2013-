using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.Avatar;

internal interface IAvatarAssetGroupFactory
{
	AvatarAssetGroupsEnum? GetAssetGroup(Roblox.Platform.Assets.AssetType? assetType);

	ICollection<Roblox.Platform.Assets.AssetType> GetAssetTypes(AvatarAssetGroupsEnum avatarAssetGroupsEnum);
}
