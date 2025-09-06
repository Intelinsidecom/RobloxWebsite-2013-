using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AssetMedia.Properties;
using Roblox.Platform.Assets;
using PlatformAssetType = Roblox.Platform.Assets.AssetType;

namespace Roblox.Platform.AssetMedia;

public class AssetMediaManager
{
	public static AssetMediaItem GetCurrent(long assetId)
	{
		return GetAssetMediaItemsByAssetID(assetId).FirstOrDefault();
	}

	public static AssetMediaItem AddAssetMedia(long assetId, long uploadedMediaAssetId, long uploaderUserId, PlatformAssetType? assetType = null)
	{
		List<AssetMediaItem> mediaItems = new List<AssetMediaItem>(GetAssetMediaItemsByAssetID(assetId));
		AssetMediaItem newPrimary = AssetMediaItem.CreateNew(assetId, uploadedMediaAssetId, uploaderUserId);
		for (int i = GetMaximumAssetMedia(assetType) - 1; i < mediaItems.Count; i++)
		{
			mediaItems[i].Delete();
		}
		foreach (AssetMediaItem item in mediaItems)
		{
			item.SortOrder++;
			item.Save();
		}
		return newPrimary;
	}

	public static ICollection<AssetMediaItem> GetAssetMediaItemsByAssetID(long assetId)
	{
		return AssetMediaItem.GetAssetMediaItemsByAssetID_Paged(assetId, 0, Settings.Default.GetAssetMediaItemsPageSize);
	}

	public static long GetTotalNumberOfAssetMediaItemsByAssetID(long assetId)
	{
		return AssetMediaItem.GetTotalNumberOfAssetMediaItemsByAssetID(assetId);
	}

	public static void DeleteAssetMediaItem(long assetMediaItemId)
	{
		AssetMediaItem.Get(assetMediaItemId).Delete();
	}

	public static void SetSortOrder(long assetMediaItemId, int sortOrder)
	{
		AssetMediaItem mediaItem = AssetMediaItem.Get(assetMediaItemId);
		if (mediaItem.SortOrder != sortOrder)
		{
			mediaItem.SortOrder = sortOrder;
			mediaItem.Save();
		}
	}

	private static int GetMaximumAssetMedia(PlatformAssetType? assetType)
	{
		if (!assetType.HasValue)
		{
			return Settings.Default.MaximumPlaceMediaItemsPerPlace;
		}
		PlatformAssetType value = assetType.Value;
		if (value == PlatformAssetType.Plugin)
		{
			return Settings.Default.MaximumPluginAssetMediaCount;
		}
		return Settings.Default.MaximumPlaceMediaItemsPerPlace;
	}
}
