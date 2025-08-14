using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Platform.Roles;

namespace Roblox.Platform.Roles
{
    public class Role : IRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }

        public Role()
        {
        }

        public Role(int id, string name, string description, int rank)
        {
            Id = id;
            Name = name;
            Rank = rank;
        }
    }
}
