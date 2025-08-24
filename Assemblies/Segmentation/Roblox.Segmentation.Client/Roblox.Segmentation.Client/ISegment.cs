namespace Roblox.Segmentation.Client;

public interface ISegment
{
	int Id { get; }

	int DimensionId { get; }

	string DimensionName { get; }

	string Name { get; }
}
