namespace Roblox.GameLocalization.Client.GameLocalizationRoles
{
    public enum RoleAssigneeType
    {
        User = 0,
        Group = 1
    }

    public class IsAssignedForRoleRequest
    {
        public long AssigneeTargetId { get; set; }
        public RoleAssigneeType AssigneeType { get; set; }
        public long UniverseId { get; set; }
    }

    public class IsAssignedForRoleResponse
    {
        public bool IsAssigned { get; set; }
    }
}
