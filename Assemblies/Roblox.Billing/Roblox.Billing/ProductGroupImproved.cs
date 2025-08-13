namespace Roblox.Billing;

internal class ProductGroupImproved : IProductGroup
{
	public byte Id { get; private set; }

	public string Name { get; private set; }

	internal ProductGroupImproved(byte id, string name)
	{
		Id = id;
		Name = name;
	}
}
