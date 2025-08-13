using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupRelationship : IRobloxEntity<long, GroupRelationshipDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GroupRelationshipDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GroupRelationship", isNullCacheable: true);

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

	public GroupRelationship()
	{
		_EntityDAL = new GroupRelationshipDAL();
	}

	public GroupRelationship(GroupRelationshipDAL entityDal)
	{
		_EntityDAL = entityDal;
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

	public static GroupRelationship CreateNew(long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		GroupRelationship groupRelationship = new GroupRelationship();
		groupRelationship.GroupID = groupId;
		groupRelationship.RelatedGroupID = relatedGroupId;
		groupRelationship.GroupRelationshipTypeID = groupRelationshipTypeId;
		groupRelationship.Save();
		return groupRelationship;
	}

	public static GroupRelationship Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupRelationshipDAL, GroupRelationship>(EntityCacheInfo, id, () => GroupRelationshipDAL.Get(id));
	}

	public static GroupRelationship Get(long groupId, long relatedGroupId, byte groupRelationshipTypeId)
	{
		return EntityHelper.GetEntityByLookup<long, GroupRelationshipDAL, GroupRelationship>(EntityCacheInfo, $"GroupID:{groupId}_RelatedGroupID:{relatedGroupId}_GroupRelationshipTypeID:{groupRelationshipTypeId}", () => GroupRelationshipDAL.Get(groupId, relatedGroupId, groupRelationshipTypeId));
	}

	public static ICollection<GroupRelationship> GetGroupRelationshipsByGroupIDAndTypeIDPaged(long groupId, byte typeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupRelationshipsByGroupAndTypePaged_GroupID:{groupId}_TypeID:{typeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}_TypeID:{typeId}"), collectionId, () => GroupRelationshipDAL.GetGroupRelationshipIDsByGroupIDAndTypeIDPaged(groupId, typeId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID(long groupId, byte typeId)
	{
		if (groupId == 0L || typeId == 0)
		{
			return 0;
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}_TypeID:{typeId}"), $"GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID_GroupID:{groupId}_TypeID:{typeId}", () => GroupRelationshipDAL.GetTotalNumberOfGroupRelationshipsByGroupIDAndTypeID(groupId, typeId));
	}

	public void Construct(GroupRelationshipDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"GroupID:{GroupID}_RelatedGroupID:{RelatedGroupID}_GroupRelationshipTypeID:{GroupRelationshipTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupID:{GroupID}_TypeID:{GroupRelationshipTypeID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
