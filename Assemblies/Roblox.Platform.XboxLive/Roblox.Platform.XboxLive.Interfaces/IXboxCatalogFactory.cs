using System.Collections.Generic;

namespace Roblox.Platform.XboxLive.Interfaces;

public interface IXboxCatalogFactory
{
	bool IsXboxExclusivityEnabled();

	bool IsXboxExclusiveCatalogItem(long assetId);

	IReadOnlyCollection<long> GetXboxExclusiveCatalogItems(int startIndex, int maxRows);

	void CreateNewXboxExclusiveCatalogItem(long assetId);

	void DeleteXboxExclusiveCatalogItem(long assetId);

	long? GetXboxExclusivePackageAssetIdByAssetIds(IReadOnlyCollection<long> assetIds);
}
