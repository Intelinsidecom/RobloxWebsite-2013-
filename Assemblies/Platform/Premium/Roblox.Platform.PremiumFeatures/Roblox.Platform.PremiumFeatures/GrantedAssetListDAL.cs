using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class GrantedAssetListDAL
{
	private int _ID;

	private string _Value = string.Empty;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	internal int ID
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

	internal string Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value.Substring(0, (value.Length < 50) ? value.Length : 50);
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
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[GrantedAssetLists_DeleteGrantedAssetListByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
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
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[GrantedAssetLists_InsertGrantedAssetList]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
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
		queryParameters.Add(new SqlParameter("@Value", _Value));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[GrantedAssetLists_UpdateGrantedAssetListByID]", queryParameters));
	}

	private static GrantedAssetListDAL BuildDAL(SqlDataReader reader)
	{
		GrantedAssetListDAL dal = new GrantedAssetListDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static GrantedAssetListDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedAssetLists_GetGrantedAssetListByID]", queryParameters), BuildDAL);
	}

	internal static GrantedAssetListDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedAssetLists_GetGrantedAssetListByValue]", queryParameters), BuildDAL);
	}
}
