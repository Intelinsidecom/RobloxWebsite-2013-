using System.Collections.Generic;

namespace Roblox.Platform.Assets.Entities.AssetHash;

internal interface IAssetHashEntityFactory
{
	IAssetHashEntity Get(long id);

	IAssetHashEntity Get(int assetTypeId, string hash);

	IAssetHashEntity GetOrCreate(int assetTypeId, string hash, ICreator creator);

	IEnumerable<IAssetHashEntity> GetByMd5HashPaged(string hash, int startRowIndex, int maximumRows);
}
