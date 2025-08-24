using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class ReportReviewTask : IRobloxEntity<long, ReportReviewTaskDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum LookupFilter
	{
		ID,
		ReportID
	}

	private ReportReviewTaskDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ReportReviewTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long ReportID
	{
		get
		{
			return _EntityDAL.ReportID;
		}
		internal set
		{
			_EntityDAL.ReportID = value;
		}
	}

	public Report Report
	{
		get
		{
			return Report.Get(ReportID);
		}
		internal set
		{
			if (value == null)
			{
				ReportID = 0L;
			}
			else
			{
				ReportID = value.ID;
			}
		}
	}

	public long? ModeratorID
	{
		get
		{
			return _EntityDAL.ModeratorID;
		}
		set
		{
			_EntityDAL.ModeratorID = value;
		}
	}

	public DateTime? Reviewed
	{
		get
		{
			return _EntityDAL.Reviewed;
		}
		set
		{
			_EntityDAL.Reviewed = value;
		}
	}

	internal byte? Priority
	{
		get
		{
			return _EntityDAL.Priority;
		}
		set
		{
			_EntityDAL.Priority = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReportReviewTask()
	{
		_EntityDAL = new ReportReviewTaskDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static ReportReviewTask DoGet(long id)
	{
		return EntityHelper.DoGet<long, ReportReviewTaskDAL, ReportReviewTask>(() => ReportReviewTaskDAL.Get(id), id);
	}

	private static ReportReviewTask DoGet<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		switch (lookupFilter)
		{
		case LookupFilter.ID:
			return DoGet(Convert.ToInt64(id));
		case LookupFilter.ReportID:
		{
			ReportReviewTaskDAL.SelectFilter selectFilter = ReportReviewTaskDAL.SelectFilter.ReportID;
			return EntityHelper.DoGetByLookup<long, ReportReviewTaskDAL, ReportReviewTask>(() => ReportReviewTaskDAL.Get(selectFilter, id), $"{lookupFilter}:{id}");
		}
		default:
			throw new ApplicationException($"Unknown LookupFilter: {lookupFilter}");
		}
	}

	public static ReportReviewTask CreateNew(Report report)
	{
		return CreateNew(report?.ID ?? 0, report?.ReportCategoryID);
	}

	public static ReportReviewTask CreateNew(long reportId, byte? reportCategoryId)
	{
		ReportReviewTask entity = new ReportReviewTask
		{
			ReportID = reportId
		};
		if (Settings.Default.ReportAbuseCategoryEnabled && reportCategoryId.HasValue)
		{
			ReportCategory reportCategory = ReportCategory.Get(reportCategoryId.Value);
			if (reportCategory != null)
			{
				entity.Priority = reportCategory.DefaultPriority;
			}
		}
		entity.Save();
		return entity;
	}

	public static ReportReviewTask CreateNew(Report report, long? moderatorId, DateTime? reviewed)
	{
		return CreateNew(report?.ID ?? 0, moderatorId, reviewed, null);
	}

	public static ReportReviewTask CreateNew(Report report, long? moderatorId, DateTime? reviewed, byte? priority)
	{
		return CreateNew(report?.ID ?? 0, moderatorId, reviewed, priority);
	}

	public static ReportReviewTask CreateNew(long reportId, long? moderatorId, DateTime? reviewed, byte? priority)
	{
		ReportReviewTask reportReviewTask = new ReportReviewTask();
		reportReviewTask.ReportID = reportId;
		reportReviewTask.ModeratorID = moderatorId;
		reportReviewTask.Reviewed = reviewed;
		reportReviewTask.Priority = priority;
		reportReviewTask.Save();
		return reportReviewTask;
	}

	public static ReportReviewTask Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static ReportReviewTask Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ReportReviewTask Get<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		return EntityHelper.GetEntityByLookupOld<long, ReportReviewTask>(EntityCacheInfo, $"{lookupFilter}:{id}", () => DoGet(lookupFilter, id));
	}

	public static ICollection<ReportReviewTask> GetClosedTasks(long moderatorId, int itemCount, int timeframe, bool randomize)
	{
		ICollection<ReportReviewTask> entities = new List<ReportReviewTask>();
		foreach (long taskId in ReportReviewTaskDAL.GetClosedTaskIDs(moderatorId, itemCount, timeframe, randomize))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static ICollection<ReportReviewTask> GetOpenTasksPaged(int startRowIndex, int maximumRows)
	{
		ICollection<ReportReviewTask> entities = new List<ReportReviewTask>();
		foreach (long taskId in ReportReviewTaskDAL.GetOpenTaskIDsPaged(startRowIndex + 1, maximumRows))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static ICollection<ReportReviewTask> GetOpenAssignedTasksPaged(long moderatorId, int startRowIndex, int maximumRows)
	{
		ICollection<ReportReviewTask> entities = new List<ReportReviewTask>();
		foreach (long taskId in ReportReviewTaskDAL.GetOpenAssignedTaskIDsPaged(moderatorId, startRowIndex + 1, maximumRows))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static int GetTotalNumberOfOpenAssignedTasks(long moderatorId)
	{
		return ReportReviewTaskDAL.GetTotalNumberOfOpenAssignedTasks(moderatorId);
	}

	public static int GetTotalNumberOfOpenTasks()
	{
		return ReportReviewTaskDAL.GetTotalNumberOfOpenTasks();
	}

	public static int GetTotalNumberOfOpenUnassignedTasks()
	{
		return ReportReviewTaskDAL.GetTotalNumberOfOpenUnassignedTasks();
	}

	public static int GetAgeOfOldestUnmoderatedAbuseTaskInSeconds()
	{
		return ReportReviewTaskDAL.GetAgeOfOldestUnmoderatedAbuseTaskInSeconds();
	}

	public static int GetTotalNumberOfActiveModerators()
	{
		return ReportReviewTaskDAL.GetTotalNumberOfActiveModerators();
	}

	public static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int offsetForReviewedTimeInMinutes = 5)
	{
		return ReportReviewTaskDAL.GetTotalNumberOfActiveAndRecentlyActiveModerators(offsetForReviewedTimeInMinutes);
	}

	public static int GetTotalNumberOfOpenHighPriorityTasks()
	{
		return ReportReviewTaskDAL.GetTotalNumberOfOpenTasksByPriority(Settings.Default.HighPriorityReportThreshold);
	}

	public void Construct(ReportReviewTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"{LookupFilter.ReportID}:{ReportID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
