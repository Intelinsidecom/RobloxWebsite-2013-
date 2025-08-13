using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupRelationshipRequest : IRobloxEntity<long, GroupRelationshipRequestDAL>, ICacheableObject<long>, ICacheableObject
{
	private GroupRelationshipRequestDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupRelationshipRequest", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public long RelatedGroupID
	{
		get
		{
			return _EntityDAL.RelatedGroupID;
		}
		set
		{
			_EntityDAL.RelatedGroupID = value;
		}
	}

	public byte GroupRelationshipTypeID
	{
		get
		{
			return _EntityDAL.GroupRelationshipTypeID;
		}
		set
		{
			_EntityDAL.GroupRelationshipTypeID = value;
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

	public GroupRelationshipRequest()
	{
		_EntityDAL = new GroupRelationshipRequestDAL();
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

	public static GroupRelationshipRequest CreateNew(long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		GroupRelationshipRequest groupRelationshipRequest = new GroupRelationshipRequest();
		groupRelationshipRequest.GroupID = groupId;
		groupRelationshipRequest.RelatedGroupID = relatedGroupId;
		groupRelationshipRequest.GroupRelationshipTypeID = groupRelationshipTypeId;
		groupRelationshipRequest.Save();
		return groupRelationshipRequest;
	}

	public static GroupRelationshipRequest Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupRelationshipRequestDAL, GroupRelationshipRequest>(EntityCacheInfo, id, () => GroupRelationshipRequestDAL.Get(id));
	}

	public static ICollection<GroupRelationshipRequest> GetGroupRelationshipRequestsByGroupIDRelatedGroupIDAndGroupRelationshipTypeID(long groupId, long relatedGroupId, byte groupRelationshipTypeId, int count, long? exclusiveStartId = null)
	{
		string collectionId = $"GetGroupRelationshipRequestsV2ByGroupIDRelatedGroupIDAndGroupRelationshipTypeID_GroupID:{groupId}_RelatedGroupID:{relatedGroupId}_GroupRelationshipTypeID:{groupRelationshipTypeId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheQualifierByGroupIDRelatedGroupIDGroupRelationshipTypeID(groupId, relatedGroupId, groupRelationshipTypeId)), collectionId, () => GroupRelationshipRequestDAL.GetGroupRelationshipRequestIDsByGroupIDRelatedGroupIDAndGroupRelationshipTypeID(groupId, relatedGroupId, groupRelationshipTypeId, count, exclusiveStartId), Get);
	}

	public static int GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndRelatedGroupIDAndTypeID(long groupId, long relatedGroupId, byte typeId)
	{
		if (groupId == 0L || typeId == 0)
		{
			return 0;
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheQualifierByGroupIDRelatedGroupIDGroupRelationshipTypeID(groupId, relatedGroupId, typeId)), $"GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndRelatedGroupIDAndTypeID_GroupID:{groupId}_RelatedGroupID:{relatedGroupId}_TypeID:{typeId}", () => GroupRelationshipRequestDAL.GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndRelatedGroupIDAndTypeID(groupId, relatedGroupId, typeId));
	}

	public static ICollection<GroupRelationshipRequest> GetGroupRelationshipRequestsByGroupIDAndTypeIDPaged(long groupId, byte typeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupRelationshipRequestsByGroupAndTypePaged_GroupID:{groupId}_TypeID:{typeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}_TypeID:{typeId}"), collectionId, () => GroupRelationshipRequestDAL.GetGroupRelationshipRequestIDsByGroupIDAndTypeIDPaged(groupId, typeId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndTypeID(long groupId, byte typeId)
	{
		if (groupId == 0L || typeId == 0)
		{
			return 0;
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}_TypeID:{typeId}"), $"GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndTypeID_GroupID:{groupId}_TypeID:{typeId}", () => GroupRelationshipRequestDAL.GetTotalNumberOfGroupRelationshipRequestsByGroupIDAndTypeID(groupId, typeId));
	}

	public void Construct(GroupRelationshipRequestDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}_TypeID:{GroupRelationshipTypeID}");
		yield return new StateToken(GetCacheQualifierByGroupIDRelatedGroupIDGroupRelationshipTypeID(GroupID, RelatedGroupID, GroupRelationshipTypeID));
	}

	private static string GetCacheQualifierByGroupIDRelatedGroupIDGroupRelationshipTypeID(long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		return $"GroupID:{groupId}_RelatedGroupID:{relatedGroupId}_TypeID:{groupRelationshipTypeId}";
	}
}
