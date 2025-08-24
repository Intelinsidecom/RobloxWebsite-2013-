using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Moderation;

public class AssetReviewTaskDAL
{
	public enum SelectFilter
	{
		AssetHashID,
		ID
	}

	public long ID { get; set; }

	public long AssetHashID { get; set; }

	public int AssetTypeID { get; set; }

	public long? ModeratorID { get; set; }

	public DateTime? Reviewed { get; set; }

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
		EntityHelper.DoEntityDALDelete(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_DeleteAssetReviewTaskV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (AssetHashID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		if (AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
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
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_InsertAssetReviewTaskV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (AssetHashID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetHashID.");
		}
		if (AssetTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AssetTypeID.");
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
		queryParameters.Add(new SqlParameter("@AssetHashID", AssetHashID));
		queryParameters.Add(new SqlParameter("@AssetTypeID", AssetTypeID));
		queryParameters.Add(new SqlParameter("@ModeratorID", ModeratorID.HasValue ? ((object)ModeratorID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Reviewed", Reviewed.HasValue ? ((object)Reviewed.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_UpdateAssetReviewTaskV2ByID]", queryParameters));
	}

	private static AssetReviewTaskDAL BuildDAL(SqlDataReader reader)
	{
		AssetReviewTaskDAL dal = new AssetReviewTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetHashID = (long)reader["AssetHashID"];
			dal.AssetTypeID = (int)reader["AssetTypeID"];
			dal.ModeratorID = (reader["ModeratorID"].Equals(DBNull.Value) ? null : ((long?)reader["ModeratorID"]));
			dal.Reviewed = (reader["Reviewed"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Reviewed"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public static AssetReviewTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetAssetReviewTaskV2ByID]", queryParameters), BuildDAL);
	}

	public static AssetReviewTaskDAL Get<T>(SelectFilter selectFilter, T id) where T : IComparable<T>
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
		case SelectFilter.AssetHashID:
			queryParameters.Add(new SqlParameter("@AssetHashID", id));
			storedProcedure = "[dbo].[AssetReviewTasksV2_GetAssetReviewTaskV2ByAssetHashID]";
			return EntityHelper.GetEntityDAL(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), storedProcedure, queryParameters), BuildDAL);
		default:
			throw new ApplicationException($"Unknown SelectFilter: {selectFilter}.");
		}
	}

	public static ICollection<long> GetOpenTaskIDsPaged(int assetTypeId, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeId", assetTypeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetOpenAssetReviewTaskV2IDs_Paged]", queryParameters));
	}

	public static ICollection<long> GetOpenAssignedTaskIDsPaged(int assetTypeId, long moderatorId, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetOpenAssignedAssetReviewTaskV2IDs_Paged]", queryParameters));
	}

	public static int GetTotalNumberOfOpenAssignedTasks(int assetTypeId, long moderatorId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		queryParameters.Add(new SqlParameter("@ModeratorID", moderatorId));
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetTotalNumberOfOpenAssignedAssetReviewTasksV2]", queryParameters));
	}

	public static int GetTotalNumberOfOpenTasks(int assetTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetTotalNumberOfOpenAssetReviewTasksV2ByAssetTypeID]", queryParameters));
	}

	public static int GetTotalNumberOfActiveModerators(int assetTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTaskLeasesV2_GetTotalNumberOfActiveModeratorsByAssetTypeID]", queryParameters));
	}

	public static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int assetTypeId, int offsetForReviewedTimeInMinutes)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetTypeID", assetTypeId),
			new SqlParameter("@OffsetForReviewedTimeInMinutes", offsetForReviewedTimeInMinutes)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewV2_GetTotalNumberOfActiveAndRecentlyActiveModeratorsByAssetTypeIDAndOffset]", queryParameters));
	}

	public static int GetTotalNumberOfOpenUnassignedTasks(int assetTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetTypeID", assetTypeId));
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetTotalNumberOfOpenUnassignedAssetReviewTasksV2ByAssetTypeID]", queryParameters));
	}

	public static int GetAgeOfOldestUnmoderatedTaskInSeconds(int assetTypeId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AssetTypeID", assetTypeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(RobloxDatabase.RobloxModerationNew.GetConnectionString(), "[dbo].[AssetReviewTasksV2_GetAgeOfOldestUnmoderatedAssetReviewTaskV2ByAssetTypeID]", queryParameters));
	}
}
