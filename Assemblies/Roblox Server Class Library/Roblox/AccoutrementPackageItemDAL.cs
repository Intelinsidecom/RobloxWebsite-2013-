using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AccoutrementPackageItemDAL
{
	private long _ID;

	public long AccoutrementPackageAssetID;

	public long AssetID;

	public int AssetTypeID;

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

	private static AccoutrementPackageItemDAL BuildDAL(SqlDataReader reader)
	{
		AccoutrementPackageItemDAL dal = new AccoutrementPackageItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccoutrementPackageAssetID = (long)reader["AccoutrementPackageAssetID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
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
		queryParameters.Add(new SqlParameter("@AccoutrementPackageAssetID", AccoutrementPackageAssetID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "AccoutrementPackageItems_InsertAccoutrementPackageItem", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccoutrementPackageAssetID", AccoutrementPackageAssetID));
		queryParameters.Add(new SqlParameter("@AssetID", AssetID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AccoutrementPackageItems_UpdateAccoutrementPackageItemByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AccoutrementPackageItems_DeleteAccoutrementPackageItemByID", queryParameters));
	}

	public static AccoutrementPackageItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AccoutrementPackageItems_GetAccoutrementPackageItemByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAccoutrementPackageItemIDsByAccoutrementPackageAssetID(long accoutrementPackageAssetId)
	{
		if (accoutrementPackageAssetId == 0L)
		{
			throw new ApplicationException("Invalid AccoutrementPackageAssetID!");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccoutrementPackageAssetID", accoutrementPackageAssetId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[AccoutrementPackageItems_GetAccoutrementPackageItemIDsByAccoutrementPackageAssetID]", queryParameters));
	}
}
