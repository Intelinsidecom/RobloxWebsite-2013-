namespace Roblox.Common;

/// <summary>
/// An integer range with Min and Max barriers.
///
/// If the minimum is greater than the maximum,
/// this represents the range going up from Min to int.maxvalue
/// unioned with the range going from int.minvalue to Max
/// </summary>
public struct Range
{
	public int Min { get; set; }

	public int Max { get; set; }

	public Range(int min, int max)
	{
		Min = min;
		Max = max;
	}
}
