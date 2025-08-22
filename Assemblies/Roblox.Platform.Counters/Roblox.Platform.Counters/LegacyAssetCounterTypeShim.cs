namespace Roblox
{
    // Minimal shim to satisfy references from Roblox.Platform.Counters.AssetCounterType
    public static class AssetCounterType
    {
        public enum SegmentedTypes
        {
            TotalPlays,
            TotalPlayTime,
            ReturnRate
        }

        public sealed class TypeInfo
        {
            public byte ID { get; set; }
        }

        public static byte GrossSalesRevenueRobuxID => 0;

        public static TypeInfo GetSegmentedType(SegmentedTypes type, int segmentId)
        {
            return new TypeInfo { ID = (byte)segmentId };
        }

        public static TypeInfo GetByPlatformType(SegmentedTypes type, byte platformTypeId)
        {
            return new TypeInfo { ID = platformTypeId };
        }
    }
}
