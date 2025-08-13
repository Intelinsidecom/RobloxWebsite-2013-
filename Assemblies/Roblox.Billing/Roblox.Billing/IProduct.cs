namespace Roblox.Billing;

public interface IProduct
{
	int Id { get; }

	bool IsRenewable { get; }

	string Name { get; }

	decimal Price { get; }

	IProductGroup ProductGroup { get; }
}
