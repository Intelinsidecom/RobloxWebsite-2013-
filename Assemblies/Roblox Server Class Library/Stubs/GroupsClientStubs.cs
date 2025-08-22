using System;
using System.Collections.Generic;
using Roblox.Caching.Interfaces;
using Roblox.ApiClientBase;

namespace Roblox.Groups.Client
{
    public interface IGroupsClient
    {
        void RemoveUserFromGroup(long userId, long groupId);
        GroupMembershipModel AddUserToGroup(long userId, long groupId, long roleSetId);
        GroupMembershipModel UpdateGroupMembership(long userId, long groupId, long roleSetId, bool isTopGroup);
        GroupMembershipModel GetGroupMembership(long userId, long groupId);
        IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdAndRoleSetIdPaged(long groupId, long roleSetId, int startRowIndex, int maximumRows);
        IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdAndRoleSetIdEnumerative(long groupId, long roleSetId, int count, GroupMembershipModel exclusiveStartObject, SortOrder sortOrder);
        IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdPaged(long groupId, int startRowIndex, int maximumRows);
        IEnumerable<GroupMembershipModel> GetGroupMembershipsByUserId(long userId);
        IEnumerable<GroupMembershipModel> GetTopGroupMembershipsByUserIdPaged(long userId, int startRowIndex, int maximumRows);
        int GetGroupMembershipCountByGroupId(long groupId);
        int GetGroupMembershipCountByUserId(long userId);
        int GetGroupMembershipCountByGroupIdAndRoleSetId(long groupId, long roleSetId);
    }

    public class GroupsClient : IGroupsClient
    {
        private readonly Func<string> _getApiKey;
        private readonly IRequestCache _cache;

        public GroupsClient(Func<string> getApiKey, IRequestCache cache)
        {
            _getApiKey = getApiKey;
            _cache = cache;
        }

        public void RemoveUserFromGroup(long userId, long groupId) { }
        public GroupMembershipModel AddUserToGroup(long userId, long groupId, long roleSetId) => new GroupMembershipModel { Id = 0, UserId = userId, GroupId = groupId, RoleSetId = roleSetId, Created = DateTime.UtcNow, Updated = DateTime.UtcNow };
        public GroupMembershipModel UpdateGroupMembership(long userId, long groupId, long roleSetId, bool isTopGroup) => new GroupMembershipModel { Id = 0, UserId = userId, GroupId = groupId, RoleSetId = roleSetId, IsTopGroup = isTopGroup, Created = DateTime.UtcNow, Updated = DateTime.UtcNow };
        public GroupMembershipModel GetGroupMembership(long userId, long groupId) => null;
        public IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdAndRoleSetIdPaged(long groupId, long roleSetId, int startRowIndex, int maximumRows) => Array.Empty<GroupMembershipModel>();
        public IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdAndRoleSetIdEnumerative(long groupId, long roleSetId, int count, GroupMembershipModel exclusiveStartObject, SortOrder sortOrder) => Array.Empty<GroupMembershipModel>();
        public IEnumerable<GroupMembershipModel> GetGroupMembershipsByGroupIdPaged(long groupId, int startRowIndex, int maximumRows) => Array.Empty<GroupMembershipModel>();
        public IEnumerable<GroupMembershipModel> GetGroupMembershipsByUserId(long userId) => Array.Empty<GroupMembershipModel>();
        public IEnumerable<GroupMembershipModel> GetTopGroupMembershipsByUserIdPaged(long userId, int startRowIndex, int maximumRows) => Array.Empty<GroupMembershipModel>();
        public int GetGroupMembershipCountByGroupId(long groupId) => 0;
        public int GetGroupMembershipCountByUserId(long userId) => 0;
        public int GetGroupMembershipCountByGroupIdAndRoleSetId(long groupId, long roleSetId) => 0;
    }

    public class GroupMembershipModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long GroupId { get; set; }
        public long RoleSetId { get; set; }
        public bool IsTopGroup { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
