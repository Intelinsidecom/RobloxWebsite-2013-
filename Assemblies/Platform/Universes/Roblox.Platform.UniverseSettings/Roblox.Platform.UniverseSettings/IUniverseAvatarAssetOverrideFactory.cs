using System.Collections.Generic;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseAvatarAssetOverrideFactory
{
	ICollection<Roblox.Platform.Assets.AssetType> AllowedAssetTypes { get; }

	void CreateOrUpdate(long universeId, long assetId, int assetTypeId, bool isPlayerChoice);

	UniverseAvatarAssetOverrideResponseModel GetUniverseAssetOverride(long id);

	ICollection<UniverseAvatarAssetOverrideResponseModel> GetAllUniverseAvatarAssetOverridesByUniverseId(long universeId);
}
