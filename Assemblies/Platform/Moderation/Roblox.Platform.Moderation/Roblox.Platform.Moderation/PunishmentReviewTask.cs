using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class PunishmentReviewTask : IRobloxEntity<long, PunishmentReviewTaskDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum LookupFilter
	{
		ID,
		ReportID
	}

	private PunishmentReviewTaskDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PunishmentReviewTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		internal set
		{
			_EntityDAL.UserID = value;
		}
	}

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
		internal set
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
		internal set
		{
			_EntityDAL.Reviewed = value;
		}
	}

	public byte? Priority
	{
		get
		{
			return _EntityDAL.Priority;
		}
		internal set
		{
			_EntityDAL.Priority = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PunishmentReviewTask()
	{
		_EntityDAL = new PunishmentReviewTaskDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	private static PunishmentReviewTask DoGet(long id)
	{
		return EntityHelper.DoGet<long, PunishmentReviewTaskDAL, PunishmentReviewTask>(() => PunishmentReviewTaskDAL.Get(id), id);
	}

	private static PunishmentReviewTask DoGet<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		switch (lookupFilter)
		{
		case LookupFilter.ID:
			return DoGet(Convert.ToInt64(id));
		case LookupFilter.ReportID:
		{
			PunishmentReviewTaskDAL.SelectFilter selectFilter = PunishmentReviewTaskDAL.SelectFilter.ReportID;
			return EntityHelper.DoGetByLookup<long, PunishmentReviewTaskDAL, PunishmentReviewTask>(() => PunishmentReviewTaskDAL.Get(selectFilter, id), $"{lookupFilter}:{id}");
		}
		default:
			throw new ApplicationException($"Unknown LookupFilter: {lookupFilter}");
		}
	}

	internal static PunishmentReviewTask CreateNew(Report report)
	{
		if (report == null)
		{
			return null;
		}
		PunishmentReviewTask punishmentReviewTask = new PunishmentReviewTask();
		punishmentReviewTask.UserID = report.AllegedAbuserID;
		punishmentReviewTask.ReportID = report.ID;
		punishmentReviewTask.Save();
		return punishmentReviewTask;
	}

	internal static PunishmentReviewTask CreateNew(long userId, long reportId, byte? priority)
	{
		PunishmentReviewTask punishmentReviewTask = new PunishmentReviewTask();
		punishmentReviewTask.UserID = userId;
		punishmentReviewTask.ReportID = reportId;
		punishmentReviewTask.Priority = priority;
		punishmentReviewTask.Save();
		return punishmentReviewTask;
	}

	public static PunishmentReviewTask Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static PunishmentReviewTask Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static PunishmentReviewTask Get<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		return EntityHelper.GetEntityByLookupOld<long, PunishmentReviewTask>(EntityCacheInfo, $"{lookupFilter}:{id}", () => DoGet(lookupFilter, id));
	}

	public static ICollection<PunishmentReviewTask> GetClosedTasks(long moderatorId, int itemCount, int timeframe, bool randomize)
	{
		ICollection<PunishmentReviewTask> entities = new List<PunishmentReviewTask>();
		foreach (long taskId in PunishmentReviewTaskDAL.GetClosedTaskIDs(moderatorId, itemCount, timeframe, randomize))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static ICollection<PunishmentReviewTask> GetOpenTasksPaged(int startRowIndex, int maximumRows)
	{
		ICollection<PunishmentReviewTask> entities = new List<PunishmentReviewTask>();
		foreach (long taskId in PunishmentReviewTaskDAL.GetOpenTaskIDsPaged(startRowIndex + 1, maximumRows))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static ICollection<long> GetOpenAssignedUserIDsPaged(long moderatorId, int startRowIndex, int maximumRows)
	{
		return PunishmentReviewTaskDAL.GetOpenAssignedUserIDsPaged(moderatorId, startRowIndex + 1, maximumRows);
	}

	public static ICollection<PunishmentReviewTask> GetOpenTasksByAssignedUserID(IPunishableUser punishableUser)
	{
		return GetOpenTasksByAssignedUserID(punishableUser.ID);
	}

	internal static ICollection<PunishmentReviewTask> GetOpenTasksByAssignedUserID(long punishableUserId)
	{
		ICollection<PunishmentReviewTask> entities = new List<PunishmentReviewTask>();
		foreach (long item in PunishmentReviewTaskDAL.GetOpenTaskIDsByAssignedUserID(punishableUserId))
		{
			PunishmentReviewTask punishmentReviewTask = Get(item);
			if (punishmentReviewTask != null)
			{
				entities.Add(punishmentReviewTask);
			}
		}
		return entities;
	}

	public static int GetTotalNumberOfOpenAssignedUsers(long moderatorId)
	{
		return PunishmentReviewTaskDAL.GetTotalNumberOfOpenAssignedUsers(moderatorId);
	}

	public static int GetTotalNumberOfActiveModerators()
	{
		return PunishmentReviewTaskDAL.GetTotalNumberOfActiveModerators();
	}

	public static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int offsetForReviewedTimeInMinutes = 5)
	{
		return PunishmentReviewTaskDAL.GetTotalNumberOfActiveAndRecentlyActiveModerators(offsetForReviewedTimeInMinutes);
	}

	public static int GetTotalNumberOfOpenUnassignedUsers()
	{
		return PunishmentReviewTaskDAL.GetTotalNumberOfOpenUnassignedUsers();
	}

	public static int GetTotalNumberOfOpenUsers()
	{
		return PunishmentReviewTaskDAL.GetTotalNumberOfOpenUsers();
	}

	public static int GetAgeOfOldestUnmoderatedPlayerTaskInSeconds()
	{
		return PunishmentReviewTaskDAL.GetAgeOfOldestUnmoderatedPlayerTaskInSeconds();
	}

	public void Construct(PunishmentReviewTaskDAL dal)
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
