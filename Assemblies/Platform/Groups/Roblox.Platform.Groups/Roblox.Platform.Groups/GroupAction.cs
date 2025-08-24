using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupAction : IRobloxEntity<long, GroupActionDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupActionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupAction", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	public int ActionTypeID
	{
		get
		{
			return _EntityDAL.ActionTypeID;
		}
		set
		{
			_EntityDAL.ActionTypeID = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GroupAction()
	{
		_EntityDAL = new GroupActionDAL();
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

	public static GroupAction CreateNew(long userid, long groupid, int actiontypeid, string description)
	{
		GroupAction groupAction = new GroupAction();
		groupAction.UserID = userid;
		groupAction.GroupID = groupid;
		groupAction.ActionTypeID = actiontypeid;
		groupAction.Description = description;
		groupAction.Save();
		return groupAction;
	}

	public static GroupAction Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupActionDAL, GroupAction>(EntityCacheInfo, id, () => GroupActionDAL.Get(id));
	}

	public static ICollection<GroupAction> GetGroupActionsByGroupIDAndSearchCriteriaPaged(long groupId, long? userId, int? actionTypeId, int startRowIndex, int maximumRows)
	{
		if (userId.HasValue && actionTypeId.HasValue)
		{
			return GetGroupActionsByGroupIDUserIDAndActionTypeIDPaged(groupId, userId.Value, actionTypeId.Value, startRowIndex, maximumRows);
		}
		if (userId.HasValue)
		{
			return GetGroupActionsByGroupIDAndUserIDPaged(groupId, userId.Value, startRowIndex, maximumRows);
		}
		if (actionTypeId.HasValue)
		{
			return GetGroupActionsByGroupIDAndActionTypeIDPaged(groupId, actionTypeId.Value, startRowIndex, maximumRows);
		}
		return GetGroupActionsByGroupIDPaged(groupId, startRowIndex, maximumRows);
	}

	public static int GetTotalNumberOfGroupActionsByGroupIDAndSearchCriteria(long groupId, long? userId, int? actionTypeId)
	{
		if (userId.HasValue && actionTypeId.HasValue)
		{
			return GetTotalNumberOfGroupActionsByGroupIDUserIDAndActionTypeID(groupId, userId.Value, actionTypeId.Value);
		}
		if (userId.HasValue)
		{
			return GetTotalNumberOfGroupActionsByGroupIDAndUserID(groupId, userId.Value);
		}
		if (actionTypeId.HasValue)
		{
			return GetTotalNumberOfGroupActionsByGroupIDAndActionTypeID(groupId, actionTypeId.Value);
		}
		return GetTotalNumberOfGroupActionsByGroupID(groupId);
	}

	public static ICollection<GroupAction> GetGroupActionsByGroupIDUserIDAndActionTypeIDPaged(long groupId, long userId, int actionTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupActionsByGroupIDUserIDAndActionTypeIDPaged_GroupID:{groupId}_UserID:{userId}_ActionTypeID:{actionTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetGroupActionIDsByGroupIDUserIDAndActionTypeIDPaged(groupId, userId, actionTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<GroupAction> GetGroupActionsByGroupIDAndUserIDPaged(long groupId, long userId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupActionsByGroupIDAndUserIDPaged_GroupID:{groupId}_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetGroupActionIDsByGroupIDAndUserIDPaged(groupId, userId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<GroupAction> GetGroupActionsByGroupIDAndActionTypeIDPaged(long groupId, int actionTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupActionsByGroupIDAndActionTypeIDPaged_GroupID:{groupId}_ActionTypeID:{actionTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetGroupActionIDsByGroupIDAndActionTypeIDPaged(groupId, actionTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<GroupAction> GetGroupActionsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupActionsByGroupIDPaged_GroupID:{groupId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetGroupActionIDsByGroupIDPaged(groupId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfGroupActionsByGroupIDUserIDAndActionTypeID(long groupId, long userId, int actionTypeId)
	{
		string collectionId = $"GetTotalNumberOfGroupActionsByGroupIDUserIDAndActionTypeID_GroupID:{groupId}_UserID:{userId}_ActionTypeID:{actionTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetTotalNumberOfGroupActionsByGroupIDUserIDAndActionTypeID(groupId, userId, actionTypeId));
	}

	public static int GetTotalNumberOfGroupActionsByGroupIDAndUserID(long groupId, long userId)
	{
		string collectionId = $"GetTotalNumberOfGroupActionsByGroupIDAndUserID_GroupID:{groupId}_UserID:{userId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetTotalNumberOfGroupActionsByGroupIDAndUserID(groupId, userId));
	}

	public static int GetTotalNumberOfGroupActionsByGroupIDAndActionTypeID(long groupId, int actionTypeId)
	{
		string collectionId = $"GetTotalNumberOfGroupActionsByGroupIDAndActionTypeID_GroupID:{groupId}_ActionTypeID:{actionTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetTotalNumberOfGroupActionsByGroupIDAndActionTypeID(groupId, actionTypeId));
	}

	public static int GetTotalNumberOfGroupActionsByGroupID(long groupId)
	{
		string collectionId = $"GetTotalNumberOfGroupActionsByGroupID_GroupID:{groupId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupActionDAL.GetTotalNumberOfGroupActionsByGroupID(groupId));
	}

	public void Construct(GroupActionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}");
	}
}
