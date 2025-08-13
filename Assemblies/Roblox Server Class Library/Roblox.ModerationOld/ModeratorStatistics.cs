using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Roblox.ModerationOld;

[DataObject]
public class ModeratorStatistics
{
	private ModeratorStatisticsDAL _EntityDAL;

	[DataObjectField(true, true)]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	[DataObjectField(false)]
	public long ModeratorID => _EntityDAL.ModeratorID;

	[DataObjectField(false)]
	public User Moderator => User.Get(_EntityDAL.ModeratorID);

	[DataObjectField(false)]
	public string ModeratorName => Moderator.GetAccount().Name;

	[DataObjectField(false)]
	public string ModeratorType => RoleSet.Get(_EntityDAL.ModeratorType).Name;

	[DataObjectField(false)]
	public string Date => _EntityDAL.ModerationDate.ToShortDateString();

	[DataObjectField(false)]
	public DateTime FirstAction => _EntityDAL.FirstAction;

	[DataObjectField(false)]
	public DateTime LastAction => _EntityDAL.LastAction;

	[DataObjectField(false)]
	public int ImagesProcessed => _EntityDAL.ImagesProcessed;

	[DataObjectField(false)]
	public int VideosProcessed => _EntityDAL.VideosProcessed;

	[DataObjectField(false)]
	public int AudioProcessed => _EntityDAL.AudioProcessed;

	[DataObjectField(false)]
	public int MeshesProcessed => _EntityDAL.MeshesProcessed;

	[DataObjectField(false)]
	public int AbuseReportsProcessed => _EntityDAL.AbuseReportsProcessed;

	[DataObjectField(false)]
	public int UsersProcessed => _EntityDAL.UsersProcessed;

	[DataObjectField(false)]
	public int ForumPosts => _EntityDAL.ForumPosts;

	[DataObjectField(false)]
	public int ForumDeletes => _EntityDAL.ForumDeletes;

	[DataObjectField(false)]
	public decimal HoursWorked => decimal.Round((decimal)_EntityDAL.MinutesWorked / 60m, 2);

	private ModeratorStatistics(ModeratorStatisticsDAL dal)
	{
		_EntityDAL = dal;
	}

	public static ICollection<ModeratorStatistics> GetModeratorStatistics(string startDate, string moderatorName)
	{
		DateTime dtmStartDate = DateTime.Today;
		if (moderatorName.Trim().Length == 0)
		{
			return new List<ModeratorStatistics>();
		}
		User moderator = User.GetByAccountID(Account.Get(moderatorName).ID);
		if (moderator == null)
		{
			return new List<ModeratorStatistics>();
		}
		switch (startDate)
		{
		case "Today":
			dtmStartDate = dtmStartDate.AddDays(-1.0);
			break;
		case "Week":
			dtmStartDate = dtmStartDate.AddDays(-7.0);
			break;
		case "Month":
			dtmStartDate = dtmStartDate.AddMonths(-1);
			break;
		}
		return GetModeratorStatistics(dtmStartDate, moderator);
	}

	public static ICollection<ModeratorStatistics> GetModeratorStatistics(DateTime startDate, User moderator)
	{
		ICollection<ModeratorStatistics> moderatorStatisticsCollection = new List<ModeratorStatistics>();
		foreach (ModeratorStatisticsDAL moderatorStatistic in ModeratorStatisticsDAL.GetModeratorStatistics(startDate, moderator.ID))
		{
			ModeratorStatistics moderatorStatistics = new ModeratorStatistics(moderatorStatistic);
			moderatorStatisticsCollection.Add(moderatorStatistics);
		}
		return moderatorStatisticsCollection;
	}

	public static void UpdateModeratorStatisticsImages(int count, User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, count, 0, 0, 0, 0, 0, 0, 0);
	}

	public static void UpdateModeratorStatisticsVideos(int count, User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, count, 0, 0, 0, 0, 0, 0);
	}

	public static void UpdateModeratorStatisticsAudio(int count, User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 0, 0, 0, 0, count, 0);
	}

	public static void UpdateModeratorStatisticsAbuseReports(User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 1, 0, 0, 0, 0, 0);
	}

	public static void UpdateModeratorStatisticsUsersModerated(User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 0, 1, 0, 0, 0, 0);
	}

	public static void UpdateModeratorStatisticsForumPost(User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 0, 0, 1, 0, 0, 0);
	}

	public static void UpdateModeratorStatisticsForumPostDeleted(User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 0, 0, 0, 1, 0, 0);
	}

	public static void UpdateModeratorStatisticsMeshes(int count, User moderator)
	{
		ModeratorStatisticsDAL.UpdateModeratorStatistics(moderator, 0, 0, 0, 0, 0, 0, 0, count);
	}
}
