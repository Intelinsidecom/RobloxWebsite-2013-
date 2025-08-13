using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roblox.Assets;

namespace Roblox.Assets
{
    public class Asset : IAsset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsPublic { get; set; }

        public Asset()
        {
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }

        public Asset(int id, string name, string description, int creatorId, bool isPublic)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatorId = creatorId;
            IsPublic = isPublic;
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }
    }
}
