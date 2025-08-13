using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.ContentRatings.Properties;
using Roblox.Data;

namespace Roblox.ContentRatings;

public class AssetContentRatingDAL
{
	private long _ID;

	public long AssetHashID;

	public byte ContentRatingTypeID;

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

	private static string dbConnectionString_AssetContentRatingDAL => Settings.Default.ContentRatingsConnectionString;

	private static AssetContentRatingDAL BuildDAL(SqlDataReader reader)
	{
		AssetContentRatingDAL dal = new AssetContentRatingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetHashID = (long)reader["AssetHashID"];
			dal.ContentRatingTypeID = (byte)reader["ContentRatingTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
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
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@ContentRatingTypeID", ContentRatingTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_AssetContentRatingDAL, "AssetContentRatings_InsertAssetContentRating", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@ContentRatingTypeID", ContentRatingTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AssetContentRatingDAL, "AssetContentRatings_UpdateAssetContentRatingByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AssetContentRatingDAL, "AssetContentRatings_DeleteAssetContentRatingByID", queryParameters));
	}

	public static AssetContentRatingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetContentRatingDAL, "AssetContentRatings_GetAssetContentRatingByID", queryParameters), BuildDAL);
	}

	public static AssetContentRatingDAL GetByAssetHashID(long AssetHashID)
	{
		if (AssetHashID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetContentRatingDAL, "AssetContentRatings_GetAssetContentRatingByAssetHashID", queryParameters), BuildDAL);
	}
}
