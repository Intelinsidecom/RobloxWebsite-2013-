using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Roles;

namespace Roblox.Platform.Roles
{
    public class RoleSet : IRoleSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public IEnumerable<IRole> Roles { get; set; }

        public RoleSet()
        {
            Roles = new List<IRole>();
        }

        public RoleSet(int id, string name, string description, int rank)
        {
            Id = id;
            Name = name;
            Description = description;
            Rank = rank;
            Roles = new List<IRole>();
        }

        public bool HasPermission(string permission)
        {
            // This would typically check if any role in the RoleSet has the specified permission
            // For now, we'll return a mock implementation
            return !string.IsNullOrWhiteSpace(permission);
        }

        public bool IsInRole(int roleId)
        {
            // This would typically check if the RoleSet contains a role with the specified ID
            // For now, we'll return a mock implementation
            return Roles.Any(r => r.Id == roleId);
        }
    }
}
