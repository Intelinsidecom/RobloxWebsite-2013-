using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Moderation;

public class PunishmentReviewTaskDAL
{
	public enum SelectFilter
	{
		ID,
		ReportID
	}

	public long ID { get; set; }

	public long UserID { get; set; }

	public long ReportID { get; set; }

	public long? ModeratorID { get; set; }

	public DateTime? Reviewed { get; set; }

	public byte? Priority { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_DeletePunishmentReviewTaskV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (ReportID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ReportID", ReportID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Priority", Priority.HasValue ? ((object)Priority.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_InsertPunishmentReviewTaskV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (ReportID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReportID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@ReportID", ReportID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Priority", Priority.HasValue ? ((object)Priority.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_UpdatePunishmentReviewTaskV2ByID]", queryParameters));
	}

	private static PunishmentReviewTaskDAL BuildDAL(SqlDataReader reader)
	{
		PunishmentReviewTaskDAL dal = new PunishmentReviewTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.ReportID = (long)reader["ReportID"];
			dal.ModeratorID = (reader["ModeratorID"].Equals(DBNull.Value) ? null : ((long?)reader["ModeratorID"]));
			dal.Reviewed = (reader["Reviewed"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Reviewed"]));
			dal.Priority = (reader["Priority"].Equals(DBNull.Value) ? null : ((byte?)reader["Priority"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public static PunishmentReviewTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetPunishmentReviewTaskV2ByID]", queryParameters), BuildDAL);
	}

	public static PunishmentReviewTaskDAL Get<T>(SelectFilter selectFilter, T id) where T : IComparable<T>
	{
		if (id.CompareTo(default(T)) == 0)
		{
			return null;
		}
		string storedProcedure = string.Empty;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		switch (selectFilter)
		{
		case SelectFilter.ID:
			return Get(Convert.ToInt64(id));
		case SelectFilter.ReportID:
			queryParameters.Add(new SqlParameter("@ReportID", id));
			storedProcedure = "[dbo].[PunishmentReviewTasksV2_GetPunishmentReviewTaskV2ByReportID]";
			return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), storedProcedure, queryParameters), BuildDAL);
		default:
			throw new ApplicationException($"Unknown SelectFilter: {selectFilter}.");
		}
	}

	public static ICollection<long> GetClosedTaskIDs(long moderatorId, int itemCount, int timeframe, bool randomize)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		queryParameters.Add(new SqlParameter("@ItemCount", itemCount));
		queryParameters.Add(new SqlParameter("@Timeframe", timeframe));
		queryParameters.Add(new SqlParameter("@Randomize", randomize));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetClosedPunishmentReviewTaskV2IDs]", queryParameters));
	}

	public static ICollection<long> GetOpenTaskIDsPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetOpenPunishmentReviewTaskV2IDs_Paged]", queryParameters));
	}

	public static ICollection<long> GetOpenAssignedUserIDsPaged(long moderatorId, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetOpenAssignedUserIDs_Paged]", queryParameters));
	}

	public static ICollection<long> GetOpenTaskIDsByAssignedUserID(long userId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetOpenPunishmentReviewTaskV2IDsByUserID]", queryParameters));
	}

	public static int GetTotalNumberOfOpenAssignedUsers(long moderatorId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetTotalNumberOfOpenAssignedUsers]", queryParameters));
	}

	public static int GetTotalNumberOfActiveModerators()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTaskLeasesV2_GetTotalNumberOfActiveModerators]", queryParameters));
	}

	public static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int offsetForReviewedTimeInMinutes)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@OffsetForReviewedTimeInMinutes", offsetForReviewedTimeInMinutes)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewV2_GetTotalNumberOfActiveAndRecentlyActiveModerators]", queryParameters));
	}

	public static int GetTotalNumberOfOpenUsers()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetTotalNumberOfOpenUsers]", queryParameters));
	}

	public static int GetTotalNumberOfOpenUnassignedUsers()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetTotalNumberOfOpenUnassignedUsers]", queryParameters));
	}

	public static int GetAgeOfOldestUnmoderatedPlayerTaskInSeconds()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[PunishmentReviewTasksV2_GetAgeOfOldestUnmoderatedPunishmentReviewTaskV2]", queryParameters));
	}
}
