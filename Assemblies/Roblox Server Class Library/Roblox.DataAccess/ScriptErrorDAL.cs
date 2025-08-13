using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class ScriptErrorDAL
{
	private int _ID;

	private string _ErrorString = string.Empty;

	private DateTime _Created = DateTime.MinValue;

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

	public string ErrorString
	{
		get
		{
			return _ErrorString;
		}
		set
		{
			_ErrorString = value;
		}
	}

	public DateTime Created
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

	private static string ConnectionString => RobloxDatabase.RobloxAssetSecurity.GetConnectionString();

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ErrorString", _ErrorString));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[ScriptErrors_InsertScriptError]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	private static ScriptErrorDAL BuildDAL(SqlDataReader reader)
	{
		ScriptErrorDAL dal = new ScriptErrorDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ErrorString = (string)reader["ErrorString"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static ScriptErrorDAL Get(int id)
	{
		if (id == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[ScriptErrors_GetScriptErrorByID]", queryParameters), BuildDAL);
	}

	public static ScriptErrorDAL Get(string errorString)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ErrorString", errorString));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[ScriptErrors_GetScriptErrorByErrorString]", queryParameters), BuildDAL);
	}
}
