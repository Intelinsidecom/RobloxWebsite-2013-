using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

[Serializable]
public class GroupJoinRequest : IEquatable<GroupJoinRequest>, IRobloxEntity<long, GroupJoinRequestDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupJoinRequestDAL _EntityDAL;

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false)]
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

	[DataObjectField(false, false, false)]
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

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static CacheInfo EntityCacheInfo => new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GroupJoinRequest", isNullCacheable: true);

	public GroupJoinRequest(GroupJoinRequestDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupJoinRequest()
	{
		_EntityDAL = new GroupJoinRequestDAL();
	}

	public void Delete()
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

	public static GroupJoinRequest CreateNew(long groupId, long userID)
	{
		GroupJoinRequest groupJoinRequest = new GroupJoinRequest();
		groupJoinRequest.GroupID = groupId;
		groupJoinRequest.UserID = userID;
		groupJoinRequest.Save();
		return groupJoinRequest;
	}

	private static GroupJoinRequest DoGet(long id)
	{
		return EntityHelper.DoGet<long, GroupJoinRequestDAL, GroupJoinRequest>(() => GroupJoinRequestDAL.Get(id), id);
	}

	private static GroupJoinRequest DoGet(long groupId, long userId)
	{
		return EntityHelper.DoGetByLookup<long, GroupJoinRequestDAL, GroupJoinRequest>(() => GroupJoinRequestDAL.Get(groupId, userId), null);
	}

	public static GroupJoinRequest Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static GroupJoinRequest Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static GroupJoinRequest Get(long groupId, long userID)
	{
		return EntityHelper.GetEntityByLookupOld<long, GroupJoinRequest>(EntityCacheInfo, $"GroupID:{groupId}_UserID:{userID}", () => DoGet(groupId, userID));
	}

	public static ICollection<GroupJoinRequest> GetGroupJoinRequestsByGroupID(long groupId)
	{
		string collectionId = $"GetGroupJoinRequestsByGroupID_GroupID:{groupId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupJoinRequestDAL.GetGroupJoinRequestIDsByGroupID(groupId), Get);
	}

	public static ICollection<GroupJoinRequest> GetGroupJoinRequestsByGroupIDEnumerative(long groupId, long? exclusiveStartId, int maximumRows)
	{
		string collectionId = $"GetGroupJoinRequestsByGroupID_GroupID:{groupId}_ExclusiveStartID:{exclusiveStartId}_Count:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupJoinRequestDAL.GetGroupJoinRequestsIDsByGroupIDEnumerative(groupId, exclusiveStartId, maximumRows), Get);
	}

	public static ICollection<GroupJoinRequest> GetGroupJoinRequestsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupJoinRequestsByGroupIDPaged_GroupID:{groupId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupJoinRequestDAL.GetGroupJoinRequestIDsByGroupIDPaged(groupId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<GroupJoinRequest> GetGroupJoinRequestsByUserID(long userID)
	{
		string collectionId = $"GetGroupJoinRequestsByUserID_UserID:{userID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}"), collectionId, () => GroupJoinRequestDAL.GetGroupJoinRequestIDsByUserID(userID), Get);
	}

	public static int GetTotalNumberOfGroupJoinRequestsByGroupID(long groupId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetTotalNumberOfGroupJoinRequestsByGroupID_GroupID:{groupId}", () => GroupJoinRequestDAL.GetTotalNumberOfGroupJoinRequestsByGroupID(groupId));
	}

	public static int GetTotalNumberOfGroupJoinRequestsByUserID(long userID)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}"), $"GetTotalNumberOfGroupJoinRequestsByUserID_UserID:{userID}", () => GroupJoinRequestDAL.GetTotalNumberOfGroupJoinRequestsByUserID(userID));
	}

	public void Construct(GroupJoinRequestDAL dal)
	{
		_EntityDAL = dal;
	}

	public bool Equals(GroupJoinRequest other)
	{
		return ID == other?.ID;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add($"GroupID:{GroupID}_UserID:{UserID}");
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}");
		yield return new StateToken($"GroupID:{GroupID}");
	}
}
