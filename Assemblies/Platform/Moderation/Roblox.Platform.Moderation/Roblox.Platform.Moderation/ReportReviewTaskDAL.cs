using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Moderation;

public class ReportReviewTaskDAL
{
	public enum SelectFilter
	{
		ID,
		ReportID
	}

	public long ID { get; set; }

	public long ReportID { get; set; }

	public long? ModeratorID { get; set; }

	public DateTime? Reviewed { get; set; }

	public byte? Priority { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_DeleteReportReviewTaskV2ByID]", queryParameters));
	}

	internal void Insert()
	{
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
		queryParameters.Add(new SqlParameter("@ReportID", ReportID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Priority", Priority.HasValue ? ((object)Priority.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_InsertReportReviewTaskV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
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
		queryParameters.Add(new SqlParameter("@ReportID", ReportID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Priority", Priority.HasValue ? ((object)Priority.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_UpdateReportReviewTaskV2ByID]", queryParameters));
	}

	private static ReportReviewTaskDAL BuildDAL(SqlDataReader reader)
	{
		ReportReviewTaskDAL dal = new ReportReviewTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
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

	internal static ReportReviewTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetReportReviewTaskV2ByID]", queryParameters), BuildDAL);
	}

	internal static ReportReviewTaskDAL Get<T>(SelectFilter selectFilter, T id) where T : IComparable<T>
	{
		if (id.CompareTo(default(T)) == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		switch (selectFilter)
		{
		case SelectFilter.ID:
			return Get(Convert.ToInt64(id));
		case SelectFilter.ReportID:
		{
			queryParameters.Add(new SqlParameter("@ReportID", id));
			string storedProcedure = "[dbo].[ReportReviewTasksV2_GetReportReviewTaskV2ByReportID]";
			return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), storedProcedure, queryParameters), BuildDAL);
		}
		default:
			throw new ApplicationException($"Unknown SelectFilter: {selectFilter}.");
		}
	}

	internal static ICollection<long> GetClosedTaskIDs(long moderatorId, int itemCount, int timeframe, bool randomize)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		queryParameters.Add(new SqlParameter("@ItemCount", itemCount));
		queryParameters.Add(new SqlParameter("@Timeframe", timeframe));
		queryParameters.Add(new SqlParameter("@Randomize", randomize));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetClosedReportReviewTaskV2IDs]", queryParameters));
	}

	internal static ICollection<long> GetOpenTaskIDsPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetOpenReportReviewTaskV2IDs_Paged]", queryParameters));
	}

	internal static ICollection<long> GetOpenAssignedTaskIDsPaged(long moderatorId, int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ModeratorID", moderatorId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetOpenAssignedReportReviewTaskV2IDs_Paged]", queryParameters));
	}

	internal static int GetTotalNumberOfOpenAssignedTasks(long moderatorId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ModeratorID", moderatorId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetTotalNumberOfOpenAssignedReportReviewTasksV2]", queryParameters));
	}

	internal static int GetTotalNumberOfActiveModerators()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTaskLeasesV2_GetTotalNumberOfActiveModerators]", queryParameters));
	}

	internal static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int offsetForReviewedTimeInMinutes)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@OffsetForReviewedTimeInMinutes", offsetForReviewedTimeInMinutes)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewV2_GetTotalNumberOfActiveAndRecentlyActiveModerators]", queryParameters));
	}

	internal static int GetTotalNumberOfOpenTasks()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetTotalNumberOfOpenReportReviewTasksV2]", queryParameters));
	}

	internal static int GetTotalNumberOfOpenUnassignedTasks()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetTotalNumberOfOpenUnassignedReportReviewTasksV2]", queryParameters));
	}

	internal static int GetTotalNumberOfOpenTasksByPriority(byte priority)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Priority", priority)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetTotalNumberOfOpenReportReviewTasksV2ByPriority]", queryParameters));
	}

	internal static int GetAgeOfOldestUnmoderatedAbuseTaskInSeconds()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[ReportReviewTasksV2_GetAgeOfOldestUnmoderatedReportReviewTaskV2]", queryParameters));
	}
}
