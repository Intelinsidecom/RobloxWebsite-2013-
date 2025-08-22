using System;
using System.Collections.Generic;

namespace Roblox.Permissions.Client
{
    // Minimal DTOs and client interface used by Roblox.Platform.Permissions.Core and CloudEdit
    public interface IPermissionsClient
    {
        // Permission groups
        PermissionGroup GetPermissionGroup(long id, int? page = null);
        IEnumerable<PermissionGroup> GetPermissions(string actionType, long? actionTargetId);
        EnumerativePageResult<long, long, PermissionGroup> GetPermissionGroupsByPermission(string permissionType, long? permissionTypeTargetId, bool allowAccess, long exclusiveStartId);
        PermissionGroup CreatePermissionGroup(bool evaluateByAND, string name, long creatorId, string creatorType);
        void ApplyPermissionGroupToAction(string actionType, long permissionGroupId, long creatorId, string creatorType, long? actionTargetId);
        void RemovePermissionGroupFromAction(string actionType, long permissionGroupId, long creatorId, string creatorType, long? actionTargetId);

        // Lists (custom lists)
        List GetList(long id);
        List CreateList(string name, long creatorId, string creatorType);
        EnumerativePageResult<long, long, List> GetLists(long creatorId, string creatorType, int? page);
        void CreateListMember(long listId, long userId, long actorId, string actorType);
        void DeleteListMember(long listId, long userId, long actorId, string actorType);

        // User permission groups
        EnumerativePageResult<long, long, PermissionGroup> GetPermissionGroups(long creatorId, string creatorType, int? page);
    }

    // Paged result shape used by factories
    public class EnumerativePageResult<TKey, TPageKey, TItem>
    {
        public TKey NextPageExclusiveStartId { get; set; }
        public IEnumerable<TItem> PageItems { get; set; } = Array.Empty<TItem>();
    }

    // Client DTOs translated by Roblox.Platform.Permissions.Core
    public class PermissionGroup
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string CreatorType { get; set; }
        public long CreatorId { get; set; }
        public bool EvaluateByAND { get; set; }
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
}
