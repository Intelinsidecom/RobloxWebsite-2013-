using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetHashSafetyRatingDAL
{
	private long _ID;

	public long AssetHashID;

	public float Safety;

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

	private static string ConnectionString => RobloxDatabase.RobloxAssetSecurity.GetConnectionString();

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetHashSafetyRatings_DeleteAssetHashSafetyRatingByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@Safety", Safety));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "AssetHashSafetyRatings_InsertAssetHashSafetyRating", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@Safety", Safety));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetHashSafetyRatings_UpdateAssetHashSafetyRatingByID", queryParameters));
	}

	private static AssetHashSafetyRatingDAL BuildDAL(SqlDataReader reader)
	{
		AssetHashSafetyRatingDAL dal = new AssetHashSafetyRatingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetHashID = (long)reader["AssetHashID"];
			dal.Safety = (float)reader["Safety"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static AssetHashSafetyRatingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetHashSafetyRatings_GetAssetHashSafetyRatingRatingByID", queryParameters), BuildDAL);
	}

	public static AssetHashSafetyRatingDAL GetByAssetHashID(long assetHashId)
	{
		if (assetHashId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetHashSafetyRatings_GetAssetHashSafetyRatingByAssetHashID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetHashSafetyRatingDAL> GetOrCreate(long assetHashId, float safety)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetHashID", assetHashId));
		queryParameters.Add(new SqlParameter("@Safety", safety));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetHashSafetyRatings_GetOrCreateAssetHashSafetyRatingRatingByAssetHashIDAndSafety]", queryParameters), BuildDAL);
	}
}
