using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class AssetReviewTask : IRobloxEntity<long, AssetReviewTaskDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum LookupFilter
	{
		AssetHashID,
		ID
	}

	private AssetReviewTaskDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetReviewTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		internal set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		internal set
		{
			_EntityDAL.AssetTypeID = value;
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetReviewTask()
	{
		_EntityDAL = new AssetReviewTaskDAL();
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

	private static AssetReviewTask CreateNew(long assetHashId, int assetTypeId)
	{
		AssetReviewTask assetReviewTask = new AssetReviewTask();
		assetReviewTask.AssetHashID = assetHashId;
		assetReviewTask.AssetTypeID = assetTypeId;
		assetReviewTask.Save();
		return assetReviewTask;
	}

	private static AssetReviewTask DoGet(long id)
	{
		return EntityHelper.DoGet<long, AssetReviewTaskDAL, AssetReviewTask>(() => AssetReviewTaskDAL.Get(id), id);
	}

	private static AssetReviewTask DoGet<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		switch (lookupFilter)
		{
		case LookupFilter.ID:
			return DoGet(Convert.ToInt64(id));
		case LookupFilter.AssetHashID:
		{
			AssetReviewTaskDAL.SelectFilter selectFilter = AssetReviewTaskDAL.SelectFilter.AssetHashID;
			return EntityHelper.DoGetByLookup<long, AssetReviewTaskDAL, AssetReviewTask>(() => AssetReviewTaskDAL.Get(selectFilter, id), $"{lookupFilter}:{id}");
		}
		default:
			throw new ApplicationException($"Unknown LookupFilter: {lookupFilter}");
		}
	}

	internal static AssetReviewTask CreateNew(IReviewableAsset reviewableAsset)
	{
		return CreateNew(reviewableAsset.HashID, reviewableAsset.TypeID);
	}

	internal static AssetReviewTask GetOrCreate(long assetHashId, int assetTypeId)
	{
		return Get(LookupFilter.AssetHashID, assetHashId) ?? CreateNew(assetHashId, assetTypeId);
	}

	public static AssetReviewTask Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static AssetReviewTask Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AssetReviewTask Get<T>(LookupFilter lookupFilter, T id) where T : IComparable<T>
	{
		return EntityHelper.GetEntityByLookupOld<long, AssetReviewTask>(EntityCacheInfo, $"{lookupFilter}:{id}", () => DoGet(lookupFilter, id));
	}

	public static ICollection<AssetReviewTask> GetOpenTasksPaged(int assetTypeId, int startRowIndex, int maximumRows)
	{
		ICollection<AssetReviewTask> entities = new List<AssetReviewTask>();
		foreach (long taskId in AssetReviewTaskDAL.GetOpenTaskIDsPaged(assetTypeId, startRowIndex + 1, maximumRows))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static ICollection<AssetReviewTask> GetOpenAssignedTasksPaged(int assetTypeId, long moderatorId, int startRowIndex, int maximumRows)
	{
		ICollection<AssetReviewTask> entities = new List<AssetReviewTask>();
		foreach (long taskId in AssetReviewTaskDAL.GetOpenAssignedTaskIDsPaged(assetTypeId, moderatorId, startRowIndex + 1, maximumRows))
		{
			entities.Add(Get(taskId));
		}
		return entities;
	}

	public static int GetTotalNumberOfOpenAssignedTasks(int assetTypeId, long moderatorId)
	{
		return AssetReviewTaskDAL.GetTotalNumberOfOpenAssignedTasks(assetTypeId, moderatorId);
	}

	public static int GetTotalNumberOfOpenTasks(int assetTypeId)
	{
		return AssetReviewTaskDAL.GetTotalNumberOfOpenTasks(assetTypeId);
	}

	public static int GetTotalNumberOfOpenUnassignedTasks(int assetTypeId)
	{
		return AssetReviewTaskDAL.GetTotalNumberOfOpenUnassignedTasks(assetTypeId);
	}

	public static int GetAgeOfOldestUnmoderatedTaskInSeconds(int assetTypeId)
	{
		return AssetReviewTaskDAL.GetAgeOfOldestUnmoderatedTaskInSeconds(assetTypeId);
	}

	public static int GetTotalNumberOfActiveModerators(int assetTypeId)
	{
		return AssetReviewTaskDAL.GetTotalNumberOfActiveModerators(assetTypeId);
	}

	public static int GetTotalNumberOfActiveAndRecentlyActiveModerators(int assetTypeId, int offsetForReviewedTimeInMinutes = 5)
	{
		return AssetReviewTaskDAL.GetTotalNumberOfActiveAndRecentlyActiveModerators(assetTypeId, offsetForReviewedTimeInMinutes);
	}

	public void Construct(AssetReviewTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"{LookupFilter.AssetHashID}:{AssetHashID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
