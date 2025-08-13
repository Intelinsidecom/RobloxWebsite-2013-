using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetSetItemDAL
{
	private long _ID;

	public int AssetSetID;

	public long AssetVersionID;

	public int AssetTypeID;

	public int SortOrder;

	public DateTime Created;

	public DateTime Updated;

	public long ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxAssetSets.GetConnectionString();

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", AssetSetID));
		queryParameters.Add(new SqlParameter("@AssetVersionID", AssetVersionID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@SortOrder", int.MaxValue));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "AssetSetItems_InsertAssetSetItem", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetSetID", AssetSetID));
		queryParameters.Add(new SqlParameter("@AssetVersionID", AssetVersionID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@SortOrder", SortOrder));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetSetItems_UpdateAssetSetItemByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetSetItems_DeleteAssetSetItemByID", queryParameters));
	}

	private static AssetSetItemDAL BuildDAL(SqlDataReader reader)
	{
		AssetSetItemDAL dal = new AssetSetItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetSetID = (int)reader["AssetSetID"];
			dal.AssetVersionID = (long)reader["AssetVersionID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
			dal.SortOrder = (int)(Convert.IsDBNull(reader["SortOrder"]) ? ((object)int.MaxValue) : reader["SortOrder"]);
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static AssetSetItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSetItems_GetAssetSetItemByID", queryParameters), BuildDAL);
	}

	public static AssetSetItemDAL Get(int assetSetId, long assetVersionId)
	{
		if (assetSetId == 0 || assetVersionId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		queryParameters.Add(new SqlParameter("@AssetVersionID", assetVersionId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetSetItems_GetAssetSetItemByAssetSetIDAndAssetVersionID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetSetItemDAL> GetOrCreate(int assetSetId, long assetVersionId, int assetTypeId)
	{
		if (assetSetId == 0)
		{
			throw new ApplicationException("Required value not specified: AssetSetID.");
		}
		if (assetVersionId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetVersionID.");
		}
		if (assetTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		queryParameters.Add(new SqlParameter("@AssetVersionID", assetVersionId));
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		queryParameters.Add(new SqlParameter("@SortOrder", int.MaxValue));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetSetItems_GetOrCreateAssetSetItemByAssetSetIDAndAssetVersionID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAssetSetItemIDsPaged(int assetSetId, int? assetTypeId, int startRowIndex, int maximumRows)
	{
		if (assetSetId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId.HasValue ? ((object)assetTypeId.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "AssetSetItems_GetAssetSetItemIDsByAssetSetIDAndAssetTypeID_Paged", queryParameters));
	}

	public static int GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID(int assetSetId, int? assetTypeId)
	{
		if (assetSetId == 0)
		{
			return 0;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetSetID", assetSetId));
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId.HasValue ? ((object)assetTypeId.Value) : DBNull.Value));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "AssetSetItems_GetTotalNumberOfAssetSetItemsByAssetSetIDAndAssetTypeID", queryParameters));
	}
}
