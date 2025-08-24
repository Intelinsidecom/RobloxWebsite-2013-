namespace Roblox.Segmentation.Client;

internal class Dimension : IDimension
{
	public int Id { get; set; }

	public string Name { get; set; }

	internal Dimension(int id, string name)
	{
		Id = id;
		Name = name;
	}

	public Dimension()
	{
	}
}
