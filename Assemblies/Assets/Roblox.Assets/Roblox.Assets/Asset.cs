using System;
using Roblox.Assets.DataAccess;
using Roblox.Assets.Properties;

namespace Roblox.Assets;

/// <summary>
/// The asset class should ideally have it's own assembly to make it easily portable between projects, this a crude beginning
/// </summary>
[Obsolete("Should define StartPlaceId as own setting, should use Platform.Assets for genres and categories.")]
public class Asset
{
	public static long[] DefaultHeadIds;

	public static long StartPlaceId => Settings.Default.StartPlaceId;

	static Asset()
	{
	}

	public static long GetAssetGenres(long assetId)
	{
		return AssetDAL.GetAssetGenres(assetId);
	}

	public static long GetAssetCategories(long assetId)
	{
		return AssetDAL.GetAssetCategories(assetId);
	}
}
