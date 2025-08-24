using Roblox.Platform.Assets;

namespace Roblox.Platform.Avatar;

public interface IAvatarChangeIdentifier
{
	/// <summary>
	/// For a given accoutrement add/removal, determine how it should be logged.
	/// </summary>
	AvatarChangeTypeEnum GetChangeType(int? assetTypeId, bool wearing);

	AvatarAssetGroupsEnum? GetAssetGroup(int assetTypeId);
}
