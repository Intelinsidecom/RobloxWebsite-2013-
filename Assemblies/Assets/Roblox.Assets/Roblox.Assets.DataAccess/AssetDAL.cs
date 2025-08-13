using System;
using System.Data;
using Roblox.Assets.Properties;
using Roblox.Data;

namespace Roblox.Assets.DataAccess;

internal class AssetDAL
{
	private static readonly string dbConnectionString_Assets = Settings.Default.AssetsDB;

	internal static long GetAssetGenres(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		using DbHelper dbHelper = new DbHelper(dbConnectionString_Assets);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		return (long)dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_GetAssetGenresByAssetID]", CommandType.StoredProcedure);
	}

	internal static long GetAssetCategories(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		using DbHelper dbHelper = new DbHelper(dbConnectionString_Assets);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		return (long)dbHelper.ExecuteSQLScalar("[dbo].[AssetsV2_GetAssetCategoriesByAssetID]", CommandType.StoredProcedure);
	}
}
