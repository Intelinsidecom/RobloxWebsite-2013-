using System;

namespace Roblox.InGameContentTables.Client
{
    public enum OwnerType
    {
        User = 0,
        Group = 1
    }

    public class Table
    {
        public Guid Id { get; set; }
        public OwnerType OwnerType { get; set; }
        public long OwnerTargetId { get; set; }
    }
}
