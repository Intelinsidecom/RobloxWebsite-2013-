using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class UserScreenSettingDAL
{
	public long ID { get; set; }

	public long UserID { get; set; }

	public int RobloxScreenID { get; set; }

	public bool IsSuppressed { get; set; }

	public string Parameter { get; set; }

	public DateTime Updated { get; set; }

	public DateTime Created { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxUserSettings.GetConnectionString();

	private static UserScreenSettingDAL BuildDAL(SqlDataReader reader)
	{
		UserScreenSettingDAL dal = new UserScreenSettingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.RobloxScreenID = (int)reader["RobloxScreenID"];
			dal.IsSuppressed = (bool)reader["IsSuppressed"];
			dal.Parameter = (reader["Parameter"].Equals(DBNull.Value) ? null : ((string)reader["Parameter"]));
			dal.Updated = (DateTime)reader["Updated"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RobloxScreenID", RobloxScreenID),
			new SqlParameter("@IsSuppressed", IsSuppressed),
			new SqlParameter("@Parameter", ((object)Parameter) ?? ((object)DBNull.Value)),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Created", Created)
		};
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "UserScreenSettingsV2_InsertUserScreenSettingV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RobloxScreenID", RobloxScreenID),
			new SqlParameter("@IsSuppressed", IsSuppressed),
			new SqlParameter("@Parameter", ((object)Parameter) ?? ((object)DBNull.Value)),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "UserScreenSettingsV2_UpdateUserScreenSettingV2ByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "UserScreenSettingsV2_DeleteUserScreenSettingV2ByID", queryParameters));
	}

	public static UserScreenSettingDAL GetUserScreenSettingByUserIdRobloxScreenIdAndParameter(long userId, int robloxScreenId, string parameter)
	{
		if (userId == 0L || robloxScreenId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@RobloxScreenID", robloxScreenId));
		queryParameters.Add(new SqlParameter("@Parameter", parameter));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserScreenSettingsV2_GetUserScreenSettingV2ByUserIDRobloxScreenIDAndParameter", queryParameters), BuildDAL);
	}

	public static UserScreenSettingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserScreenSettingsV2_GetUserScreenSettingV2ByID", queryParameters), BuildDAL);
	}
}
