using System.ComponentModel;

namespace Roblox.Platform.Counters;

public class AssetCounterType
{
	public enum SegmentedTypes
	{
		TotalPlays,
		TotalPlayTime,
		ReturnRate
	}

	public static byte GrossSalesRevenueRobuxID => Roblox.AssetCounterType.GrossSalesRevenueRobuxID;

	public static byte GetAssetCounterTypeIdBySegmentId(SegmentedTypes type, int segmentId)
	{
		return Roblox.AssetCounterType.GetSegmentedType(ConvertSegmentedType(type), segmentId).ID;
	}

	public static byte GetAssetCounterTypeIdByPlatformType(SegmentedTypes type, byte platformTypeId)
	{
		return Roblox.AssetCounterType.GetByPlatformType(ConvertSegmentedType(type), platformTypeId).ID;
	}

	private static Roblox.AssetCounterType.SegmentedTypes ConvertSegmentedType(SegmentedTypes type)
	{
		return type switch
		{
			SegmentedTypes.TotalPlays => Roblox.AssetCounterType.SegmentedTypes.TotalPlays, 
			SegmentedTypes.TotalPlayTime => Roblox.AssetCounterType.SegmentedTypes.TotalPlayTime, 
			SegmentedTypes.ReturnRate => Roblox.AssetCounterType.SegmentedTypes.ReturnRate, 
			_ => throw new InvalidEnumArgumentException("Invalid SegmentedType"), 
		};
	}
}
