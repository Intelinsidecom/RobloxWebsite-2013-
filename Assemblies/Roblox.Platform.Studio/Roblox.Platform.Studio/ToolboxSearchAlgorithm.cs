namespace Roblox.Platform.Studio;

internal class ToolboxSearchAlgorithm : IToolboxSearchAlgorithm
{
	public int Id { get; }

	public string Name { get; }

	public string Description { get; }

	public ToolboxSearchAlgorithm(int id, string name, string description)
	{
		Id = id;
		Name = name;
		Description = description;
	}
}
