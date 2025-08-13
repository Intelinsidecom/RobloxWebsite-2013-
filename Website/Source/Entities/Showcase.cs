using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox.Showcases.Entities
{
    public class Showcase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<ShowcaseItem> Items { get; set; }

        public Showcase()
        {
            Items = new List<ShowcaseItem>();
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }

        public Showcase(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            Items = new List<ShowcaseItem>();
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }
    }

    public class ShowcaseItem
    {
        public int Id { get; set; }
        public int ShowcaseId { get; set; }
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public ShowcaseItem()
        {
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }

        public ShowcaseItem(int id, int showcaseId, int assetId, string title, string description, int sortOrder)
        {
            Id = id;
            ShowcaseId = showcaseId;
            AssetId = assetId;
            Title = title;
            Description = description;
            SortOrder = sortOrder;
            Created = DateTime.UtcNow;
            Updated = DateTime.UtcNow;
        }
    }
}
