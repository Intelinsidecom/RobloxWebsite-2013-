using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.ModerationOld;

internal class ModeratorStatisticsDAL
{
	public long ID { get; set; }

	public long ModeratorID { get; set; }

	public int ModeratorType { get; set; }

	public DateTime ModerationDate { get; set; }

	public DateTime FirstAction { get; set; }

	public DateTime LastAction { get; set; }

	public int ImagesProcessed { get; set; }

	public int VideosProcessed { get; set; }

	public int AudioProcessed { get; set; }

	public int MeshesProcessed { get; set; }

	public int AbuseReportsProcessed { get; set; }

	public int UsersProcessed { get; set; }

	public int ForumPosts { get; set; }

	public int ForumDeletes { get; set; }

	public int MinutesWorked { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxModeration.GetConnectionString();

	private static ICollection<ModeratorStatisticsDAL> BuildDALCollection(SqlDataReader reader)
	{
		ICollection<ModeratorStatisticsDAL> dals = new List<ModeratorStatisticsDAL>();
		while (reader.Read())
		{
			ModeratorStatisticsDAL dal = new ModeratorStatisticsDAL();
			dal.ID = (long)reader["ID"];
			dal.ModeratorID = (long)reader["ModeratorID"];
			dal.ModeratorType = (int)reader["ModeratorType"];
			dal.ModerationDate = (DateTime)reader["Date"];
			dal.FirstAction = (DateTime)reader["FirstAction"];
			dal.LastAction = (DateTime)reader["LastAction"];
			dal.ImagesProcessed = (int)reader["ImagesProcessed"];
			dal.VideosProcessed = ((reader["VideosProcessed"] != DBNull.Value) ? ((int)reader["VideosProcessed"]) : 0);
			dal.AudioProcessed = ((reader["AudioProcessed"] != DBNull.Value) ? ((int)reader["AudioProcessed"]) : 0);
			dal.MeshesProcessed = ((reader["MeshesProcessed"] != DBNull.Value) ? ((int)reader["MeshesProcessed"]) : 0);
			dal.AbuseReportsProcessed = (int)reader["AbuseReportsProcessed"];
			dal.UsersProcessed = (int)reader["UserModerationProcessed"];
			dal.ForumPosts = (int)reader["ForumPosts"];
			dal.ForumDeletes = (int)reader["ForumDeletes"];
			dal.MinutesWorked = (int)reader["MinutesWorked"];
			dals.Add(dal);
		}
		return dals;
	}

	public static ICollection<ModeratorStatisticsDAL> GetModeratorStatistics(DateTime startDate, long moderatorId)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", moderatorId);
		dbHelper.SQLParameters.AddWithValue("@StartDate", startDate);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ModeratorStatisticsV2_GetModeratorStatisticsV2ByDateAndUserID]", CommandType.StoredProcedure);
		return BuildDALCollection(reader);
	}

	public static void UpdateModeratorStatistics(User moderator, int imagesProcessed, int videosProcessed, int abuseReportsProcessed, int userModerationProcessed, int forumPosts, int forumDeletes, int audioProcessed, int meshesProcessed)
	{
		Account moderatorAccount = moderator.GetAccount();
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		DateTime dtToday = DateTime.Today;
		dbHelper.SQLParameters.AddWithValue("@Date", dtToday);
		dbHelper.SQLParameters.AddWithValue("@ModeratorID", moderator.ID);
		dbHelper.SQLParameters.AddWithValue("@ModeratorType", moderatorAccount.GetHighestRoleSet().ID);
		dbHelper.SQLParameters.AddWithValue("@ImagesProcessed", imagesProcessed);
		dbHelper.SQLParameters.AddWithValue("@VideosProcessed", videosProcessed);
		dbHelper.SQLParameters.AddWithValue("@AbuseReportsProcessed", abuseReportsProcessed);
		dbHelper.SQLParameters.AddWithValue("@UserModerationProcessed", userModerationProcessed);
		dbHelper.SQLParameters.AddWithValue("@ForumPosts", forumPosts);
		dbHelper.SQLParameters.AddWithValue("@ForumDeletes", forumDeletes);
		dbHelper.SQLParameters.AddWithValue("@AudioProcessed", audioProcessed);
		dbHelper.SQLParameters.AddWithValue("@MeshesProcessed", meshesProcessed);
		dbHelper.ExecuteSQLNonQuery("[dbo].[ModeratorStatisticsV2_UpdateInsertModeratorStatisticsV2ByDate]", CommandType.StoredProcedure);
	}
}
