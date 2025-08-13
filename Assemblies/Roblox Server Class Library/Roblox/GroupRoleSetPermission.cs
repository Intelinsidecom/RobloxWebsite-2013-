using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupRoleSetPermission : IEquatable<GroupRoleSetPermission>, IRobloxEntity<long, GroupRoleSetPermissionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GroupRoleSetPermissionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "GroupRoleSetPermission", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long RoleSetID
	{
		get
		{
			return _EntityDAL.RoleSetID;
		}
		internal set
		{
			_EntityDAL.RoleSetID = value;
		}
	}

	public int RoleSetPermissionTypeID
	{
		get
		{
			return _EntityDAL.RoleSetPermissionTypeID;
		}
		internal set
		{
			_EntityDAL.RoleSetPermissionTypeID = value;
		}
	}

	public GroupRoleSetPermissionType.PermissionCategory RoleSetPermissionTypeCategory
	{
		get
		{
			return (GroupRoleSetPermissionType.PermissionCategory)_EntityDAL.RoleSetPermissionTypeCategoryID;
		}
		internal set
		{
			_EntityDAL.RoleSetPermissionTypeCategoryID = (byte)value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GroupRoleSetPermissionType GetRoleSetPermissionType()
	{
		return GroupRoleSetPermissionType.Get(RoleSetPermissionTypeID);
	}

	public GroupRoleSetPermission(GroupRoleSetPermissionDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupRoleSetPermission()
	{
		_EntityDAL = new GroupRoleSetPermissionDAL();
	}

	public void Construct(GroupRoleSetPermissionDAL dal)
	{
		_EntityDAL = dal;
	}

	public void Delete()
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

	private static GroupRoleSetPermission DoGetOrCreate(long roleSetId, int roleSetPermissionTypeId, byte roleSetPermissionTypeCategoryId)
	{
		return EntityHelper.DoGetOrCreate<long, GroupRoleSetPermissionDAL, GroupRoleSetPermission>(() => GroupRoleSetPermissionDAL.GetOrCreate(roleSetId, roleSetPermissionTypeId, roleSetPermissionTypeCategoryId));
	}

	public static GroupRoleSetPermission GetOrCreate(long roleSetId, GroupRoleSetPermissionType.Permission perm)
	{
		return GetOrCreate(roleSetId, GroupRoleSetPermissionType.Get(perm));
	}

	public static GroupRoleSetPermission GetOrCreate(long roleSetId, GroupRoleSetPermissionType permType)
	{
		return GetOrCreate(roleSetId, permType.ID, (byte)permType.Category);
	}

	public static GroupRoleSetPermission GetOrCreate(long roleSetId, int roleSetPermissionTypeId, byte roleSetPermissionTypeCategoryId)
	{
		return EntityHelper.GetOrCreateEntity<long, GroupRoleSetPermission>(EntityCacheInfo, $"RoleSetID:{roleSetId}_RoleSetPermissionTypeID:{roleSetPermissionTypeId}_RoleSetPermissionTypeCategoryID:{roleSetPermissionTypeCategoryId}", () => DoGetOrCreate(roleSetId, roleSetPermissionTypeId, roleSetPermissionTypeCategoryId));
	}

	public static GroupRoleSetPermission Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupRoleSetPermissionDAL, GroupRoleSetPermission>(EntityCacheInfo, id, () => GroupRoleSetPermissionDAL.Get(id));
	}

	public static GroupRoleSetPermission GetByRoleSetIDAndTypeID(long roleSetId, int typeId)
	{
		return EntityHelper.GetEntityByLookup<long, GroupRoleSetPermissionDAL, GroupRoleSetPermission>(EntityCacheInfo, $"RoleSetID:{roleSetId}_TypeID:{typeId}", () => GroupRoleSetPermissionDAL.GetByRoleSetIDAndTypeID(roleSetId, typeId));
	}

	public static int GetTotalNumberOfRoleSetPermissionsByRoleSetID(long roleSetId)
	{
		string countId = $"GetTotalNumberOfRoleSetPermissionsByRoleSetID_RoleSetID:{roleSetId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"RoleSetID:{roleSetId}"), countId, () => GroupRoleSetPermissionDAL.GetTotalNumberOfRoleSetPermissionsByRoleSetID(roleSetId));
	}

	public static ICollection<GroupRoleSetPermission> GetRoleSetPermissionsByRoleSetID(long roleSetID)
	{
		string collectionId = "GetRoleSetPermissionsByRoleSetID: " + roleSetID;
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupRoleSetID:{roleSetID}"), collectionId, () => GroupRoleSetPermissionDAL.GetRoleSetPermissionIDsByRoleSetID(roleSetID), Get);
	}

	public bool Equals(GroupRoleSetPermission other)
	{
		return this == other;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"RoleSetID:{RoleSetID}_TypeID:{RoleSetPermissionTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GroupRoleSetID:{RoleSetID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
