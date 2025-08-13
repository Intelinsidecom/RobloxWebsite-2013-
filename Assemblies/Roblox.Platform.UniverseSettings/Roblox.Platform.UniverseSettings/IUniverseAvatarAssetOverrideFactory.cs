using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseAvatarAssetOverrideFactory
{
	ICollection<AssetType> AllowedAssetTypes { get; }

	void CreateOrUpdate(long universeId, long assetId, int assetTypeId, bool isPlayerChoice);

	UniverseAvatarAssetOverrideResponseModel GetUniverseAssetOverride(long id);

	ICollection<UniverseAvatarAssetOverrideResponseModel> GetAllUniverseAvatarAssetOverridesByUniverseId(long universeId);
}
