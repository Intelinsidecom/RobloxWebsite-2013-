namespace Roblox.Billing;

internal class Purchaser : IPurchaser
{
	public long Id { get; private set; }

	internal Purchaser(long id)
	{
		Id = id;
	}
}
