using System;

namespace Roblox.Presence.Client
{
    // Minimal DTO stub to satisfy Roblox.Platform.Presence usage
    public class PresenceReport
    {
        public DateTime? LastObserved { get; set; }
        public string LocationType { get; set; }
        public string LocationId { get; set; }
        public bool IsOnline { get; set; }
        public long? UniverseId { get; set; }
    }
}
