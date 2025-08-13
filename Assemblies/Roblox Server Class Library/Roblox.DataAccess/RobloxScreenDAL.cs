using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class RobloxScreenDAL
{
	private int _ID;

	public string ScreenName;

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

	private static string ConnectionString => RobloxDatabase.RobloxUserSettings.GetConnectionString();

	private static RobloxScreenDAL BuildDAL(SqlDataReader reader)
	{
		RobloxScreenDAL dal = new RobloxScreenDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ScreenName = (string)reader["ScreenName"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ScreenName", ScreenName));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "RobloxScreens_InsertRobloxScreen", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ScreenName", ScreenName));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "RobloxScreens_UpdateRobloxScreenByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "RobloxScreens_DeleteRobloxScreenByID", queryParameters));
	}

	public static RobloxScreenDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "RobloxScreens_GetRobloxScreenByID", queryParameters), BuildDAL);
	}

	public static RobloxScreenDAL Get(string screenName)
	{
		if (string.IsNullOrEmpty(screenName))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ScreenName", screenName)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "RobloxScreens_GetRobloxScreenByName", queryParameters), BuildDAL);
	}
}
