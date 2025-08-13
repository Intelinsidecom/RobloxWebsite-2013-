using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Caching;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

public class GroupRoleSet : IEquatable<GroupRoleSet>, IRobloxEntity<long, GroupRoleSetDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum Sort
	{
		Name,
		Rank,
		Created,
		Updated
	}

	public enum SortOrder
	{
		Ascending,
		Descending
	}

	/// Enums *
	public const byte GuestRank = 0;

	public const byte OwnerRank = byte.MaxValue;

	/// DAL Object *
	private GroupRoleSetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false), "GroupRoleSet", isNullCacheable: false);

	/// Data Members *
	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false)]
	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		internal set
		{
			_EntityDAL.Name = value;
		}
	}

	[DataObjectField(false, false, true)]
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
	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		internal set
		{
			_EntityDAL.Description = value;
		}
	}

	[DataObjectField(false, false, false)]
	public byte Rank
	{
		get
		{
			return _EntityDAL.Rank;
		}
		set
		{
			_EntityDAL.Rank = value;
		}
	}

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	/// Public Methods *
	public ICollection<GroupRoleSetPermission> GetPermissions()
	{
		ICollection<GroupRoleSetPermission> rankList = GroupRoleSetPermission.GetRoleSetPermissionsByRoleSetID(ID);
		if (Rank == byte.MaxValue && rankList.Count < Enum.GetValues(typeof(GroupRoleSetPermissionType)).Length)
		{
			foreach (GroupRoleSetPermissionType type in GroupRoleSetPermissionType.GetAllPermissions())
			{
				GroupRoleSetPermission.GetOrCreate(ID, type);
			}
		}
		return rankList;
	}

	public bool HasPermission(GroupRoleSetPermissionType.Permission permission)
	{
		Group group = Group.Get(GroupID);
		if (group == null || group.IsLocked)
		{
			return false;
		}
		if (Rank == byte.MaxValue)
		{
			return true;
		}
		foreach (GroupRoleSetPermission permission2 in GetPermissions())
		{
			if (permission2.GetRoleSetPermissionType() == permission)
			{
				return true;
			}
		}
		return false;
	}

	/// Constructors *
	public GroupRoleSet(GroupRoleSetDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupRoleSet()
	{
		_EntityDAL = new GroupRoleSetDAL();
	}

	public void Construct(GroupRoleSetDAL dal)
	{
		_EntityDAL = dal;
	}

	/// CRUD *
	internal void Delete()
	{
		foreach (GroupRoleSetPermission item in GroupRoleSetPermission.GetRoleSetPermissionsByRoleSetID(ID))
		{
			item.Delete();
		}
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

	internal static GroupRoleSet CreateNew(long groupId, string name, string description, byte rank)
	{
		GroupRoleSet groupRoleSet = new GroupRoleSet();
		groupRoleSet.GroupID = groupId;
		groupRoleSet.Name = name;
		groupRoleSet.Description = description;
		groupRoleSet.Rank = rank;
		groupRoleSet.Save();
		return groupRoleSet;
	}

	private static GroupRoleSet DoGetOrCreate(long groupId, string name, string description, byte rank)
	{
		return EntityHelper.DoGetOrCreate<long, GroupRoleSetDAL, GroupRoleSet>(() => GroupRoleSetDAL.GetOrCreate(groupId, name, description, rank));
	}

	internal static GroupRoleSet GetOrCreate(long groupId, string name, string description, byte rank)
	{
		return EntityHelper.GetOrCreateEntity<long, GroupRoleSet>(EntityCacheInfo, $"GroupID:{groupId}_Name:{name}", () => DoGetOrCreate(groupId, name, description, rank));
	}

	/// Getters (single) *
	public static GroupRoleSet Get(long? userId, long groupId)
	{
		if (!userId.HasValue)
		{
			return GetGuestRoleSet(groupId);
		}
		UserGroup ug = UserGroup.Get(userId.Value, groupId);
		if (ug == null)
		{
			return GetGuestRoleSet(groupId);
		}
		return Get(ug.RoleSetID);
	}

	public static GroupRoleSet Get(long groupId, string name)
	{
		if (Settings.Default.UseSparsePairTestForGroupRoleSetsEnabled)
		{
			IDictionary<string, GroupRoleSet> groupRoleSets = GetGroupRoleSetsDictionaryByGroupId(groupId);
			if (groupRoleSets == null || !groupRoleSets.TryGetValue(name, out var groupRoleSet))
			{
				return null;
			}
			return groupRoleSet;
		}
		return EntityHelper.GetEntityByLookup<long, GroupRoleSetDAL, GroupRoleSet>(EntityCacheInfo, $"GroupID:{groupId}_Name:{name}", () => GroupRoleSetDAL.Get(groupId, name));
	}

	public static GroupRoleSet Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupRoleSetDAL, GroupRoleSet>(EntityCacheInfo, id, () => GroupRoleSetDAL.Get(id));
	}

	public static ICollection<GroupRoleSet> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntitiesByIds<GroupRoleSet, GroupRoleSetDAL, long>(EntityCacheInfo, ids.ToList().AsReadOnly(), GroupRoleSetDAL.MultiGet).ToList();
	}

	public static GroupRoleSet GetGuestRoleSet(long groupId)
	{
		return Get(groupId, "Guest");
	}

	/// Getters (multiple) / Totals *
	internal static IDictionary<string, GroupRoleSet> GetGroupRoleSetsDictionaryByGroupId(long groupId)
	{
		string key = $"Roblox.GetGroupRoleSetsSetByGroupId_GroupID:{groupId}";
		IDictionary<string, GroupRoleSet> groupRoleSetDictionary = (IDictionary<string, GroupRoleSet>)HttpRuntime.Cache.Get(key);
		if (groupRoleSetDictionary == null)
		{
			groupRoleSetDictionary = GetGroupRoleSetsByGroupID(groupId).ToDictionary((GroupRoleSet grs) => grs.Name, (GroupRoleSet grs) => grs);
			string qualifier = $"GroupID:{groupId}";
			string[] dependencyKeys = new string[1] { Cacheable.BuildStateTokenKey(EntityCacheInfo, CacheManager.CacheScopeFilter.Qualified, qualifier) };
			CacheDependency cacheDepenency = new CacheDependency(null, dependencyKeys);
			HttpRuntime.Cache.Insert(key, groupRoleSetDictionary, cacheDepenency, Cache.NoAbsoluteExpiration, LocalCache.GlobalSlidingExpiration);
		}
		return groupRoleSetDictionary;
	}

	public static ICollection<GroupRoleSet> GetGroupRoleSetsByGroupID(long groupId)
	{
		string collectionId = $"GetRoleSetsByGroupID_GroupID{groupId}";
		if (Settings.Default.IsMultiGetGroupRoleSetsEnabled)
		{
			return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupRoleSetDAL.GetGroupRoleSetIDsByGroupID(groupId), MultiGet);
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupRoleSetDAL.GetGroupRoleSetIDsByGroupID(groupId), Get);
	}

	public static ICollection<GroupRoleSet> GetGroupRoleSetsByGroupIDAndMaxRank(long groupId, byte maxRank)
	{
		string collectionId = $"GetGroupRoleSetsByGroupIDAndMaxRank_GroupID{groupId}_MaxRank{maxRank}";
		if (Settings.Default.IsMultiGetGroupRoleSetsEnabled)
		{
			return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupRoleSetDAL.GetGroupRoleSetIDsByGroupIDAndMaxRank(groupId, maxRank), MultiGet);
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), collectionId, () => GroupRoleSetDAL.GetGroupRoleSetIDsByGroupIDAndMaxRank(groupId, maxRank), Get);
	}

	public static int GetTotalNumberOfGroupRoleSetsByGroupID(long groupId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GroupID:{groupId}"), $"GetTotalNumberOfGroupRoleSetsByGroupID_GroupID:{groupId}", () => GroupRoleSetDAL.GetTotalNumberOfGroupRoleSetsByGroupID(groupId));
	}

	public static GroupRoleSet GetOwnerGroupRoleSetByGroupID(long groupId)
	{
		return EntityHelper.GetEntityByLookup<long, GroupRoleSetDAL, GroupRoleSet>(EntityCacheInfo, $"Owner_GroupID:{groupId}", () => GroupRoleSetDAL.GetOwnerGroupRoleSetByGroupID(groupId));
	}

	public static GroupRoleSet GetDefaultStartingRoleSetByGroupID(long groupId)
	{
		List<GroupRoleSet> grs = (List<GroupRoleSet>)GetGroupRoleSetsByGroupID(groupId);
		if (grs.Count == 0 || grs.Count == 1)
		{
			return null;
		}
		return grs.OrderBy((GroupRoleSet a) => a.Rank).ToList()[1];
	}

	/// Operators *
	public static bool operator ==(GroupRoleSet lhs, GroupRoleSet rhs)
	{
		if ((object)lhs == null)
		{
			return (object)rhs == null;
		}
		if ((object)rhs == null)
		{
			return false;
		}
		if (lhs.ID == rhs.ID)
		{
			return lhs.GroupID == rhs.GroupID;
		}
		return false;
	}

	public static bool operator !=(GroupRoleSet lhs, GroupRoleSet rhs)
	{
		return !(lhs == rhs);
	}

	public override bool Equals(object obj)
	{
		GroupRoleSet other = obj as GroupRoleSet;
		return this == other;
	}

	public override int GetHashCode()
	{
		return ID.GetHashCode();
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public bool Equals(GroupRoleSet other)
	{
		return this == other;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add($"GroupID:{GroupID}_Name:{Name}");
			idLookups.Add($"Owner_GroupID:{GroupID}");
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"GroupID:{GroupID}")
		};
	}
}
