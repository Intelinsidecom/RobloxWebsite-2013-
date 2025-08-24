using System.Collections.Generic;
using System.Linq;
using Roblox.Classification.Interfaces;
using Roblox.Classification.Properties;
using Roblox.Segmentation.Client;

namespace Roblox.Classification;

public class GenderClassifier : IClassifier<string>
{
	private static GenderClassifier _Singleton;

	private readonly Dictionary<string, ISegment> _SegmentLookupCache = new Dictionary<string, ISegment>();

	public static GenderClassifier Singleton
	{
		get
		{
			if (_Singleton == null || _Singleton.Dimension.Name != Settings.Default.GenderDimensionName)
			{
				_Singleton = new GenderClassifier(Settings.Default.GenderDimensionName);
			}
			return _Singleton;
		}
	}

	public IDimension Dimension { get; private set; }

	public ISegment UnknownSegment { get; private set; }

	public IEnumerable<ISegment> Segments { get; private set; }

	private GenderClassifier(string dimensionName)
	{
		SegmentationClient segmentationClient = SegmentationClientFactory.GetSegmentationClient();
		Dimension = segmentationClient.GetDimension(dimensionName);
		Segments = segmentationClient.GetDimensionSegments(Dimension);
		UnknownSegment = Segments.FirstOrDefault((ISegment s) => s.Name == "Unknown");
		_SegmentLookupCache = Segments.ToDictionary((ISegment s) => s.Name);
	}

	public ISegment Classify(string gender)
	{
		if (!_SegmentLookupCache.TryGetValue(gender, out var segment))
		{
			return UnknownSegment;
		}
		return segment;
	}
}
