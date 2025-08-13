using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class GroupRoleSetPermissionType : IEquatable<GroupRoleSetPermissionType>, IRobloxEntity<int, GroupRoleSetPermissionTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	/// Enums *
	public enum Permission
	{
		/// WARNING: These are letter for letter the same values as the "Name" field in the database and must stay that way *
		/// NOTE:  Associated image icons are retrieved by using enumVal.ToString()+".png" from the images/groups/permissions folder *
		CanDeletePosts,
		CanPostToWall,
		CanInviteMembers,
		CanPostToStatus,
		CanRemoveMembers,
		CanViewStatus,
		CanViewWall,
		CanChangeRank,
		CanAdvertise,
		CanManageRelationships,
		CanAddGroupPlaces,
		CanViewAuditLog,
		CanCreateItems,
		CanManageItems,
		CanSpendGroupFunds,
		CanManageClan,
		CanManageGroupGames
	}

	public enum PermissionCategory
	{
		/// Hard coded.  Deal. *
		Group = 1,
		Building
	}

	private static LazyWithRetry<List<GroupRoleSetPermissionType>> _AllPermissionsLazy = new LazyWithRetry<List<GroupRoleSetPermissionType>>(delegate
	{
		List<GroupRoleSetPermissionType> list = new List<GroupRoleSetPermissionType>();
		string[] names = Enum.GetNames(typeof(Permission));
		for (int i = 0; i < names.Length; i++)
		{
			GroupRoleSetPermissionType byName = GetByName(names[i]);
			if (byName != null)
			{
				list.Add(byName);
			}
		}
		return list;
	});

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanDeletePostsLazy = LazyGetter("CanDeletePosts");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanPostToWallLazy = LazyGetter("CanPostToWall");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanInviteMembersLazy = LazyGetter("CanInviteMembers");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanPostToStatusLazy = LazyGetter("CanPostToStatus");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanRemoveMembersLazy = LazyGetter("CanRemoveMembers");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanViewWallLazy = LazyGetter("CanViewWall");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanViewStatusLazy = LazyGetter("CanViewStatus");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanChangeRankLazy = LazyGetter("CanChangeRank");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanAdvertiseLazy = LazyGetter("CanAdvertise");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanManageRelationshipsLazy = LazyGetter("CanManageRelationships");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanAddGroupPlacesLazy = LazyGetter("CanAddGroupPlaces");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanViewAuditLogLazy = LazyGetter("CanViewAuditLog");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanCreateItemsLazy = LazyGetter("CanCreateItems");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanManageItemsLazy = LazyGetter("CanManageItems");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanSpendGroupFundsLazy = LazyGetter("CanSpendGroupFunds");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanChangeOwnerLazy = LazyGetter("CanChangeOwner");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanDeleteGroupLazy = LazyGetter("CanDeleteGroup");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanRenameGroupLazy = LazyGetter("CanRenameGroup");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanAdjustCurrencyAmountsLazy = LazyGetter("CanAdjustCurrencyAmounts");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanAbandonGroupLazy = LazyGetter("CanAbandonGroup");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanClaimGroupLazy = LazyGetter("CanClaimGroup");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanChangeGroupDescriptionLazy = LazyGetter("CanChangeGroupDescription");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanManageClanLazy = LazyGetter("CanManageClan");

	private static readonly LazyWithRetry<GroupRoleSetPermissionType> _CanManageGroupGamesLazy = LazyGetter("CanManageGroupGames");

	/// DAL Object *
	private GroupRoleSetPermissionTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GroupRoleSetPermissionType", isNullCacheable: true);

	private static List<GroupRoleSetPermissionType> _AllPermissions => _AllPermissionsLazy.Value;

	public static GroupRoleSetPermissionType CanDeletePosts => _CanDeletePostsLazy.Value;

	public static GroupRoleSetPermissionType CanPostToWall => _CanPostToWallLazy.Value;

	public static GroupRoleSetPermissionType CanInviteMembers => _CanInviteMembersLazy.Value;

	public static GroupRoleSetPermissionType CanPostToStatus => _CanPostToStatusLazy.Value;

	public static GroupRoleSetPermissionType CanRemoveMembers => _CanRemoveMembersLazy.Value;

	public static GroupRoleSetPermissionType CanViewStatus => _CanViewStatusLazy.Value;

	public static GroupRoleSetPermissionType CanViewWall => _CanViewWallLazy.Value;

	public static GroupRoleSetPermissionType CanChangeRank => _CanChangeRankLazy.Value;

	public static GroupRoleSetPermissionType CanAdvertise => _CanAdvertiseLazy.Value;

	public static GroupRoleSetPermissionType CanManageRelationships => _CanManageRelationshipsLazy.Value;

	public static GroupRoleSetPermissionType CanAddGroupPlaces => _CanAddGroupPlacesLazy.Value;

	public static GroupRoleSetPermissionType CanViewAuditLog => _CanViewAuditLogLazy.Value;

	public static GroupRoleSetPermissionType CanCreateItems => _CanCreateItemsLazy.Value;

	public static GroupRoleSetPermissionType CanManageItems => _CanManageItemsLazy.Value;

	public static GroupRoleSetPermissionType CanSpendGroupFunds => _CanSpendGroupFundsLazy.Value;

	public static GroupRoleSetPermissionType CanChangeOwner => _CanChangeOwnerLazy.Value;

	public static GroupRoleSetPermissionType CanDeleteGroup => _CanDeleteGroupLazy.Value;

	public static GroupRoleSetPermissionType CanRenameGroup => _CanRenameGroupLazy.Value;

	public static GroupRoleSetPermissionType CanAdjustCurrencyAmounts => _CanAdjustCurrencyAmountsLazy.Value;

	public static GroupRoleSetPermissionType CanAbandonGroup => _CanAbandonGroupLazy.Value;

	public static GroupRoleSetPermissionType CanClaimGroup => _CanClaimGroupLazy.Value;

	public static GroupRoleSetPermissionType CanChangeGroupDescription => _CanChangeGroupDescriptionLazy.Value;

	public static GroupRoleSetPermissionType CanManageClan => _CanManageClanLazy.Value;

	public static GroupRoleSetPermissionType CanManageGroupGames => _CanManageGroupGamesLazy.Value;

	/// Data Members *
	public int ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
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

	public PermissionCategory Category
	{
		get
		{
			return (PermissionCategory)_EntityDAL.CategoryID;
		}
		set
		{
			_EntityDAL.CategoryID = (byte)value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	/// Static Accessors *
	private static LazyWithRetry<GroupRoleSetPermissionType> LazyGetter(string name)
	{
		return new LazyWithRetry<GroupRoleSetPermissionType>(() => GetByName(name));
	}

	/// Constructors *
	private GroupRoleSetPermissionType(GroupRoleSetPermissionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupRoleSetPermissionType()
	{
		_EntityDAL = new GroupRoleSetPermissionTypeDAL();
	}

	public void Construct(GroupRoleSetPermissionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	/// CRUD *
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

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal static GroupRoleSetPermissionType CreateNew(Permission permission, string description)
	{
		GroupRoleSetPermissionType groupRoleSetPermissionType = new GroupRoleSetPermissionType();
		groupRoleSetPermissionType.Name = permission.ToString();
		groupRoleSetPermissionType.Description = description;
		groupRoleSetPermissionType.Save();
		return groupRoleSetPermissionType;
	}

	/// Getters (single) *
	public static GroupRoleSetPermissionType Get(int id)
	{
		return EntityHelper.GetEntity<int, GroupRoleSetPermissionTypeDAL, GroupRoleSetPermissionType>(EntityCacheInfo, id, () => GroupRoleSetPermissionTypeDAL.Get(id));
	}

	public static GroupRoleSetPermissionType GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, GroupRoleSetPermissionTypeDAL, GroupRoleSetPermissionType>(EntityCacheInfo, $"Name:{name}", () => GroupRoleSetPermissionTypeDAL.GetByName(name));
	}

	public static GroupRoleSetPermissionType Get(Permission type)
	{
		return GetByName(type.ToString());
	}

	/// Getters (multiple *
	public static List<GroupRoleSetPermissionType> GetAllPermissions()
	{
		return _AllPermissions;
	}

	public static ICollection<GroupRoleSetPermissionType> GetPermissionByCategory(PermissionCategory category)
	{
		string collectionId = $"GetPermissionByCategory_Category:{category}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"CategoryID:{category}"), collectionId, () => GroupRoleSetPermissionTypeDAL.GetGroupRoleSetPermissionTypeIDsByCategoryID((byte)category), Get);
	}

	/// Operators *
	public static bool operator ==(GroupRoleSetPermissionType lhs, Permission rhs)
	{
		if ((object)lhs == null)
		{
			return false;
		}
		return lhs.Name == rhs.ToString();
	}

	public static bool operator !=(GroupRoleSetPermissionType lhs, Permission rhs)
	{
		return !(lhs == rhs);
	}

	public static bool operator ==(Permission lhs, GroupRoleSetPermissionType rhs)
	{
		if ((object)rhs == null)
		{
			return false;
		}
		return lhs.ToString() == rhs.Name;
	}

	public static bool operator !=(Permission lhs, GroupRoleSetPermissionType rhs)
	{
		return !(lhs == rhs);
	}

	public static bool operator ==(GroupRoleSetPermissionType lhs, GroupRoleSetPermissionType rhs)
	{
		if ((object)lhs == null)
		{
			return (object)rhs == null;
		}
		if ((object)rhs == null)
		{
			return false;
		}
		return lhs.ID == rhs.ID;
	}

	public static bool operator !=(GroupRoleSetPermissionType lhs, GroupRoleSetPermissionType rhs)
	{
		return !(lhs == rhs);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	public bool Equals(GroupRoleSetPermissionType other)
	{
		return this == other;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"CategoryID:{Category}")
		};
	}
}
