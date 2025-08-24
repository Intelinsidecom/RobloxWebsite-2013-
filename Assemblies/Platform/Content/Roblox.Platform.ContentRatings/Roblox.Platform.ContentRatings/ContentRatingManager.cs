using System;
using Roblox.ContentRatings.Properties;

namespace Roblox.ContentRatings;

public static class ContentRatingManager
{
	public static void CreateOrUpdateAssetRating(long assetHashID, byte newRatingID)
	{
		AssetContentRating rating = AssetContentRating.GetByAssetHashID(assetHashID);
		if (rating != null)
		{
			rating.ContentRatingTypeID = newRatingID;
			rating.Save();
		}
		else
		{
			AssetContentRating.CreateNew(assetHashID, newRatingID);
		}
	}

	public static void DeleteAssetRating(long assetHashID)
	{
		AssetContentRating.GetByAssetHashID(assetHashID)?.Delete();
	}

	public static bool CanOwnAsset(long assetHashID, DateTime? userBirthDate)
	{
		AssetContentRating assetContentRating = AssetContentRating.GetByAssetHashID(assetHashID);
		if (assetContentRating == null)
		{
			return true;
		}
		if (!Settings.Default.ContentRatingEnabled)
		{
			return false;
		}
		if (ContentRatingType.Get(assetContentRating.ContentRatingTypeID).Value == ContentRatingType.ThirteenPlus.Value && userBirthDate.HasValue)
		{
			return DateTime.Compare(DateTime.Now.AddYears(-13), userBirthDate.Value) >= 0;
		}
		return false;
	}

	public static AssetContentRating GetAssetContentRatingByAssetHashID(long assetHashID)
	{
		return AssetContentRating.GetByAssetHashID(assetHashID);
	}
}
