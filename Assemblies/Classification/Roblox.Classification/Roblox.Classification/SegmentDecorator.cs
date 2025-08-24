using Roblox.Segmentation.Client;

namespace Roblox.Classification;

internal abstract class SegmentDecorator : ISegment
{
	protected ISegment DecoratedSegment { get; set; }

	public int DimensionId => DecoratedSegment.DimensionId;

	public string DimensionName => DecoratedSegment.DimensionName;

	public int Id => DecoratedSegment.Id;

	public string Name => DecoratedSegment.Name;

	public SegmentDecorator(ISegment decoratedSegment)
	{
		DecoratedSegment = decoratedSegment;
	}
}
