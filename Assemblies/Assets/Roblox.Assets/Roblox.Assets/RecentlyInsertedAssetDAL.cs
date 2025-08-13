using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Assets.Properties;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Assets;

public class RecentlyInsertedAssetDAL
{
	public long UserID;

	public long AssetID;

	public int AssetTypeID;

	public DateTime Created;

	public DateTime Updated;

	public long ID { get; set; }

	private static string dbConnectionString_RecentlyInsertedAssetDAL => Settings.Default.RobloxStudioConnectionString;

	private static RecentlyInsertedAssetDAL BuildDAL(SqlDataReader reader)
	{
		RecentlyInsertedAssetDAL dal = new RecentlyInsertedAssetDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
			dal.Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc);
			dal.Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc);
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@CreatedUtc", Created.ToUniversalTime()));
		queryParameters.Add(new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime()));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_InsertRecentlyInsertedAsset", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@CreatedUtc", Created.ToUniversalTime()));
		queryParameters.Add(new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime()));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_UpdateRecentlyInsertedAssetByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_DeleteRecentlyInsertedAssetByID", queryParameters));
	}

	public static RecentlyInsertedAssetDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_GetRecentlyInsertedAssetByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetRecentlyInsertedAssetIDsByUserIDAndAssetTypeID_Paged(long userID, int assetTypeID, int startRowIndex, int maximumRows)
	{
		if (userID == 0L)
		{
			return null;
		}
		if (assetTypeID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_GetRecentlyInsertedAssetIDsByUserIDAndAssetTypeID_Paged", queryParameters));
	}

	public static RecentlyInsertedAssetDAL GetRecentlyInsertedAssetIDsByUserIDAndAssetID(long userID, long assetID)
	{
		if (userID == 0L)
		{
			return null;
		}
		if (assetID == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userID));
		queryParameters.Add(new SqlParameter("@AssetID", assetID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_RecentlyInsertedAssetDAL, "RecentlyInsertedAssetsV2_GetRecentlyInsertedAssetIDByUserIDAndAssetID", queryParameters), BuildDAL);
	}
}
