using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class UserModerationNoteDAL
{
	public long ID { get; set; }

	public long UserID { get; set; }

	public long ModeratorID { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string dbConnectionString_UserModerationNoteDAL => Settings.Default.dbConnectionString_RobloxModeration;

	private static UserModerationNoteDAL BuildDAL(SqlDataReader reader)
	{
		UserModerationNoteDAL dal = new UserModerationNoteDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.ModeratorID = (long)reader["ModeratorID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_UserModerationNoteDAL, "UserModerationNotesV2_InsertUserModerationNoteV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_UserModerationNoteDAL, "UserModerationNotesV2_UpdateUserModerationNoteV2ByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_UserModerationNoteDAL, "UserModerationNotesV2_DeleteUserModerationNoteV2ByID", queryParameters));
	}

	public static UserModerationNoteDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_UserModerationNoteDAL, "UserModerationNotesV2_GetUserModerationNoteV2ByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetUserModerationNoteIDsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_UserModerationNoteDAL, "UserModerationNotesV2_GetUserModerationNoteV2IDsByUserID", queryParameters));
	}
}
