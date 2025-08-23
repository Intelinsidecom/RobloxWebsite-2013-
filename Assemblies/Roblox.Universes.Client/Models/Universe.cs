using System;

namespace Roblox.Universes.Client
{
    // Minimal data model used by Roblox.Platform.Universes
    public class Universe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }
        // Some callsites treat 0 as null; keep nullable to accommodate both.
        public long? RootPlaceId { get; set; }
        public string CreatorType { get; set; }
        public long CreatorTargetId { get; set; }
        public string PrivacyType { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool StudioAccessToApisAllowed { get; set; }
    }
}
