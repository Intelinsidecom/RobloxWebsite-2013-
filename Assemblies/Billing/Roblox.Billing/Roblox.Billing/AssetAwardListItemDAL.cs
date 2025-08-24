using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class AssetAwardListItemDAL
{
	private int _ID;

	public long AssetID;

	public int AssetAwardListID;

	public DateTime Created;

	public DateTime Updated;

	public int ID
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

	private static string dbConnectionString_AssetAwardListItemDAL => Settings.Default.BillingConnectionString;

	private static AssetAwardListItemDAL BuildDAL(SqlDataReader reader)
	{
		AssetAwardListItemDAL dal = new AssetAwardListItemDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.AssetAwardListID = (int)reader["AssetAwardListID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetAwardListID", AssetAwardListID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_AssetAwardListItemDAL, "AssetAwardListItems_InsertAssetAwardListItem", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetAwardListID", AssetAwardListID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AssetAwardListItemDAL, "AssetAwardListItems_UpdateAssetAwardListItemByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AssetAwardListItemDAL, "AssetAwardListItems_DeleteAssetAwardListItemByID", queryParameters));
	}

	public static AssetAwardListItemDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetAwardListItemDAL, "AssetAwardListItems_GetAssetAwardListItemByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAssetAwardListItemIDsByAssetAwardListID(int AssetAwardListID)
	{
		if (AssetAwardListID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetAwardListID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetAwardListID", AssetAwardListID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AssetAwardListItemDAL, "AssetAwardListItems_GetAssetAwardListItemIDsByAssetAwardListID", queryParameters));
	}
}
