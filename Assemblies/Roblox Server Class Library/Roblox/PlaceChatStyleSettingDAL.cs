using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class PlaceChatStyleSettingDAL
{
	private long _ID;

	public long AssetID;

	public byte PlaceChatStyleTypeID;

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

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PlaceChatStyleSettings_DeletePlaceChatStyleSettingByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@PlaceChatStyleTypeID", PlaceChatStyleTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "PlaceChatStyleSettings_InsertPlaceChatStyleSetting", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@PlaceChatStyleTypeID", PlaceChatStyleTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PlaceChatStyleSettings_UpdatePlaceChatStyleSettingByID", queryParameters));
	}

	private static PlaceChatStyleSettingDAL BuildDAL(SqlDataReader reader)
	{
		PlaceChatStyleSettingDAL dal = new PlaceChatStyleSettingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.PlaceChatStyleTypeID = (byte)reader["PlaceChatStyleTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static PlaceChatStyleSettingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceChatStyleSettings_GetPlaceChatStyleSettingByID", queryParameters), BuildDAL);
	}

	public static PlaceChatStyleSettingDAL GetByAssetID(long assetId)
	{
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceChatStyleSettings_GetPlaceChatStyleSettingByAssetID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<PlaceChatStyleSettingDAL> GetOrCreate(long assetId, byte placeChatStyleTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		queryParameters.Add(new SqlParameter("@PlaceChatStyleTypeID", placeChatStyleTypeId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[PlaceChatStyleSettings_GetOrCreatePlaceChatStyleSettingByAssetID]", queryParameters), BuildDAL);
	}
}
