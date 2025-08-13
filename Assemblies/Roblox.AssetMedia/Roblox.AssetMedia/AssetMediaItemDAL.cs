using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.AssetMedia;

internal class AssetMediaItemDAL
{
	public long ID { get; set; }

	public long AssetID { get; set; }

	public long MediaAssetID { get; set; }

	public long UploaderUserID { get; set; }

	public int SortOrder { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxAssetMedia.GetConnectionString();

	public static AssetMediaItemDAL BuildDAL(SqlDataReader reader)
	{
		AssetMediaItemDAL dal = new AssetMediaItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.MediaAssetID = (long)reader["MediaAssetID"];
			dal.UploaderUserID = (long)reader["UploaderUserID"];
			dal.SortOrder = (int)reader["SortOrder"];
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
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@MediaAssetID", MediaAssetID),
			new SqlParameter("@UploaderUserID", UploaderUserID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "AssetMediaItemsV2_InsertAssetMediaItem", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@MediaAssetID", MediaAssetID),
			new SqlParameter("@UploaderUserID", UploaderUserID),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetMediaItemsV2_UpdateAssetMediaItemByID", queryParameters));
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetMediaItemsV2_DeleteAssetMediaItemByID", queryParameters));
	}

	public static AssetMediaItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetMediaItemsV2_GetAssetMediaItemByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAssetMediaItemIDsByAssetID_Paged(long assetId, int startRowIndex, int maximumRows)
	{
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", assetId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "AssetMediaItemsV2_GetAssetMediaItemIDsByAssetID_Paged", queryParameters));
	}

	public static long GetTotalNumberOfAssetMediaItemsByAssetID(long assetId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetID", assetId)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "AssetMediaItemsV2_GetTotalNumberOfAssetMediaItemsByAssetID", queryParameters));
	}
}
