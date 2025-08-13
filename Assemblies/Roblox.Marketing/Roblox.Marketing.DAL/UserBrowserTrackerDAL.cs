using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing.DAL;

public class UserBrowserTrackerDAL
{
	private int _ID;

	public int? UserID;

	public long BrowserTrackerID;

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

	private static string dbConnectionString_UserBrowserTrackerDAL => Settings.Default.RobloxMarketing;

	private static UserBrowserTrackerDAL BuildDAL(SqlDataReader reader)
	{
		UserBrowserTrackerDAL dal = new UserBrowserTrackerDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = (reader["UserID"].Equals(DBNull.Value) ? null : ((int?)reader["UserID"]));
			dal.BrowserTrackerID = (long)reader["BrowserTrackerID"];
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
		queryParameters.Add(new SqlParameter("@UserID", UserID.HasValue ? ((object)UserID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@BrowserTrackerID", BrowserTrackerID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_UserBrowserTrackerDAL, "UserBrowserTrackers_InsertUserBrowserTracker", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public static UserBrowserTrackerDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_UserBrowserTrackerDAL, "UserBrowserTrackers_GetUserBrowserTrackerByID", queryParameters), BuildDAL);
	}
}
