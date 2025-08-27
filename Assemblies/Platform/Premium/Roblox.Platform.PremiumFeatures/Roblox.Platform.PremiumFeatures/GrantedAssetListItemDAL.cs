using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class GrantedAssetListItemDAL
{
	private long _ID;

	private int _GrantedAssetListID;

	private long _AssetID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	internal long ID
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

	internal int GrantedAssetListID
	{
		get
		{
			return _GrantedAssetListID;
		}
		set
		{
			_GrantedAssetListID = value;
		}
	}

	internal long AssetID
	{
		get
		{
			return _AssetID;
		}
		set
		{
			_AssetID = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_DeleteGrantedAssetListItemByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_GrantedAssetListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedAssetListID.");
		}
		if (_AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", _GrantedAssetListID));
		queryParameters.Add(new SqlParameter("@AssetID", _AssetID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_InsertGrantedAssetListItem]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (_GrantedAssetListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedAssetListID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", _GrantedAssetListID));
		queryParameters.Add(new SqlParameter("@AssetID", _AssetID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_UpdateGrantedAssetListItemByID]", queryParameters));
	}

	internal static GrantedAssetListItemDAL BuildDAL(SqlDataReader reader)
	{
		GrantedAssetListItemDAL dal = new GrantedAssetListItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.GrantedAssetListID = (int)reader["GrantedAssetListID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static GrantedAssetListItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_GetGrantedAssetListItemByID]", queryParameters), BuildDAL);
	}

	internal static GrantedAssetListItemDAL GetByGrantedAssetListIDAndAssetID(int grantedAssetListId, long assetId)
	{
		if (grantedAssetListId == 0)
		{
			return null;
		}
		if (assetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", grantedAssetListId));
		queryParameters.Add(new SqlParameter("@AssetID", assetId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_GetGrantedAssetListItemByGrantedAssetListIDAndAssetID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetGrantedAssetListItemIDsByGrantedAssetListID(int grantedAssetListId)
	{
		if (grantedAssetListId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", grantedAssetListId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[GrantedAssetListItems_GetGrantedAssetListItemIDsByGrantedAssetListID]", queryParameters));
	}
}
