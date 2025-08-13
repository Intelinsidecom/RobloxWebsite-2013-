using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Platform.XboxLive.Entities;
using Roblox.Platform.XboxLive.Interfaces;
using Roblox.Platform.XboxLive.Properties;

namespace Roblox.Platform.XboxLive;

public class XboxCatalogFactory : IXboxCatalogFactory
{
	private static Dictionary<string, long> _XboxPackagesLookupMap;

	private static ICollection<long> _AllXboxCatalogAssetIds;

	static XboxCatalogFactory()
	{
		GenerateXboxLookupDataStructures();
	}

	public bool IsXboxExclusivityEnabled()
	{
		return Settings.Default.XboxExclusivityEnabled;
	}

	public bool IsXboxExclusiveCatalogItem(long assetId)
	{
		if (!IsXboxExclusivityEnabled())
		{
			return false;
		}
		return XboxExclusiveCatalogAsset.GetAllXboxExclusiveCatalogAssetIds().Contains(assetId);
	}

	public IReadOnlyCollection<long> GetXboxExclusiveCatalogItems(int startIndex, int maxRows)
	{
		return (from x in GetAllXboxExclusiveCatalogAssets().Skip(startIndex).Take(maxRows)
			select x.AssetID).ToList();
	}

	public void CreateNewXboxExclusiveCatalogItem(long assetId)
	{
		if (!IsXboxExclusiveCatalogItem(assetId))
		{
			XboxExclusiveCatalogAsset.CreateNew(assetId);
		}
	}

	public void DeleteXboxExclusiveCatalogItem(long assetId)
	{
		if (IsXboxExclusiveCatalogItem(assetId))
		{
			XboxExclusiveCatalogAsset.GetByAssetID(assetId).Delete();
		}
	}

	public long? GetXboxExclusivePackageAssetIdByAssetIds(IReadOnlyCollection<long> assetIds)
	{
		string key = GetAssetIdsKey(assetIds);
		if (!GenerateAllXboxCatalogAssetIds().SetEquals(_AllXboxCatalogAssetIds))
		{
			GenerateXboxLookupDataStructures();
		}
		if (_XboxPackagesLookupMap.TryGetValue(key, out var packageAssetId))
		{
			return packageAssetId;
		}
		return null;
	}

	private static string GetAssetIdsKey(IEnumerable<long> assetIds)
	{
		IOrderedEnumerable<long> orderedEnumerable = assetIds.OrderBy((long id) => id);
		StringBuilder sb = new StringBuilder();
		foreach (long assetId in orderedEnumerable)
		{
			sb.Append(assetId);
			sb.Append("_");
		}
		return sb.ToString();
	}

	private static void GenerateXboxLookupDataStructures()
	{
		_XboxPackagesLookupMap = GenerateXboxPackagesLookupMap();
		_AllXboxCatalogAssetIds = GenerateAllXboxCatalogAssetIds();
	}

	private static Dictionary<string, long> GenerateXboxPackagesLookupMap()
	{
		Dictionary<string, long> lookupMap = new Dictionary<string, long>();
		foreach (XboxExclusiveCatalogAsset allXboxExclusiveCatalogAsset in GetAllXboxExclusiveCatalogAssets())
		{
			Asset asset = Asset.MustGet(allXboxExclusiveCatalogAsset.AssetID);
			if (asset.AssetTypeID == AssetType.PackageID)
			{
				string key = GetAssetIdsKey(from pI in AccoutrementPackageItem.GetAccoutrementPackageItems(asset.ID)
					select pI.AssetID);
				lookupMap[key] = asset.ID;
			}
		}
		return lookupMap;
	}

	private static HashSet<long> GenerateAllXboxCatalogAssetIds()
	{
		HashSet<long> allAssetIdsHash = new HashSet<long>();
		foreach (XboxExclusiveCatalogAsset xboxCatalogAsset in GetAllXboxExclusiveCatalogAssets())
		{
			allAssetIdsHash.Add(xboxCatalogAsset.AssetID);
		}
		return allAssetIdsHash;
	}

	private static ICollection<XboxExclusiveCatalogAsset> GetAllXboxExclusiveCatalogAssets()
	{
		List<XboxExclusiveCatalogAsset> xboxExclusiveCatalogAssets = new List<XboxExclusiveCatalogAsset>();
		int exclusiveStartId = 0;
		ICollection<XboxExclusiveCatalogAsset> assets;
		do
		{
			assets = XboxExclusiveCatalogAsset.GetXboxExclusiveCatalogAssets(100, exclusiveStartId);
			foreach (XboxExclusiveCatalogAsset asset in assets)
			{
				xboxExclusiveCatalogAssets.Add(asset);
				exclusiveStartId = asset.ID;
			}
		}
		while (assets.Count >= 100);
		return xboxExclusiveCatalogAssets;
	}
}
