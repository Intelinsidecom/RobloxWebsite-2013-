using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Web.ElevatedActions.DAL;

public class ElevatedActionLogDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxRoles.GetConnectionString();

	public int ID { get; set; }

	public int ElevatedActionID { get; set; }

	public long UserID { get; set; }

	public int RoleSetID { get; set; }

	public string LogData { get; set; }

	public bool Success { get; set; }

	public string IpAddress { get; set; }

	public int BrowserTrackerID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static ElevatedActionLogDAL BuildDAL(SqlDataReader reader)
	{
		ElevatedActionLogDAL dal = new ElevatedActionLogDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ElevatedActionID = (int)reader["ElevatedActionID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.RoleSetID = (int)reader["RoleSetID"];
			dal.LogData = (string)reader["LogData"];
			dal.Success = (bool)reader["Success"];
			dal.IpAddress = (string)reader["IpAddress"];
			dal.BrowserTrackerID = (int)reader["BrowserTrackerID"];
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
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ElevatedActionID", ElevatedActionID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@LogData", LogData),
			new SqlParameter("@Success", Success),
			new SqlParameter("@IpAddress", IpAddress),
			new SqlParameter("@BrowserTrackerID", BrowserTrackerID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "ElevatedActionLogs_InsertElevatedActionLog", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ElevatedActionID", ElevatedActionID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@LogData", LogData),
			new SqlParameter("@Success", Success),
			new SqlParameter("@IpAddress", IpAddress),
			new SqlParameter("@BrowserTrackerID", BrowserTrackerID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ElevatedActionLogs_UpdateElevatedActionLogByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ElevatedActionLogs_DeleteElevatedActionLogByID", queryParameters));
	}

	public static ElevatedActionLogDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ElevatedActionLogs_GetElevatedActionLogByID", queryParameters), BuildDAL);
	}
}
