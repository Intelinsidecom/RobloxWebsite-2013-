using System.Collections.Generic;
using System.Linq;
using Roblox.Classification.Interfaces;
using Roblox.Classification.Properties;
using Roblox.Segmentation.Client;

namespace Roblox.Classification;

public class AgeClassifier : IClassifier<int>
{
	private static AgeClassifier _Singleton;

	private const string _UnknownAgeSegmentName = "Unknown";

	private const string _TenOrUnderAgeSegmentName = "10-";

	private const string _ElevenToTwelveAgeSegmentName = "11-12";

	private const string _ThirteenToFourteenAgeSegmentName = "13-14";

	private const string _FifteenToSeventeenAgeSegmentName = "15-17";

	private const string _EighteenOrOverAgeSegmentName = "18+";

	private static readonly Dictionary<string, Range<int>> _AgeSegmentRanges;

	private readonly List<AgeSegment> _AgeSegments = new List<AgeSegment>();

	public static AgeClassifier Singleton
	{
		get
		{
			if (_Singleton == null || _Singleton.Dimension.Name != Settings.Default.AgeDimensionName)
			{
				_Singleton = new AgeClassifier(Settings.Default.AgeDimensionName);
			}
			return _Singleton;
		}
	}

	public IDimension Dimension { get; private set; }

	public ISegment UnknownSegment { get; private set; }

	public IEnumerable<ISegment> Segments { get; private set; }

	static AgeClassifier()
	{
		_AgeSegmentRanges = new Dictionary<string, Range<int>>();
		_AgeSegmentRanges["10-"] = new Range<int>(0, 10);
		_AgeSegmentRanges["11-12"] = new Range<int>(11, 12);
		_AgeSegmentRanges["13-14"] = new Range<int>(13, 14);
		_AgeSegmentRanges["15-17"] = new Range<int>(15, 17);
		_AgeSegmentRanges["18+"] = new Range<int>(18, int.MaxValue);
	}

	private AgeClassifier(string dimensionName)
	{
		SegmentationClient segmentationClient = SegmentationClientFactory.GetSegmentationClient();
		Dimension = segmentationClient.GetDimension(dimensionName);
		Segments = segmentationClient.GetDimensionSegments(Dimension);
		UnknownSegment = Segments.FirstOrDefault((ISegment s) => s.Name == "Unknown");
		foreach (ISegment segment in Segments)
		{
			if (_AgeSegmentRanges.ContainsKey(segment.Name))
			{
				_AgeSegments.Add(new AgeSegment(segment, _AgeSegmentRanges[segment.Name]));
			}
		}
		_AgeSegments.Sort();
	}

	private ISegment LookupSegment(int age)
	{
		foreach (AgeSegment ageSegment in _AgeSegments)
		{
			if (ageSegment.ContainsAge(age))
			{
				return ageSegment;
			}
		}
		return UnknownSegment;
	}

	public ISegment Classify(int age)
	{
		return LookupSegment(age);
	}
}
