namespace Roblox.Segmentation.Client;

internal class Segment : ISegment
{
	public int Id { get; set; }

	public int DimensionId { get; set; }

	public string DimensionName { get; set; }

	public string Name { get; set; }

	public Segment()
	{
	}

	internal Segment(int id, int dimensionId, string dimensionName, string name)
	{
		Id = id;
		DimensionId = dimensionId;
		DimensionName = dimensionName;
		Name = name;
	}
}
