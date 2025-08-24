using System;
using Roblox.Segmentation.Client;

namespace Roblox.Classification;

internal class AgeSegment : SegmentDecorator, IComparable<AgeSegment>
{
	public Range<int> AgeRange { get; }

	public AgeSegment(ISegment segment, Range<int> ageRange)
		: base(segment)
	{
		AgeRange = ageRange;
	}

	public bool ContainsAge(int age)
	{
		return AgeRange.Contains(age);
	}

	public int CompareTo(AgeSegment other)
	{
		return AgeRange.CompareTo(other.AgeRange);
	}
}
