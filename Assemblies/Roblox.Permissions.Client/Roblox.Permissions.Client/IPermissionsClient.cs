using System;
using System.Collections.Generic;

namespace Roblox.Permissions.Client
{
    // Minimal DTOs and client interface used by Roblox.Platform.Permissions.Core and CloudEdit
    public interface IPermissionsClient
    {
        // Permission groups
        PermissionGroup GetPermissionGroup(long id, int? page = null);
        ICollection<PermissionGroup> GetPermissions(string actionType, long? actionTargetId);
        EnumerativePageResult<long, long, PermissionGroup> GetPermissionGroupsByPermission(string permissionType, long? permissionTypeTargetId, bool allowAccess, long exclusiveStartId);
        PermissionGroup CreatePermissionGroup(bool evaluateByAND, string name, long creatorId, string creatorType);
        void ApplyPermissionGroupToAction(string actionType, long permissionGroupId, long creatorId, string creatorType, long? actionTargetId);
        void RemovePermissionGroupFromAction(string actionType, long permissionGroupId, long creatorId, string creatorType, long? actionTargetId);

        // Permission group management
        void AddPermissionToPermissionGroup(long permissionGroupId, string permissionType, bool allowAccess, long creatorId, string creatorType, long? permissionTypeTargetId = null);
        void RemovePermissionFromPermissionGroup(long permissionGroupId, string permissionType, bool allowAccess, long creatorId, string creatorType, long? permissionTypeTargetId = null);
        void UpdatePermissionGroup(long permissionGroupId, bool evaluateByAND, string name, long creatorId, string creatorType);
        void DeletePermissionGroup(long permissionGroupId, long creatorId, string creatorType);

        // Actions for permission group
        EnumerativePageResult<long, long, Action> GetActionsForPermissionGroup(long permissionGroupId, long exclusiveStartId);

        // Lists (custom lists)
        List GetList(long id);
        List CreateList(string name, long creatorId, string creatorType);
        EnumerativePageResult<long, long, List> GetLists(long creatorId, string creatorType, int? page);
        void CreateListMember(long listId, long userId, long actorId, string actorType);
        void DeleteListMember(long listId, long userId, long actorId, string actorType);

        // Membership checks
        bool IsListMember(long listId, long userId);

        // List management
        void UpdateList(long listId, string name, long actorId, string actorType);
        void DeleteList(long listId, long actorId, string actorType);
        PageResult<long, long> GetListMembers(long listId, int? page);

        // User permission groups
        EnumerativePageResult<long, long, PermissionGroup> GetPermissionGroups(long creatorId, string creatorType, int? page);
    }

    // Paged result shape used by factories
    public class EnumerativePageResult<TKey, TPageKey, TItem>
    {
        public TKey NextPageExclusiveStartId { get; set; }
        public IEnumerable<TItem> PageItems { get; set; } = Array.Empty<TItem>();
    }

    // Non-enumerative page result used by list member queries
    public class PageResult<TKey, TItem>
    {
        public TKey Count { get; set; }
        public IEnumerable<TItem> PageItems { get; set; } = Array.Empty<TItem>();
    }

    // Client DTOs translated by Roblox.Platform.Permissions.Core
    public interface IPermissionGroup
    {
        long ID { get; set; }
        string Name { get; set; }
        string CreatorType { get; set; }
        long CreatorId { get; set; }
        bool EvaluateByAND { get; set; }
        ICollection<Permission> Permissions { get; set; }
    }

    public class PermissionGroup : IPermissionGroup
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string CreatorType { get; set; }
        public long CreatorId { get; set; }
        public bool EvaluateByAND { get; set; }
        public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }

    public class List
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string CreatorType { get; set; }
        public long CreatorId { get; set; }
    }

    public class Action
    {
        public string ActionType { get; set; }
        public long? ActionTargetId { get; set; }
    }

    public class Permission
    {
        public long ID { get; set; }
        public bool AllowAccess { get; set; }
        public string PermissionType { get; set; }
        public long? PermissionTypeTargetId { get; set; }
    }
}
